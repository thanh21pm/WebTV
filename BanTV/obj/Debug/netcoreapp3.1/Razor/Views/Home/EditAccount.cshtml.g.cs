#pragma checksum "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Home\EditAccount.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d87e4a2de65b91a2bd2ed491f5081bf44057e69"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_EditAccount), @"mvc.1.0.view", @"/Views/Home/EditAccount.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d87e4a2de65b91a2bd2ed491f5081bf44057e69", @"/Views/Home/EditAccount.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5060917ffb4f25a7036e0102b1cc36904af80b5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_EditAccount : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditAccount", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Home\EditAccount.cshtml"
  
    ViewData["Title"] = "Sửa thông tin tài khoản";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<br />
<br />
<br />
<br />
<div class=""container"">
    <div class=""row justify-content-center"">
        <h3 class=""col-md-4 text-success"">Sửa thông tin tài khoản</h3>
    </div>
    <div class=""row justify-content-center"">
        <div class=""col-md-4 "">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d87e4a2de65b91a2bd2ed491f5081bf44057e693954", async() => {
                WriteLiteral("\r\n                <div class=\"my-3\">\r\n                    <label>Họ tên</label>\r\n                    <input type=\"text\" name=\"hoten\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 521, "\"", 551, 1);
#nullable restore
#line 17 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Home\EditAccount.cshtml"
WriteAttributeValue("", 529, ViewBag.khachhang.Ten, 529, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                </div>\r\n                <div class=\"my-3\">\r\n                    <label>Số điện thoại</label>\r\n                    <input type=\"text\" name=\"dienthoai\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 743, "\"", 779, 1);
#nullable restore
#line 21 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Home\EditAccount.cshtml"
WriteAttributeValue("", 751, ViewBag.khachhang.Dienthoai, 751, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                </div>\r\n                <div class=\"my-3\">\r\n                    <label>Email</label>\r\n                    <input type=\"text\" name=\"email\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 959, "\"", 991, 1);
#nullable restore
#line 25 "E:\DoanthuctapBanTV\BanTV\BanTV\Views\Home\EditAccount.cshtml"
WriteAttributeValue("", 967, ViewBag.khachhang.Email, 967, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                </div>
                <div class=""my-3"">
                    <label>Mật khẩu mới</label>
                    <input type=""text"" name=""matkhau"" class=""form-control"" />
                </div>
                <div class=""my-3 d-grid"">
                    <input type=""submit"" value=""Lưu"" class=""btn btn-block btn-success"" />
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n<br />\r\n<br />\r\n<br />\r\n<br />\r\n");
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