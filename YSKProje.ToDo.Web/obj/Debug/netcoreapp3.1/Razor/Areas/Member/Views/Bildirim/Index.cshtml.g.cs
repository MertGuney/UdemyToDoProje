#pragma checksum "F:\VisualStudio\source\UdemyMvcCoreDosyaları\UdemyToDo\YSKProje.ToDo.Web\Areas\Member\Views\Bildirim\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44dbe9be4eda36fda96abc176fa59d380cac7256"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Member_Views_Bildirim_Index), @"mvc.1.0.view", @"/Areas/Member/Views/Bildirim/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44dbe9be4eda36fda96abc176fa59d380cac7256", @"/Areas/Member/Views/Bildirim/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12358c2b297112514a3b80dd31a32e2ad21531b0", @"/Areas/Member/_ViewImports.cshtml")]
    public class Areas_Member_Views_Bildirim_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BildirimListDto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("my-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\VisualStudio\source\UdemyMvcCoreDosyaları\UdemyToDo\YSKProje.ToDo.Web\Areas\Member\Views\Bildirim\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Member/Views/Shared/_MemberLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "F:\VisualStudio\source\UdemyMvcCoreDosyaları\UdemyToDo\YSKProje.ToDo.Web\Areas\Member\Views\Bildirim\Index.cshtml"
 if (Model.Count > 0)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\VisualStudio\source\UdemyMvcCoreDosyaları\UdemyToDo\YSKProje.ToDo.Web\Areas\Member\Views\Bildirim\Index.cshtml"
     foreach (var bildirim in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-light p-3 my-2\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44dbe9be4eda36fda96abc176fa59d380cac72565913", async() => {
                WriteLiteral("\r\n                <p class=\"lead\">\r\n                    <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 410, "\"", 430, 1);
#nullable restore
#line 14 "F:\VisualStudio\source\UdemyMvcCoreDosyaları\UdemyToDo\YSKProje.ToDo.Web\Areas\Member\Views\Bildirim\Index.cshtml"
WriteAttributeValue("", 418, bildirim.Id, 418, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    ");
#nullable restore
#line 15 "F:\VisualStudio\source\UdemyMvcCoreDosyaları\UdemyToDo\YSKProje.ToDo.Web\Areas\Member\Views\Bildirim\Index.cshtml"
               Write(bildirim.Aciklama);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <button type=\"submit\" class=\"btn btn-info btn-sm float-right\">Okundu</button>\r\n                </p>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 20 "F:\VisualStudio\source\UdemyMvcCoreDosyaları\UdemyToDo\YSKProje.ToDo.Web\Areas\Member\Views\Bildirim\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "F:\VisualStudio\source\UdemyMvcCoreDosyaları\UdemyToDo\YSKProje.ToDo.Web\Areas\Member\Views\Bildirim\Index.cshtml"
     
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-light p-3 my-2\">\r\n        <p class=\"lead\">\r\n            Okunmamış Bildiriminiz Bulunmamakta.\r\n        </p>\r\n    </div>\r\n");
#nullable restore
#line 29 "F:\VisualStudio\source\UdemyMvcCoreDosyaları\UdemyToDo\YSKProje.ToDo.Web\Areas\Member\Views\Bildirim\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BildirimListDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
