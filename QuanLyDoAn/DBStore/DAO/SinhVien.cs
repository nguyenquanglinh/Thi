using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBStore.DAO
{
    public class SinhVien
    {
        public SinhVien(string tenSV, string passWord):this()
        {
            this.TenSV = tenSV;
            this.PassWord = passWord;
        }
        public SinhVien(string maSV,string tenSV, string passWord):this(tenSV,passWord)
        {
            this.MaSV = maSV;
        }
        
        public SinhVien(DataRow dataRow) : this(dataRow["maSV"].ToString(), dataRow["tenSV"].ToString(), dataRow["passWord"].ToString())
        {
            
        }
        public SinhVien() { }
        public string TenSV { get; set; }
        public string PassWord { get; set; }
        public string MaSV { get; set; }
    }
}
