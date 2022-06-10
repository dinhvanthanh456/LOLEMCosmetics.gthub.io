using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using LOLEMCosmetics.Models;

namespace LOLEMCosmetics.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            LOLEMCosmeticsDbContext context =app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService < LOLEMCosmeticsDbContext > ();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.LOLEMs.Any())
            {
                context.LOLEMs.AddRange(
                new LOLEM 
                {
                    Title = "Combo Body Siêu Trắng Da ",

                    Description = "CKích trắng Collagen x3 kết hợp với body collagen x3 sẽ giúp làn da chị em bật tone hơn nhiều lần so với dùng body không. TRẮNG GẤP 3 LẦN KEM BODY THÔNG THƯỜNG  THẤM NHANH TRONG 3 GIÂY  HIỆU QUẢ TRONG VÒNG 7 NGÀY",
               
                Genre = "Combo ",
                    Price = 11.98m
                },
                new LOLEM
                {
                    Title = "Combo Face Chống Lão Hóa",
                    Description = "Serum Căng Bóng Da Collagen X3 chính hãng Mỹ Phẩm Đông Anh- Dòng serum giúp giữ ẩm,cân bằng đổ PH cho da,giảm thâm nám,tàn nhang rất tốt.- Hướng dẫn sử dụng: rửa sạch mặt,lau khô,thoa 1 lớp mỏng serum.- Nếu kết hợp với kem face thì thoa 1 lớp mỏng serum trước,xong tới kem Face.!",
               
                Genre = "Combo ",
                    Price = 17.46m
                },
                new LOLEM
                {
                    Title = "Tẩy Tế Bào Chết Chanh & Bạc Hà",
                    Description = "+ Lấy 1 lượng vừa phải thoa lên da ( để da khô mới thoa gel)+ Thoa đều lớp gel lên da,massage nhẹ nhàng trên da để loại bỏ lớp tế bào chết trên da.+ Sau đó rửa sạch lại với nước.!",
               
                Genre = "Tẩy Tế Bào Chết",
                    Price = 13.41m
                },
                new LOLEM
                {
                    Title = "Chống Nắng Nọc Ong",
                    Description = "Chống tia UV-A, UV-B, ánh sáng xanh từ điện thoại giúp chống chảy xệ, nếp nhăn, đồi mồi và lão hoá da.👉 Cân bằng độ điều màu cho da.👉 Cân bằng độ nhờn cho da,cấp ẩm và tạo lớp màn bảo vệ da.👉 Kiềm dầu và make up,nâng tone cho da.👉 kết cấu nhẹ,không gây bí tắt,có thể kết hợp kem dưỡng giúp kiềm dầu,hút ẩm,cấp nước cho da khô..",
               
                Genre = "Chống Nắng",
                    Price = 18.69m
                },
                new LOLEM
                {

                    Title = "Trà Giảm Cân Vị Đào",
                    Description = "TRÀ GIẢM CÂN VỊ ĐÀO+ Một hộp gồm 15 gói uống.+ Xuất xứ : Việt Nam+ Hạn sử dụng : 3 năm theo trên bao bì sản phẩm- Lưu ý : nếu mở gói uống ra mà không dùng không được để quá 1 ngày.",
               
                Genre = "Trà Giảm Cân",
                    Price = 31.26m
                }
                );
                context.SaveChanges();
            }
        }
    }
}