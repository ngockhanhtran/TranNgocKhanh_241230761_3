using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TranNgocKhanh_241230761_3.Models;

public class TaiSan
{
    [Key]
    public int MaTs { get; set; }

    [DisplayName("Loai tai san")]
    public int MaLoai { get; set; }

    [DisplayName("Ten tai san")]
    [Required(ErrorMessage ="Ten tai san khong duoc de trong")]
    public string TenTs { get; set; } = null!;

    [DisplayName("Nguyen gia (trieu)")]
    [Required(ErrorMessage ="Vui long nhap nguyen gia")]
    [Range(1, 2000, ErrorMessage ="Nguyen gia phai tu 1 den 2000")]
    public decimal? NguyenGia { get; set; }

    [DisplayName("Ten file anh")]
    [RegularExpression(@"^.+\.(jpg|jpeg|png|webp)$", ErrorMessage = "Anh phai co duoi la .jpg | .jpeg | .png | .webp ")]
    public string? Anh { get; set; }

    public virtual LoaiTaiSan MaLoaiNavigation { get; set; } = null!;
}
