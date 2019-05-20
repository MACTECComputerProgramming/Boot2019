/* Book.cs   
 * This class extends ReadingMaterial
 * and includes details about book
 * objects. 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingMaterialApp
{
    class Book : ReadingMaterial, IPrintable
    {
        private string callNumber;
        private bool hardBack;
        private bool paperBack;
        private int numberOfPages;

 
        public Book()
            : base()
        {
        }

        public Book(string first, string last, string typeOfMaterial, string typeOfPublication,
            string pub, string publicDate, string callNum, bool hardBackVersion, bool paperBackVersion)
            : base(first, last, typeOfMaterial, typeOfPublication, pub, publicDate)
        {
            callNumber = callNum;
            hardBack = hardBackVersion;
            paperBack = paperBackVersion;
        }

        public string CallNumber
        {
            get
            {
                return callNumber;
            }
            set
            {
                callNumber = value;
            }
        }

        public bool HardBack
        {
            get
            {
                return hardBack;
            }
            set
            {
                hardBack = value;
            }
        }

        public bool PaperBack
        {
            get
            {
                return paperBack;
            }
            set
            {
                paperBack = value;
            }
        }

        public int NumberOfPages
        {
            get 
            { 
                return numberOfPages; 
            }
            set 
            { 
                numberOfPages = value; 
            }
        }

        public string GetHardCopyPublicationDetails()
        {
            return "Available from publisher";
        }

        public override string ToString()
        {
            return base.ToString() +
                "\nCall Number: " + callNumber; 
        }
    }
}
