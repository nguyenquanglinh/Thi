using DBStore.DAO;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ServerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoAnController : ControllerBase
    {
        [HttpGet]
        public List<DoAn> GetListDoAn(string maSV=null)
        {
            return new DBStore.DbAcess().GetListDoAn(maSV);
        }
        [HttpPost]
        public List<DoAn> AddDoAn(DoAn doAn)
        {
            return new DBStore.DbAcess().ThemDoAn(doAn);
        }
        [HttpPut]
        public List<DoAn> UpdateDoAn(DoAn doAn)
        {
            return new DBStore.DbAcess().SuaDoAn(doAn);
        }
        [HttpDelete]
        public List<DoAn> DeleteDoAn(string maDoAn, string tenDoAn="", string moTa="", string file_word_pdf="", string file_source_code="", string maSV="", string maGV="")
        {
            return new DBStore.DbAcess().XoaDoAn(new DoAn(maDoAn, tenDoAn, moTa, file_word_pdf, file_source_code, maSV, maGV));
        }
    }
}
