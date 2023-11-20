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

namespace Superheroes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int posicion = 0;

        List<Superheroe> personaje;
     

        public MainWindow()
        {
            
            InitializeComponent();
            personaje = Superheroe.GetSamples();
            xenvuevelDock.DataContext = personaje.FirstOrDefault();
            

        }

        private void Pasar_Personaje_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) 
        {
            Image image = (Image)sender;

            if (image.Name == "xDerechaImage" &&
                posicion < 2)
            {
                posicion++;
                xpaginaTextBlock.Text = posicion + 1 + "/3";
                xenvuevelDock.DataContext = personaje[posicion];
            }
            else if (image.Name == "xIzquierdaImage" &&
                posicion > 0) 
            { 
                posicion--;
                xpaginaTextBlock.Text = posicion + 1 + "/3";
                xenvuevelDock.DataContext = personaje[posicion];
            }
        }

    }
}
