#pragma checksum "C:\Users\Дом\Desktop\found\found\Views\Messages\Messages.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d7377bd40ed0bdcbf9c7c2135bb708caabf974d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Messages_Messages), @"mvc.1.0.view", @"/Views/Messages/Messages.cshtml")]
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
#line 1 "C:\Users\Дом\Desktop\found\found\Views\Messages\Messages.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Дом\Desktop\found\found\Views\Messages\Messages.cshtml"
using found.Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d7377bd40ed0bdcbf9c7c2135bb708caabf974d", @"/Views/Messages/Messages.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b851c7d8e223d479df046125e2b081e47919a4f3", @"/Views/_ViewImports.cshtml")]
    public class Views_Messages_Messages : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DialogsVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Messages", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Messages", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\Дом\Desktop\found\found\Views\Messages\Messages.cshtml"
   var dialog = Model.GetCurrDialog;


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"container mt-5 mb-4\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d7377bd40ed0bdcbf9c7c2135bb708caabf974d6040", async() => {
                WriteLiteral(@"
                        <div class=""col-12 col-lg-7 col-xl-9"">
                            <div class=""py-2 px-4 border-bottom d-lg-block"">
                                <div class=""d-flex align-items-center py-1"">
                                    <div class=""flex-grow-1 pl-3""> 
                                        <h5><strong class=""text-blue"">");
#nullable restore
#line 13 "C:\Users\Дом\Desktop\found\found\Views\Messages\Messages.cshtml"
                                                                 Write(dialog?.Users.FirstOrDefault(u =>u.id != @HttpContextAccessor.HttpContext.Session.GetInt32("id")).login);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</strong></h5>
                                    </div>
                                </div>
                            </div>
                            <div class=""position-relative"" >
                                <div class=""chat-messages p-4 messages-block"" id=""messageblock"">
");
#nullable restore
#line 19 "C:\Users\Дом\Desktop\found\found\Views\Messages\Messages.cshtml"
                                     foreach (var message in Model.GetAllDialogsMessages)
                                    {

                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Дом\Desktop\found\found\Views\Messages\Messages.cshtml"
                                         if (message.usersid != @HttpContextAccessor.HttpContext.Session.GetInt32("id"))
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                            <div class=""d-flex justify-content-between mb-4"">
                                                <div class=""card mask-custom min-width-250px bachground-gray"">
                                                    <div class=""card-header h-47 d-flex justify-content-between p-3"">
                                                        <p class=""fw-bold mb-0 text-black"">");
#nullable restore
#line 27 "C:\Users\Дом\Desktop\found\found\Views\Messages\Messages.cshtml"
                                                                                      Write(message.Users.login);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                                        <p class=\"text-black small mb-0\"><i class=\"far fa-clock\">\r\n                                                               </i>");
#nullable restore
#line 29 "C:\Users\Дом\Desktop\found\found\Views\Messages\Messages.cshtml"
                                                              Write(Math.Ceiling(DateTime.Now.Subtract(Convert.ToDateTime(message.datetime)).TotalMinutes));

#line default
#line hidden
#nullable disable
                WriteLiteral(" минут назад</p>\r\n                                                    </div>\r\n                                                    <div class=\"card-body h-52\">\r\n                                                        <p class=\"mb-0 text-black\">");
#nullable restore
#line 32 "C:\Users\Дом\Desktop\found\found\Views\Messages\Messages.cshtml"
                                                                              Write(message.message);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                                    </div>\r\n                                                </div>\r\n                                            </div>\r\n");
#nullable restore
#line 36 "C:\Users\Дом\Desktop\found\found\Views\Messages\Messages.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                            <div class=""d-flex justify-content-end mb-4"">
                                                <div class=""card mask-custom min-width-250px bg-messages"">
                                                    <div class=""card-header h-47 d-flex justify-content-between p-3"">
                                                        <p class=""fw-bold mb-0 text-white"">Вы</p>
                                                        <p class=""text-light small mb-0 text-white""><i class=""far fa-clock"">
                                                                </i>");
#nullable restore
#line 44 "C:\Users\Дом\Desktop\found\found\Views\Messages\Messages.cshtml"
                                                               Write(Math.Ceiling(DateTime.Now.Subtract(Convert.ToDateTime(message.datetime)).TotalMinutes));

#line default
#line hidden
#nullable disable
                WriteLiteral(" минут назад</p>\r\n                                                    </div>\r\n                                                    <div class=\"card-body h-52\">\r\n                                                        <p class=\"mb-0 text-white\">");
#nullable restore
#line 47 "C:\Users\Дом\Desktop\found\found\Views\Messages\Messages.cshtml"
                                                                              Write(message.message);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                                    </div>\r\n                                                </div>\r\n                                            </div>\r\n");
#nullable restore
#line 51 "C:\Users\Дом\Desktop\found\found\Views\Messages\Messages.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\Дом\Desktop\found\found\Views\Messages\Messages.cshtml"
                                         
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                </div>
                            </div>
                            <div class=""flex-grow-0 py-3 px-4 border-top"">
                                <div class=""input-group"">
                                    <input type=""text""  required class=""form-control"" name=""message"">
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d7377bd40ed0bdcbf9c7c2135bb708caabf974d12768", async() => {
                    WriteLiteral("Отправить");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-dialogid", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 58 "C:\Users\Дом\Desktop\found\found\Views\Messages\Messages.cshtml"
                                                                                          WriteLiteral(dialog.id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["dialogid"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-dialogid", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["dialogid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n");
            WriteLiteral("<script type=\"text/javascript\">\r\n  var block = document.getElementById(\"messageblock\");\r\n  block.scrollTop = block.scrollHeight;\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DialogsVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
