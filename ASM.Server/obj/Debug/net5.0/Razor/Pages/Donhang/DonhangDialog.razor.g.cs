#pragma checksum "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\Donhang\DonhangDialog.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f276cd8269c8aae1d9a6e630879f2e87ba2842f"
// <auto-generated/>
#pragma warning disable 1591
namespace ASM.Server.Pages.Donhang
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
#line 2 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\Donhang\DonhangDialog.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\Donhang\DonhangDialog.razor"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Donhangdialog/{id}")]
    public partial class DonhangDialog : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h3");
            __builder.AddContent(1, 
#nullable restore
#line 8 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\Donhang\DonhangDialog.razor"
     Tieude

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(2, "\r\n<hr>\r\n");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-md-4");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(7);
            __builder.AddAttribute(8, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\Donhang\DonhangDialog.razor"
                          donHang

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "OnInvalidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 12 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\Donhang\DonhangDialog.razor"
                                                     SubmitForm

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(11);
                __builder2.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(13, "input");
                    __builder3.AddAttribute(14, "type", "hidden");
                    __builder3.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\Donhang\DonhangDialog.razor"
                                            donHang.DonHangID

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => donHang.DonHangID = __value, donHang.DonHangID));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(17, "\r\n                ");
                    __builder3.OpenElement(18, "div");
                    __builder3.AddAttribute(19, "class", "form-group");
                    __builder3.AddMarkupContent(20, "<label class=\"control-label\">Khach hang</label>\r\n                    ");
                    __builder3.OpenElement(21, "input");
                    __builder3.AddAttribute(22, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\Donhang\DonhangDialog.razor"
                                  donHang.KhachHang

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(23, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => donHang.KhachHang = __value, donHang.KhachHang));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\Donhang\DonhangDialog.razor"
       
    [Parameter]
    public string id { get; set; }
    private DonHang donHang { get; set; }
    private string Tieude = "";
    IReadOnlyList<IBrowserFile> selectedFiles;
    protected override void OnInitialized()
    {
        if(string.IsNullOrWhiteSpace(id)|| id == "0")
        {
            navigation.NavigateTo("donhangList", true);
        }
        else
        {
            Tieude = "Sua don hang";
            donHang = _donhangService.GetDonHang(int.Parse(id));
        }
    }
    private async void SubmitForm()
    {
        _donhangService.EditDonHang(donHang.DonHangID, donHang);
        navigation.NavigateTo("DonhangList");
    }
    private void Cancel()
    {
        navigation.NavigateTo("DonhangList", true);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWebHostEnvironment env { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDonHangSvc _donhangService { get; set; }
    }
}
#pragma warning restore 1591