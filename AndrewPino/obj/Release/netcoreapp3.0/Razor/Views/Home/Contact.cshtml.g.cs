#pragma checksum "/home/andrew/RiderProjects/AndrewPino/AndrewPino/Views/Home/Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "434b4c165092521d4dd0cf3624e949f3c251c306"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"434b4c165092521d4dd0cf3624e949f3c251c306", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa63b07b4769b6285b520dad0f7454792313d137", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Submission", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "/home/andrew/RiderProjects/AndrewPino/AndrewPino/Views/Home/Contact.cshtml"
  
    ViewData["Title"] = "Contact Andrew Pino: Andrew Pino";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container align-content-center\">\n  <div class=\"row\">\n    <div class=\"col-lg-6 col-md-6 col-sm-6\">\n      <div class=\"form-wrapper\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "434b4c165092521d4dd0cf3624e949f3c251c3064419", async() => {
                WriteLiteral("\n          ");
#nullable restore
#line 9 "/home/andrew/RiderProjects/AndrewPino/AndrewPino/Views/Home/Contact.cshtml"
     Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
          <!-- inputs -->
          <div class=""form-group"">
            <label class=""sr-only"" for=""Name"">Name</label>
            <div class=""input-group"">
              <div class=""input-group-addon"">
                <span class=""glyphicon glyphicon-user"" aria-hidden=""true""></span>
              </div>
              <input type=""text"" class=""form-control"" id=""Name"" name=""Name"" placeholder=""Name"">
            </div>
          </div>
          <div class=""form-group"">
            <label class=""sr-only"" for=""Email"">Email</label>
            <div class=""input-group"">
              <div class=""input-group-addon"">
                <span class=""glyphicon glyphicon-envelope"" aria-hidden=""true""></span>
              </div>
              <input type=""text"" class=""form-control"" id=""Email"" name=""Email"" placeholder=""Email"">
            </div>
          </div>
          <div class=""form-group"">
            <label class=""sr-only"" for=""Subject"">Subject</label>
            <div class=""input-group"">
              <div class");
                WriteLiteral(@"=""input-group-addon"">
                <span class=""glyphicon glyphicon-info-sign"" aria-hidden=""true""></span>
              </div>
              <input type=""text"" class=""form-control"" id=""Subject"" name=""Subject"" placeholder=""Subject"">
            </div>
          </div>
          <div class=""form-group"">
            <label class=""sr-only"" for=""Message"">Message</label>
            <textarea class=""form-control"" id=""Message"" name=""Message"" rows=""6"" placeholder=""Message"" itemid=""message""></textarea>
          </div>
          
");
                WriteLiteral(@"
          <!-- buttons -->
          <div class=""btn-group pull-right"" role=""group"">
            <button type=""reset"" class=""btn btn-outline-primary btn btn-default btn-sm small-button-width"">
              <span class=""glyphicon glyphicon-remove"" aria-hidden=""true""></span> Reset
            </button>
            <button type=""submit"" class=""btn btn-outline-primary btn btn-default btn-sm small-button-width"" data-toggle=""modal"" href=""#ignismyModal"">
              <span class=""glyphicon glyphicon-envelope"" aria-hidden=""true""></span> Submit
            </button>
              <div class=""modal fade"" id=""ignismyModal"" role=""dialog"">
                <div class=""modal-dialog"">
                  <div class=""modal-content"">
                    <div class=""modal-header"">
                      <button type=""button"" class=""close"" data-dismiss=""modal""");
                BeginWriteAttribute("aria-label", " aria-label=\"", 3306, "\"", 3319, 0);
                EndWriteAttribute();
                WriteLiteral(@"><span>×</span></button>
                    </div>
                  <div class=""modal-body"">
                    <div class=""thank-you-pop"">
                      <img src=""http://goactionstations.co.uk/wp-content/uploads/2017/03/Green-Round-Tick.png"" alt=""Thank You for Your Submission"">
                        <h1>Thank You!</h1>
                        <p>Your submission has been received and I will contact you soon</p>
                      </div>
                    </div>
                  </div>
                </div>
              </div>
          </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
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
