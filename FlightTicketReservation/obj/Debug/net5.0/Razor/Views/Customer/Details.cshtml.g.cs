#pragma checksum "C:\Users\KAR1291\Downloads\FlightTicketReservation-main\FlightTicketReservation-main\Views\Customer\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b544cbfb36e3fa4bc9d1a6e0158e2a699a37028f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Details), @"mvc.1.0.view", @"/Views/Customer/Details.cshtml")]
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
#line 1 "C:\Users\KAR1291\Downloads\FlightTicketReservation-main\FlightTicketReservation-main\Views\_ViewImports.cshtml"
using FlightTicketReservation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\KAR1291\Downloads\FlightTicketReservation-main\FlightTicketReservation-main\Views\_ViewImports.cshtml"
using FlightTicketReservation.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b544cbfb36e3fa4bc9d1a6e0158e2a699a37028f", @"/Views/Customer/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"128f8dcb36ed5dabf9dcf2bf94493ecb14edf312", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Customer_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FlightTicketReservation.Models.FlightDetail>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "getallFlights", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\KAR1291\Downloads\FlightTicketReservation-main\FlightTicketReservation-main\Views\Customer\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Details</h1>\n\n<div>\n    <h4>FlightDetail</h4>\n    <hr />\n    <dl class=\"row\">\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 14 "C:\Users\KAR1291\Downloads\FlightTicketReservation-main\FlightTicketReservation-main\Views\Customer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Flightid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 17 "C:\Users\KAR1291\Downloads\FlightTicketReservation-main\FlightTicketReservation-main\Views\Customer\Details.cshtml"
       Write(Html.DisplayFor(model => model.Flightid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 20 "C:\Users\KAR1291\Downloads\FlightTicketReservation-main\FlightTicketReservation-main\Views\Customer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Flightname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 23 "C:\Users\KAR1291\Downloads\FlightTicketReservation-main\FlightTicketReservation-main\Views\Customer\Details.cshtml"
       Write(Html.DisplayFor(model => model.Flightname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 26 "C:\Users\KAR1291\Downloads\FlightTicketReservation-main\FlightTicketReservation-main\Views\Customer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Source));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 29 "C:\Users\KAR1291\Downloads\FlightTicketReservation-main\FlightTicketReservation-main\Views\Customer\Details.cshtml"
       Write(Html.DisplayFor(model => model.Source));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 32 "C:\Users\KAR1291\Downloads\FlightTicketReservation-main\FlightTicketReservation-main\Views\Customer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Destination));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 35 "C:\Users\KAR1291\Downloads\FlightTicketReservation-main\FlightTicketReservation-main\Views\Customer\Details.cshtml"
       Write(Html.DisplayFor(model => model.Destination));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 38 "C:\Users\KAR1291\Downloads\FlightTicketReservation-main\FlightTicketReservation-main\Views\Customer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Departuretime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 41 "C:\Users\KAR1291\Downloads\FlightTicketReservation-main\FlightTicketReservation-main\Views\Customer\Details.cshtml"
       Write(Html.DisplayFor(model => model.Departuretime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 44 "C:\Users\KAR1291\Downloads\FlightTicketReservation-main\FlightTicketReservation-main\Views\Customer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Arrivaltime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 47 "C:\Users\KAR1291\Downloads\FlightTicketReservation-main\FlightTicketReservation-main\Views\Customer\Details.cshtml"
       Write(Html.DisplayFor(model => model.Arrivaltime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 50 "C:\Users\KAR1291\Downloads\FlightTicketReservation-main\FlightTicketReservation-main\Views\Customer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Totalcapacity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 53 "C:\Users\KAR1291\Downloads\FlightTicketReservation-main\FlightTicketReservation-main\Views\Customer\Details.cshtml"
       Write(Html.DisplayFor(model => model.Totalcapacity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 56 "C:\Users\KAR1291\Downloads\FlightTicketReservation-main\FlightTicketReservation-main\Views\Customer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Costperseat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 59 "C:\Users\KAR1291\Downloads\FlightTicketReservation-main\FlightTicketReservation-main\Views\Customer\Details.cshtml"
       Write(Html.DisplayFor(model => model.Costperseat));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 62 "C:\Users\KAR1291\Downloads\FlightTicketReservation-main\FlightTicketReservation-main\Views\Customer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Imagepath));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 65 "C:\Users\KAR1291\Downloads\FlightTicketReservation-main\FlightTicketReservation-main\Views\Customer\Details.cshtml"
           Write(Html.DisplayFor(model=>model.Imagepath));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b544cbfb36e3fa4bc9d1a6e0158e2a699a37028f10337", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FlightTicketReservation.Models.FlightDetail> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
