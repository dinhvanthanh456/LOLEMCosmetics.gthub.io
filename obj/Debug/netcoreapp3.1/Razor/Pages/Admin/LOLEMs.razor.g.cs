#pragma checksum "D:\1234\LOLEMCosmetics\Pages\Admin\LOLEMs.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ac76a295ce4fd50eef6b19562ae165b09f37f7b"
// <auto-generated/>
#pragma warning disable 1591
namespace LOLEMCosmetics.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "D:\1234\LOLEMCosmetics\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\1234\LOLEMCosmetics\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\1234\LOLEMCosmetics\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\1234\LOLEMCosmetics\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\1234\LOLEMCosmetics\Pages\Admin\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\1234\LOLEMCosmetics\Pages\Admin\_Imports.razor"
using LOLEMCosmetics.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/LOLEMs")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin")]
    public partial class LOLEMs : OwningComponentBase<ILOLEMCosmeticsRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "table");
            __builder.AddAttribute(1, "class", "table table-sm table-striped table-bordered");
            __builder.AddMarkupContent(2, "\r\n ");
            __builder.AddMarkupContent(3, "<thead>\r\n <tr>\r\n <th>ID</th>\r\n <th>Tên Sản Phẩm</th>\r\n <th>Sẩn Phẩm</th>\r\n <th>Giá Bán</th>\r\n <td></td>\r\n </tr>\r\n </thead>\r\n ");
            __builder.OpenElement(4, "tbody");
            __builder.AddMarkupContent(5, "\r\n");
#nullable restore
#line 15 "D:\1234\LOLEMCosmetics\Pages\Admin\LOLEMs.razor"
  if (LOLEMData?.Count() > 0)
 {
 

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\1234\LOLEMCosmetics\Pages\Admin\LOLEMs.razor"
  foreach (LOLEM b in LOLEMData)
 {

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, " ");
            __builder.OpenElement(7, "tr");
            __builder.AddMarkupContent(8, "\r\n ");
            __builder.OpenElement(9, "td");
#nullable restore
#line 20 "D:\1234\LOLEMCosmetics\Pages\Admin\LOLEMs.razor"
__builder.AddContent(10, b.LOLEMID);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n ");
            __builder.OpenElement(12, "td");
#nullable restore
#line 21 "D:\1234\LOLEMCosmetics\Pages\Admin\LOLEMs.razor"
__builder.AddContent(13, b.Title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n ");
            __builder.OpenElement(15, "td");
#nullable restore
#line 22 "D:\1234\LOLEMCosmetics\Pages\Admin\LOLEMs.razor"
__builder.AddContent(16, b.Genre);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n ");
            __builder.OpenElement(18, "td");
#nullable restore
#line 23 "D:\1234\LOLEMCosmetics\Pages\Admin\LOLEMs.razor"
__builder.AddContent(19, b.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n ");
            __builder.OpenElement(21, "td");
            __builder.AddMarkupContent(22, "\r\n ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(23);
            __builder.AddAttribute(24, "class", "btn btn-info btn-sm");
            __builder.AddAttribute(25, "href", 
#nullable restore
#line 26 "D:\1234\LOLEMCosmetics\Pages\Admin\LOLEMs.razor"
        GetDetailsUrl(b.LOLEMID)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(27, "\r\n Details\r\n ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(28, "\r\n ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(29);
            __builder.AddAttribute(30, "class", "btn btn-warning btn-sm");
            __builder.AddAttribute(31, "href", 
#nullable restore
#line 30 "D:\1234\LOLEMCosmetics\Pages\Admin\LOLEMs.razor"
        GetEditUrl(b.LOLEMID)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(32, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(33, "\r\n Edit\r\n ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(34, "\r\n ");
            __builder.OpenElement(35, "button");
            __builder.AddAttribute(36, "class", "btn btn-danger btn-sm");
            __builder.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "D:\1234\LOLEMCosmetics\Pages\Admin\LOLEMs.razor"
             e => DeleteLOLEM(b)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(38, "\r\n Delete\r\n ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n");
#nullable restore
#line 39 "D:\1234\LOLEMCosmetics\Pages\Admin\LOLEMs.razor"
 }

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "D:\1234\LOLEMCosmetics\Pages\Admin\LOLEMs.razor"
  
 }
 else
 {

#line default
#line hidden
#nullable disable
            __builder.AddContent(42, " ");
            __builder.AddMarkupContent(43, "<tr>\r\n <td colspan=\"5\" class=\"text-center\">No LOLEMs</td>\r\n </tr>\r\n");
#nullable restore
#line 46 "D:\1234\LOLEMCosmetics\Pages\Admin\LOLEMs.razor"
 }

#line default
#line hidden
#nullable disable
            __builder.AddContent(44, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(47);
            __builder.AddAttribute(48, "class", "btn btn-primary");
            __builder.AddAttribute(49, "href", "/admin/LOLEMs/create");
            __builder.AddAttribute(50, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(51, "Thêm Sản Phẩm");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "D:\1234\LOLEMCosmetics\Pages\Admin\LOLEMs.razor"
       
 public ILOLEMCosmeticsRepository Repository => Service;
 public IEnumerable<LOLEM> LOLEMData { get; set; }
 protected async override Task OnInitializedAsync()
 {
 await UpdateData();
 }
 public async Task UpdateData()
 {
 LOLEMData = await Repository.LOLEMs.ToListAsync();
  }
 public async Task DeleteLOLEM(LOLEM b)
 {
 Repository.DeleteLOLEM(b);
 await UpdateData();
 }
 public string GetDetailsUrl(long id) => $"/admin/LOLEMs/details/{id}";
 public string GetEditUrl(long id) => $"/admin/LOLEMs/edit/{id}";

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
