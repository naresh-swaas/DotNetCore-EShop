#pragma checksum "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\Web\Views\Manage\ExternalLogins.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2366e767c369b4525bcfdc1a02ac4d1a91c41d5a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Microsoft.eShopWeb.Web.Pages.Manage.Views_Manage_ExternalLogins), @"mvc.1.0.view", @"/Views/Manage/ExternalLogins.cshtml")]
namespace Microsoft.eShopWeb.Web.Pages.Manage
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
#line 1 "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\Web\Views\_ViewImports.cshtml"
using Microsoft.eShopWeb.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\Web\Views\_ViewImports.cshtml"
using Microsoft.eShopWeb.Web.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\Web\Views\_ViewImports.cshtml"
using Microsoft.eShopWeb.Web.ViewModels.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\Web\Views\_ViewImports.cshtml"
using Microsoft.eShopWeb.Web.ViewModels.Manage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\Web\Views\_ViewImports.cshtml"
using Microsoft.eShopWeb.Web.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\Web\Views\_ViewImports.cshtml"
using Microsoft.eShopWeb.Infrastructure.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\Web\Views\Manage\_ViewImports.cshtml"
using Microsoft.eShopWeb.Web.Views.Manage;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2366e767c369b4525bcfdc1a02ac4d1a91c41d5a", @"/Views/Manage/ExternalLogins.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3eac3cadc9c5c1e04416db60e767f2c2d60b242", @"/Views/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b3290b6ac67a9a81540f7bbe5f2c69ec45f3e9a", @"/Views/Manage/_ViewImports.cshtml")]
    public class Views_Manage_ExternalLogins : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ExternalLoginsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_StatusMessage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "LoginProvider", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "ProviderKey", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveLogin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "LinkLogin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\Web\Views\Manage\ExternalLogins.cshtml"
  
    ViewData["Title"] = "Manage your external logins";
    ViewData.AddActivePage(ManageNavPages.ExternalLogins);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2366e767c369b4525bcfdc1a02ac4d1a91c41d5a7952", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 6 "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\Web\Views\Manage\ExternalLogins.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.StatusMessage);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("for", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 7 "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\Web\Views\Manage\ExternalLogins.cshtml"
 if (Model.CurrentLogins?.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4>Registered Logins</h4>\n    <table class=\"table\">\n        <tbody>\n");
#nullable restore
#line 12 "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\Web\Views\Manage\ExternalLogins.cshtml"
             foreach (var login in Model.CurrentLogins)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td>");
#nullable restore
#line 15 "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\Web\Views\Manage\ExternalLogins.cshtml"
                   Write(login.LoginProvider);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>\n");
#nullable restore
#line 17 "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\Web\Views\Manage\ExternalLogins.cshtml"
                         if (Model.ShowRemoveButton)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2366e767c369b4525bcfdc1a02ac4d1a91c41d5a10932", async() => {
                WriteLiteral("\n                                <div>\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2366e767c369b4525bcfdc1a02ac4d1a91c41d5a11264", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 21 "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\Web\Views\Manage\ExternalLogins.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => login.LoginProvider);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2366e767c369b4525bcfdc1a02ac4d1a91c41d5a13242", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 22 "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\Web\Views\Manage\ExternalLogins.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => login.ProviderKey);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                    <button type=\"submit\" class=\"btn btn-default\"");
                BeginWriteAttribute("title", " title=\"", 974, "\"", 1038, 7);
                WriteAttributeValue("", 982, "Remove", 982, 6, true);
                WriteAttributeValue(" ", 988, "this", 989, 5, true);
#nullable restore
#line 23 "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\Web\Views\Manage\ExternalLogins.cshtml"
WriteAttributeValue(" ", 993, login.LoginProvider, 994, 20, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 1014, "login", 1015, 6, true);
                WriteAttributeValue(" ", 1020, "from", 1021, 5, true);
                WriteAttributeValue(" ", 1025, "your", 1026, 5, true);
                WriteAttributeValue(" ", 1030, "account", 1031, 8, true);
                EndWriteAttribute();
                WriteLiteral(">Remove</button>\n                                </div>\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 26 "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\Web\Views\Manage\ExternalLogins.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            WriteLiteral(" &nbsp;\n");
#nullable restore
#line 30 "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\Web\Views\Manage\ExternalLogins.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\n                </tr>\n");
#nullable restore
#line 33 "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\Web\Views\Manage\ExternalLogins.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n    </table>\n");
#nullable restore
#line 36 "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\Web\Views\Manage\ExternalLogins.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\Web\Views\Manage\ExternalLogins.cshtml"
 if (Model.OtherLogins?.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4>Add another service to log in.</h4>\n    <hr />\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2366e767c369b4525bcfdc1a02ac4d1a91c41d5a19020", async() => {
                WriteLiteral("\n        <div id=\"socialLoginList\">\n            <p>\n");
#nullable restore
#line 44 "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\Web\Views\Manage\ExternalLogins.cshtml"
                 foreach (var provider in Model.OtherLogins)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <button type=\"submit\" class=\"btn btn-default\" name=\"provider\"");
                BeginWriteAttribute("value", " value=\"", 1745, "\"", 1767, 1);
#nullable restore
#line 46 "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\Web\Views\Manage\ExternalLogins.cshtml"
WriteAttributeValue("", 1753, provider.Name, 1753, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("title", " title=\"", 1768, "\"", 1823, 6);
                WriteAttributeValue("", 1776, "Log", 1776, 3, true);
                WriteAttributeValue(" ", 1779, "in", 1780, 3, true);
                WriteAttributeValue(" ", 1782, "using", 1783, 6, true);
                WriteAttributeValue(" ", 1788, "your", 1789, 5, true);
#nullable restore
#line 46 "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\Web\Views\Manage\ExternalLogins.cshtml"
WriteAttributeValue(" ", 1793, provider.DisplayName, 1794, 21, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 1815, "account", 1816, 8, true);
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 46 "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\Web\Views\Manage\ExternalLogins.cshtml"
                                                                                                                                                            Write(provider.DisplayName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\n");
#nullable restore
#line 47 "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\Web\Views\Manage\ExternalLogins.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </p>\n        </div>\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 51 "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\Web\Views\Manage\ExternalLogins.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ExternalLoginsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
