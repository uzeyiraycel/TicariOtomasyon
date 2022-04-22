using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TICARIOTOMASYON
{
    class sqlbaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection con = new SqlConnection(@"Data Source=UZEYIRAYCEL-PC;Initial Catalog=DbOtomasyon;Integrated Security=True");
            con.Open();
            return con;
        }

    }
}
