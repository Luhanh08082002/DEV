using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DTO;
using DAL;

namespace BLL
{
    public class Borreewer_BILL
    {
        DAL_BORROEEWER da = new DAL_BORROEEWER();

        public DataTable getBorreewer()
        {
            return da.getBorreewer_DAL();
        }
        public DataTable SearchBorrew(string name)
        {
            return da.SearchBorrew_DAL(name);
        }
        public DataTable getBook()
        {
            return da.getBooks_DAL();
        }
        public bool UpdateBook(Book_DTO id)
        {
            return da.UpdateBook_DAL(id);

        }
        public bool DeleteBook(string id)
        {
            return da.DeleteBook_DAL(id);
        }
        public bool isCheckID(string id)
        {
            return da.isCheckId_DAl(id);

        }
        
        public bool InsertBorreewer(Book_DTO tv)
        {
            return da.InsertBorreewer_DAL(tv);
        }
       
    }

}
