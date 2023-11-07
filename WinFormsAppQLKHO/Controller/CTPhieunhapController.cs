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
    internal class CTPhieunhapController
    {
        List<CTPhieunhap> lstCTPhieunhap;
        CTPhieunhap CTphieuNhap;
        public CTPhieunhapController()
        {
            lstCTPhieunhap = new List<CTPhieunhap>();
            CTphieuNhap = new CTPhieunhap();
        }

        public List<CTPhieunhap> load()
        {
            SqlConnection conn = DataHelper.getConnection();

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM CHITIETPHIEUNHAP", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Int32 id = Int32.Parse(reader["ID"].ToString());
                    String mapn = reader["MAPN"].ToString();
                    String mamh = reader["MAMH"].ToString();
                    Int32 sluong = Int32.Parse(reader["SOLUONG"].ToString());
                    Decimal dongia = Decimal.Parse(reader["DONGIA"].ToString());

                    CTPhieunhap CTphieuNhap = new CTPhieunhap( mapn, mamh, sluong, dongia);
                    lstCTPhieunhap.Add(CTphieuNhap);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return lstCTPhieunhap;
        }

        public CTPhieunhap Get(string mapn)
        {
            foreach (CTPhieunhap CTphieuNhap in lstCTPhieunhap)
            {
                if (CTphieuNhap.getMapn() == mapn)
                {
                    return CTphieuNhap;
                }
            }
            return null;
        }
        public bool insert(CTPhieunhap CTphieuNhap)
        {
            string mapn = CTphieuNhap.getMapn();
            string mamh = CTphieuNhap.getMamh();
            Int32 sluong = CTphieuNhap.getSluong();
            decimal dongia = CTphieuNhap.getDongia();

            using (SqlConnection conn = DataHelper.getConnection())
            {
                conn.Open();
                string query = "INSERT INTO CHITIETPHIEUNHAP(MAPN, MAMH, SOLUONG, DONGIA) " +
                    "VALUES (@mapn, @mamh, @sluong, @dongia)";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@mapn", mapn);
                    command.Parameters.AddWithValue("@mamh", mamh);
                    command.Parameters.AddWithValue("@sluong", sluong);
                    command.Parameters.AddWithValue("@dongia", dongia);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        public bool update(CTPhieunhap CTphieuNhap)
        {
            Int32 id = CTphieuNhap.getId();
            string mapn = CTphieuNhap.getMapn();
            string mamh = CTphieuNhap.getMamh();
            Int32 sluong = CTphieuNhap.getSluong();
            decimal dongia = CTphieuNhap.getDongia();
            using (SqlConnection conn = DataHelper.getConnection())
            {
                conn.Open();
                string query = "UPDATE CHITIETPHIEUNHAP SET MAPN = @mapn, MAMH = @mamh, SOLUONG = @sluong, DONGIA = @dongia, " +
                    "WHERE ID = @id";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@mapn", mapn);
                    command.Parameters.AddWithValue("@mamh", mamh);
                    command.Parameters.AddWithValue("@sluong", sluong);
                    command.Parameters.AddWithValue("@dongia", dongia);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        public bool delete(string mapn)
        {
            using (SqlConnection conn = DataHelper.getConnection())
            {
                string query = "DELETE FROM CHITIETPHIEUNHAP WHERE MAPN = '" + mapn + "'";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@mapn", mapn);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }

            }

        }

        public bool delete(CTPhieunhap phieuNhap)
        {
            string mapn = CTphieuNhap.getMapn();
            string mamh = CTphieuNhap.getMamh();
            Int32 sluong = CTphieuNhap.getSluong();
            decimal dongia = CTphieuNhap.getDongia();
            using (SqlConnection conn = DataHelper.getConnection())
            {
                conn.Open();
                string query = "DELETE FROM CHITIETPHIEUNHAP WHERE MAPN = '" + mapn + "'";
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
                string query = "SELECT COUNT(*) FROM CHITIETPHIEUNHAP WHERE MAPN = @mapn";

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
         *  CTPhieunhap phieuNhap : đối tượng cần kiểm tra sự tồn tại
         * Output:
         *  true: nếu mamh của đối tượng đã tồn tại trong csdl
         *  false: nếu mamh của đối tượng chưa có trong csdl
         */

        public bool isExist(CTPhieunhap phieuNhap)
        {
            using (SqlConnection conn = DataHelper.getConnection())
            {
                conn.Open();
                string mapn = phieuNhap.getMapn();
                string query = "SELECT COUNT(*) FROM CHITIETPHIEUNHAP WHERE MAPN = @mapn";

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
