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
    /// Interaction logic for ListeEnquete.xaml
    /// </summary>
    public partial class ListeEnquete : UserControl
    {
        public ListeEnquete()
        {
            InitializeComponent();
            listView_Enquete.Items.Add(Controller.EnqueteDAO.List());  
        }

        private void button_modify_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_delete_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
