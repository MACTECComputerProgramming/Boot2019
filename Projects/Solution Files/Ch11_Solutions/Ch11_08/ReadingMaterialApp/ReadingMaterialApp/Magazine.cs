/* Magazine.cs   
 * This class extends ReadingMaterial
 * to provide additional attributes for
 * magazines including the editor, article
 * name and author. 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingMaterialApp
{
    class Magazine : ReadingMaterial, IPrintable
    {
        private string articleName;
        private string articleAuthor;
        private string editor;

        public Magazine()
            : base()
        {
        }

        public Magazine(string first, string last, string nameMaterial, string type,
                string pub, string publicDate, string artTitle, string artAuthor)
            : base(first, last, nameMaterial, type, pub, publicDate)
        {
            articleName = artTitle;
            articleAuthor = artAuthor;
            editor = base.AuthorFirstName + " " + AuthorLastName;
        }

        public string ArticleName
        {
            get
            {
                return articleName;
            }
            set
            {
                articleName = value;
            }
        }

        public string ArticleAuthor
        {
            get
            {
                return articleAuthor;
            }
            set
            {
                articleAuthor = value;
            }
        }

        public string Editor
        {
            get
            {
                return editor;
            }
            set
            {
                editor = value;
            }
        }

        public string GetHardCopyPublicationDetails()
        {
            return "Available at news stand";
        }


        public override string ToString()
        {
            return base.ToString() +
                "\nArticle: " + articleName +
                "\nAuthor: " + articleAuthor +
                "\n" + GetHardCopyPublicationDetails();
        }
    }
}
