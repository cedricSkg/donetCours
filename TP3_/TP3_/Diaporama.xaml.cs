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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TP3_
{
    /// <summary>
    /// Logique d'interaction pour Diaporama.xaml
    /// </summary>
    public partial class Diaporama : Window
    {
        private int currentIndex = 0;
        public List<String> sDiapo = new List<String>();
        public Diaporama()
        {
            InitializeComponent();
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            if (sDiapo.Count > 0)
            {
                // Affichez la première image ou effectuez d'autres actions nécessaires
                ImageSourceConverter s = new ImageSourceConverter();
                Image1.Source = (ImageSource)s.ConvertFromString(sDiapo[0]);
            }
        }

        private void VisibleToInvisible_Completed(object sender, EventArgs e)
        {
            // Changez l'indice de l'image affichée
            currentIndex = (currentIndex + 1) % sDiapo.Count;

            // Chargez l'image de l'indice en cours
            ImageSourceConverter s = new ImageSourceConverter();
            Image2.Source = (ImageSource)s.ConvertFromString(sDiapo[currentIndex]);

            // Démarrez le storyboard "InvisibleToVisible" pour faire réapparaître l'image
            Storyboard sb = (Storyboard)this.FindResource("InvisibleToVisible");
            sb.Begin();
        }

    }
}
