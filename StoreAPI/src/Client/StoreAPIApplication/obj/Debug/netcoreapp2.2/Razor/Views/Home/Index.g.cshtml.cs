#pragma checksum "C:\Users\Javier\source\repos\StoreAPI\StoreAPI\StoreAPI\src\Client\StoreAPIApplication\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5c2152364066adf24ca6ee99d22d508eb535a60"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\Javier\source\repos\StoreAPI\StoreAPI\StoreAPI\src\Client\StoreAPIApplication\Views\_ViewImports.cshtml"
using StoreAPIApplication;

#line default
#line hidden
#line 2 "C:\Users\Javier\source\repos\StoreAPI\StoreAPI\StoreAPI\src\Client\StoreAPIApplication\Views\_ViewImports.cshtml"
using CommonStoreAPI;

#line default
#line hidden
#line 3 "C:\Users\Javier\source\repos\StoreAPI\StoreAPI\StoreAPI\src\Client\StoreAPIApplication\Views\_ViewImports.cshtml"
using StoreAPIApplication.Config;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5c2152364066adf24ca6ee99d22d508eb535a60", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7390a99fa8ee0a5dbe31198f4527fc07951934bb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Javier\source\repos\StoreAPI\StoreAPI\StoreAPI\src\Client\StoreAPIApplication\Views\Home\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(71, 37, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"es\">\r\n");
            EndContext();
            BeginContext(108, 802, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d5c2152364066adf24ca6ee99d22d508eb535a603932", async() => {
                BeginContext(114, 789, true);
                WriteLiteral(@"
  <title>Boutique Party Store - El Salvador</title>

  <meta charset=""utf-8"">
  <meta name=""viewport"" content=""width=device-width,initial-scale=1.0"">
  <meta name=""description"" content=""StoreAPI for APPLAUDO"" />

  <link href='https://fonts.googleapis.com/css?family=Roboto:300,400,500,700|Material+Icons' rel=""stylesheet"">
  <link href='    https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css' rel=""stylesheet"">

  <link href=""bundle/css/app.82daff93ee130c79e02487663d614641.css"" rel=""stylesheet"">
  <link href=""bundle/css/app.fa01397231cf9efc27be9adf2fa86414.css"" rel=""stylesheet"">
  <link href=""bundle/css/app.183ca5fc797caef22a60d60b77d8bd23.css"" rel=""stylesheet"">
<link href=""bundle/css/app.ee462714c12a84951e236986026ff128.css"" rel=""stylesheet"">");
                EndContext();
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
            EndContext();
            BeginContext(910, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(912, 1009, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d5c2152364066adf24ca6ee99d22d508eb535a605932", async() => {
                BeginContext(918, 56, true);
                WriteLiteral("\r\n  <div id=\"app\"></div>\r\n  <script>\r\n    window.user = ");
                EndContext();
                BeginContext(975, 71, false);
#line 26 "C:\Users\Javier\source\repos\StoreAPI\StoreAPI\StoreAPI\src\Client\StoreAPIApplication\Views\Home\Index.cshtml"
             Write(Html.Raw(Newtonsoft.Json.JsonConvert.SerializeObject(_currentUser.Get)));

#line default
#line hidden
                EndContext();
                BeginContext(1046, 28, true);
                WriteLiteral(";\r\n    window.Api = { URL: \'");
                EndContext();
                BeginContext(1075, 17, false);
#line 27 "C:\Users\Javier\source\repos\StoreAPI\StoreAPI\StoreAPI\src\Client\StoreAPIApplication\Views\Home\Index.cshtml"
                    Write(Parameters.ApiURL);

#line default
#line hidden
                EndContext();
                BeginContext(1092, 822, true);
                WriteLiteral(@"' }
  </script>
  <script type=""text/javascript"" src=""bundle/js/manifest.fba1583d154550ce3f65.js""></script>
  <script type=""text/javascript"" src=""bundle/js/vendor.a1bbf8e258362610753c.js""></script>
  <script type=""text/javascript"" src=""bundle/js/app.cb4ad9c43db476ab7c45.js""></script>
  <script type=""text/javascript"" src=""bundle/js/manifest.fba1583d154550ce3f65.js""></script>
  <script type=""text/javascript"" src=""bundle/js/vendor.a1bbf8e258362610753c.js""></script>
  <script type=""text/javascript"" src=""bundle/js/app.15fb50daee6dfde309e9.js""></script>
<script type=""text/javascript"" src=""bundle/js/manifest.fba1583d154550ce3f65.js""></script><script type=""text/javascript"" src=""bundle/js/vendor.58c3215a3fbe819cbb54.js""></script><script type=""text/javascript"" src=""bundle/js/app.550a24b0384dbbf1599a.js""></script>");
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
            BeginContext(1921, 11, true);
            WriteLiteral("\r\n</html>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ICurrentUserFactory _currentUser { get; private set; }
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
