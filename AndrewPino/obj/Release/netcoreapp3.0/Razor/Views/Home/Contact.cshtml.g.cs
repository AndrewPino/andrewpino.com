#pragma checksum "/home/andrew/RiderProjects/AndrewPino/AndrewPino/Views/Home/Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d18abf8d0e4ddf55c89877b820e2e1052c1a021"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
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
#line 1 "/home/andrew/RiderProjects/AndrewPino/AndrewPino/Views/_ViewImports.cshtml"
using AndrewPino;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/andrew/RiderProjects/AndrewPino/AndrewPino/Views/_ViewImports.cshtml"
using AndrewPino.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d18abf8d0e4ddf55c89877b820e2e1052c1a021", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2dd52c46f024792d0c76972e2635733f9433ecca", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"container align-content-center\">\n  <div class=\"row\">\n    <div class=\"col-lg-6 col-md-6 col-sm-6\">\n      <div class=\"form-wrapper\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d18abf8d0e4ddf55c89877b820e2e1052c1a0213307", async() => {
                WriteLiteral(@"
          <!-- inputs -->
          <div class=""form-group"">
            <label class=""sr-only"" for=""name"">Name</label>
            <div class=""input-group"">
              <div class=""input-group-addon"">
                <span class=""glyphicon glyphicon-user"" aria-hidden=""true""></span>
              </div>
              <input type=""text"" class=""form-control"" id=""name"" placeholder=""Name"">
            </div>
          </div>
          <div class=""form-group"">
            <label class=""sr-only"" for=""email"">Email</label>
            <div class=""input-group"">
              <div class=""input-group-addon"">
                <span class=""glyphicon glyphicon-envelope"" aria-hidden=""true""></span>
              </div>
              <input type=""text"" class=""form-control"" id=""email"" placeholder=""Email"">
            </div>
          </div>
          <div class=""form-group"">
            <label class=""sr-only"" for=""subject"">Subject</label>
            <div class=""input-group"">
              <div class=""input-group-addon"">
   ");
                WriteLiteral(@"             <span class=""glyphicon glyphicon-info-sign"" aria-hidden=""true""></span>
              </div>
              <input type=""text"" class=""form-control"" id=""subject"" placeholder=""Subject"">
            </div>
          </div>
          <div class=""form-group"">
            <label class=""sr-only"" for=""message"">Message</label>
            <textarea class=""form-control"" id=""message"" rows=""6"" placeholder=""Message""></textarea>
          </div>

          <!-- buttons -->
          <div class=""btn-group pull-right"" role=""group"">
            <button type=""reset"" class=""btn btn-outline-primary btn btn-default btn-sm small-button-width"">
              <span class=""glyphicon glyphicon-remove"" aria-hidden=""true""></span> Reset
            </button>
            <button type=""submit"" class=""btn btn-outline-primary btn btn-default btn-sm small-button-width"">
              <span class=""glyphicon glyphicon-envelope"" aria-hidden=""true""></span> Submit
            </button>
          </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n      </div>\n    </div>\n  </div>\n</div>");
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
