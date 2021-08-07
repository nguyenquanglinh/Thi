using DBStore.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBStore
{
    public class DbAcess
    {
        #region parameter connection
        SqlConnection connection = new SqlConnection();
        public static string strConnString = "Data Source =" + "DESKTOP-I80N8RF\\SQLEXPRESS;Database = QuanLyDoAnSnhVien; Integrated Security=SSPI;";
        #endregion

        #region function cơ bản 
        private void MoKetNoi()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.ConnectionString = strConnString;
                    connection.Open();
                }
            }
            catch
            {
                throw new Exception("Khong the mo duoc cong ket noi");
            }
        }
        public DbAcess()
        {
            MoKetNoi();
        }
        public bool HuyKetNoi()
        {
            try
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
                return true;
            }
            catch
            {
                throw new Exception("Khong the huy cong ket noi");
            }
        }
        public DataTable LayDuLieuTruyVanSQL(string Sql)
        {
            MoKetNoi();
            var ada = new SqlDataAdapter(Sql, connection);
            var dta = new DataTable();
            ada.Fill(dta);
            return dta;
        }
        public bool ThucThiTruyVan(string sql)
        {
            try
            {
                MoKetNoi();
                var cmd = new SqlCommand(sql, connection);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    HuyKetNoi();
                    return true;
                }
                return false;

            }
            catch
            {
                throw new Exception("Khong the thuc thi truy van");
            }
        }
        #endregion

        #region sql truy vấn bảng đồ án
        public List<DoAn> GetListDoAn(string maSV = null)
        {
            var ret = new List<DoAn>();
            string sql = "select * from DoAn";
            if (maSV != null)
                sql = "select * from DoAn where maSV=" + maSV;
            var x = LayDuLieuTruyVanSQL(sql);
            for (int i = 0; i < x.Rows.Count; i++)
            {
                ret.Add(new DoAn(x.Rows[i]));
            }
            return ret;
        }
        public List<DoAn> ThemDoAn(DoAn da)
        {
            string sql = "insert into DoAn(tenDoAn,moTa,file_word_pdf,file_source_code,maSV,maGVHD)values(N'" + da.TenDoAN + "',N'" + da.MoTa + "',N'" + da.FileWordPdf + "',N'" + da.FileSourceCode + "',N'" + da.MaSV + "',N'" + da.MaGVHD + "')";
            ThucThiTruyVan(sql);
            return GetListDoAn();
        }
        public List<DoAn> SuaDoAn(DoAn da)
        {
            string sql = "update DoAn set tenDoAn=N'" + da.TenDoAN +
                "',moTa=N'" + da.MoTa + "',file_word_pdf=N'" + da.FileWordPdf + "',file_source_code=N'" + da.FileSourceCode
                + "',maSV=N'"+da.MaSV+"',maGVHD='" + da.MaGVHD + "'where maDoAn=N'" + da.MaDoAn + "'";
            ThucThiTruyVan(sql);
            return GetListDoAn();
        }
        public List<DoAn> XoaDoAn(DoAn da)
        {
            string sql = "delete DoAn where maDoAn=" + da.MaDoAn;
            ThucThiTruyVan(sql);
            return GetListDoAn();
        }
        #endregion

        #region truy vấn bảng sinh viên
        public List<SinhVien> GetListSinhVien()
        {
            var ret = new List<SinhVien>();
            string sql = "select * from SinhVien";
            var x = LayDuLieuTruyVanSQL(sql);
            for (int i = 0; i < x.Rows.Count; i++)
            {
                ret.Add(new SinhVien(x.Rows[i]));
            }
            return ret;
        }
        public List<SinhVien> ThemSinhVien(SinhVien sv)
        {
            string sql = "insert into SinhVien(tenSV,passWord)values(N'" + sv.TenSV + "',N'" + sv.PassWord + "')";
            ThucThiTruyVan(sql);
            return GetListSinhVien();
        }
        public List<SinhVien> SuaSinhVien(SinhVien sv)
        {
            string sql = "update SinhVien set tenSV=N'"+sv.TenSV+"',passWord='"+sv.PassWord+"'where maSV=N'"+sv.MaSV+"'";
            ThucThiTruyVan(sql);
            return GetListSinhVien();
        }
        public List<SinhVien> XoaSinhVien(SinhVien sv)
        {
            string sql = "exec DeleteSinhVien "+sv.MaSV;
            ThucThiTruyVan(sql);
            return GetListSinhVien();
        }

        public bool CheckGiaoVienLogin(GiaoVien giaoVien)
        {
            string sql = "select * from GiaoVien where maGV=N'" + giaoVien.MaGV + "'and tenGV=N'" + giaoVien.TenGV + "' and passWord=N'" + giaoVien.PassWord + "'";
            return LayDuLieuTruyVanSQL(sql).Rows.Count > 0;
        }
        #endregion

        #region truy vấn bảng giáo viên
        public List<GiaoVien> GetListGiaoVien()
        {
            var ret = new List<GiaoVien>();
            string sql = "select * from GiaoVien";
            var x = LayDuLieuTruyVanSQL(sql);
            for (int i = 0; i < x.Rows.Count; i++)
            {
                ret.Add(new GiaoVien(x.Rows[i]));
            }
            return ret;
        }
        public List<GiaoVien> ThemGiaoVien(GiaoVien gv)
        {
            string sql = "insert into GiaoVien(tenGV,passWord)values(N'" + gv.TenGV + "',N'" + gv.PassWord + "')";
            ThucThiTruyVan(sql);
            return GetListGiaoVien();
        }
        public List<GiaoVien> SuaGiaoVien(GiaoVien gv)
        {
            string sql = "update GiaoVien set tenGV=N'" + gv.TenGV + "',passWord='" + gv.PassWord + "'where maGV=N'" + gv.MaGV + "'";
            ThucThiTruyVan(sql);
            return GetListGiaoVien();
        }
        public List<GiaoVien> XoaGiaoVien(GiaoVien sv)
        {
            string sql = "exec DeleteGiaoVien " + sv.MaGV;
            ThucThiTruyVan(sql);
            return GetListGiaoVien();
        }
        #endregion
        #region login
        public bool CheckSinhVienLogin(SinhVien sv)
        {
            string sql = "select * from SinhVien where maSV=N'" + sv.MaSV + "'and tenSV=N'" + sv.TenSV + "' and passWord=N'" + sv.PassWord + "'";
            return LayDuLieuTruyVanSQL(sql).Rows.Count>0; 
        }
        #endregion
    }
}

