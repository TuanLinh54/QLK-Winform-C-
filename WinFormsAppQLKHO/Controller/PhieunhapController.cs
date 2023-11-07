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
    internal class PhieunhapController
    {
        List<Phieunhap> lstPhieunhap;
        Phieunhap phieuNhap;
        public PhieunhapController()
        {
            lstPhieunhap = new List<Phieunhap>();
            phieuNhap = new Phieunhap();
        }

        public List<Phieunhap> load()
        {
            SqlConnection conn = DataHelper.getConnection();

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM PHIEUNHAP", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    String mapn = reader["MAPN"].ToString();
                    String makho = reader["MAKHO"].ToString();
                    DateTime ngaypn = DateTime.Parse(reader["NGAYPN"].ToString());
                    String nguoigiao = reader["NGUOIGIAO"].ToString();
                    String sohd = reader["SOHD"].ToString();
                    DateTime ngayhd = DateTime.Parse(reader["NGAYHD"].ToString());
                    String dvgiao = reader["DVGIAO"].ToString();

                    Phieunhap phieuNhap = new Phieunhap(mapn, makho, ngaypn, nguoigiao, sohd, ngayhd, dvgiao);
                    lstPhieunhap.Add(phieuNhap);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return lstPhieunhap;
        }

        public Phieunhap Get(string mapn)
        {
            foreach (Phieunhap phieuNhap in lstPhieunhap)
            {
                if (phieuNhap.getMapn() == mapn)
                {
                    return phieuNhap;
                }
            }
            return null;
        }
        public bool insert(Phieunhap phieuNhap)
        {
            string mapn = phieuNhap.getMapn();
            string makho = phieuNhap.getMakho();
            DateTime ngaypn = phieuNhap.getNgaypn();
            string nguoigiao = "";
            string sohd = phieuNhap.getSohd();
            DateTime ngayhd = phieuNhap.getNgayhd();
            string dvgiao = phieuNhap.getDvgiao();
            using (SqlConnection conn = DataHelper.getConnection())
            {
                conn.Open();
                string query = "INSERT INTO PHIEUNHAP(MAPN, MAKHO, NGAYPN, NGUOIGIAO, SOHD, NGAYHD, DVGIAO) " +
                    "VALUES (@mapn, @makho, @ngaypn, @nguoigiao, @sohd, @ngayhd, @dvgiao )";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@mapn", mapn);
                    command.Parameters.AddWithValue("@makho", makho);
                    command.Parameters.AddWithValue("@ngaypn", ngaypn);
                    command.Parameters.AddWithValue("@nguoigiao", nguoigiao);
                    command.Parameters.AddWithValue("@sohd", sohd);
                    command.Parameters.AddWithValue("@ngayhd", ngayhd);
                    command.Parameters.AddWithValue("@dvgiao", dvgiao);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        public bool update(Phieunhap phieuNhap)
        {
            string mapn = phieuNhap.getMapn();
            string makho = phieuNhap.getMakho();
            DateTime ngaypn = phieuNhap.getNgaypn();
            string nguoigiao = phieuNhap.getNguoigiao();
            string sohd = phieuNhap.getSohd();
            DateTime ngayhd = phieuNhap.getNgayhd();
            string dvgiao = phieuNhap.getDvgiao();
            using (SqlConnection conn = DataHelper.getConnection())
            {
                conn.Open();
                string query = "UPDATE PHIEUNHAP SET MAKHO = @makho, NGAYPN = @ngaypn, NGUOIGIAO = @nguoigiao, SOHD = @sohd, NGAYHD = @ngayhd, DVGIAO = @dvgiao, " +
                    "WHERE MAPN = @mapn";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@mapn", mapn);
                    command.Parameters.AddWithValue("@makho", makho);
                    command.Parameters.AddWithValue("@ngaypn", ngaypn);
                    command.Parameters.AddWithValue("@nguoigiao", nguoigiao);
                    command.Parameters.AddWithValue("@sohd", sohd);
                    command.Parameters.AddWithValue("@ngayhd", ngayhd);
                    command.Parameters.AddWithValue("@dvgiao", dvgiao);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        public bool delete(string mapn)
        {
            using (SqlConnection conn = DataHelper.getConnection())
            {
                string query = "DELETE FROM PHIEUNHAP WHERE MAPN = '" + mapn + "'";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@mapn", mapn);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }

            }

        }

        public bool delete(Phieunhap phieuNhap)
        {
            string mapn = phieuNhap.getMapn();
            string makho = phieuNhap.getMakho();
            DateTime ngaypn = phieuNhap.getNgaypn();
            string nguoigiao = phieuNhap.getNguoigiao();
            string sohd = phieuNhap.getSohd();
            DateTime ngayhd = phieuNhap.getNgayhd();
            string dvgiao = phieuNhap.getDvgiao();
            using (SqlConnection conn = DataHelper.getConnection())
            {
                conn.Open();
                string query = "DELETE FROM PHIEUNHAP WHERE MAPN = '" + mapn + "'";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@mapn", mapn);

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

        public bool isExist(String mapn)
        {
            using (SqlConnection conn = DataHelper.getConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM PHIEUNHAP WHERE MAPN = @mapn";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@mapn", mapn);
                    int rowCount = (int)command.ExecuteScalar();
                    return rowCount > 0;
                }
            }

        }

        /*
         * Method name: isExist
         * Parameters:
         *  Phieunhap phieuNhap : đối tượng cần kiểm tra sự tồn tại
         * Output:
         *  true: nếu mamh của đối tượng đã tồn tại trong csdl
         *  false: nếu mamh của đối tượng chưa có trong csdl
         */

        public bool isExist(Phieunhap phieuNhap)
        {
            using (SqlConnection conn = DataHelper.getConnection())
            {
                conn.Open();
                string mapn = phieuNhap.getMapn();
                string query = "SELECT COUNT(*) FROM PHIEUNHAP WHERE MAPN = @mapn";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@mapn", phieuNhap.getMapn());
                    int rowCount = (int)command.ExecuteScalar();
                    return rowCount > 0;
                }
            }

            return false;
        }
    }
}
