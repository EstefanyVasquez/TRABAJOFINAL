using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TRABAJOFINAL
{
    class Class1
    {
        public static SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection(@"server=JOSE2021\SQLEXPRESS; database=Consultorio; Integrated security=true;");
            cn.Open();
            return cn;
        }

    }
}

