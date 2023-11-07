using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppQLKHO.Model
{
    internal class CTPhieunhap
    {
        private Int32 id;
        private String mapn;
        private String mamh;
        private Int32 sluong;
        private Decimal dongia;

        public CTPhieunhap() { }

        public CTPhieunhap( string mapn, string mamh, int sluong, decimal dongia)
        {
            this.mapn = mapn;
            this.mamh = mamh;
            this.sluong = sluong;
            this.dongia = dongia;
        }

        public Int32 getId() { return id; }
        public String getMapn() {  return mapn; }
        public String getMamh() {  return mamh; }
        public Int32 getSluong() {  return sluong; }
        public Decimal getDongia() {  return dongia; }

        // public void setId(Int32 id) { this.id = id; }
        public void setMapn(String mapn) {  this.mapn = mapn; }
        public void setMamh(String mamh) {  this.mamh = mamh; }
        public void setSluong(Int32 sluong) {  this.sluong = sluong;}
        public void setDongia(Decimal dongia) {  this.dongia = dongia;}

    }
}
