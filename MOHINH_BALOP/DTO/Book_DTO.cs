using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class Book_DTO
    {
        public string BOOK_ID { get; set; }
        public string BOOKNAME { get; set; }
        public string AUTHOR { get; set; }
        public DateTime PUBLICCATION_YEAR { get; set; } 
        public Book_DTO()
        {

        } 
        public Book_DTO(string BOOK_ID, string BOOKNAME, string AUTHOR, DateTime PUBLICCATION_YEAR)
        {
            this.BOOK_ID = BOOK_ID;
            this.BOOKNAME = BOOKNAME;
            this.AUTHOR = AUTHOR;
            this.PUBLICCATION_YEAR = PUBLICCATION_YEAR;
        }
    }
   
   
}
