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
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Media;

namespace Virus1
{
    /// <summary>
    /// Interaction logic for BegalinisPaleidimas.xaml
    /// </summary>
    public partial class BegalinisPaleidimas : Window
    {
        public BegalinisPaleidimas()
        {
            InitializeComponent();
        }

        private void migtukas3_Click(object sender, RoutedEventArgs e)
        {
           
           
            this.Close();
        }

        private void Animacija_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            
           
            this.Close();
        }

        private void Submit_Click_1(object sender, RoutedEventArgs e)
        {
            if (Passwordas.Password != "4761")
            {
             
                Passwordas.Clear();
            }
            else if (Passwordas.Password == "4761")
            {
                this.Close();
            }
        }
    }
}
