#pragma checksum "C:\Users\user\source\repos\TestRazor\TestRazor\Pages\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ac42bc5325762d7bc00f8020632a5a2c56e70bc"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ac42bc5325762d7bc00f8020632a5a2c56e70bc", @"/Pages/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5f01d6888c35a5d7685e9e7cc1b8948523d5ba5", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Show : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ac42bc5325762d7bc00f8020632a5a2c56e70bc3566", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ac42bc5325762d7bc00f8020632a5a2c56e70bc4818", async() => {
                WriteLiteral("\r\n\r\n<div>\r\n");
#nullable restore
#line 17 "C:\Users\user\source\repos\TestRazor\TestRazor\Pages\Show.cshtml"
     if( TempData["Name"]!=null)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("         <p>");
#nullable restore
#line 19 "C:\Users\user\source\repos\TestRazor\TestRazor\Pages\Show.cshtml"
       Write(TempData["Name"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
#nullable restore
#line 20 "C:\Users\user\source\repos\TestRazor\TestRazor\Pages\Show.cshtml"

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\user\source\repos\TestRazor\TestRazor\Pages\Show.cshtml"
     if(User.Identity.IsAuthenticated)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <a href=\"/Logout\"> Log out</a>\r\n");
#nullable restore
#line 25 "C:\Users\user\source\repos\TestRazor\TestRazor\Pages\Show.cshtml"
        
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("  \r\n</div>\r\n<div>\r\n");
#nullable restore
#line 30 "C:\Users\user\source\repos\TestRazor\TestRazor\Pages\Show.cshtml"
 if(Model.h!=null)
{

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\user\source\repos\TestRazor\TestRazor\Pages\Show.cshtml"
 foreach(var i in Model.h)
{
  

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n      ");
#nullable restore
#line 35 "C:\Users\user\source\repos\TestRazor\TestRazor\Pages\Show.cshtml"
 Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral(" &emsp;\r\n  ");
#nullable restore
#line 36 "C:\Users\user\source\repos\TestRazor\TestRazor\Pages\Show.cshtml"
         
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\user\source\repos\TestRazor\TestRazor\Pages\Show.cshtml"
 
}

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n</div>\r\n<div class =\"table\">\r\n<div align=\"center\">\r\n");
#nullable restore
#line 44 "C:\Users\user\source\repos\TestRazor\TestRazor\Pages\Show.cshtml"
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
      <th scope=""col"">Redemption price</th>
    </tr>
  </thead>
        
");
#nullable restore
#line 58 "C:\Users\user\source\repos\TestRazor\TestRazor\Pages\Show.cshtml"
         foreach(var i in Model.Items)
        {
          

#line default
#line hidden
#nullable disable
                WriteLiteral("               <tr>\r\n                   \r\n                   <td> ");
#nullable restore
#line 63 "C:\Users\user\source\repos\TestRazor\TestRazor\Pages\Show.cshtml"
                   Write(i.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                   <td>");
#nullable restore
#line 64 "C:\Users\user\source\repos\TestRazor\TestRazor\Pages\Show.cshtml"
                  Write(i.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                   <td>");
#nullable restore
#line 65 "C:\Users\user\source\repos\TestRazor\TestRazor\Pages\Show.cshtml"
                  Write(i.Describe);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                       <td>");
#nullable restore
#line 66 "C:\Users\user\source\repos\TestRazor\TestRazor\Pages\Show.cshtml"
                      Write(i.BeginPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                       <td>");
#nullable restore
#line 67 "C:\Users\user\source\repos\TestRazor\TestRazor\Pages\Show.cshtml"
                      Write(i.RedemtionPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                       <td>\r\n                           <a");
                BeginWriteAttribute("href", " href=\"", 1431, "\"", 1447, 2);
                WriteAttributeValue("", 1438, "Bet/", 1438, 4, true);
#nullable restore
#line 69 "C:\Users\user\source\repos\TestRazor\TestRazor\Pages\Show.cshtml"
WriteAttributeValue("", 1442, i.Id, 1442, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                           ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ac42bc5325762d7bc00f8020632a5a2c56e70bc9825", async() => {
                    WriteLiteral("\r\n                               <input type=\"hidden\"");
                    BeginWriteAttribute("value", " value=\"", 1551, "\"", 1564, 1);
#nullable restore
#line 71 "C:\Users\user\source\repos\TestRazor\TestRazor\Pages\Show.cshtml"
WriteAttributeValue("", 1559, i.Id, 1559, 5, false);

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
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                           Do bet</a>\r\n                       </td>\r\n                       <td>\r\n                           <a");
                BeginWriteAttribute("href", " href=\"", 1733, "\"", 1749, 2);
                WriteAttributeValue("", 1740, "Pay/", 1740, 4, true);
#nullable restore
#line 76 "C:\Users\user\source\repos\TestRazor\TestRazor\Pages\Show.cshtml"
WriteAttributeValue("", 1744, i.Id, 1744, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Redemption</a>\r\n                       </td>\r\n                \r\n               </tr>\r\n");
#nullable restore
#line 80 "C:\Users\user\source\repos\TestRazor\TestRazor\Pages\Show.cshtml"

           
                
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("           </table>\r\n");
#nullable restore
#line 85 "C:\Users\user\source\repos\TestRazor\TestRazor\Pages\Show.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n\r\n</div>\r\n\r\n\r\n<div class =\"table\">\r\n<div align=\"center\">\r\n");
#nullable restore
#line 93 "C:\Users\user\source\repos\TestRazor\TestRazor\Pages\Show.cshtml"
     if(Model._Users!=null)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"         <table class=""table table-striped"">
              <thead>
    <tr>
    
      <th scope=""col"">Id</th>
      <th scope=""col"">First name</th>
      <th scope=""col"">Second name</th>
      <th scope=""col"">Email address</th>

    </tr>
  </thead>
        
");
#nullable restore
#line 107 "C:\Users\user\source\repos\TestRazor\TestRazor\Pages\Show.cshtml"
         foreach(var i in Model._Users)
        {
          

#line default
#line hidden
#nullable disable
                WriteLiteral("               <tr>\r\n                   \r\n                   <td> ");
#nullable restore
#line 112 "C:\Users\user\source\repos\TestRazor\TestRazor\Pages\Show.cshtml"
                   Write(i.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                   <td>");
#nullable restore
#line 113 "C:\Users\user\source\repos\TestRazor\TestRazor\Pages\Show.cshtml"
                  Write(i.FirstName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                   <td>");
#nullable restore
#line 114 "C:\Users\user\source\repos\TestRazor\TestRazor\Pages\Show.cshtml"
                  Write(i.SecondName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                   <td>");
#nullable restore
#line 115 "C:\Users\user\source\repos\TestRazor\TestRazor\Pages\Show.cshtml"
                  Write(i.EmailAddress);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                   \r\n\r\n                \r\n               </tr>\r\n");
#nullable restore
#line 120 "C:\Users\user\source\repos\TestRazor\TestRazor\Pages\Show.cshtml"

           
                
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("           </table>\r\n");
#nullable restore
#line 125 "C:\Users\user\source\repos\TestRazor\TestRazor\Pages\Show.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n\r\n</div>\r\n");
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
