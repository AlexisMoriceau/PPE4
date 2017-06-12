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

namespace PPE.Pages.Enquetes
{
    /// <summary>
    /// Interaction logic for AjoutEnquete.xaml
    /// </summary>
    public partial class AjoutEnquete : UserControl
    {
        public AjoutEnquete()
        {
            InitializeComponent();
            combo_theme.ItemsSource = Controller.ThemeDAO.List();
            
        }

      private void textBox_Nom_GotFocus(object sender, RoutedEventArgs e)
        {
          //  textBox_Nom.Text = "";
        } 

        private void button_AjoutSequence_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_Valider_Click(object sender, RoutedEventArgs e)
        {
            PPE.enquete lol = new PPE.enquete();
            lol.sequences = (App.Current as App).listeseq;
   

        }
        private void button_delete_Click(object sender, RoutedEventArgs e)
        {
            
        }
        private void button_modify_Click(object sender, RoutedEventArgs e)
        {
         //   Button btn = (Button)sender;
         //   (App.Current as App).newsequence = (sequence)btn.DataContext;

        }


        private void isenable()
        {
            /*if (globseq.Count != 0 || textBox_Nom.Text != "")
            {
             //   button_Valider.IsEnabled = true;
            }*/
        }
        private void textBox_Nom_TextChanged(object sender, TextChangedEventArgs e)
        {
           // isenable();
        }

        private void comboBox_SousTheme_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            comboBox_SousTheme.ItemsSource = Controller.ThemeDAO.ssTheme(combo_theme.SelectedItem as PPE.theme);
        }
    }
}
