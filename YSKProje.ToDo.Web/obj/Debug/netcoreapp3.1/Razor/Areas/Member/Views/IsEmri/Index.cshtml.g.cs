#pragma checksum "F:\VisualStudio\source\UdemyMvcCoreDosyaları\UdemyToDo\YSKProje.ToDo.Web\Areas\Member\Views\IsEmri\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8781ca51ed004e1c6aea4da18e8f711ef1cd1a06"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Member_Views_IsEmri_Index), @"mvc.1.0.view", @"/Areas/Member/Views/IsEmri/Index.cshtml")]
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
#line 3 "F:\VisualStudio\source\UdemyMvcCoreDosyaları\UdemyToDo\YSKProje.ToDo.Web\Areas\Member\_ViewImports.cshtml"
using YSKProje.ToDo.DTO.DTOs.AciliyetDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\VisualStudio\source\UdemyMvcCoreDosyaları\UdemyToDo\YSKProje.ToDo.Web\Areas\Member\_ViewImports.cshtml"
using YSKProje.ToDo.DTO.DTOs.AppUserDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\VisualStudio\source\UdemyMvcCoreDosyaları\UdemyToDo\YSKProje.ToDo.Web\Areas\Member\_ViewImports.cshtml"
using YSKProje.ToDo.DTO.DTOs.BildirimDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\VisualStudio\source\UdemyMvcCoreDosyaları\UdemyToDo\YSKProje.ToDo.Web\Areas\Member\_ViewImports.cshtml"
using YSKProje.ToDo.DTO.DTOs.GorevDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\VisualStudio\source\UdemyMvcCoreDosyaları\UdemyToDo\YSKProje.ToDo.Web\Areas\Member\_ViewImports.cshtml"
using YSKProje.ToDo.DTO.DTOs.RaporDtos;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8781ca51ed004e1c6aea4da18e8f711ef1cd1a06", @"/Areas/Member/Views/IsEmri/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12358c2b297112514a3b80dd31a32e2ad21531b0", @"/Areas/Member/_ViewImports.cshtml")]
    public class Areas_Member_Views_IsEmri_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GorevListAllDto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EkleRapor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-light btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GuncelleRapor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "F:\VisualStudio\source\UdemyMvcCoreDosyaları\UdemyToDo\YSKProje.ToDo.Web\Areas\Member\Views\IsEmri\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Member/Views/Shared/_MemberLayout.cshtml";
    int index = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "F:\VisualStudio\source\UdemyMvcCoreDosyaları\UdemyToDo\YSKProje.ToDo.Web\Areas\Member\Views\IsEmri\Index.cshtml"
 foreach (var item in Model)
{
    index++;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card my-1\">\r\n        <div class=\"card-header\">\r\n            ");
#nullable restore
#line 13 "F:\VisualStudio\source\UdemyMvcCoreDosyaları\UdemyToDo\YSKProje.ToDo.Web\Areas\Member\Views\IsEmri\Index.cshtml"
       Write(item.Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"card-body\">\r\n            <h5 class=\"card-title\"><span class=\"text-danger\">Aciliyet Durumu :</span> ");
#nullable restore
#line 16 "F:\VisualStudio\source\UdemyMvcCoreDosyaları\UdemyToDo\YSKProje.ToDo.Web\Areas\Member\Views\IsEmri\Index.cshtml"
                                                                                 Write(item.Aciliyet.Tanim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <p class=\"card-text\">");
#nullable restore
#line 17 "F:\VisualStudio\source\UdemyMvcCoreDosyaları\UdemyToDo\YSKProje.ToDo.Web\Areas\Member\Views\IsEmri\Index.cshtml"
                            Write(item.Aciklama);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p class=\"text-right\">\r\n");
#nullable restore
#line 19 "F:\VisualStudio\source\UdemyMvcCoreDosyaları\UdemyToDo\YSKProje.ToDo.Web\Areas\Member\Views\IsEmri\Index.cshtml"
                 if (item.Raporlar.Count > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a class=\"btn btn-light btn-sm\" data-toggle=\"collapse\"");
            BeginWriteAttribute("href", " href=\"", 683, "\"", 713, 2);
            WriteAttributeValue("", 690, "#collapseExample-", 690, 17, true);
#nullable restore
#line 21 "F:\VisualStudio\source\UdemyMvcCoreDosyaları\UdemyToDo\YSKProje.ToDo.Web\Areas\Member\Views\IsEmri\Index.cshtml"
WriteAttributeValue("", 707, index, 707, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\" aria-expanded=\"false\" aria-controls=\"collapseExample\">\r\n                        Raporlara Git <i class=\"fas fa-caret-down ml-2\"></i> <span class=\"badge badge-dark\">");
#nullable restore
#line 22 "F:\VisualStudio\source\UdemyMvcCoreDosyaları\UdemyToDo\YSKProje.ToDo.Web\Areas\Member\Views\IsEmri\Index.cshtml"
                                                                                                       Write(item.Raporlar.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </a>\r\n");
#nullable restore
#line 24 "F:\VisualStudio\source\UdemyMvcCoreDosyaları\UdemyToDo\YSKProje.ToDo.Web\Areas\Member\Views\IsEmri\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"lead font-weight-bold font-italic p2 d-block text-left mb-1\">Hiç Rapor Yazmamışsınız.</span>\r\n");
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8781ca51ed004e1c6aea4da18e8f711ef1cd1a068939", async() => {
                WriteLiteral("<i class=\"fas fa-plus-circle mr-2\"></i> Rapor Yaz");
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
#line 29 "F:\VisualStudio\source\UdemyMvcCoreDosyaları\UdemyToDo\YSKProje.ToDo.Web\Areas\Member\Views\IsEmri\Index.cshtml"
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
#line 30 "F:\VisualStudio\source\UdemyMvcCoreDosyaları\UdemyToDo\YSKProje.ToDo.Web\Areas\Member\Views\IsEmri\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a class=\"btn btn-dark btn-sm\" data-toggle=\"modal\" data-target=\"#exampleModal\" data-id=\"");
#nullable restore
#line 31 "F:\VisualStudio\source\UdemyMvcCoreDosyaları\UdemyToDo\YSKProje.ToDo.Web\Areas\Member\Views\IsEmri\Index.cshtml"
                                                                                                   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Tamamlandı olarak işaretle</a>\r\n            </p>\r\n            <div class=\"collapse\"");
            BeginWriteAttribute("id", " id=\"", 1507, "\"", 1534, 2);
            WriteAttributeValue("", 1512, "collapseExample-", 1512, 16, true);
#nullable restore
#line 33 "F:\VisualStudio\source\UdemyMvcCoreDosyaları\UdemyToDo\YSKProje.ToDo.Web\Areas\Member\Views\IsEmri\Index.cshtml"
WriteAttributeValue("", 1528, index, 1528, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8781ca51ed004e1c6aea4da18e8f711ef1cd1a0612528", async() => {
                WriteLiteral("<i class=\"fas fa-plus-circle mr-2\"></i>Rapor Yaz");
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
#line 34 "F:\VisualStudio\source\UdemyMvcCoreDosyaları\UdemyToDo\YSKProje.ToDo.Web\Areas\Member\Views\IsEmri\Index.cshtml"
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
            WriteLiteral("\r\n                <table class=\"table table-hover table-bordered table-sm \">\r\n                    <tr>\r\n                        <th>Ad</th>\r\n                        <th>Tanım</th>\r\n                        <th>İşlem</th>\r\n                    </tr>\r\n");
#nullable restore
#line 41 "F:\VisualStudio\source\UdemyMvcCoreDosyaları\UdemyToDo\YSKProje.ToDo.Web\Areas\Member\Views\IsEmri\Index.cshtml"
                     foreach (var rapor in item.Raporlar)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 44 "F:\VisualStudio\source\UdemyMvcCoreDosyaları\UdemyToDo\YSKProje.ToDo.Web\Areas\Member\Views\IsEmri\Index.cshtml"
                           Write(rapor.Tanim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 45 "F:\VisualStudio\source\UdemyMvcCoreDosyaları\UdemyToDo\YSKProje.ToDo.Web\Areas\Member\Views\IsEmri\Index.cshtml"
                           Write(rapor.Detay);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8781ca51ed004e1c6aea4da18e8f711ef1cd1a0616098", async() => {
                WriteLiteral("<i class=\"far fa-edit mr-2\"></i>Düzenle");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 46 "F:\VisualStudio\source\UdemyMvcCoreDosyaları\UdemyToDo\YSKProje.ToDo.Web\Areas\Member\Views\IsEmri\Index.cshtml"
                                                                                               WriteLiteral(rapor.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 48 "F:\VisualStudio\source\UdemyMvcCoreDosyaları\UdemyToDo\YSKProje.ToDo.Web\Areas\Member\Views\IsEmri\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 53 "F:\VisualStudio\source\UdemyMvcCoreDosyaları\UdemyToDo\YSKProje.ToDo.Web\Areas\Member\Views\IsEmri\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Modal -->
<div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Uyarı</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body text-center font-weight-bold lead"">
                Bu işlemi gerçekleştirmek istediğinizden emin misiniz ?
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Vazgeç</button>
                <button id=""btnKaydet"" type=""button"" class=""btn btn-primary"">Evet</button>
            </div>
        </div>
    </div>
</div>
");
            DefineSection("JavaScript", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">
        $(document).ready(function () {
            $(""#exampleModal"").on(""show.bs.modal"", function (event) {
                let tetikleyenElement = $(event.relatedTarget);
                let data = tetikleyenElement.data(""id"");
                $(""#btnKaydet"").click(function () {
                    $.ajax({
                        type: ""GET"",
                        contentType: ""application/json; charset=utf-8"",
                        url: ""./IsEmri/TamamlaGorev"",
                        data: { gorevId: data },
                        success: function () {
                            window.location.reload();
                        },
                        error: function (error) {
                            alert(error.responseText);
                        }
                    })
                })
            });
        });
    </script>
");
            }
            );
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
