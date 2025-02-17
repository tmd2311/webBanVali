﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webBanVali.Models;
using webBanVali.Models.ProductModels;

namespace webBanVali.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductAPIController : ControllerBase
    {
        QlbanVaLiContext db = new QlbanVaLiContext();
        [HttpGet]
        public IEnumerable<Product> GetAllProduct()
        {
            var sanPham=(from p in db.TDanhMucSps select new Product
            {
                MaSp=p.MaSp,
                TenSp=p.TenSp,
                MaLoai=p.MaLoai,
                AnhDaiDien=p.AnhDaiDien,
                GiaLonNhat=p.GiaLonNhat
            }).ToList();    
            return sanPham;
        }

        [HttpGet("{maloai}")]
        public IEnumerable<Product> GetProductsByCatrgory(string maloai)
        {
            var sanPham = (from p in db.TDanhMucSps
                           where p.MaLoai==maloai
                           select new Product
                           {
                               MaSp = p.MaSp,
                               TenSp = p.TenSp,
                               MaLoai = p.MaLoai,
                               AnhDaiDien = p.AnhDaiDien,
                               GiaLonNhat = p.GiaLonNhat
                           }).ToList();
            return sanPham;
        }
    }
}
