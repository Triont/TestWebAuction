#pragma checksum "C:\Users\user\source\repos\TestRazor\TestRazor\Pages\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95e70f03a066869be7a1974cfd716a78b2fbc869"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TestRazor.Pages.Pages_Show), @"mvc.1.0.razor-page", @"/Pages/Show.cshtml")]
namespace TestRazor.Pages
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
#line 1 "C:\Users\user\source\repos\TestRazor\TestRazor\Pages\_ViewImports.cshtml"
using TestRazor;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95e70f03a066869be7a1974cfd716a78b2fbc869", @"/Pages/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5f01d6888c35a5d7685e9e7cc1b8948523d5ba5", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Show : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95e70f03a066869be7a1974cfd716a78b2fbc8693989", async() => {
                WriteLiteral("\r\n <link href=\"//twitter-bootstrap/css/bootstrap.min.css\" rel=\"stylesheet\" />\r\n");
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
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95e70f03a066869be7a1974cfd716a78b2fbc8695241", async() => {
                WriteLiteral("\r\n ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95e70f03a066869be7a1974cfd716a78b2fbc8695500", async() => {
                    WriteLiteral("\r\n        <label> Enter name of item</label>\r\n        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "95e70f03a066869be7a1974cfd716a78b2fbc8695820", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 17 "C:\Users\user\source\repos\TestRazor\TestRazor\Pages\Show.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ToFound);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n        <input type=\"submit\" value=\"Found!\"/>\r\n\r\n    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n<div>\r\n");
#nullable restore
#line 22 "C:\Users\user\source\repos\TestRazor\TestRazor\Pages\Show.cshtml"
     if( TempData["Name"]!=null)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("         <p>");
#nullable restore
#line 24 "C:\Users\user\source\repos\TestRazor\TestRazor\Pages\Show.cshtml"
       Write(TempData["Name"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
#nullable restore
#line 25 "C:\Users\user\source\repos\TestRazor\TestRazor\Pages\Show.cshtml"

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\user\source\repos\TestRazor\TestRazor\Pages\Show.cshtml"
     if(User.Identity.IsAuthenticated)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <a href=\"/Logout\"> Log out</a>\r\n");
#nullable restore
#line 30 "C:\Users\user\source\repos\TestRazor\TestRazor\Pages\Show.cshtml"
        
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("  \r\n</div>\r\n<div>\r\n");
#nullable restore
#line 35 "C:\Users\user\source\repos\TestRazor\TestRazor\Pages\Show.cshtml"
 if(Model.h!=null)
{

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\user\source\repos\TestRazor\TestRazor\Pages\Show.cshtml"
 foreach(var i in Model.h)
{
  

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n      ");
#nullable restore
#line 40 "C:\Users\user\source\repos\TestRazor\TestRazor\Pages\Show.cshtml"
 Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral(" &emsp;\r\n  ");
#nullable restore
#line 41 "C:\Users\user\source\repos\TestRazor\TestRazor\Pages\Show.cshtml"
         
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\user\source\repos\TestRazor\TestRazor\Pages\Show.cshtml"
 
}

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n</div>\r\n<div class =\"table\">\r\n<div align=\"center\">\r\n");
#nullable restore
#line 49 "C:\Users\user\source\repos\TestRazor\TestRazor\Pages\Show.cshtml"
     if(Model.Items!=null)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"         <table class=""table table-striped"">
              <thead>
    <tr>
    
      <th scope=""col"">Id</th>
      <th scope=""col"">Name</th>
      <th scope=""col"">Desription</th>
       <th scope=""col"">Begin price</th>
         <th scope=""col"">Bet</th>
      <th scope=""col"">Redemption price</th>
        <th scope=""col"">Redempt</th>
      <th scope=""col"">Status</th>
    </tr>
  </thead>
        
");
#nullable restore
#line 66 "C:\Users\user\source\repos\TestRazor\TestRazor\Pages\Show.cshtml"
         foreach(var i in Model.Items)
        {
          

#line default
#line hidden
#nullable disable
                WriteLiteral("               <tr>\r\n                   \r\n                   <td> ");
#nullable restore
#line 71 "C:\Users\user\source\repos\TestRazor\TestRazor\Pages\Show.cshtml"
                   Write(i.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                   <td>");
#nullable restore
#line 72 "C:\Users\user\source\repos\TestRazor\TestRazor\Pages\Show.cshtml"
                  Write(i.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                   <td>");
#nullable restore
#line 73 "C:\Users\user\source\repos\TestRazor\TestRazor\Pages\Show.cshtml"
                  Write(i.Describe);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                       <td>");
#nullable restore
#line 74 "C:\Users\user\source\repos\TestRazor\TestRazor\Pages\Show.cshtml"
                      Write(i.BeginPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                   \r\n                   </td>\r\n");
                WriteLiteral("                       <td>\r\n");
#nullable restore
#line 79 "C:\Users\user\source\repos\TestRazor\TestRazor\Pages\Show.cshtml"
                            if(i.Status!="Expired")
                           {

#line default
#line hidden
#nullable disable
                WriteLiteral("                           <a");
                BeginWriteAttribute("href", " href=\"", 1843, "\"", 1859, 2);
                WriteAttributeValue("", 1850, "Bet/", 1850, 4, true);
#nullable restore
#line 81 "C:\Users\user\source\repos\TestRazor\TestRazor\Pages\Show.cshtml"
WriteAttributeValue("", 1854, i.Id, 1854, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                           ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95e70f03a066869be7a1974cfd716a78b2fbc86913808", async() => {
                    WriteLiteral("\r\n                               <input type=\"hidden\"");
                    BeginWriteAttribute("value", " value=\"", 1963, "\"", 1976, 1);
#nullable restore
#line 83 "C:\Users\user\source\repos\TestRazor\TestRazor\Pages\Show.cshtml"
WriteAttributeValue("", 1971, i.Id, 1971, 5, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n                           ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                           Do bet</a>\r\n");
#nullable restore
#line 86 "C:\Users\user\source\repos\TestRazor\TestRazor\Pages\Show.cshtml"
                           }

#line default
#line hidden
#nullable disable
                WriteLiteral("                           \r\n                       </td>\r\n                       <td>\r\n                          ");
#nullable restore
#line 90 "C:\Users\user\source\repos\TestRazor\TestRazor\Pages\Show.cshtml"
                     Write(i.RedemtionPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                          </td>\r\n                          <td>\r\n");
#nullable restore
#line 93 "C:\Users\user\source\repos\TestRazor\TestRazor\Pages\Show.cshtml"
                               if(i.Status!="Expired")
                              {

#line default
#line hidden
#nullable disable
                WriteLiteral("                           <a");
                BeginWriteAttribute("href", " href=\"", 2403, "\"", 2419, 2);
                WriteAttributeValue("", 2410, "Pay/", 2410, 4, true);
#nullable restore
#line 95 "C:\Users\user\source\repos\TestRazor\TestRazor\Pages\Show.cshtml"
WriteAttributeValue("", 2414, i.Id, 2414, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Redemption</a>\r\n");
#nullable restore
#line 96 "C:\Users\user\source\repos\TestRazor\TestRazor\Pages\Show.cshtml"
                           }

#line default
#line hidden
#nullable disable
                WriteLiteral("                       </td>\r\n                       <td>\r\n                           ");
#nullable restore
#line 99 "C:\Users\user\source\repos\TestRazor\TestRazor\Pages\Show.cshtml"
                      Write(i.Status);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                       </td>\r\n                \r\n               </tr>\r\n");
#nullable restore
#line 103 "C:\Users\user\source\repos\TestRazor\TestRazor\Pages\Show.cshtml"

           
                
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("           </table>\r\n");
#nullable restore
#line 108 "C:\Users\user\source\repos\TestRazor\TestRazor\Pages\Show.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n\r\n</div>\r\n\r\n\r\n<div class =\"table\">\r\n");
                WriteLiteral("\r\n</div>\r\n");
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
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TestRazor.Pages.ShowModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TestRazor.Pages.ShowModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TestRazor.Pages.ShowModel>)PageContext?.ViewData;
        public TestRazor.Pages.ShowModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
