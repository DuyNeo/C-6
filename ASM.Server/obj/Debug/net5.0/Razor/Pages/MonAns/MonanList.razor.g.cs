#pragma checksum "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\MonAns\MonanList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4bc81f1915e5beb27e615ef2b74547d59856d590"
// <auto-generated/>
#pragma warning disable 1591
namespace ASM.Server.Pages.MonAns
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
#line 3 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\MonAns\MonanList.razor"
using ASM.Server.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/MonanList")]
    public partial class MonanList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>danh sach mon an</h1>");
#nullable restore
#line 6 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\MonAns\MonanList.razor"
 if (monAns == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>");
#nullable restore
#line 9 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\MonAns\MonanList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<a class=\"btn btn-success p-10\" href=\"/MonAnDialog/0\">them</a>");
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table");
            __builder.AddMarkupContent(5, "<thead><tr><th>Tên</th>\r\n                <th>Giá</th>\r\n                <th>Phân loại</th>\r\n                <th>Hình</th>\r\n                <th>Trạng thái</th>\r\n                \r\n                <th></th></tr></thead>\r\n        ");
            __builder.OpenElement(6, "tbody");
#nullable restore
#line 27 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\MonAns\MonanList.razor"
             foreach (var item in monAns)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "tr");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 30 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\MonAns\MonanList.razor"
                         item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n                    ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 31 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\MonAns\MonanList.razor"
                         item.Gia

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
#nullable restore
#line 33 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\MonAns\MonanList.razor"
                         switch (@item.phanLoai)
                        {
                            case MonAn.PhanLoai.DoAnNhanh:

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(15, "<span class=\"badge bg-success\">Đồ ăn nhanh</span>");
#nullable restore
#line 37 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\MonAns\MonanList.razor"
                                break;

                            default:

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(16, "<span class=\"badge bg-warning text-dark\">Combo</span>");
#nullable restore
#line 41 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\MonAns\MonanList.razor"
                                break;
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.OpenElement(18, "td");
#nullable restore
#line 45 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\MonAns\MonanList.razor"
                         if (item.Photos.Any())
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(19, "img");
            __builder.AddAttribute(20, "src", "images/food/" + (
#nullable restore
#line 47 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\MonAns\MonanList.razor"
                                               item.Photos.FirstOrDefault().FileName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "alt");
            __builder.AddAttribute(22, "style", "width:150px;border-radius:0px");
            __builder.CloseElement();
#nullable restore
#line 48 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\MonAns\MonanList.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(23, "<img src=\"/images/nophoto.png\" alt style=\"width:150px;border-radius:0px\">");
#nullable restore
#line 52 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\MonAns\MonanList.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 54 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\MonAns\MonanList.razor"
                         item.TrangThai

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n  \r\n                    ");
            __builder.OpenElement(28, "td");
            __builder.OpenElement(29, "a");
            __builder.AddAttribute(30, "class", "btn btn-info");
            __builder.AddAttribute(31, "href", "/MonAnDialog/" + (
#nullable restore
#line 57 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\MonAns\MonanList.razor"
                                                                    item.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(32, "Sua");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                        ");
            __builder.OpenElement(34, "a");
            __builder.AddAttribute(35, "class", "btn btn-info");
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 58 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\MonAns\MonanList.razor"
                                                            ()=> Delete(item.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(37, "Xoa");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 62 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\MonAns\MonanList.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 65 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\MonAns\MonanList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 67 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\MonAns\MonanList.razor"
       
    public List<MonAn> monAns;
    protected override void OnInitialized()
    {
        monAns = _monanService.GetMonAnAll();
    }
    private void Delete(int id)
    {
        //_nguoidungService.AddnguoidungDelete(id);
        //emloyees = _service.GetEmployees();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMonAnSvc _monanService { get; set; }
    }
}
#pragma warning restore 1591