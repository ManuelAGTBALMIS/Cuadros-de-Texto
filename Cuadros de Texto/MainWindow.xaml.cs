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

namespace Cuadros_de_Texto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            escribirNombre_TextBox.Tag = nombreOculto_TextBlock;
            escribirApellido_TextBox.Tag = apellidoOculto_TextBlock;
        }

        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            TextBlock mOculto = (sender as TextBox).Tag as TextBlock;


            if(mOculto.IsVisible && )
            {
                mOculto.Visibility = Visibility.Hidden;
            }
            else if (mOculto.Visibility == Visibility.Hidden)
            {
                mOculto.Visibility = Visibility.Visible;
            }

        }




    }
}
