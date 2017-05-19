using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace PPE.Controller
{
    
    class ThemeDAO
    {
        public static PPE4Entities db = new PPE4Entities();

        public static List<theme> List()
        {
            List<theme> ListeTheme = db.themes.ToList();
            return ListeTheme;
        }

        public static List<theme> ssTheme(theme letheme)
        {
            List<theme> ListessTheme = db.themes.ToList();
            var result = db.themes.Include(x => x.themes).Single(x => x.id == letheme.id);           
            return result.theme1.ToList();
        }


    }
}
