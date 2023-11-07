using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsAppQLKHO.Model;
using WinFormsAppQLKHO.Utils;

namespace WinFormsAppQLKHO
{
    internal class khoController
    {

        List<kho> lstkho;

        public khoController()
        {
            lstkho = new List<kho>();
        }

        public List<kho> load()
        {
            SqlConnection conn = DataHelper.getConnection();

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM KHO", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read()) {
                    String makho = reader["makho"].ToString();
                    String tenkho = reader["tenkho"].ToString();
                    String diachi = reader["diachi"].ToString();

                    kho Kho = new kho(makho, tenkho, diachi);
                    lstkho.Add(Kho);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return lstkho;
        }

        public kho Get(string makho)
        {
            foreach (kho kho in lstkho)
            {
                if(kho.getMakho() == makho)
                {
                    return kho;
                }
            }
            return null;
        }

        public bool delete(string makho)
        {
            using (SqlConnection conn = DataHelper.getConnection())
            {
                string query = "DELETE FROM KHO WHERE MAKHO = '" + makho + "'";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@makho", makho);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }

            }

        }

        public bool delete(kho Kho)
        {
            string makho = Kho.getMakho();
            string tenkho = Kho.getTenkho();
            string diachi = Kho.getDiachi();
            using (SqlConnection conn = DataHelper.getConnection())
            {
                conn.Open();
                string query = "DELETE FROM KHO WHERE MAKHO = '" + makho + "'";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@makho", makho);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public bool insert(kho Kho)
        {
            string makho = Kho.getMakho();
            string tenkho = Kho.getTenkho();
            string diachi = Kho.getDiachi();
            using (SqlConnection conn = DataHelper.getConnection())
            {
                conn.Open();
                string query = "INSERT INTO KHO(MAKHO, TENKHO, DIACHI) VALUES (@makho, @tenkho, @diachi )";
                using(SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@makho", makho);
                    command.Parameters.AddWithValue("@tenkho", tenkho);
                    command.Parameters.AddWithValue("@diachi", diachi);
                    
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public bool update(kho Kho)
        {
            string makho = Kho.getMakho();
            string tenkho = Kho.getTenkho();
            string diachi = Kho.getDiachi();
            using (SqlConnection conn = DataHelper.getConnection())
            {
                conn.Open();
                string query = "UPDATE KHO SET DIACHI = @diachi, TENKHO = @tenkho WHERE MAKHO = @makho";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@makho", makho);
                    command.Parameters.AddWithValue("@tenkho", tenkho);
                    command.Parameters.AddWithValue("@diachi", diachi);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        /*
         * Method name: isExist
         * Parameters:
         *  String makho : mã kho cần kiểm tra sự tồn tại
         * Output:
         *  true: nếu makho đã tồn tại trong csdl
         *  false: nếu makho chưa có trong csdl
         */

        public bool isExist(String makho)
        {
            using (SqlConnection conn = DataHelper.getConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM KHO WHERE MAKHO = @makho";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@makho", makho);
                    int rowCount = (int)command.ExecuteScalar();
                    return rowCount > 0;
                }
            }

        }

        /*
         * Method name: isExist
         * Parameters:
         *  kho Kho : đối tượng cần kiểm tra sự tồn tại
         * Output:
         *  true: nếu makho của đối tượng đã tồn tại trong csdl
         *  false: nếu makho của đối tượng chưa có trong csdl
         */

        public bool isExist(kho Kho)
        {
            using (SqlConnection conn = DataHelper.getConnection())
            {
                conn.Open();
                string makho = Kho.getMakho();
                string query = "SELECT COUNT(*) FROM KHO WHERE MAKHO = @makho";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@makho", Kho.getMakho());
                    int rowCount = (int)command.ExecuteScalar();
                    return rowCount > 0;
                }
            }

            return false;
        }
    }
}
