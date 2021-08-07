using DBStore.DAO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Linq;

namespace WebUploadDoAn.Controllers
{
    public class HomeController : Controller
    {
        private static string maSV = null;
        private static string maGV = null;
        public IActionResult Index()
        {
            ViewBag.Session = maSV;
            ViewBag.maGV = maGV;
            if (ViewBag.Session != null)
                return View(new DBStore.DbAcess().GetListDoAn(maSV));
            else if (ViewBag.maGV != null)
                return View(new DBStore.DbAcess().GetListDoAn());
            return RedirectToAction("login");
        }
        public IActionResult Create()
        {
            if (maSV == null && maGV == null)
                return RedirectToAction("login");
            ViewBag.Session = maSV;
            ViewBag.maGV = maGV;
            ViewBag.ListGVHD = new DBStore.DbAcess().GetListGiaoVien();
            ViewBag.ListSV = new DBStore.DbAcess().GetListSinhVien();
            return View();
        }
        private string CopyFile(IFormFile FileWordPdf, string folderName = "wwwroot")
        {
            var path = "";
            try
            {
                path = Path.Combine(
                  Directory.GetCurrentDirectory(), folderName,
                  FileWordPdf.FileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    FileWordPdf.CopyToAsync(stream);
                }
            }
            catch
            {
            }
            return path;
        }
        [HttpPost]
        public IActionResult Create(string MaDoAn, string MaSV, string TenDoAN, string MoTa, string MaGVHD,
            IFormFile FileWordPdf, IFormFile FileSourceCode)
        {
            if (maSV == null)
                return RedirectToAction("login");
            CopyFile(FileWordPdf);
            CopyFile(FileSourceCode);
            ViewBag.Session = maSV;
            new DBStore.DbAcess().ThemDoAn(new DoAn(MaDoAn, TenDoAN, MoTa, FileWordPdf.FileName, FileSourceCode.FileName, MaSV, MaGVHD));
            return RedirectToAction("index");
        }
        public IActionResult Edit(string id)
        {
            if (maSV == null)
                return RedirectToAction("login");
            ViewBag.Session = maSV;
            ViewBag.ListGVHD = new DBStore.DbAcess().GetListGiaoVien();
            return View(new DBStore.DbAcess().GetListDoAn().Where(i => i.MaDoAn == id).FirstOrDefault());
        }
        [HttpPost]
        public IActionResult Edit(string MaDoAn, string MaSV, string TenDoAN, string MoTa, string MaGVHD,
            IFormFile FileWordPdf, IFormFile FileSourceCode)
        {
            if (maSV == null)
                return RedirectToAction("login");
            var doAn = new DBStore.DbAcess().GetListDoAn().Where(i => i.MaDoAn == MaDoAn).FirstOrDefault();
            ViewBag.Session = maSV;
            if (FileWordPdf != null)
               doAn.FileWordPdf= CopyFile(FileWordPdf);
            if (FileSourceCode != null)
                doAn.FileSourceCode= CopyFile(FileSourceCode);
            doAn.TenDoAN = TenDoAN;
            doAn.MoTa = MoTa;
            doAn.MaGVHD = MaGVHD;
            new DBStore.DbAcess().SuaDoAn(doAn);
            return RedirectToAction("index");
        }
        public IActionResult Details(string id)
        {

            ViewBag.Session = maSV;
            ViewBag.maGV = maGV;
            if (ViewBag.Session != null)
                return View(new DBStore.DbAcess().GetListDoAn(maSV).Where(i => i.MaDoAn == id).FirstOrDefault());
            else if (ViewBag.maGV != null)
                return View(new DBStore.DbAcess().GetListDoAn().Where(i => i.MaDoAn == id).FirstOrDefault());
            return RedirectToAction("login");

        }
        public IActionResult Delete(string id)
        {
            if (maSV == null&&maGV==null)
                return RedirectToAction("login");
            ViewBag.Session = maSV;
            
            var doAn = new DBStore.DbAcess().GetListDoAn().Where(i => i.MaDoAn == id).FirstOrDefault();
            ViewBag.maDoAn = id;
            ViewBag.FileWordPdf = doAn.FileWordPdf;
            ViewBag.FileSourceCode = doAn.FileSourceCode;
            return View(doAn);
        }
        [HttpPost]
        public IActionResult Delete(string MaDoAn, string FileWordPdf, string FileSourceCode)
        {
            if (maSV == null&&maGV==null)
                return RedirectToAction("login");
            ViewBag.Session = maSV;
            var da=new DoAn();
            da.MaDoAn = MaDoAn;
            new DBStore.DbAcess().XoaDoAn(da);
            return RedirectToAction("index");
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string TenSV, string PassWord, string MaSV)
        {

            if (new DBStore.DbAcess().CheckSinhVienLogin(new SinhVien(MaSV, TenSV, PassWord)))
            {
                maSV = MaSV;
                return RedirectToAction("index");
            }
            else if (new DBStore.DbAcess().CheckGiaoVienLogin(new GiaoVien(MaSV, TenSV, PassWord)))
            {
                maGV = MaSV;
                return RedirectToAction("index");
            }
            ViewBag.LoginErr = "Thông tin tài khoản không chính xác";
            return View();
        }
        public IActionResult Logout()
        {
            maSV = null;
            maGV = null;
            return RedirectToAction("index");
        }
        public IActionResult Privacy()
        {
            return RedirectToAction("index");
        }
    }
}
