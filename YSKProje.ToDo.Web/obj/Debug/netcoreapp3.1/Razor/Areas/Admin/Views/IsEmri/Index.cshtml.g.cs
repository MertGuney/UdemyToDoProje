#pragma checksum "F:\VisualStudio\source\UdemyMvcCoreDosyaları\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2c6c4586a75b7ab90797d4bd7afffd39935b669"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_IsEmri_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/IsEmri/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 3 "F:\VisualStudio\source\UdemyMvcCoreDosyaları\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\_ViewImports.cshtml"
using YSKProje.ToDo.DTO.DTOs.AciliyetDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\VisualStudio\source\UdemyMvcCoreDosyaları\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\_ViewImports.cshtml"
using YSKProje.ToDo.DTO.DTOs.AppUserDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\VisualStudio\source\UdemyMvcCoreDosyaları\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\_ViewImports.cshtml"
using YSKProje.ToDo.DTO.DTOs.BildirimDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\VisualStudio\source\UdemyMvcCoreDosyaları\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\_ViewImports.cshtml"
using YSKProje.ToDo.DTO.DTOs.GorevDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\VisualStudio\source\UdemyMvcCoreDosyaları\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\_ViewImports.cshtml"
using YSKProje.ToDo.DTO.DTOs.RaporDtos;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2c6c4586a75b7ab90797d4bd7afffd39935b669", @"/Areas/Admin/Views/IsEmri/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdbfcac96b53e97d9be63b92a806e3e1c3bc236e", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_IsEmri_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GorevListAllDto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AtaPersonel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info btn-sm "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detaylandır", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success btn-sm "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\VisualStudio\source\UdemyMvcCoreDosyaları\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "F:\VisualStudio\source\UdemyMvcCoreDosyaları\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\Index.cshtml"
 if (Model.Count != 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table table-hover table-bordered table-sm mt-2 "">
        <tr>
            <th>Ad</th>
            <th>Oluşturulma Tarihi</th>
            <th>Çalışan Personel</th>
            <th>Aciliyet</th>
            <th>Rapor Sayısı</th>
            <th>İşlem</th>
        </tr>
");
#nullable restore
#line 18 "F:\VisualStudio\source\UdemyMvcCoreDosyaları\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 21 "F:\VisualStudio\source\UdemyMvcCoreDosyaları\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\Index.cshtml"
               Write(item.Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "F:\VisualStudio\source\UdemyMvcCoreDosyaları\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\Index.cshtml"
               Write(item.OlusturulmaTarih.ToShortTimeString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n");
#nullable restore
#line 24 "F:\VisualStudio\source\UdemyMvcCoreDosyaları\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\Index.cshtml"
                      
                        if (item.AppUser == null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"badge badge-danger\">Çalışan Personel Yok</span>\r\n");
#nullable restore
#line 28 "F:\VisualStudio\source\UdemyMvcCoreDosyaları\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"badge badge-success\">");
#nullable restore
#line 31 "F:\VisualStudio\source\UdemyMvcCoreDosyaları\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\Index.cshtml"
                                                         Write(item.AppUser.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Çalışıyor.</span>\r\n");
#nullable restore
#line 32 "F:\VisualStudio\source\UdemyMvcCoreDosyaları\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\Index.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td>");
#nullable restore
#line 35 "F:\VisualStudio\source\UdemyMvcCoreDosyaları\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\Index.cshtml"
               Write(item.Aciliyet.Tanim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 36 "F:\VisualStudio\source\UdemyMvcCoreDosyaları\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\Index.cshtml"
               Write(item.Raporlar.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n");
#nullable restore
#line 38 "F:\VisualStudio\source\UdemyMvcCoreDosyaları\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\Index.cshtml"
                      
                        if (item.AppUser == null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2c6c4586a75b7ab90797d4bd7afffd39935b6699475", async() => {
                WriteLiteral("<i class=\"fas fa-caret-square-right mr-2\"></i>Personel Ata");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 41 "F:\VisualStudio\source\UdemyMvcCoreDosyaları\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\Index.cshtml"
                                                          WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 42 "F:\VisualStudio\source\UdemyMvcCoreDosyaları\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2c6c4586a75b7ab90797d4bd7afffd39935b66912146", async() => {
                WriteLiteral("<i class=\"fas fa-info-circle mr-2\"></i>Detay Göster");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 45 "F:\VisualStudio\source\UdemyMvcCoreDosyaları\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\Index.cshtml"
                                                          WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 46 "F:\VisualStudio\source\UdemyMvcCoreDosyaları\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\Index.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n            </tr>\r\n");
#nullable restore
#line 50 "F:\VisualStudio\source\UdemyMvcCoreDosyaları\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n");
#nullable restore
#line 52 "F:\VisualStudio\source\UdemyMvcCoreDosyaları\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"my-2 text-center lead\">\r\n        Herhangi Bir Gorev Bulunmamaktadır.\r\n    </div>\r\n");
#nullable restore
#line 58 "F:\VisualStudio\source\UdemyMvcCoreDosyaları\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\IsEmri\Index.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<GorevListAllDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
