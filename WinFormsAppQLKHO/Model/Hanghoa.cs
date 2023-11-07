using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppQLKHO.Model
{
    internal class Hanghoa
    {
        private String mamh;
        private String tenmh;
        private String dvt;

        public Hanghoa() { }

        public Hanghoa(String mamh, String tenmh, String dvt)
        {
            this.mamh = mamh;
            this.tenmh = tenmh;
            this.dvt = dvt;
        }

        public String getMamh() { return mamh;}
        public String getTenmh() {  return tenmh;}
        public String getDvt() {  return dvt;}

        public void setMamh(String mamh) {  this.mamh = mamh; }
        public void setTenmh(String tenmh) {  this.tenmh = tenmh; }
        public void setDvt(String dvt) { this.dvt = dvt; }
        
        public String toString() { return mamh + tenmh; }
    }
}
