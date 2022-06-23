using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TRABAJOFINAL
{
    class Class1
    {
        public static SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection("SERVER= DESKTOP-N1R7OD4; DATABASE= Consultorio; integrated security=true;");
            cn.Open();
            return cn;

        }
    }
}

