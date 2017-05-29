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
            button_Valider.IsEnabled = true;
            button_AjoutReponse.IsEnabled = true;
            button_AjoutQuestion.IsEnabled = true;
            button_Ajouter.IsEnabled = true;  
        }
        public quizz quizz22;
        public static PPE4Entities db = new PPE4Entities();

        public static List<reponse__quizz> R = new List<reponse__quizz>();
        public static List<question__quizz> Q = new List<question__quizz>();

        #region Fonction BoutonEnable
        private void BoutonEnableA()
        {
 /*           if(listView_Question.Items.Count == 1 || listView_Reponse.Items.Count > 0)
            {
                button_Ajouter.IsEnabled = false;
            }
            else
            {
                button_Ajouter.IsEnabled = true;
            }*/
        }

        private void BoutonEnableQ()
        {
    /*        if(Q == null)
            {
                button_AjoutQuestion.IsEnabled = false;
            }
            else
            {
                button_AjoutQuestion.IsEnabled = true;
            }*/
        }

        private void BoutonEnableR()
        {
      /*      if (R == null)
            {
                button_AjoutReponse.IsEnabled = false;
            }
            else
            {
                button_AjoutReponse.IsEnabled = true;
            }*/
        }

        private void BoutonEnableV()
        {
          /*  if (textBox_Nom.Text == "" || listView_Question.Items == null || listView_Reponse.Items == null)
              {
                 button_Valider.IsEnabled = false;
              }
              else
              {
                  button_Valider.IsEnabled = true;
              }*/
        }
        #endregion

        private void textBox_Nom_GotFocus(object sender, RoutedEventArgs e)
        {
            textBox_Nom.Text = "";
        }

        private void button_AjoutReponse_Click(object sender, RoutedEventArgs e)
        {
            var reponse = new reponse__quizz { Intitule = textBox_Reponse.Text };
            R.Add(reponse);
            listView_Reponse.ItemsSource = (R);
            textBox_Reponse.Clear();
        }

        private void button_AjoutQuestion_Click(object sender, RoutedEventArgs e)
        {
            var question = new question__quizz { Intitule = textBox_Question.Text };
            Q.Add(question);
            listView_Question.ItemsSource = (Q);
            textBox_Question.Clear();
        }

        private void button_Valider_Click(object sender, RoutedEventArgs e)
        {
            quizz22 = new quizz { Intitule = textBox_Nom.Text };
            db.quizzs.Add(quizz22);
            textBox_Question.Clear();
            textBox_Nom.Clear();
            textBox_Reponse.Clear();
            listView_Question.Items.Clear();
            listView_Reponse.Items.Clear();
            MessageBox.Show("Votre quizz a été ajouté, il reste modifiable en cas d'erreur de saisie");
        }

        private void button_Ajouter_Click(object sender, RoutedEventArgs e)
        {
            var question = new question__quizz { Intitule = listView_Question.Items.ToString() };
            question.quizz = quizz22;
            db.question__quizz.Add(question);
            foreach (var item in R)
            {
                item.question__quizz = question;
                db.reponse__quizz.Add(item);
                textBox_Reponse.Clear();                         
            }
        }

        #region EnableBouton


        private void textBox_Question_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoutonEnableQ();
        }

        private void textBox_Reponse_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoutonEnableR();
        }

        private void textBox_Nom_TextChanged(object sender, TextChangedEventArgs e)
        {
            BoutonEnableV();
        }
        #endregion
    }
}
