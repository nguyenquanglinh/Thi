using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBStore.DAO
{
   public class DoAn
    {
        public DoAn() {  }
        public DoAn(DataRow dataRow):this(dataRow["maDoAn"].ToString(),
            dataRow["tenDoAn"].ToString(),
            dataRow["moTa"].ToString(),
            dataRow["file_word_pdf"].ToString(),
            dataRow["file_source_code"].ToString(),
            dataRow["maSV"].ToString(),
            dataRow["maGVHD"].ToString()
            )
        {
        }

        public DoAn(string maDoAn,string tenDoAn, string moTa,string file_word_pdf,string file_source_code,string maSV,string maGV):this(tenDoAn,moTa,file_word_pdf,file_source_code,maSV,maGV) {
            this.MaDoAn = maDoAn;
        }
        public DoAn(string tenDoAn, string moTa, string file_word_pdf, string file_source_code, string maSV, string maGV):this(tenDoAn)
        {
            this.MoTa = moTa;
            this.FileWordPdf = file_word_pdf;
            this.FileSourceCode = file_source_code;
            this.MaSV = maSV;
            this.MaGVHD = maGV;
        }
        public DoAn(string tenDoAn):this()
        {
            this.TenDoAN = tenDoAn;

        }
        public string MaDoAn { get; set; }
        public string MaSV { get; }
        public string TenDoAN { get; set; }
        public string MoTa { get; set; }
        public string MaGVHD { get; set; }
        public string FileWordPdf { get; set; }
        public string FileSourceCode { get; set; }
    }
}
