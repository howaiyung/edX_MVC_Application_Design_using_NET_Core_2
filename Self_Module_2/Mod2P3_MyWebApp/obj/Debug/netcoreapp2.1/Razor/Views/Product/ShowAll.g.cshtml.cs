#pragma checksum "C:\Users\ZipZash\Documents\Projects\Mod2P3_MyWebApp\Views\Product\ShowAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bfe2471feafb5c2554443ed5fc020850383fd6aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ShowAll), @"mvc.1.0.view", @"/Views/Product/ShowAll.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/ShowAll.cshtml", typeof(AspNetCore.Views_Product_ShowAll))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bfe2471feafb5c2554443ed5fc020850383fd6aa", @"/Views/Product/ShowAll.cshtml")]
    public class Views_Product_ShowAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Mod2P3_MyWebApp.Models.Product>>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 14, true);
            WriteLiteral("\r\n<html>\r\n    ");
            EndContext();
            BeginContext(59, 445, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "347a2e1aae594528bbff3cda8d56e1b0", async() => {
                BeginContext(65, 14, true);
                WriteLiteral("\r\n        <h1>");
                EndContext();
                BeginContext(80, 19, false);
#line 5 "C:\Users\ZipZash\Documents\Projects\Mod2P3_MyWebApp\Views\Product\ShowAll.cshtml"
       Write(ViewData["Heading"]);

#line default
#line hidden
                EndContext();
                BeginContext(99, 164, true);
                WriteLiteral("</h1>\r\n        <table border=\"1\">\r\n            <tr>\r\n                <td>ID</td>\r\n                <td>Name</td>\r\n                <td>Price</td>\r\n            </tr>\r\n");
                EndContext();
#line 12 "C:\Users\ZipZash\Documents\Projects\Mod2P3_MyWebApp\Views\Product\ShowAll.cshtml"
             foreach(var p in Model){

#line default
#line hidden
                BeginContext(302, 46, true);
                WriteLiteral("                <tr>\r\n                    <td>");
                EndContext();
                BeginContext(349, 4, false);
#line 14 "C:\Users\ZipZash\Documents\Projects\Mod2P3_MyWebApp\Views\Product\ShowAll.cshtml"
                   Write(p.ID);

#line default
#line hidden
                EndContext();
                BeginContext(353, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(385, 6, false);
#line 15 "C:\Users\ZipZash\Documents\Projects\Mod2P3_MyWebApp\Views\Product\ShowAll.cshtml"
                   Write(p.Name);

#line default
#line hidden
                EndContext();
                BeginContext(391, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(423, 7, false);
#line 16 "C:\Users\ZipZash\Documents\Projects\Mod2P3_MyWebApp\Views\Product\ShowAll.cshtml"
                   Write(p.Price);

#line default
#line hidden
                EndContext();
                BeginContext(430, 30, true);
                WriteLiteral("</td>\r\n                </tr>\r\n");
                EndContext();
#line 18 "C:\Users\ZipZash\Documents\Projects\Mod2P3_MyWebApp\Views\Product\ShowAll.cshtml"
            }

#line default
#line hidden
                BeginContext(475, 22, true);
                WriteLiteral("        </table>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(504, 9, true);
            WriteLiteral("\r\n</html>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Mod2P3_MyWebApp.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591