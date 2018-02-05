using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace OtelOtomasyonu
{
    public class Genel
    {
        public SqlConnection baglanti = new SqlConnection("Data Source=user-bilgisayar;Initial Catalog=OtelOtomasyonu;Integrated Security=True;MultipleActiveResultSets=True");

    }
}
