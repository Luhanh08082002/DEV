using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using DTO;

namespace DAL
{
    public class DAL_BORROEEWER:DBconnect
    {
        int result = -1;
        public DataTable getBorreewer_DAL()
        {
            SqlDataAdapter dataAdapter= new SqlDataAdapter("SELECT * FROM BORROEEWER", _conn);
            DataTable dataTableBorr = new DataTable();
            dataAdapter.Fill(dataTableBorr);
            return dataTableBorr;
        }

        public DataTable getBooks_DAL()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM BOOKSS", _conn);
            DataTable dataTableBorr = new DataTable();
            dataAdapter.Fill(dataTableBorr);
            return dataTableBorr;

        }
        public bool InsertBorreewer_DAL(Book_DTO tv)
         {
            try
            {
                _conn.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = _conn;
                command.CommandText = "INSERT INTO BOOKSS( BOOK_ID, BOOKNAME, AUTHOR, PUBLICCATION_YEAR)" + "VALUES(@BOOK_ID,@BOOKNAME,@AUTHOR,@PUBLICCATION_YEAR)";
                SqlParameter parameter1 = new SqlParameter("@BOOK_ID", tv.BOOK_ID);
                command.Parameters.Add(parameter1);
                SqlParameter parameter2 = new SqlParameter("@BOOKNAME", tv.BOOKNAME);
                command.Parameters.Add(parameter2);
                SqlParameter parameter3 = new SqlParameter("@AUTHOR", tv.AUTHOR);
                command.Parameters.Add(parameter3);
                SqlParameter parameter4 = new SqlParameter("@PUBLICCATION_YEAR", tv.PUBLICCATION_YEAR);
                command.Parameters.Add(parameter4);
                result = command.ExecuteNonQuery();
                if(result > 0)
                {
                    return true;
                }
            }catch(Exception ex)
            {
                return false;
            }
            finally { _conn.Close(); }
            return false;
        }
        
        public bool UpdateBook_DAL(Book_DTO id)
        {
            Console.WriteLine(">>>>", id.ToString());
            try
            {
                // cách 1
                _conn.Open();
                string SQL = "UPDATE BOOKSS SET BOOKNAME=@BOOKNAME,AUTHOR=@AUTHOR ,PUBLICCATION_YEAR =@PUBLICCATION_YEAR WHERE BOOK_ID=@BOOK_ID";
                SqlCommand command = new SqlCommand(SQL, _conn);
                command.Parameters.AddWithValue("@BOOK_ID", id.BOOK_ID);
                command.Parameters.AddWithValue("@BOOKNAME", id.BOOKNAME);
                command.Parameters.AddWithValue("@AUTHOR", id.AUTHOR);
                command.Parameters.AddWithValue("@PUBLICCATION_YEAR", id.PUBLICCATION_YEAR);
                result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            finally { _conn.Close(); }
            return false;
        }

        public bool DeleteBook_DAL(string id)
        {
            try
            {
                _conn.Open();
                string SQL = "DELETE FROM BOOKSS WHERE BOOK_ID=@BOOK_ID";
                SqlCommand command = new SqlCommand(SQL, _conn);
                command.Parameters.AddWithValue("@BOOK_ID", id);
             

                if (command.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch(Exception ex)
            {
                return false;
            }
            finally { _conn.Close(); }
            return false;
        }
        public bool isCheckId_DAl(string id)
        {
            try
            {
                _conn.Open();
                string SQL = "SELECT COUNT(*) FROM BOOKSS WHERE BOOK_ID = @BOOK_ID";
                SqlCommand command = new SqlCommand(SQL, _conn);
                command.Parameters.AddWithValue("@BOOK_ID", id);
                int count = (int)command.ExecuteScalar();
                    return count > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally { _conn.Close(); }
            return false;
        }
        public DataTable SearchBorrew_DAL(string name)
        {
            string SQL = "SELECT * FROM BORROEEWER WHERE FIRSTNAME LIKE '%" +name+"%'"; 
            SqlDataAdapter dataAdapter = new SqlDataAdapter(SQL, _conn);
            DataTable dataTableBorr = new DataTable();
            dataAdapter.Fill(dataTableBorr);
            return dataTableBorr;
        }
    }
}
