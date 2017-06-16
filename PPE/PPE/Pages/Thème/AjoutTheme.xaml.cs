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

namespace PPE.Pages.Thème
{
    /// <summary>
    /// Interaction logic for AjoutTheme.xaml
    /// </summary>
    public partial class AjoutTheme : UserControl
    {
        public AjoutTheme()
        {
            InitializeComponent();
        }
        public theme theme22;

        private void textBox_Nom_GotFocus(object sender, RoutedEventArgs e)
        {
            textBox_Nom.Text = "";
        }

        private void button_Valider_Click_1(object sender, RoutedEventArgs e)
        {
            theme22 = new theme { Intutile = textBox_Nom.Text };
            Controller.ThemeDAO.addtheme(theme22);
            MessageBox.Show("Votre thème à bien été ajouté");
        }
    }
}
