using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;
using DTO;
using System.Runtime.Remoting.Messaging;

namespace DAL
{
    public class DBconnect
    {
        protected SqlConnection _conn = new SqlConnection(@"Data Source=DESKTOP-IFEAUMD;Initial Catalog=LibraryManagementSystem;Integrated Security=True");
    }
}
