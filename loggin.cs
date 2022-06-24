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
    class loggin
    {
        public DataTable login(string user, string pass, SqlConnection con)
        {
            DataTable tb = new DataTable();
            string strSql = "SELECT * FROM Usuarios WHERE Usuario = @user AND Pass = @pass";
            SqlDataAdapter da = new SqlDataAdapter(strSql, con);
            da.SelectCommand.CommandType = CommandType.Text;
            da.SelectCommand.Parameters.Add("@user", SqlDbType.VarChar, 15).Value = user;
            da.SelectCommand.Parameters.Add("@pass", SqlDbType.VarChar, 50).Value = pass;
            da.Fill(tb);
            return tb;
        }
        public DataTable dni(Int32 dni, SqlConnection con)
        {
            DataTable tb = new DataTable();
            string strSql = "SELECT * FROM DNI WHERE DNI = @dni";
            SqlDataAdapter da = new SqlDataAdapter(strSql, con);
            da.SelectCommand.CommandType = CommandType.Text;
            da.SelectCommand.Parameters.Add("@dni", SqlDbType.BigInt).Value = dni;
            da.Fill(tb);
            return tb;
        }
    }
}
