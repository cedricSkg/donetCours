using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Security.Policy;
using System.Windows.Forms.DataVisualization.Charting;

namespace TP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WSMeteo.meteo3ilSoapClient service = new WSMeteo.meteo3ilSoapClient("meteo3ilSoap");
            String Date, Desc;
            String temp = service.Get_Value(1, out Date, out Desc);
            textBox1.Text = "Température actuelle : " + temp + "\r\n";
            textBox1.Text += "Mesurée à : " + Date;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WCFMeteo.Service1Client service = new WCFMeteo.Service1Client();
            WCFMeteo.MeteoData meteoData = service.Get_MeteoData(); // Instancie un objet de la classe meteoData 
            textBox2.Text = "Pression : " + meteoData.d_Pres.ToString("0.00") + "\r\nTempérature : " + meteoData.d_Temp.ToString("0.00") + "\r\nHum : " 
                + meteoData.i_Hum.ToString("0.00") + "\r\nPrécipitation : " + meteoData.d_PrecJour.ToString("0.00") + "\r\nRelevé à : " + meteoData.dt_Releve ;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String restUrl = "http://www.meteorestservice.lab3il.fr/ServiceRest.svc/meteo/2";
            HttpWebRequest WS = (HttpWebRequest)WebRequest.Create(restUrl);
            WS.Method = WebRequestMethods.Http.Get;
            WebResponse webResponse = WS.GetResponse();
            StreamReader streamReader = new StreamReader(webResponse.GetResponseStream());
            String str = streamReader.ReadToEnd();
            str = str.Substring(str.IndexOf(">") + 1, str.Length - str.IndexOf(">") - 1);
            str = str.Substring(0, str.IndexOf("<"));
            textBox3.Text = "Température : " + str;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MyServiceMeteo.ServiceClient service = new MyServiceMeteo.ServiceClient();
            string meteoData = service.Meteo_GetTemperature(); // Instancie un objet de la classe meteoData 
            textBox4.Text = "Température : " + meteoData ;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MyServiceMeteo.ServiceClient service = new MyServiceMeteo.ServiceClient();
            DateTime dateRecherche = dateTimePicker1.Value;
            string dateReleve;
            string meteoData = service.Meteo_GetTemperatureByDate(dateRecherche.ToString("yyyy-MM-dd HH:mm:ss"), out dateReleve); // Utilisation du format ISO pour la date
            textBox5.Text = "Température : " + meteoData;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MyServiceMeteo.ServiceClient service = new MyServiceMeteo.ServiceClient();
            string sdate = dateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm:ss");
            DataSet ds = service.Meteo_GetTemperatureDay(sdate);
            // Réinitialiser le graphique
            chart1.Series.Clear();

            // Créer une série pour la température
            Series tempSeries = new Series("Temp");
            tempSeries.XValueMember = "DateReleveVC";
            tempSeries.YValueMembers = "Temp";
            tempSeries.ChartType = SeriesChartType.Line;
            tempSeries.LegendText = "Température";
            chart1.Series.Add(tempSeries);

            // Créer une série pour la température ressentie
            Series tempRessentieSeries = new Series("TempR");
            tempRessentieSeries.XValueMember = "DateReleveVC";
            tempRessentieSeries.YValueMembers = "TempR";
            tempRessentieSeries.ChartType = SeriesChartType.Line;
            tempRessentieSeries.LegendText = "Température ressentie";
            chart1.Series.Add(tempRessentieSeries);

            // Créer une série pour la température du point de rosée
            Series tempPointRoseeSeries = new Series("TempPR");
            tempPointRoseeSeries.XValueMember = "DateReleveVC";
            tempPointRoseeSeries.YValueMembers = "TempPR";
            tempPointRoseeSeries.ChartType = SeriesChartType.Line;
            tempPointRoseeSeries.LegendText = "Température du point de rosée";
            chart1.Series.Add(tempPointRoseeSeries);

            // Définir la source de données du graphique
            chart1.DataSource = ds.Tables[0];

            // Actualiser le graphique
            chart1.DataBind();
            chart1.Visible = true;
        }
    }
}
