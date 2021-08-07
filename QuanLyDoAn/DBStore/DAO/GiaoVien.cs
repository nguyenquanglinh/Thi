using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBStore.DAO
{
    public class GiaoVien
    {
        public GiaoVien() { }
        public GiaoVien(string tenGV, string passWord):this()
        {
            this.TenGV = tenGV;
            this.PassWord = passWord;
        }
        public GiaoVien(string maGV, string tenGV, string passWord) : this(tenGV, passWord)
        {
            this.MaGV = maGV;
        }

        public GiaoVien(DataRow dataRow) : this(dataRow["maGV"].ToString(), dataRow["tenGV"].ToString(), dataRow["passWord"].ToString())
        {

        }
        public string TenGV { get; set; }
        public string PassWord { get; set; }
        public string MaGV { get; set; }
    }
}
