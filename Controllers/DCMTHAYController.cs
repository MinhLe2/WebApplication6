using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication6.Controllers
{
    public class DCMTHAYController : Controller
    {
        // GET: DCMTHAY
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult TamGiac(string soA, string soB, string soC) {
            int a = Convert.ToInt32(soA);
            int b = Convert.ToInt32(soB);
            int c = Convert.ToInt32(soC);

            string sql = "insert into CheckTriangle(soA,soB,soC) values(@soA,@soB,@soC)";
            SqlCommand com = new SqlCommand(sql, con);
            com.CommandType = CommandType.Text;
            com.Parameters.AddWithValue("@SoA", a);
            com.Parameters.AddWithValue("@SoB", b);
            com.Parameters.AddWithValue("@SoC", c);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
            return View();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-076VVOB;Initial Catalog=Minh;Integrated Security=True");
    }
}