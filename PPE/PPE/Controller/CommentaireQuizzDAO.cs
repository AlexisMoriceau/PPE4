using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE.Controller
{
    class CommentaireQuizzDAO
    {
        public static PPE4Entities db = new PPE4Entities();

        public static List<commentaire__quizz> List()
        {
            List<commentaire__quizz> ListeCommentaireQuizz = db.commentaire__quizz.ToList();
            return ListeCommentaireQuizz;
        }

        public static commentaire__quizz Select (int id)
        {
            commentaire__quizz CommenataireQ = db.commentaire__quizz.Find(id);
            return CommenataireQ;
        }

        public static string Delete(commentaire__quizz CommentaireQ)
        {
            db.commentaire__quizz.Attach(CommentaireQ);
            db.commentaire__quizz.Remove(CommentaireQ);
            db.SaveChanges();
            return "le commentaire a bien été supprimé";
        }
    }
}
