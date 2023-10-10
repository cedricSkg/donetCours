using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;
using MessageBox = System.Windows.MessageBox;
using System.IO;
using Path = System.IO.Path;


namespace TP3_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Photo ph;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult dr = fbd.ShowDialog();
            if(dr.ToString() == "OK")
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(fbd.SelectedPath);

                textbox1.Text = fbd.SelectedPath;
                // Boucle foreach pour parcourir les fichiers JPEG dans le répertoire
                foreach (FileInfo fileInfo in directoryInfo.GetFiles("*.jpg"))
                {
                    // Ajoute le chemin complet du fichier à la ListBox
                    listbox1.Items.Add(fileInfo.FullName);
                }

            }
            else
            {
                MessageBox.Show("Une erreur est survenu lors de l'ouverture de la boite de dialogue");
            }

            

        }

        private void listbox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Vérifiez s'il y a des éléments sélectionnés dans la ListBox
            if (listbox1.SelectedItem != null)
            {
                // Instance de la photo 
                ph = new Photo(listbox1.SelectedItem.ToString());
                
                // Obtenez le chemin de l'image sélectionnée (assumant que les éléments ListBox sont des chaînes contenant les chemins des images)
                //string selectedImagePath = listbox1.SelectedItem.ToString();

                // Assurez-vous que lb1 existe (vous pouvez vérifier si lb1 n'est pas null)
                if (lb1 != null)
                {
                    // Définissez le contenu du Label lb1 avec le chemin de l'image
                    lb1.Content = Path.GetFileName(ph.Source);
                }
                // Date de creation
                lb2.Content = (ph.Metadata.DateTaken != null) ? ph.Metadata.DateTaken.ToString() : "No date";
                // titre
                lb3.Content = (ph.Metadata.Title != null) ? ph.Metadata.Title.ToString() : "No title";
                // Appareil photo
                lb4.Content = (ph.Metadata.Camera != null) ? ph.Metadata.Camera.ToString() : "No camera";
                // Application
                lb5.Content = (ph.Metadata.Application != null) ? ph.Metadata.Application.ToString() : "No application";
                // Temps acquisition
                lb6.Content = (ph.Metadata.IsoSpeed != null) ? ph.Metadata.IsoSpeed.ToString() + " s": "No ISO Speed";
                // Ouverture
                lb7.Content = (ph.Metadata.Ouverture != null) ? ph.Metadata.Ouverture.ToString() : "No aperture";
                // Distance focale
                lb8.Content = (ph.Metadata.Focale != null) ? ph.Metadata.Focale.ToString() + " mm" : "No focal length";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Diaporama diaporama = new Diaporama();
            foreach (string path in listbox1.Items)
            {
                diaporama.sDiapo.Add(path);
            }
            diaporama.ShowDialog();
        }
    }
}
