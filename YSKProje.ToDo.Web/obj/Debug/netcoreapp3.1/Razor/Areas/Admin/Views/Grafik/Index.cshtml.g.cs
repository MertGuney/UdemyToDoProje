#pragma checksum "F:\VisualStudio\source\UdemyMvcCoreDosyaları\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\Grafik\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7bd583d5058be702dd64a670d4cc641ce831501b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Grafik_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Grafik/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bd583d5058be702dd64a670d4cc641ce831501b", @"/Areas/Admin/Views/Grafik/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdbfcac96b53e97d9be63b92a806e3e1c3bc236e", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Grafik_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "F:\VisualStudio\source\UdemyMvcCoreDosyaları\UdemyToDo\YSKProje.ToDo.Web\Areas\Admin\Views\Grafik\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"piechart_3d\" style=\"width: 900px; height: 500px;\"></div>\r\n<div id=\"piechart_3d2\" style=\"width: 900px; height: 500px;\"></div>\r\n\r\n");
            DefineSection("JavaScript", async() => {
                WriteLiteral(@"

    <script type=""text/javascript"" src=""https://www.gstatic.com/charts/loader.js""></script>

    <script type=""text/javascript"">

        google.charts.load(""current"", { packages: [""corechart""] });
        google.charts.setOnLoadCallback(drawChart);
        function drawChart() {

            let enCokIsTamamlayan = [['Personel Adı', 'Görev Sayısı']];
            $.ajax({
                type: ""GET"",
                url: ""./Grafik/EnCokTamamlayan"",
                async: false,
                success: function (data) {
                    let gelenObje = jQuery.parseJSON(data);
                    $.each(gelenObje, function (index, value) {
                        enCokIsTamamlayan.push([value.Isim, value.GorevSayisi]);
                    });
                }
            })

            var data = google.visualization.arrayToDataTable(enCokIsTamamlayan);

            var options = {
                title: 'En Çok İş Tamamlayan 5 Personel',
                is3D: true,
         ");
                WriteLiteral(@"   };

            var chart = new google.visualization.PieChart(document.getElementById('piechart_3d'));
            chart.draw(data, options);
        }

        google.charts.load(""current"", { packages: [""corechart""] });
        google.charts.setOnLoadCallback(drawChart2);
        function drawChart2() {

            let EnCokCalisan = [['Personel Adı', 'Görev Sayısı']];
            $.ajax({
                type: ""GET"",
                url: ""./Grafik/EnCokCalisan"",
                async: false,
                success: function (data) {
                    let gelenObje2 = jQuery.parseJSON(data);
                    $.each(gelenObje2, function (index, value) {
                        EnCokCalisan.push([value.Isim, value.GorevSayisi]);
                    });
                }
            })

            var data = google.visualization.arrayToDataTable(EnCokCalisan);

            var options = {
                title: 'Şu an Görevde Çalışan Personeller',
                is3D: true");
                WriteLiteral(",\r\n            };\r\n\r\n            var chart = new google.visualization.PieChart(document.getElementById(\'piechart_3d2\'));\r\n            chart.draw(data, options);\r\n        }\r\n    </script>\r\n\r\n");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
