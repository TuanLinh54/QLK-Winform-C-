using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsAppQLKHO.Utils;

namespace WinFormsAppQLKHO.Model
{
    internal class kho
    {
        private String makho;
        private String tenkho;
        private String diachi;

        public kho() { }

        public kho (String makho, String tenkho, String diachi)
        {
            this.makho = makho;
            this.tenkho = tenkho;
            this.diachi = diachi;
        }
        
        public String getMakho() { return makho; }
        public String getTenkho() { return tenkho; }
        public String getDiachi() { return diachi; }

        public void setMakho(String makho)
        {
            this.makho = makho;
        }
        public void setTenkho(String tenkho)
        {
            this.tenkho = tenkho;
        }
        public void setDiachi(String diachi)
        {
            this.diachi = diachi;
        }

        public String toString()
        {
            return makho + tenkho;
        }
        
    }
}
