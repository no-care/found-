#pragma checksum "C:\Users\Дом\Desktop\found\found\Views\Advert\CurrAdvert.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23a81e752f8081bda44507ae56a34d08aaa13751"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Advert_CurrAdvert), @"mvc.1.0.view", @"/Views/Advert/CurrAdvert.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23a81e752f8081bda44507ae56a34d08aaa13751", @"/Views/Advert/CurrAdvert.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b851c7d8e223d479df046125e2b081e47919a4f3", @"/Views/_ViewImports.cshtml")]
    public class Views_Advert_CurrAdvert : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Дом\Desktop\found\found\Views\Advert\CurrAdvert.cshtml"
    var advert = Model.GetAdvert;
    

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h3 class=\"display-3 mt-5 text-center\">Объявление № ");
#nullable restore
#line 3 "C:\Users\Дом\Desktop\found\found\Views\Advert\CurrAdvert.cshtml"
                                                               Write(advert.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                <div class=\"mt-3 mb-2\">\r\n      \r\n                <div class=\"container text-center mt-1\">\r\n                    <img class=\"img-fluid\" width=\"500\" height=\"500\"");
            BeginWriteAttribute("src", " src=\"", 300, "\"", 317, 1);
#nullable restore
#line 7 "C:\Users\Дом\Desktop\found\found\Views\Advert\CurrAdvert.cshtml"
WriteAttributeValue("", 306, advert.img, 306, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 318, "\"", 342, 1);
#nullable restore
#line 7 "C:\Users\Дом\Desktop\found\found\Views\Advert\CurrAdvert.cshtml"
WriteAttributeValue("", 324, advert.desc_short, 324, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    <h3>");
#nullable restore
#line 8 "C:\Users\Дом\Desktop\found\found\Views\Advert\CurrAdvert.cshtml"
                   Write(advert.desc_short);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <p class=\"container\">Место находки: ");
#nullable restore
#line 9 "C:\Users\Дом\Desktop\found\found\Views\Advert\CurrAdvert.cshtml"
                                                   Write(advert.location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"container\">Время находки: ");
#nullable restore
#line 10 "C:\Users\Дом\Desktop\found\found\Views\Advert\CurrAdvert.cshtml"
                                                   Write(advert.time);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"container\">Описание: ");
#nullable restore
#line 11 "C:\Users\Дом\Desktop\found\found\Views\Advert\CurrAdvert.cshtml"
                                              Write(advert.desc_long);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"container\">");
#nullable restore
#line 12 "C:\Users\Дом\Desktop\found\found\Views\Advert\CurrAdvert.cshtml"
                                    Write(advert.Usersid);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p><a class=\"btn btn-warning btn-sm text-dark\">Ответить</a></p>\r\n                </div>\r\n                </div>\r\n");
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