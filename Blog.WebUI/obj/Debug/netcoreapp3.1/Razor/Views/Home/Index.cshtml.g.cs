#pragma checksum "C:\Users\Ömer\Desktop\Ömer-MersusPC\WEB\Blog\Blog.WebUI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aafaf681c7300a00aa8bf496e2d38fc6282df5d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Blog.WebUI.Models.Home.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace Blog.WebUI.Models.Home
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
#line 2 "C:\Users\Ömer\Desktop\Ömer-MersusPC\WEB\Blog\Blog.WebUI\Views\_ViewImports.cshtml"
using Blog.WebUI.Enums;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aafaf681c7300a00aa8bf496e2d38fc6282df5d8", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0165ab883ebda4a031cfcee4cab8d38315da2452", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BlogListViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BlogDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Blog.WebUI.TagHelpers.ImageTagHelper __Blog_WebUI_TagHelpers_ImageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Ömer\Desktop\Ömer-MersusPC\WEB\Blog\Blog.WebUI\Views\Home\Index.cshtml"
 if (ViewBag.ActiveCategory != null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ömer\Desktop\Ömer-MersusPC\WEB\Blog\Blog.WebUI\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("GetCategoryName", new { @categoryId = (int)ViewBag.ActiveCategory }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ömer\Desktop\Ömer-MersusPC\WEB\Blog\Blog.WebUI\Views\Home\Index.cshtml"
                                                                                                      
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\Ömer\Desktop\Ömer-MersusPC\WEB\Blog\Blog.WebUI\Views\Home\Index.cshtml"
 if (!string.IsNullOrWhiteSpace(ViewBag.SearchString))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Ömer\Desktop\Ömer-MersusPC\WEB\Blog\Blog.WebUI\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("Search",new { @s=ViewBag.SearchString }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Ömer\Desktop\Ömer-MersusPC\WEB\Blog\Blog.WebUI\Views\Home\Index.cshtml"
                                                                          
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 14 "C:\Users\Ömer\Desktop\Ömer-MersusPC\WEB\Blog\Blog.WebUI\Views\Home\Index.cshtml"
 foreach (var blog in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card mb-4\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("getblogimage", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aafaf681c7300a00aa8bf496e2d38fc6282df5d85473", async() => {
            }
            );
            __Blog_WebUI_TagHelpers_ImageTagHelper = CreateTagHelper<global::Blog.WebUI.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Blog_WebUI_TagHelpers_ImageTagHelper);
#nullable restore
#line 17 "C:\Users\Ömer\Desktop\Ömer-MersusPC\WEB\Blog\Blog.WebUI\Views\Home\Index.cshtml"
__Blog_WebUI_TagHelpers_ImageTagHelper.Id = blog.Id;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("id", __Blog_WebUI_TagHelpers_ImageTagHelper.Id, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n        <div class=\"card-body\">\r\n            <h2 class=\"card-title\">");
#nullable restore
#line 20 "C:\Users\Ömer\Desktop\Ömer-MersusPC\WEB\Blog\Blog.WebUI\Views\Home\Index.cshtml"
                              Write(blog.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n            <p class=\"card-text\">");
#nullable restore
#line 21 "C:\Users\Ömer\Desktop\Ömer-MersusPC\WEB\Blog\Blog.WebUI\Views\Home\Index.cshtml"
                            Write(blog.ShortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aafaf681c7300a00aa8bf496e2d38fc6282df5d87398", async() => {
                WriteLiteral("Read More &rarr;");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 22 "C:\Users\Ömer\Desktop\Ömer-MersusPC\WEB\Blog\Blog.WebUI\Views\Home\Index.cshtml"
                                         WriteLiteral(blog.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <div class=\"card-footer text-muted\">\r\n            Posted on ");
#nullable restore
#line 25 "C:\Users\Ömer\Desktop\Ömer-MersusPC\WEB\Blog\Blog.WebUI\Views\Home\Index.cshtml"
                 Write(blog.PostedTime.ToLongDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 28 "C:\Users\Ömer\Desktop\Ömer-MersusPC\WEB\Blog\Blog.WebUI\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BlogListViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
