using webBanVali.Models;
using Microsoft.AspNetCore.Mvc;
using webBanVali.Repository;
namespace webBanVali.ViewComponents
{
    public class LoaiSpViewComponent: ViewComponent
    {
        private readonly ILoaiSPRepository _loaiSp;
        public LoaiSpViewComponent(ILoaiSPRepository loaiSp)
        {
            _loaiSp = loaiSp;
        }
        public IViewComponentResult Invoke()
        {
            var loaisp = _loaiSp.GetAllLoaiSP().OrderBy(x => x.Loai);
            return View(loaisp);
        }

    }
}
