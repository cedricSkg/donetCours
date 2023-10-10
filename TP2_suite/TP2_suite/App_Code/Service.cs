using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service" dans le code, le fichier svc et le fichier de configuration.
public class Service : IService
{
    private string temp;

    public string GetData(int value)
	{
		return string.Format("You entered: {0}", value);
	}

	public CompositeType GetDataUsingDataContract(CompositeType composite)
	{
		if (composite == null)
		{
			throw new ArgumentNullException("composite");
		}
		if (composite.BoolValue)
		{
			composite.StringValue += "Suffix";
		}
		return composite;
	}

    // Chaîne de connexion à la base de données SQL Server
    private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Cours\\Donet\\TP2_suite\\TP2_suite\\App_Data\\Database.mdf;Integrated Security=True;";

    public string Meteo_GetTemperature()
    {
        double temperature = 0;

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();

                // Créez une commande SQL pour récupérer la dernière valeur de température
                string sqlQuery = "SELECT * FROM [T_Data] WHERE [DateReleve] = (SELECT MAX([DateReleve]) FROM [T_Data])";
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Récupérez la valeur de température depuis le SqlDataReader
                            int tempColumnIndex = reader.GetOrdinal("Temp");
                            if (!reader.IsDBNull(tempColumnIndex))
                            {
                                temperature = reader.GetDouble(tempColumnIndex);
                                Console.WriteLine("temp = " + temperature);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Gérer les erreurs de connexion ou d'exécution de la requête ici
                Console.WriteLine("Erreur : " + ex.Message);
            }
        }

        return temperature.ToString("0.00");
    }

    public string Meteo_GetTemperatureByDate(string dateRecherche, out string dateReleve)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            SqlCommand command = new SqlCommand(
                "SELECT * FROM [T_Data] WHERE [DateReleve] = (SELECT MAX([DateReleve]) FROM [T_Data] WHERE DateReleve < '"+ dateRecherche + "')",
                connection);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    // Récupérer la date du relevé au format de chaîne
                    dateReleve = reader["DateReleveVC"].ToString();

                    // Récupérer la température en double
                    double temperature = reader.GetDouble(reader.GetOrdinal("Temp"));

                    // Formater la température en chaîne
                    string temperatureStr = temperature.ToString("0.00");

                    return temperatureStr;
                }
                else
                {
                    // Aucune donnée trouvée
                    dateReleve = null;
                    return "Aucune donnée trouvée pour la date spécifiée.";
                }
            }
        }
    }

    public DataSet Meteo_GetTemperatureDay(string dateRecherche)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            SqlCommand command = new SqlCommand(
                "SELECT * FROM [T_Data] WHERE [DateReleve] > '" + dateRecherche + "' AND [DateReleve] < DateAdd(d, 1, '" + dateRecherche + "')",
                connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();

            // Remplir le DataSet avec les données de la requête SQL
            adapter.Fill(dataSet);

            return dataSet;
        }
    }

}
