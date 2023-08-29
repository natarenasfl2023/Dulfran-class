using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace APP_COMERCIO
{
    public class CLS_CONEXION
    {
        public SqlConnection connection = new SqlConnection("Data Source=DESKTOP-EEKCIUN;Initial Catalog=dbs_comercio;Integrated Security=True");
    }
}