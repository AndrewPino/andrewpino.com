#pragma checksum "/home/andrew/RiderProjects/AndrewPino/AndrewPino/Views/Home/Submission.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2459a9ebab2541d4ba53b6ac57df59cea0935e55"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Submission), @"mvc.1.0.view", @"/Views/Home/Submission.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2459a9ebab2541d4ba53b6ac57df59cea0935e55", @"/Views/Home/Submission.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa63b07b4769b6285b520dad0f7454792313d137", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Submission : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<link href=""//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css"" rel=""stylesheet"" id=""bootstrap-css"">
<script src=""//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js""></script>
<script src=""//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js""></script>
<!------ Include the above in your HEAD tag ---------->

<!--Model Popup starts-->
<div class=""container"">
    <div class=""row"">
");
            WriteLiteral(@"        <div class=""modal fade"" id=""ignismyModal"" role=""dialog"">
            <div class=""modal-dialog"">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <button type=""button"" class=""close"" data-dismiss=""modal""");
            BeginWriteAttribute("aria-label", " aria-label=\"", 785, "\"", 798, 0);
            EndWriteAttribute();
            WriteLiteral("><span>×</span></button>\n                    </div>\n\t\t\t\t\t<div class=\"modal-body\">\n                       <div class=\"thank-you-pop\">\n                            <img src=\"http://goactionstations.co.uk/wp-content/uploads/2017/03/Green-Round-Tick.png\"");
            BeginWriteAttribute("alt", " alt=\"", 1048, "\"", 1054, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <h1>Thank You!</h1>
                            <p>Your submission has been received and I will contact you soon</p>
                        </div>
                    </div>
				</div>
            </div>
        </div>
    </div>
</div>
<!--Model Popup ends-->");
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
