using System;

namespace Tutorials {
    class Book 
    {
        public string title;
        public string author;
        public int pages;

        private string key = "sfhjks#$535nsjkf3$Q2323";

    
        public Book(string aTitle, string aAuthor, int aPages){
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }

        public bool easyToRead(){
            if(pages > 100){
                return true;
            }
            return false;
        }

        public string CopyRightKey {
            get {return key;}
            set{ 
                key = value;
            }
        }
    }
}