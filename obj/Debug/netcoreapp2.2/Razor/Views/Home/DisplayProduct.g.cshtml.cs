#pragma checksum "C:\Users\TylerN\Coding\ProNCat\Views\Home\DisplayProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3222207a9cc6a745ccdc928034572382e778cc14"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_DisplayProduct), @"mvc.1.0.view", @"/Views/Home/DisplayProduct.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/DisplayProduct.cshtml", typeof(AspNetCore.Views_Home_DisplayProduct))]
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
#line 1 "C:\Users\TylerN\Coding\ProNCat\Views\_ViewImports.cshtml"
using ProNCat;

#line default
#line hidden
#line 2 "C:\Users\TylerN\Coding\ProNCat\Views\_ViewImports.cshtml"
using ProNCat.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3222207a9cc6a745ccdc928034572382e778cc14", @"/Views/Home/DisplayProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20f7c04f08b39963e7048ebb98698a9732f75a0d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_DisplayProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(16, 33, true);
            WriteLiteral("<div class=\"jumbotron\">\r\n    <h1>");
            EndContext();
            BeginContext(50, 17, false);
#line 3 "C:\Users\TylerN\Coding\ProNCat\Views\Home\DisplayProduct.cshtml"
   Write(Model.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(67, 14, true);
            WriteLiteral("</h1>\r\n    <p>");
            EndContext();
            BeginContext(82, 17, false);
#line 4 "C:\Users\TylerN\Coding\ProNCat\Views\Home\DisplayProduct.cshtml"
  Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(99, 124, true);
            WriteLiteral("</p>\r\n    <a href=\"/\">Go Back</a>\r\n</div>\r\n\r\n\r\n\r\n<div class=\"row\">\r\n    <div class=\"col col-sm-6\">\r\n        <h2>Categories: ");
            EndContext();
            BeginContext(224, 22, false);
#line 12 "C:\Users\TylerN\Coding\ProNCat\Views\Home\DisplayProduct.cshtml"
                   Write(Model.Categories.Count);

#line default
#line hidden
            EndContext();
            BeginContext(246, 7, true);
            WriteLiteral("</h2>\r\n");
            EndContext();
#line 13 "C:\Users\TylerN\Coding\ProNCat\Views\Home\DisplayProduct.cshtml"
         foreach (var c in Model.Categories)
        {

#line default
#line hidden
            BeginContext(310, 16, true);
            WriteLiteral("            <li>");
            EndContext();
            BeginContext(327, 23, false);
#line 15 "C:\Users\TylerN\Coding\ProNCat\Views\Home\DisplayProduct.cshtml"
           Write(c.Category.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(350, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 16 "C:\Users\TylerN\Coding\ProNCat\Views\Home\DisplayProduct.cshtml"
        }

#line default
#line hidden
            BeginContext(368, 85, true);
            WriteLiteral("    </div>\r\n    <div class=\"col col-sm-6\">\r\n        <h2>Add Categories</h2>\r\n        ");
            EndContext();
            BeginContext(453, 651, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3222207a9cc6a745ccdc928034572382e778cc145793", async() => {
                BeginContext(517, 58, true);
                WriteLiteral("\r\n            <select class=\"form-control\" name=\"catID\">\r\n");
                EndContext();
#line 22 "C:\Users\TylerN\Coding\ProNCat\Views\Home\DisplayProduct.cshtml"
                  
                    List<Category> All = (List<Category>) ViewBag.AllCategories;
                    List<Category> Added = Model.Categories.Select( a => a.Category).ToList();
                    foreach(Category c in All.Except(Added))
                    {

#line default
#line hidden
                BeginContext(858, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(882, 54, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3222207a9cc6a745ccdc928034572382e778cc146763", async() => {
                    BeginContext(913, 14, false);
#line 27 "C:\Users\TylerN\Coding\ProNCat\Views\Home\DisplayProduct.cshtml"
                                                 Write(c.CategoryName);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 27 "C:\Users\TylerN\Coding\ProNCat\Views\Home\DisplayProduct.cshtml"
                           WriteLiteral(c.CategoryId);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(936, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 28 "C:\Users\TylerN\Coding\ProNCat\Views\Home\DisplayProduct.cshtml"
                    }
                

#line default
#line hidden
                BeginContext(980, 117, true);
                WriteLiteral("            </select>\r\n            <input type=\"submit\" value=\"Add Category\" class=\"btn btn-danger btn-sm\">\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 467, "/product/", 467, 9, true);
#line 20 "C:\Users\TylerN\Coding\ProNCat\Views\Home\DisplayProduct.cshtml"
AddHtmlAttributeValue("", 476, Model.ProductId, 476, 16, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 492, "/category", 492, 9, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1104, 20, true);
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
