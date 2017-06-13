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
        question__sequence QS = new question__sequence();
        public reponse__sequence RS = new reponse__sequence();
        public List<reponse__sequence> LRS = new List<reponse__sequence>();
        public List<sequence> LS = new List<sequence>();
       

        public AjoutSequence()
        {
            InitializeComponent();
        }
        private void OnLoad(object sender, RoutedEventArgs e)
        {
            
            listView_Question.ItemsSource = null;
            listView_Question.Items.Clear();
            listView_Reponse.ItemsSource = null;
            listView_Reponse.Items.Clear();
            LRS.Clear();
            QS = new question__sequence();
        }

        private void button_AjoutQuestion_Click(object sender, RoutedEventArgs e)
        {
            
            QS.Intitule = textBox_Question.Text;
            listView_Question.Items.Add(QS);
            listView_Question.Items.Refresh();
        }
        private void button_AjoutReponse_Click(object sender, RoutedEventArgs e)
        {
            reponse__sequence reponseSeq = new reponse__sequence();
            reponseSeq.Intitule = textBox_Reponse.Text;
            LRS.Add(reponseSeq);
            listView_Reponse.ItemsSource = null;
            listView_Reponse.Items.Clear();
            listView_Reponse.ItemsSource = LRS;
            
            /*
            LRS.Add(RS);
            listView_Reponse.ItemsSource = null;
            listView_Reponse.Items.Clear();
            listView_Reponse.ItemsSource = LRS;
            listView_Reponse.Items.Refresh();
            QS.reponse__sequence.Add(RS);
            */
            
        }
        private void button_Valider_Click(object sender, RoutedEventArgs e)
        {
            QS.reponse__sequence = new List<reponse__sequence>();
            foreach (var item in listView_Reponse.Items)
            {
                QS.reponse__sequence.Add(item as reponse__sequence);
            }
            foreach (var item in listView_Question.Items)
            {
                (App.Current as App).listequestion.Add(QS);
            }
            List<question__sequence> questseq = new List<question__sequence>();
            questseq.Add(QS);
            sequence newseq = new sequence { Intitule = textBox.Text, question__sequence = questseq };
            (App.Current as App).newsequence = newseq;
            (App.Current as App).listeseq.Add(newseq);
        }
    }
}
