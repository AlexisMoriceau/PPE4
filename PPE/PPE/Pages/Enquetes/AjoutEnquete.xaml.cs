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
        public static List<sequence> seq = new List<sequence>();
        public AjoutEnquete()
        {
            InitializeComponent();
        }

      private void textBox_Nom_GotFocus(object sender, RoutedEventArgs e)
        {
          //  textBox_Nom.Text = "";
        } 

        private void button_AjoutSequence_Click(object sender, RoutedEventArgs e)
        {
            sequence newseq = new sequence { Intitule = textBox_Sequence.Text };
            seq.Add(newseq);
            listView_Enquete.Items.Refresh();
            listView_Enquete.ItemsSource = seq;
            isenable();

        }

        private void button_Valider_Click(object sender, RoutedEventArgs e)
        {

        }
        private void button_delete_Click(object sender, RoutedEventArgs e)
        {

        }
        private void button_modify_Click(object sender, RoutedEventArgs e)
        {

        }

        private void isenable()
        {
            if (seq.Count != 0 || textBox_Nom.Text != "")
            {
             //   button_Valider.IsEnabled = true;
            }
        }
        private void textBox_Nom_TextChanged(object sender, TextChangedEventArgs e)
        {
           // isenable();
        }
    }
}
