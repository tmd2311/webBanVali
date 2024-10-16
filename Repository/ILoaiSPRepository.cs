using webBanVali.Models;
using webBanVali.Models;
namespace webBanVali.Repository
{
    public interface ILoaiSPRepository
    {
        TLoaiSp Add(TLoaiSp loaiSp);
        TLoaiSp Update(TLoaiSp loaiSp);
        TLoaiSp Delete(string maloaiSp);
        TLoaiSp GetLoaiSp(string maloaiSp);
        IEnumerable<TLoaiSp> GetAllLoaiSP();
    }
}
