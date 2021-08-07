using DBStore.DAO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GiaoVienController : ControllerBase
    {
        [HttpGet]
        public List<GiaoVien> GetListGiaoVien()
        {
            return new DBStore.DbAcess().GetListGiaoVien();
        }
        [HttpPost]
        public List<GiaoVien> AddGiaoVien(GiaoVien gv)
        {
            return new DBStore.DbAcess().ThemGiaoVien(gv);
        }
        [HttpPut]
        public List<GiaoVien> UpdateDoAn(GiaoVien gv)
        {
            return new DBStore.DbAcess().SuaGiaoVien(gv);
        }
        [HttpDelete]
        public List<GiaoVien> DeleteDoAn(string maGV, string tenGV="", string passWord="")
        {
            return new DBStore.DbAcess().XoaGiaoVien(new GiaoVien(maGV, tenGV, passWord));
        }
    }
}
