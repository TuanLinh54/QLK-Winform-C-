using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppQLKHO.Model
{
    internal class Phieunhap
    {
        private String mapn;
        private String makho;
        private DateTime ngaypn;
        private String nguoigiao;
        private String sohd;
        private DateTime ngayhd;
        private String dvgiao;

        public Phieunhap() { }

        public Phieunhap(String mapn, String makho, DateTime ngaypn, String nguoigiao, String sohd, DateTime ngayhd, String dvgiao)
        {
            this.mapn = mapn;
            this.makho = makho;
            this.ngaypn = ngaypn;
            this.nguoigiao = nguoigiao;
            this.sohd = sohd;
            this.ngayhd = ngayhd;
            this.dvgiao = dvgiao;
        }

        public String getMapn() {  return mapn; }
        public String getMakho() {  return makho; }
        public DateTime getNgaypn() {  return ngaypn; }
        public String getNguoigiao() {  return nguoigiao; }
        public String getSohd() {  return sohd; }
        public DateTime getNgayhd() {  return ngayhd; }
        public String getDvgiao() {  return dvgiao; }

        public void setMapn(String mapn) {  this.mapn = mapn; }
        public void setMakho(String makho) {  this.makho = makho; }
        public void setNgaypn(DateTime ngaypn) { this.ngaypn = ngaypn; }
        public void setNguoigiao(String nguoigiao) { this.nguoigiao = nguoigiao; }
        public void setSohd(String sohd) { this.sohd = sohd; }
        public void setNgayhd(DateTime ngayhd) { this.ngayhd = ngayhd; }
        public void setDvgiao(String dvgiao) { this.dvgiao = dvgiao; }
    }
}
