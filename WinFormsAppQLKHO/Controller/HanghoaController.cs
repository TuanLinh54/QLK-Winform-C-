using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsAppQLKHO.Model;
using WinFormsAppQLKHO.Utils;

namespace WinFormsAppQLKHO.Controller
{
    internal class HanghoaController
    {
        List<Hanghoa> lstHanghoa;
        Hanghoa hangHoa;
        public HanghoaController()
        {
            lstHanghoa = new List<Hanghoa>();
            hangHoa = new Hanghoa();
        }

        public List<Hanghoa> load()
        {
            SqlConnection conn = DataHelper.getConnection();

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM HANGHOA", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    String mamh = reader["MAMH"].ToString();
                    String tenmh = reader["TENMH"].ToString();
                    String dvt = reader["DVT"].ToString();

                    Hanghoa hangHoa = new Hanghoa(mamh, tenmh, dvt);
                    lstHanghoa.Add(hangHoa);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return lstHanghoa;
        }

        public Hanghoa Get(string mamh)
        {
            foreach (Hanghoa hangHoa in lstHanghoa)
            {
                if (hangHoa.getMamh() == mamh)
                {
                    return hangHoa;
                }
            }
            return null;
        }
        public bool insert(Hanghoa hangHoa)
        {
            string mamh = hangHoa.getMamh();
            string tenmh = hangHoa.getTenmh();
            string dvt = hangHoa.getDvt();
            using (SqlConnection conn = DataHelper.getConnection())
            {
                conn.Open();
                string query = "INSERT INTO HANGHOA(MAMH, TENMH, DVT) VALUES (@mamh, @tenmh, @dvt )";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@mamh", mamh);
                    command.Parameters.AddWithValue("@tenmh", tenmh);
                    command.Parameters.AddWithValue("@dvt", dvt);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        public bool update(Hanghoa hangHoa)
        {
            string mamh = hangHoa.getMamh();
            string tenmh = hangHoa.getTenmh();
            string dvt = hangHoa.getDvt();
            using (SqlConnection conn = DataHelper.getConnection())
            {
                conn.Open();
                string query = "UPDATE HANGHOA SET TENMH = @tenmh, DVT = @dvt WHERE MAMH = @mamh";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@mamh", mamh);
                    command.Parameters.AddWithValue("@tenmh", tenmh);
                    command.Parameters.AddWithValue("@dvt", dvt);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        public bool delete(string mamh)
        {
            using (SqlConnection conn = DataHelper.getConnection())
            {
                string query = "DELETE FROM HANGHOA WHERE MAMH = '" + mamh + "'";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@mamh", mamh);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }

            }

        }

        public bool delete(Hanghoa hangHoa)
        {
            string mamh = hangHoa.getMamh();
            string tenmh = hangHoa.getTenmh();
            string dvt = hangHoa.getDvt();
            using (SqlConnection conn = DataHelper.getConnection())
            {
                conn.Open();
                string query = "DELETE FROM HANGHOA WHERE MAMH = '" + mamh + "'";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@mamh", mamh);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        /*
         * Method name: isExist
         * Parameters:
         *  String mamh : mã kho cần kiểm tra sự tồn tại
         * Output:
         *  true: nếu mamh đã tồn tại trong csdl
         *  false: nếu mamh chưa có trong csdl
         */

        public bool isExist(String mamh)
        {
            using (SqlConnection conn = DataHelper.getConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM HANGHOA WHERE MAMH = @mamh";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@mamh", mamh);
                    int rowCount = (int)command.ExecuteScalar();
                    return rowCount > 0;
                }
            }

        }

        /*
         * Method name: isExist
         * Parameters:
         *  Hanghoa hangHoa : đối tượng cần kiểm tra sự tồn tại
         * Output:
         *  true: nếu mamh của đối tượng đã tồn tại trong csdl
         *  false: nếu mamh của đối tượng chưa có trong csdl
         */

        public bool isExist(Hanghoa hangHoa)
        {
            using (SqlConnection conn = DataHelper.getConnection())
            {
                conn.Open();
                string mamh = hangHoa.getMamh();
                string query = "SELECT COUNT(*) FROM HANGHOA WHERE MAMH = @mamh";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@mamh", hangHoa.getMamh());
                    int rowCount = (int)command.ExecuteScalar();
                    return rowCount > 0;
                }
            }

            return false;
        }
    }
}
