#pragma checksum "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\Bookings\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91895e5f4e853cbbe9f585c29a3105cbdcf3698f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bookings_Delete), @"mvc.1.0.view", @"/Views/Bookings/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Bookings/Delete.cshtml", typeof(AspNetCore.Views_Bookings_Delete))]
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
#line 1 "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\_ViewImports.cshtml"
using HotelManagementSystem_CoreMvc;

#line default
#line hidden
#line 2 "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\_ViewImports.cshtml"
using HotelManagementSystem_CoreMvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91895e5f4e853cbbe9f585c29a3105cbdcf3698f", @"/Views/Bookings/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27a05c3478fa7695a36c8c1154752c1e005bb52f", @"/Views/_ViewImports.cshtml")]
    public class Views_Bookings_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HotelManagementSystem_CoreMvc.Models.Booking>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\Bookings\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(97, 168, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Booking</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(266, 45, false);
#line 15 "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\Bookings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(311, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(355, 41, false);
#line 18 "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\Bookings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(396, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(440, 44, false);
#line 21 "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\Bookings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(484, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(528, 40, false);
#line 24 "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\Bookings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(568, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(612, 43, false);
#line 27 "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\Bookings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(655, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(699, 39, false);
#line 30 "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\Bookings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(738, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(782, 41, false);
#line 33 "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\Bookings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(823, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(867, 37, false);
#line 36 "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\Bookings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(904, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(948, 41, false);
#line 39 "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\Bookings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(989, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1033, 37, false);
#line 42 "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\Bookings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(1070, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1114, 42, false);
#line 45 "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\Bookings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NID_No));

#line default
#line hidden
            EndContext();
            BeginContext(1156, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1200, 38, false);
#line 48 "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\Bookings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NID_No));

#line default
#line hidden
            EndContext();
            BeginContext(1238, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1282, 47, false);
#line 51 "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\Bookings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ArrivalTime));

#line default
#line hidden
            EndContext();
            BeginContext(1329, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1373, 43, false);
#line 54 "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\Bookings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ArrivalTime));

#line default
#line hidden
            EndContext();
            BeginContext(1416, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1460, 49, false);
#line 57 "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\Bookings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DepartureDate));

#line default
#line hidden
            EndContext();
            BeginContext(1509, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1553, 45, false);
#line 60 "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\Bookings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DepartureDate));

#line default
#line hidden
            EndContext();
            BeginContext(1598, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1642, 41, false);
#line 63 "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\Bookings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Notes));

#line default
#line hidden
            EndContext();
            BeginContext(1683, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1727, 37, false);
#line 66 "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\Bookings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Notes));

#line default
#line hidden
            EndContext();
            BeginContext(1764, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1808, 41, false);
#line 69 "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\Bookings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Adult));

#line default
#line hidden
            EndContext();
            BeginContext(1849, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1893, 45, false);
#line 72 "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\Bookings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Adult.AdultId));

#line default
#line hidden
            EndContext();
            BeginContext(1938, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1982, 47, false);
#line 75 "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\Bookings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.BeddingType));

#line default
#line hidden
            EndContext();
            BeginContext(2029, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2073, 59, false);
#line 78 "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\Bookings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.BeddingType.BeddingTypeName));

#line default
#line hidden
            EndContext();
            BeginContext(2132, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2176, 41, false);
#line 81 "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\Bookings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Child));

#line default
#line hidden
            EndContext();
            BeginContext(2217, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2261, 45, false);
#line 84 "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\Bookings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Child.ChildId));

#line default
#line hidden
            EndContext();
            BeginContext(2306, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2350, 48, false);
#line 87 "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\Bookings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.RoomQuantity));

#line default
#line hidden
            EndContext();
            BeginContext(2398, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2442, 59, false);
#line 90 "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\Bookings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.RoomQuantity.RoomQuantityId));

#line default
#line hidden
            EndContext();
            BeginContext(2501, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2545, 44, false);
#line 93 "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\Bookings\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.RoomType));

#line default
#line hidden
            EndContext();
            BeginContext(2589, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2633, 53, false);
#line 96 "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\Bookings\Delete.cshtml"
       Write(Html.DisplayFor(model => model.RoomType.RoomTypeName));

#line default
#line hidden
            EndContext();
            BeginContext(2686, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(2724, 214, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d0feab8abae41ac8e8e64231d40bc86", async() => {
                BeginContext(2750, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2760, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "100bafd7d0894826a2db522150a4d551", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 101 "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\Bookings\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.BookingId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2803, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(2887, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf2840de56c044b4a3117ade2d347f10", async() => {
                    BeginContext(2909, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2925, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2938, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HotelManagementSystem_CoreMvc.Models.Booking> Html { get; private set; }
    }
}
#pragma warning restore 1591
