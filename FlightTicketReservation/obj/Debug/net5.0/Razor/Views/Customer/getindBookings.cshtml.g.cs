#pragma checksum "C:\Users\KAR1291\Downloads\FlightTicketReservation-main\FlightTicketReservation-main\Views\Customer\getindBookings.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f87802213f47b4b7ad380fe2840f3b0b666d406"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_getindBookings), @"mvc.1.0.view", @"/Views/Customer/getindBookings.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f87802213f47b4b7ad380fe2840f3b0b666d406", @"/Views/Customer/getindBookings.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"128f8dcb36ed5dabf9dcf2bf94493ecb14edf312", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Customer_getindBookings : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FlightTicketReservation.Models.BookingDetail>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\KAR1291\Downloads\FlightTicketReservation-main\FlightTicketReservation-main\Views\Customer\getindBookings.cshtml"
  
    ViewData["Title"] = "getindBookings";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>getindBookings</h1>\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 12 "C:\Users\KAR1291\Downloads\FlightTicketReservation-main\FlightTicketReservation-main\Views\Customer\getindBookings.cshtml"
           Write(Html.DisplayNameFor(model => model.Bookingid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 15 "C:\Users\KAR1291\Downloads\FlightTicketReservation-main\FlightTicketReservation-main\Views\Customer\getindBookings.cshtml"
           Write(Html.DisplayNameFor(model => model.Flightid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 18 "C:\Users\KAR1291\Downloads\FlightTicketReservation-main\FlightTicketReservation-main\Views\Customer\getindBookings.cshtml"
           Write(Html.DisplayNameFor(model => model.Routeid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 21 "C:\Users\KAR1291\Downloads\FlightTicketReservation-main\FlightTicketReservation-main\Views\Customer\getindBookings.cshtml"
           Write(Html.DisplayNameFor(model => model.Doj));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 24 "C:\Users\KAR1291\Downloads\FlightTicketReservation-main\FlightTicketReservation-main\Views\Customer\getindBookings.cshtml"
           Write(Html.DisplayNameFor(model => model.Numberofpassengers));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 27 "C:\Users\KAR1291\Downloads\FlightTicketReservation-main\FlightTicketReservation-main\Views\Customer\getindBookings.cshtml"
           Write(Html.DisplayNameFor(model => model.Totalvalue));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 30 "C:\Users\KAR1291\Downloads\FlightTicketReservation-main\FlightTicketReservation-main\Views\Customer\getindBookings.cshtml"
           Write(Html.DisplayNameFor(model => model.Customerid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 36 "C:\Users\KAR1291\Downloads\FlightTicketReservation-main\FlightTicketReservation-main\Views\Customer\getindBookings.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>\n                ");
#nullable restore
#line 39 "C:\Users\KAR1291\Downloads\FlightTicketReservation-main\FlightTicketReservation-main\Views\Customer\getindBookings.cshtml"
           Write(Html.DisplayFor(modelItem => item.Bookingid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 42 "C:\Users\KAR1291\Downloads\FlightTicketReservation-main\FlightTicketReservation-main\Views\Customer\getindBookings.cshtml"
           Write(Html.DisplayFor(modelItem => item.Flightid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 45 "C:\Users\KAR1291\Downloads\FlightTicketReservation-main\FlightTicketReservation-main\Views\Customer\getindBookings.cshtml"
           Write(Html.DisplayFor(modelItem => item.Routeid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 48 "C:\Users\KAR1291\Downloads\FlightTicketReservation-main\FlightTicketReservation-main\Views\Customer\getindBookings.cshtml"
           Write(Html.DisplayFor(modelItem => item.Doj));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 51 "C:\Users\KAR1291\Downloads\FlightTicketReservation-main\FlightTicketReservation-main\Views\Customer\getindBookings.cshtml"
           Write(Html.DisplayFor(modelItem => item.Numberofpassengers));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 54 "C:\Users\KAR1291\Downloads\FlightTicketReservation-main\FlightTicketReservation-main\Views\Customer\getindBookings.cshtml"
           Write(Html.DisplayFor(modelItem => item.Totalvalue));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 57 "C:\Users\KAR1291\Downloads\FlightTicketReservation-main\FlightTicketReservation-main\Views\Customer\getindBookings.cshtml"
           Write(Html.DisplayFor(modelItem => item.Customerid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n\n        </tr>\n");
#nullable restore
#line 61 "C:\Users\KAR1291\Downloads\FlightTicketReservation-main\FlightTicketReservation-main\Views\Customer\getindBookings.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FlightTicketReservation.Models.BookingDetail>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591