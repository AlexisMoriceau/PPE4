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
    /// Interaction logic for AjoutSequence.xaml
    /// </summary>
    public partial class AjoutSequence : UserControl
    {
        public question__sequence QS = new question__sequence();
        public reponse__sequence RS = new reponse__sequence();
        public List<reponse__sequence> LRS = new List<reponse__sequence>();
        public List<sequence> LS = new List<sequence>();


        public AjoutSequence()
        {
            InitializeComponent();
            QS = new question__sequence();
            RS = new reponse__sequence();
            LRS = new List<reponse__sequence>();
            LS = new List<sequence>();
        }

        private void button_AjoutQuestion_Click(object sender, RoutedEventArgs e)
        {
            QS.Intitule = textBox_Question.Text;
            listView_Question.Items.Add(QS);
            listView_Question.Items.Refresh();
        }
        private void button_AjoutReponse_Click(object sender, RoutedEventArgs e)
        {
            reponse__sequence lol = new reponse__sequence();
            QS = new question__sequence();
            lol.Intitule = textBox_Reponse.Text;
            listView_Reponse.Items.Add(lol);
            listView_Reponse.Items.Refresh();
            QS.reponse__sequence.Add(lol);
        }

        private void button_Valider_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in listView_Question.Items)
            {
                QS = listView_Question.Items.
            }
            foreach (var item in (listView_Reponse.Items))
            {
                QS.reponse__sequence.Add(item as reponse__sequence);
            }
            listView_Question.ItemsSource = null;
            listView_Reponse.ItemsSource = null;
            listView_Question.Items.Clear();
            listView_Reponse.Items.Clear();
            (App.Current as App).newquestion = QS;
            PPE.sequence lol = new PPE.sequence();
            lol.Intitule = "kek";
            lol.question__sequence.Add(QS);
            LS.Add(lol);
            (App.Current as App).listeseq = LS;
            
        }
    }
}
