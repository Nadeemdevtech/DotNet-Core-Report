#pragma checksum "D:\Setup\Setup software\asp.net workspace\DotNet Core Report\DotNet Core Report\ExitGateReportPanel\Views\InvalidRFIDs\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2b96938ec1221fabbc34586c5697d10823227b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_InvalidRFIDs_Create), @"mvc.1.0.view", @"/Views/InvalidRFIDs/Create.cshtml")]
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
#line 1 "D:\Setup\Setup software\asp.net workspace\DotNet Core Report\DotNet Core Report\ExitGateReportPanel\Views\_ViewImports.cshtml"
using ExitGateReportPanel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Setup\Setup software\asp.net workspace\DotNet Core Report\DotNet Core Report\ExitGateReportPanel\Views\_ViewImports.cshtml"
using ExitGateReportPanel.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2b96938ec1221fabbc34586c5697d10823227b3", @"/Views/InvalidRFIDs/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2bf9f63f8bd1aca83f6c42c7d12b044f67727a38", @"/Views/_ViewImports.cshtml")]
    public class Views_InvalidRFIDs_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<InvalidRFID>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Setup\Setup software\asp.net workspace\DotNet Core Report\DotNet Core Report\ExitGateReportPanel\Views\InvalidRFIDs\Create.cshtml"
  
    ViewBag.Title = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2 style=\"color:white;\">Create</h2>\r\n\r\n");
#nullable restore
#line 9 "D:\Setup\Setup software\asp.net workspace\DotNet Core Report\DotNet Core Report\ExitGateReportPanel\Views\InvalidRFIDs\Create.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Setup\Setup software\asp.net workspace\DotNet Core Report\DotNet Core Report\ExitGateReportPanel\Views\InvalidRFIDs\Create.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"form-horizontal\" style=\"color:white;\">\r\n    <h4>InvalidRFID</h4>\r\n    <hr />\r\n    ");
#nullable restore
#line 16 "D:\Setup\Setup software\asp.net workspace\DotNet Core Report\DotNet Core Report\ExitGateReportPanel\Views\InvalidRFIDs\Create.cshtml"
Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 18 "D:\Setup\Setup software\asp.net workspace\DotNet Core Report\DotNet Core Report\ExitGateReportPanel\Views\InvalidRFIDs\Create.cshtml"
   Write(Html.LabelFor(model => model.RFID, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-6\">\r\n            ");
#nullable restore
#line 20 "D:\Setup\Setup software\asp.net workspace\DotNet Core Report\DotNet Core Report\ExitGateReportPanel\Views\InvalidRFIDs\Create.cshtml"
       Write(Html.EditorFor(model => model.RFID, new { htmlAttributes = new { @class = "form-control", rows = "2", id = "textbox", type = "text", maxlength = "150"} }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 21 "D:\Setup\Setup software\asp.net workspace\DotNet Core Report\DotNet Core Report\ExitGateReportPanel\Views\InvalidRFIDs\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.RFID, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <hr />\r\n    ");
#nullable restore
#line 26 "D:\Setup\Setup software\asp.net workspace\DotNet Core Report\DotNet Core Report\ExitGateReportPanel\Views\InvalidRFIDs\Create.cshtml"
Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 28 "D:\Setup\Setup software\asp.net workspace\DotNet Core Report\DotNet Core Report\ExitGateReportPanel\Views\InvalidRFIDs\Create.cshtml"
   Write(Html.LabelFor(model => model.Reason, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-6\">\r\n            ");
#nullable restore
#line 30 "D:\Setup\Setup software\asp.net workspace\DotNet Core Report\DotNet Core Report\ExitGateReportPanel\Views\InvalidRFIDs\Create.cshtml"
       Write(Html.EditorFor(model => model.Reason, new { htmlAttributes = new { @class = "form-control", rows = "2" , id = "textbox" ,type = "text" ,maxlength = "200" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 31 "D:\Setup\Setup software\asp.net workspace\DotNet Core Report\DotNet Core Report\ExitGateReportPanel\Views\InvalidRFIDs\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.Reason, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 35 "D:\Setup\Setup software\asp.net workspace\DotNet Core Report\DotNet Core Report\ExitGateReportPanel\Views\InvalidRFIDs\Create.cshtml"
   Write(Html.LabelFor(model => model.IsEnable, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            <div class=\"checkbox\">\r\n                ");
#nullable restore
#line 38 "D:\Setup\Setup software\asp.net workspace\DotNet Core Report\DotNet Core Report\ExitGateReportPanel\Views\InvalidRFIDs\Create.cshtml"
           Write(Html.EditorFor(model => model.IsEnable));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 39 "D:\Setup\Setup software\asp.net workspace\DotNet Core Report\DotNet Core Report\ExitGateReportPanel\Views\InvalidRFIDs\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.IsEnable, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
        </div>
    </div>

    <div class=""form-group"">
        <div class=""col-md-offset-2 col-md-10"">
            <input type=""submit"" value=""Create"" class=""btn btn-danger"" onclick=""checkLength()""/>
        </div>
    </div>
</div>
");
#nullable restore
#line 50 "D:\Setup\Setup software\asp.net workspace\DotNet Core Report\DotNet Core Report\ExitGateReportPanel\Views\InvalidRFIDs\Create.cshtml"


}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    ");
#nullable restore
#line 55 "D:\Setup\Setup software\asp.net workspace\DotNet Core Report\DotNet Core Report\ExitGateReportPanel\Views\InvalidRFIDs\Create.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<InvalidRFID> Html { get; private set; }
    }
}
#pragma warning restore 1591
