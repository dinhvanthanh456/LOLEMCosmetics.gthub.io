using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;
namespace LOLEMCosmetics.Models
{
    public class Order
    {
        [BindNever]
        public int OrderID { get; set; }
        [BindNever]
        public ICollection<CartLine> Lines { get; set; }
        [Required(ErrorMessage = "Ban Chưa Nhập Họ Và Tên")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Ban Chưa Nhập Địa Chỉ")]
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        [Required(ErrorMessage = "Ban Chưa Nhập Email")]
        public string City { get; set; }
        [Required(ErrorMessage = "Ban Chưa Nhập CMNN/CCCD")]
        public string State { get; set; }
        public string Zip { get; set; }
        [Required(ErrorMessage = "Ban Chưa Nhập Giới Tính")]
        public string Country { get; set; }
        [BindNever]
        public bool Shipped { get; set; }
    }
}