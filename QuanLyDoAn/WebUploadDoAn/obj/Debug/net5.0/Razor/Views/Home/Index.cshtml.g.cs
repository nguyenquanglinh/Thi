#pragma checksum "C:\Users\Dell\source\repos\QuanLyDoAn\WebUploadDoAn\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59f5f914f93a339ec130adaf4215f5a82f432a15"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Dell\source\repos\QuanLyDoAn\WebUploadDoAn\Views\_ViewImports.cshtml"
using WebUploadDoAn;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dell\source\repos\QuanLyDoAn\WebUploadDoAn\Views\_ViewImports.cshtml"
using WebUploadDoAn.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59f5f914f93a339ec130adaf4215f5a82f432a15", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef8f0d76a41250ead4aa81fc134968de2c140c8b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DBStore.DAO.DoAn>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<p>\r\n");
#nullable restore
#line 4 "C:\Users\Dell\source\repos\QuanLyDoAn\WebUploadDoAn\Views\Home\Index.cshtml"
     if (ViewBag.Session != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "59f5f914f93a339ec130adaf4215f5a82f432a153628", async() => {
                WriteLiteral("Thêm");
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
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\Dell\source\repos\QuanLyDoAn\WebUploadDoAn\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "C:\Users\Dell\source\repos\QuanLyDoAn\WebUploadDoAn\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MaDoAn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\Dell\source\repos\QuanLyDoAn\WebUploadDoAn\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MaSV));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\Dell\source\repos\QuanLyDoAn\WebUploadDoAn\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TenDoAN));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\Dell\source\repos\QuanLyDoAn\WebUploadDoAn\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MoTa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\Dell\source\repos\QuanLyDoAn\WebUploadDoAn\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MaGVHD));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\Dell\source\repos\QuanLyDoAn\WebUploadDoAn\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FileWordPdf));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\Dell\source\repos\QuanLyDoAn\WebUploadDoAn\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FileSourceCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 37 "C:\Users\Dell\source\repos\QuanLyDoAn\WebUploadDoAn\Views\Home\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 41 "C:\Users\Dell\source\repos\QuanLyDoAn\WebUploadDoAn\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.MaDoAn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 44 "C:\Users\Dell\source\repos\QuanLyDoAn\WebUploadDoAn\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.MaSV));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 47 "C:\Users\Dell\source\repos\QuanLyDoAn\WebUploadDoAn\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.TenDoAN));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 50 "C:\Users\Dell\source\repos\QuanLyDoAn\WebUploadDoAn\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.MoTa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 53 "C:\Users\Dell\source\repos\QuanLyDoAn\WebUploadDoAn\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.MaGVHD));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 56 "C:\Users\Dell\source\repos\QuanLyDoAn\WebUploadDoAn\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.FileWordPdf));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 59 "C:\Users\Dell\source\repos\QuanLyDoAn\WebUploadDoAn\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.FileSourceCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n\r\n");
#nullable restore
#line 63 "C:\Users\Dell\source\repos\QuanLyDoAn\WebUploadDoAn\Views\Home\Index.cshtml"
                     if (ViewBag.Session != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a>\r\n                            ");
#nullable restore
#line 66 "C:\Users\Dell\source\repos\QuanLyDoAn\WebUploadDoAn\Views\Home\Index.cshtml"
                       Write(Html.ActionLink("Xem", "Details", new { id = item.MaDoAn }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </a>\r\n                        <a>\r\n                            ");
#nullable restore
#line 69 "C:\Users\Dell\source\repos\QuanLyDoAn\WebUploadDoAn\Views\Home\Index.cshtml"
                       Write(Html.ActionLink("Sửa", "Edit", new { id = item.MaDoAn }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </a>\r\n                        <a>\r\n                            ");
#nullable restore
#line 72 "C:\Users\Dell\source\repos\QuanLyDoAn\WebUploadDoAn\Views\Home\Index.cshtml"
                       Write(Html.ActionLink("Xóa", "Delete", new { id = item.MaDoAn }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </a>\r\n");
#nullable restore
#line 74 "C:\Users\Dell\source\repos\QuanLyDoAn\WebUploadDoAn\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 77 "C:\Users\Dell\source\repos\QuanLyDoAn\WebUploadDoAn\Views\Home\Index.cshtml"
                     if (ViewBag.maGV!=null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a>\r\n                            ");
#nullable restore
#line 80 "C:\Users\Dell\source\repos\QuanLyDoAn\WebUploadDoAn\Views\Home\Index.cshtml"
                       Write(Html.ActionLink("Xem", "Details", new { id = item.MaDoAn }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </a>\r\n");
#nullable restore
#line 82 "C:\Users\Dell\source\repos\QuanLyDoAn\WebUploadDoAn\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n            </tr>\r\n");
#nullable restore
#line 85 "C:\Users\Dell\source\repos\QuanLyDoAn\WebUploadDoAn\Views\Home\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DBStore.DAO.DoAn>> Html { get; private set; }
    }
}
#pragma warning restore 1591
