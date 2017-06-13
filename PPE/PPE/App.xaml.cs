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
        public sequence newsequence { get; set; }

        public List<sequence> listeseq { get; set; }
        

        public question__sequence newquestion { get; set; }

        public List<reponse__sequence> RQ { get; set; }

        

    }
}
