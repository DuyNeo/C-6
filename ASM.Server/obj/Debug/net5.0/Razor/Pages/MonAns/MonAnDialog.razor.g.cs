#pragma checksum "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\MonAns\MonAnDialog.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2fd3add0298527e2785188607a8bf8fe2339922"
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
#line 2 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\MonAns\MonAnDialog.razor"
using ASM.Server.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\MonAns\MonAnDialog.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\MonAns\MonAnDialog.razor"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/MonAnDialog/{id}")]
    public partial class MonAnDialog : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h3");
            __builder.AddContent(1, 
#nullable restore
#line 9 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\MonAns\MonAnDialog.razor"
     Tieude

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(2, "\r\n");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-md-4");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(7);
            __builder.AddAttribute(8, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\MonAns\MonAnDialog.razor"
                          monAn

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 12 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\MonAns\MonAnDialog.razor"
                                                 SubmitForm

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(11);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n            ");
                __builder2.OpenElement(13, "input");
                __builder2.AddAttribute(14, "type", "hidden");
                __builder2.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\MonAns\MonAnDialog.razor"
                                        monAn.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => monAn.Id = __value, monAn.Id));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\r\n            ");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "form-group");
                __builder2.AddMarkupContent(20, "<label class=\"control-label\">Ten mon an</label>\r\n                ");
                __builder2.OpenElement(21, "input");
                __builder2.AddAttribute(22, "class", "form-control");
                __builder2.AddAttribute(23, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\MonAns\MonAnDialog.razor"
                              monAn.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => monAn.Name = __value, monAn.Name));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n                ");
                __Blazor.ASM.Server.Pages.MonAns.MonAnDialog.TypeInference.CreateValidationMessage_0(__builder2, 26, 27, 
#nullable restore
#line 18 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\MonAns\MonAnDialog.razor"
                                          () => monAn.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n\r\n            ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "form-group");
                __builder2.AddMarkupContent(31, "<label class=\"control-label\">gia mon an</label>\r\n                ");
                __builder2.OpenElement(32, "input");
                __builder2.AddAttribute(33, "class", "form-control");
                __builder2.AddAttribute(34, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\MonAns\MonAnDialog.razor"
                              monAn.Gia

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => monAn.Gia = __value, monAn.Gia));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n                ");
                __Blazor.ASM.Server.Pages.MonAns.MonAnDialog.TypeInference.CreateValidationMessage_1(__builder2, 37, 38, 
#nullable restore
#line 24 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\MonAns\MonAnDialog.razor"
                                          () => monAn.Gia

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n         \r\n                ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "form-group");
                __builder2.AddMarkupContent(42, "<label for=\"exampleInputEmail1\" class=\"form-label\">Phân loại</label>\r\n                    ");
                __Blazor.ASM.Server.Pages.MonAns.MonAnDialog.TypeInference.CreateInputSelect_2(__builder2, 43, 44, "form-control", 45, "email", 46, 
#nullable restore
#line 29 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\MonAns\MonAnDialog.razor"
                                                                   monAn.phanLoai

#line default
#line hidden
#nullable disable
                , 47, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => monAn.phanLoai = __value, monAn.phanLoai)), 48, () => monAn.phanLoai, 49, (__builder3) => {
#nullable restore
#line 30 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\MonAns\MonAnDialog.razor"
                         foreach (var pl in Enum.GetValues(typeof(MonAn.PhanLoai)))
                        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(50, "option");
                    __builder3.AddAttribute(51, "value", 
#nullable restore
#line 32 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\MonAns\MonAnDialog.razor"
                                            pl

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(52, 
#nullable restore
#line 32 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\MonAns\MonAnDialog.razor"
                                                 pl

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 33 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\MonAns\MonAnDialog.razor"
                        }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
#nullable restore
#line 36 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\MonAns\MonAnDialog.razor"
                 try
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\MonAns\MonAnDialog.razor"
                     if (monAn.Photos.Any() && id != "0")
                    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(53, "div");
                __builder2.AddAttribute(54, "class", "d-flex flex-wrap photo-upload");
#nullable restore
#line 41 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\MonAns\MonAnDialog.razor"
                             foreach (var item in monAn.Photos)
                            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(55, "div");
                __builder2.AddAttribute(56, "class", "photodetail w-25 p-1");
                __builder2.OpenElement(57, "img");
                __builder2.AddAttribute(58, "class", "w-100");
                __builder2.AddAttribute(59, "src", "images/food/" + (
#nullable restore
#line 44 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\MonAns\MonAnDialog.razor"
                                                                          item.FileName

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n                                    ");
                __builder2.OpenElement(61, "span");
                __builder2.AddAttribute(62, "class", "btn btn-danger");
                __builder2.AddAttribute(63, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\MonAns\MonAnDialog.razor"
                                                                             ()=>Delete(@item.Id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(64, "Delete");
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 49 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\MonAns\MonAnDialog.razor"
                                
                            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
#nullable restore
#line 52 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\MonAns\MonAnDialog.razor"


                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\MonAns\MonAnDialog.razor"
                     
                }
                catch
                {

                }

                

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\MonAns\MonAnDialog.razor"
                 if (id != "0")
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(65, "div");
                __builder2.AddAttribute(66, "class", "form-group");
                __builder2.OpenElement(67, "label");
                __builder2.AddAttribute(68, "class", "custom-file-upload");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputFile>(69);
                __builder2.AddAttribute(70, "class", "form-control");
                __builder2.AddAttribute(71, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>(this, 
#nullable restore
#line 71 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\MonAns\MonAnDialog.razor"
                                                                      OnInputFileChange

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(72, "id", "file-upload");
                __builder2.AddAttribute(73, "accept", ".gif,.jpg,.jpeg,.png");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(74, "\r\n                            <i class=\"fa fa-cloud-upload\"></i> Chọn ảnh\r\n                        ");
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 77 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\MonAns\MonAnDialog.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(75, "div");
                __builder2.AddAttribute(76, "class", "form-control form-check");
                __builder2.OpenElement(77, "label");
                __builder2.AddAttribute(78, "class", "col-form-label");
                __builder2.OpenElement(79, "input");
                __builder2.AddAttribute(80, "type", "checkbox");
                __builder2.AddAttribute(81, "class", "form-group-input");
                __builder2.AddAttribute(82, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 81 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\MonAns\MonAnDialog.razor"
                                                                               monAn.TrangThai

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(83, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => monAn.TrangThai = __value, monAn.TrangThai));
                __builder2.SetUpdatesAttributeName("checked");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(84, "Trang thai\r\n                    ");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(85, "\r\n                ");
                __builder2.OpenElement(86, "div");
                __builder2.AddAttribute(87, "class", "form-control");
                __builder2.OpenElement(88, "button");
                __builder2.AddAttribute(89, "type", "submit");
                __builder2.AddAttribute(90, "class", "btn btn-info");
                __builder2.AddAttribute(91, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 85 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\MonAns\MonAnDialog.razor"
                                                                         (() => SubmitForm())

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(92, "Luu");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(93, "\r\n                    ");
                __builder2.OpenElement(94, "input");
                __builder2.AddAttribute(95, "type", "button");
                __builder2.AddAttribute(96, "class", "btn btn-primary");
                __builder2.AddAttribute(97, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 86 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\MonAns\MonAnDialog.razor"
                                                                            Cancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(98, "value", "Thoat");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 91 "C:\Users\hp\OneDrive\Máy tính\ASM.Share\ASM.Server\Pages\MonAns\MonAnDialog.razor"
       
    [Parameter]
    public string id { get; set; }
    private MonAn monAn { get; set; }
    private string Tieude = "";
    IReadOnlyList<IBrowserFile> selectedFiles;
    protected override void OnInitialized()
    {
        if (string.IsNullOrWhiteSpace(id) || id == "0")
        {
            Tieude = "Them mon an";
            monAn = new MonAn();
        }
        else
        {
            Tieude = "Sua mon an";
            monAn = _monAnService.GetMonAn(int.Parse(id));
        }
    }
    private async void SubmitForm()
    {
        //if (selectedFiles != null && selectedFiles.Count > 0)
        //{
        //    var file = selectedFiles[0];
        //    //foreach (var file in selectedFiles)
        //    {
        //        Stream stream = file.OpenReadStream();
        //        var path = $"{env.WebRootPath}\\image\\Monan\\{file.Name}";
        //        FileStream fs = File.Create(path);
        //        await stream.CopyToAsync(fs);
        //        stream.Close();
        //        fs.Close();
        //    }
        //    //monAn.Photos = file.Name;
        //}
        if (monAn.Id == 0)
        {
            _monAnService.AddMonAn(monAn);
        }
        else
        {
            _monAnService.EditMonAn(monAn.Id, monAn);
        }
        navigation.NavigateTo("MonanList");
    }
    private void Cancel()
    {
        navigation.NavigateTo("MonanList", true);

    }

    public void Delete(int id)
    {
        var photo = _context.ProductPhotos.Where(p => p.Id == id).FirstOrDefault();
        if (photo != null)
        {
            _context.Remove(photo);
            _context.SaveChanges();

            var filename = "wwwroot/images/food/" + photo.FileName;
            System.IO.File.Delete(filename);
        }
    }
    IReadOnlyList<IBrowserFile> selectedFile;

    private async void OnInputFileChange(InputFileChangeEventArgs e)
    {
        selectedFile = e.GetMultipleFiles();

        if (selectedFile != null && selectedFile.Count > 0)
        {
            var file = selectedFile[0];

            var rootPath = $"{env.WebRootPath}\\images";
            if (!Directory.Exists(rootPath))
            {
                Directory.CreateDirectory(rootPath);
            }

            string dirPath = rootPath + @"\" + "food";
            if (!Directory.Exists(dirPath))
            {
                Directory.CreateDirectory(dirPath);
            }


            //var path = $"{env.WebRootPath}\\images\\food\\{file.Name}";
            string filePath = dirPath + @"\" + file.Name;
            var stream = file.OpenReadStream();
            var fs = File.Create(filePath);

            await stream.CopyToAsync(fs);
            stream.Close();
            fs.Close();
            var photo = new ProductPhoto()
            {
                ProductId = monAn.Id,
                FileName = file.Name
            };
            //var listphoto = new List<ProductPhoto>();
            //listphoto.Add(photo);
            //monan.Photos =  listphoto;
            _context.ProductPhotos.Add(photo);
            _context.SaveChanges();
            //toastService.ShowInfo($"Vừa thêm ảnh {file.Name} cho món {monAn.Name}");
        }
        this.StateHasChanged();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWebHostEnvironment env { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DataContext _context { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMonAnSvc _monAnService { get; set; }
    }
}
namespace __Blazor.ASM.Server.Pages.MonAns.MonAnDialog
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "type", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
