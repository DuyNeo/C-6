#pragma checksum "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\Khachhang\KhachhangList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1c49be3a3a714bb6b3c4e96e8b81b15af9135b5"
// <auto-generated/>
#pragma warning disable 1591
namespace ASM.Server.Pages.Khachhang
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\_Imports.razor"
using ASM.Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\_Imports.razor"
using ASM.Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\Khachhang\KhachhangList.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\Khachhang\KhachhangList.razor"
using Shares;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/khachhanglist")]
    public partial class KhachhangList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 class=\"text-center\">Danh sách khách hàng</h1>");
#nullable restore
#line 7 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\Khachhang\KhachhangList.razor"
 if (users == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>");
#nullable restore
#line 10 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\Khachhang\KhachhangList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table");
            __builder.AddMarkupContent(4, "<thead><tr><th scope=\"col\">User Name</th>\r\n                <th scope=\"col\">Ngày sinh</th>\r\n                <th scope=\"col\">Số điện thoại</th>\r\n                <th scope=\"col\">Email</th></tr></thead>\r\n        ");
            __builder.OpenElement(5, "tbody");
#nullable restore
#line 23 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\Khachhang\KhachhangList.razor"
             foreach (var item in users)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.OpenElement(7, "td");
            __builder.AddContent(8, 
#nullable restore
#line 26 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\Khachhang\KhachhangList.razor"
                         item.UserName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n                    ");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 27 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\Khachhang\KhachhangList.razor"
                         item.DayOfBirth

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 28 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\Khachhang\KhachhangList.razor"
                         item.PhoneNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 29 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\Khachhang\KhachhangList.razor"
                         item.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "td");
            __builder.OpenElement(20, "a");
            __builder.AddAttribute(21, "class", "btn btn-info");
            __builder.AddAttribute(22, "href", "/khachhangdetail/" + (
#nullable restore
#line 30 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\Khachhang\KhachhangList.razor"
                                                                        item.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(23, "Chi tiết");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 32 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\Khachhang\KhachhangList.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 35 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\Khachhang\KhachhangList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\Khachhang\KhachhangList.razor"
      
    public List<AppUser> users;
    protected override void OnInitialized()
    {
        users = _context.Users.ToList();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DataContext _context { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDonHangSvc _donhangSvc { get; set; }
    }
}
#pragma warning restore 1591