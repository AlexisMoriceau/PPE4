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
    /// Interaction logic for CommentaireEnquete.xaml
    /// </summary>
    public partial class CommentaireEnquete : UserControl
    {
        public CommentaireEnquete()
        {
            InitializeComponent();
            comboBox_ComEnquete.ItemsSource = Controller.EnqueteDAO.List();
            
        }

        private void comboBox_ComEnquete_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            listView_ComEnquete.ItemsSource = Controller.CommentaireEnqueteDAO.listeCommEnq(comboBox_ComEnquete.SelectedItem as PPE.enquete);
            listView_ComEnquete.Items.Refresh();
        }

        private void ButtonSupprimer_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            Controller.CommentaireEnqueteDAO.Delete((commentaire__enquete)btn.DataContext);
            listView_ComEnquete.ItemsSource = Controller.CommentaireEnqueteDAO.listeCommEnq(comboBox_ComEnquete.SelectedItem as PPE.enquete);
        }



    }
}
