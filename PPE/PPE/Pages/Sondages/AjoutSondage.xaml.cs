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

namespace PPE.Pages.Sondages
{
    /// <summary>
    /// Interaction logic for AjoutSondage.xaml
    /// </summary>
    public partial class AjoutSondage : UserControl
    {
        public AjoutSondage()
        {
            InitializeComponent();

        }

        private void textBox_Nom_GotFocus(object sender, RoutedEventArgs e)
        {
            textBox_Nom.Text = "";
        }
    }
}
