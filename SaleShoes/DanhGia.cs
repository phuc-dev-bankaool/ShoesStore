//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SaleShoes
{
    using System;
    using System.Collections.Generic;
    
    public partial class DanhGia
    {
        public int MaDanhGia { get; set; }
        public string NoiDung { get; set; }
        public Nullable<int> MaKH { get; set; }
        public Nullable<int> MaSanPham { get; set; }
    
        public virtual KhachHang KhachHang { get; set; }
        public virtual SanPham SanPham { get; set; }
    }
}
