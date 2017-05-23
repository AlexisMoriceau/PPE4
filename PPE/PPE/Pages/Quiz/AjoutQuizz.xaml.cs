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

namespace PPE.Pages.Quiz
{
    /// <summary>
    /// Interaction logic for AjoutQuizz.xaml
    /// </summary>
    public partial class AjoutQuizz : UserControl
    {
        public AjoutQuizz()
        {
            InitializeComponent();
            comboBox_Theme.ItemsSource = Controller.ThemeDAO.List(); 
        }

        private void textBox_Nom_GotFocus(object sender, RoutedEventArgs e)
        {
            textBox_Nom.Text = "";
        }

        private void button_AjoutReponse_Click(object sender, RoutedEventArgs e)
        {

        }
    }
    public class Test
    {
        public string test { get; set; }
    }
}
