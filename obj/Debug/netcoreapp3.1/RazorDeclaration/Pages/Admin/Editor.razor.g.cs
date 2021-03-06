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
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/LOLEMs/edit/{id:long}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/LOLEMs/create")]
    public partial class Editor : OwningComponentBase<ILOLEMCosmeticsRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "D:\1234\LOLEMCosmetics\Pages\Admin\Editor.razor"
       
 public ILOLEMCosmeticsRepository Repository => Service;
 [Inject]
 public NavigationManager NavManager { get; set; }
 [Parameter]
 public long Id { get; set; } = 0;
 public LOLEM LOLEM { get; set; } = new LOLEM();
 protected override void OnParametersSet()
 {
 if (Id != 0)
 {
 LOLEM = Repository.LOLEMs.FirstOrDefault(b => b.LOLEMID == Id);
 }
 }
 public void SaveLOLEM()
 {
 if (Id == 0)
 {
 Repository.CreateLOLEM(LOLEM);
 }
 else
 {
 Repository.SaveLOLEM(LOLEM);
 }
 NavManager.NavigateTo("/admin/LOLEMs");
 }
 public string ThemeColor => Id == 0 ? "primary" : "warning";
 public string TitleText => Id == 0 ? "Create" : "Edit";

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
