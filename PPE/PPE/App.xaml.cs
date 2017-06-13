using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace PPE
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public PPE.enquete creationenquete = new enquete();
        public sequence newsequence = new sequence();

        public List<sequence> listeseq = new List<sequence>();
        

        public question__sequence newquestion { get; set; }

        public List<question__sequence> listequestion = new List<question__sequence>();



        public List<reponse__sequence> RQ = new List<reponse__sequence>();

        public enquete enquetemodif { get; set; }

    }

    public class newenquete
    {
        question__sequence questionseq { get; set; }
    }
}
