#pragma checksum "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Main\XemThongKeTheoNgay.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f2c1d9a3d0f38355c2b9ec1cd204f6f31e8b324"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Main_XemThongKeTheoNgay), @"mvc.1.0.view", @"/Views/Main/XemThongKeTheoNgay.cshtml")]
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
#line 1 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\_ViewImports.cshtml"
using BanTV;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\_ViewImports.cshtml"
using BanTV.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f2c1d9a3d0f38355c2b9ec1cd204f6f31e8b324", @"/Views/Main/XemThongKeTheoNgay.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5060917ffb4f25a7036e0102b1cc36904af80b5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Main_XemThongKeTheoNgay : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BanTV.Models.HoaDon>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ThongKeTheoNgay", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChiTietHoaDonTheoNgay", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Main\XemThongKeTheoNgay.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n<br />\r\n<br />\r\n<br />\r\n<h1 class=\"text-info\">Thống kê hóa đơn theo ngày</h1>\r\n<label>Ngày bắt đầu: ");
#nullable restore
#line 11 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Main\XemThongKeTheoNgay.cshtml"
                Write(ViewData["ngaybatdau"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n<br />\r\n<label>Ngày kết thúc: ");
#nullable restore
#line 13 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Main\XemThongKeTheoNgay.cshtml"
                 Write(ViewData["ngayketthuc"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n<br />\r\n<label>Tổng tiền trong khoảng thời gian trên: ");
#nullable restore
#line 15 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Main\XemThongKeTheoNgay.cshtml"
                                         Write(ViewData["tongtien"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n<br />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f2c1d9a3d0f38355c2b9ec1cd204f6f31e8b3245240", async() => {
                WriteLiteral("Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<table class=""table"">
    <thead>
        <tr>
            <th>
                Mã hóa đơn
            </th>
            <th>
                Mã khách hàng
            </th>
            <th>
                Tên khách hàng
            </th>
            <th>
                Email
            </th>
            <th>
                Điện thoại
            </th>
           
            <th>
                Ngày bán
            </th>
            <th>
                Tổng tiền
            </th>


            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 50 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Main\XemThongKeTheoNgay.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 54 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Main\XemThongKeTheoNgay.cshtml"
           Write(Html.DisplayFor(modelItem => item.Mahd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 57 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Main\XemThongKeTheoNgay.cshtml"
           Write(Html.DisplayFor(modelItem => item.MakhNavigation.Makh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 60 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Main\XemThongKeTheoNgay.cshtml"
           Write(Html.DisplayFor(modelItem => item.MakhNavigation.Ten));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 63 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Main\XemThongKeTheoNgay.cshtml"
           Write(Html.DisplayFor(modelItem => item.MakhNavigation.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 66 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Main\XemThongKeTheoNgay.cshtml"
           Write(Html.DisplayFor(modelItem => item.MakhNavigation.Dienthoai));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 69 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Main\XemThongKeTheoNgay.cshtml"
           Write(Html.DisplayFor(modelItem => item.Ngay));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 72 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Main\XemThongKeTheoNgay.cshtml"
           Write(Html.DisplayFor(modelItem => item.Tongtien));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f2c1d9a3d0f38355c2b9ec1cd204f6f31e8b3249447", async() => {
                WriteLiteral("\r\n                    Chi tiết\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 75 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Main\XemThongKeTheoNgay.cshtml"
                                                                                WriteLiteral(item.Mahd);

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
            WriteLiteral("\r\n            </td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 81 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Main\XemThongKeTheoNgay.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BanTV.Models.HoaDon>> Html { get; private set; }
    }
}
#pragma warning restore 1591
