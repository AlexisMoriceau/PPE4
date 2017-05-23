using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE.Controller
{
    class ReponseQuizzDAO
    {
        public static PPE4Entities db = new PPE4Entities();

        public static List<reponse__quizz> List()
        {
            List<reponse__quizz> ListeReponseQuizz = db.reponse__quizz.ToList();
            return ListeReponseQuizz;
        }

        public static reponse__quizz Select (int id)
        {
            reponse__quizz ReponseQ = db.reponse__quizz.Find(id);
            return ReponseQ;
        }

        public static string Modify(reponse__quizz ReponseQ)
        {
            db.reponse__quizz.Attach(ReponseQ);
            db.Entry(ReponseQ).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return "La réponse à une question de quizz a bien été modifié";
        }

        public static string Delete(reponse__quizz ReponseQ)
        {
            db.reponse__quizz.Attach(ReponseQ);
            db.reponse__quizz.Remove(ReponseQ);
            db.SaveChanges();
            return "La réponse à une question de quizz a bien été supprimé";
        }

        public static string Add(reponse__quizz ReponseQ)
        {
            db.reponse__quizz.Add(ReponseQ);
            db.SaveChanges();
            return "La réponse à une question de quizz à bien été ajouté";
        }
    }
}
