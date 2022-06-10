// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
