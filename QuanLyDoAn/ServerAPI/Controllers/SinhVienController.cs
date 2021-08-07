using DBStore.DAO;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ServerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SinhVienController : ControllerBase
    {
        [HttpGet]
        public List<SinhVien> GetListDoAn()
        {
             return new DBStore.DbAcess().GetListSinhVien();
        }
        [HttpPost]
        public List<SinhVien> AddSinhVien(SinhVien sv)
        {
            return new DBStore.DbAcess().ThemSinhVien(sv);
        }
        [HttpPut]
        public List<SinhVien> UpdateDoAn(SinhVien sv)
        {
            return new DBStore.DbAcess().SuaSinhVien(sv);
        }
        [HttpDelete]
        public List<SinhVien> DeleteDoAn(string maSV, string tenSV="", string passWord="")
        {
            return new DBStore.DbAcess().XoaSinhVien(new SinhVien(maSV, tenSV, passWord));
        }
    }
}
