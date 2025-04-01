using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;


namespace DAL
{
    public class DALNhaCungCap
    {
        DataContext db = new DataContext();

        public List<NhaCungCap> layNhaCungCap()
        {
            List<NhaCungCap> arr = new List<NhaCungCap>();

            var nccs = (from x in db.NhaCungCapLinqs
                        select new { x.maNhaCungCap, x.tenNhaCungCap, x.diaChi });
            foreach (var ncc in nccs)
            {
                NhaCungCap x = new NhaCungCap(ncc.maNhaCungCap, ncc.tenNhaCungCap, ncc.diaChi);
                arr.Add(x);
            }

            return arr;
        }
        public List<NhaCungCap> layNhaCungCapTheoTen(string tenNhaCungCap)
        {
            List<NhaCungCap> arr = new List<NhaCungCap>();
            var nccs = (from x in db.NhaCungCapLinqs where x.tenNhaCungCap == tenNhaCungCap
                        select new { x.maNhaCungCap, x.tenNhaCungCap, x.diaChi });
            foreach (var ncc in nccs)
            {
                NhaCungCap x = new NhaCungCap(ncc.maNhaCungCap, ncc.tenNhaCungCap, ncc.diaChi);
                arr.Add(x);
            }
            return arr;
        }
        public List<NhaCungCap> layNhaCungCapTheoMa(string maNhaCungCap)
        {
            List<NhaCungCap> arr = new List<NhaCungCap>();
            var nccs = (from x in db.NhaCungCapLinqs 
                        where x.maNhaCungCap == int.Parse(maNhaCungCap)
                        select new { x.maNhaCungCap, x.tenNhaCungCap, x.diaChi });
            foreach (var ncc in nccs)
            {
                NhaCungCap x = new NhaCungCap(ncc.maNhaCungCap, ncc.tenNhaCungCap, ncc.diaChi);
                arr.Add(x);
            }
            return arr;

        }
        public void themNhaCungCap(NhaCungCap ncc)
        {
            NhaCungCapLinq nccm = new NhaCungCapLinq();
            nccm.maNhaCungCap = ncc.MaNhaCungCap;
            nccm.tenNhaCungCap = ncc.TenNhaCungCap;
            nccm.diaChi = ncc.DiaChi;
            db.NhaCungCapLinqs.InsertOnSubmit(nccm);
            db.SubmitChanges();
        }
        public void suaNhaCungCap(NhaCungCap ncc)
        {
            var capnhat = db.NhaCungCapLinqs.Single(nccs => nccs.maNhaCungCap == ncc.MaNhaCungCap);
            capnhat.maNhaCungCap = ncc.MaNhaCungCap;
            capnhat.tenNhaCungCap = ncc.TenNhaCungCap;
            capnhat.diaChi = ncc.DiaChi;
            db.SubmitChanges();
        }

        public void xoaNhaCungCap(NhaCungCap ncc)
        {
            var xoa = from nccs in db.NhaCungCapLinqs where nccs.maNhaCungCap == ncc.MaNhaCungCap select nccs;
            foreach(var i in xoa)
            {
                db.NhaCungCapLinqs.DeleteOnSubmit(i);
                db.SubmitChanges();
            }
        }
    }
}
