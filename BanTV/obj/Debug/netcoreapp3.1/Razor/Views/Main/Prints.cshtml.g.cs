#pragma checksum "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Main\Prints.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d0a6243d5d3944fe79698279810c49d8c784106"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Main_Prints), @"mvc.1.0.view", @"/Views/Main/Prints.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d0a6243d5d3944fe79698279810c49d8c784106", @"/Views/Main/Prints.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5060917ffb4f25a7036e0102b1cc36904af80b5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Main_Prints : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BanTV.Models.HoaDon>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("150"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onload", new global::Microsoft.AspNetCore.Html.HtmlString("window.print();"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Main\Prints.cshtml"
   ViewData["Title"] = "In hoá đơn";
    Layout = "~/Views/Shared/_Layout2.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d0a6243d5d3944fe79698279810c49d8c7841064256", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <title>AdminLTE 2 | Invoice</title>
    <meta content='width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no' name='viewport'>
    <!-- Bootstrap 3.3.2 -->
    <link href=""../../bootstrap/css/bootstrap.min.css"" rel=""stylesheet"" type=""text/css"" />
    <!-- Font Awesome Icons -->
    <link href=""https://maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css"" rel=""stylesheet"" type=""text/css"" />
    <!-- Ionicons -->
    <link href=""http://code.ionicframework.com/ionicons/2.0.0/css/ionicons.min.css"" rel=""stylesheet"" type=""text/css"" />
    <!-- Theme style -->
    <link href=""../../dist/css/AdminLTE.min.css"" rel=""stylesheet"" type=""text/css"" />

    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
      <script src=""https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js""></script>
      <script src=""htt");
                WriteLiteral("ps://oss.maxcdn.com/libs/respond.js/1.3.0/respond.min.js\"></script>\r\n    <![endif]-->\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d0a6243d5d3944fe79698279810c49d8c7841066399", async() => {
                WriteLiteral(@"
    <div class=""wrapper"">
        <!-- Main content -->
        <section class=""invoice"">
            <!-- title row -->
            <div class=""row"">
                <div class=""col-xs-12"">
                    <h2 class=""page-header"">
                        <i class=""fa fa-globe""></i>Chi tiết đơn hàng có mã số: ");
#nullable restore
#line 34 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Main\Prints.cshtml"
                                                                          Write(Model.Mahd);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                        <small class=\"pull-right\">ngày lập: ");
#nullable restore
#line 36 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Main\Prints.cshtml"
                                                       Write(Model.Ngay);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</small>
                    </h2>
                </div><!-- /.col -->
            </div>
            <!-- info row -->
            <div class=""row invoice-info"">
                <div class=""col-sm-4 invoice-col"">

                    <address>
                        <strong>Thông tin hóa đơn</strong><br>
                        Mã hóa đơn: ");
#nullable restore
#line 46 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Main\Prints.cshtml"
                               Write(Model.Mahd);

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n                        Ngày lập: ");
#nullable restore
#line 47 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Main\Prints.cshtml"
                             Write(Model.Ngay);

#line default
#line hidden
#nullable disable
                WriteLiteral("<br>\r\n                        Tổng tiền: ");
#nullable restore
#line 48 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Main\Prints.cshtml"
                              Write(Model.Tongtien);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"<br>

                    </address>
                </div><!-- /.col -->
                <div class=""col-sm-4 invoice-col"">

                    <address>
                        <strong>Thông tin khách hàng</strong><br>
                        Mã khách hàng: ");
#nullable restore
#line 56 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Main\Prints.cshtml"
                                  Write(Model.Makh);

#line default
#line hidden
#nullable disable
                WriteLiteral("<br>\r\n                        Tên: ");
#nullable restore
#line 57 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Main\Prints.cshtml"
                        Write(Model.MakhNavigation.Ten);

#line default
#line hidden
#nullable disable
                WriteLiteral("<br>\r\n                        Điện thoại: ");
#nullable restore
#line 58 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Main\Prints.cshtml"
                               Write(Model.MakhNavigation.Dienthoai);

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n                        Email: ");
#nullable restore
#line 59 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Main\Prints.cshtml"
                          Write(Model.MakhNavigation.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n                        Địa chỉ:  ");
#nullable restore
#line 60 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Main\Prints.cshtml"
                                    
                            string diachi = Model.MadcNavigation.Diachi1 + ", " + Model.MadcNavigation.Phuongxa + ", " + Model.MadcNavigation.Quanhuyen + ", " + Model.MadcNavigation.Tinhthanh;

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <label>");
#nullable restore
#line 62 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Main\Prints.cshtml"
                              Write(diachi);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n");
                WriteLiteral(@"                    </address>
                </div><!-- /.col -->

            </div><!-- /.row -->
            <!-- Table row -->
            <table class=""table"">
                <thead>
                    <tr>
                        <th scope=""col"">MaMH</th>
                        <th scope=""col"">Tên</th>
                        <th scope=""col"">Hình Ảnh</th>
                        <th scope=""col"">Giá</th>
                        <th scope=""col"">Số lượng</th>
                        <th scope=""col"">Thành tiền</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 81 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Main\Prints.cshtml"
                     foreach (CthoaDon c in ViewBag.chittiethoadon)
                    {
                        int stt = 1;

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 85 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Main\Prints.cshtml"
                           Write(stt);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 86 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Main\Prints.cshtml"
                           Write(c.Mamh);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 87 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Main\Prints.cshtml"
                           Write(c.MamhNavigation.Ten);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5d0a6243d5d3944fe79698279810c49d8c78410612560", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 3965, "~/images/images/", 3965, 16, true);
#nullable restore
#line 88 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Main\Prints.cshtml"
AddHtmlAttributeValue("", 3981, c.MamhNavigation.Hinhanh, 3981, 25, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 89 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Main\Prints.cshtml"
                           Write(c.Dongia.ToString("n0"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" đ</td>\r\n                            <td>");
#nullable restore
#line 90 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Main\Prints.cshtml"
                           Write(c.Soluong);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 91 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Main\Prints.cshtml"
                           Write(c.Thanhtien.ToString("n0"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" đ</td>\r\n                        </tr>\r\n");
#nullable restore
#line 93 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Main\Prints.cshtml"
                        stt++;
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </tbody>\r\n            </table>\r\n\r\n\r\n\r\n        </section><!-- /.content -->\r\n    </div>\r\n    <div class=\"clearfix\"></div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BanTV.Models.HoaDon> Html { get; private set; }
    }
}
#pragma warning restore 1591
