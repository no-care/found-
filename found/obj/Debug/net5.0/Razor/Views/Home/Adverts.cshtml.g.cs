#pragma checksum "C:\Users\Дом\Desktop\found\found\Views\Home\Adverts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5a498c69cc218441c11faed48bcbf418aeb1de5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Adverts), @"mvc.1.0.view", @"/Views/Home/Adverts.cshtml")]
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
#line 1 "C:\Users\Дом\Desktop\found\found\Views\_ViewImports.cshtml"
using found;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Дом\Desktop\found\found\Views\_ViewImports.cshtml"
using found.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Дом\Desktop\found\found\Views\_ViewImports.cshtml"
using found.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Дом\Desktop\found\found\Views\Home\Adverts.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5a498c69cc218441c11faed48bcbf418aeb1de5", @"/Views/Home/Adverts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b851c7d8e223d479df046125e2b081e47919a4f3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Adverts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AdvLVModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary background-blue text-white corner-radius-15px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Advert", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CurrAdvert", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("    <div class=\"container mt-5\">\r\n        <main role=\"main\" class=\"pb-3\">\r\n            <h1 class=\"text-blue\">Объявления</h1>\r\n            <hr>\r\n            <div class=\"row mt-4 mb-2\">\r\n");
#nullable restore
#line 9 "C:\Users\Дом\Desktop\found\found\Views\Home\Adverts.cshtml"
                  
                    foreach (var advert in Model.allAdv)
                    {
                        if (advert.Usersid != @HttpContextAccessor.HttpContext.Session.GetInt32("id"))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-lg-3 mt-2 text-center\">\r\n                                <img class=\"img-fluid img-adverts img-center\"");
            BeginWriteAttribute("src", " src=\"", 667, "\"", 684, 1);
#nullable restore
#line 15 "C:\Users\Дом\Desktop\found\found\Views\Home\Adverts.cshtml"
WriteAttributeValue("", 673, advert.img, 673, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 685, "\"", 709, 1);
#nullable restore
#line 15 "C:\Users\Дом\Desktop\found\found\Views\Home\Adverts.cshtml"
WriteAttributeValue("", 691, advert.desc_short, 691, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                <h3 class=\"text-blue\">");
#nullable restore
#line 16 "C:\Users\Дом\Desktop\found\found\Views\Home\Adverts.cshtml"
                                                 Write(advert.desc_short);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                <p class=\"text-blue\">Найдено: ");
#nullable restore
#line 17 "C:\Users\Дом\Desktop\found\found\Views\Home\Adverts.cshtml"
                                                         Write(advert.location);

#line default
#line hidden
#nullable disable
            WriteLiteral(" в ");
#nullable restore
#line 17 "C:\Users\Дом\Desktop\found\found\Views\Home\Adverts.cshtml"
                                                                            Write(advert.time);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p class=\"text-blue\">Автор: ");
#nullable restore
#line 18 "C:\Users\Дом\Desktop\found\found\Views\Home\Adverts.cshtml"
                                                       Write(advert.Users.login);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e5a498c69cc218441c11faed48bcbf418aeb1de57032", async() => {
                WriteLiteral("Подробнее");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 19 "C:\Users\Дом\Desktop\found\found\Views\Home\Adverts.cshtml"
                                                                                                                                                                      WriteLiteral(advert.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\r\n                            </div>\r\n");
#nullable restore
#line 21 "C:\Users\Дом\Desktop\found\found\Views\Home\Adverts.cshtml"
                        }
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </main>\r\n        </div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AdvLVModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
