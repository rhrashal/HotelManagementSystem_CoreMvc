#pragma checksum "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\Bookings\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7a88c96349208824340dbd87ddd6b6c492ee6a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bookings_Index), @"mvc.1.0.view", @"/Views/Bookings/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Bookings/Index.cshtml", typeof(AspNetCore.Views_Bookings_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7a88c96349208824340dbd87ddd6b6c492ee6a1", @"/Views/Bookings/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27a05c3478fa7695a36c8c1154752c1e005bb52f", @"/Views/_ViewImports.cshtml")]
    public class Views_Bookings_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HotelManagementSystem_CoreMvc.Models.Booking>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(66, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\Bookings\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(109, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(138, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b94479e71530479d81b62982d14201ef", async() => {
                BeginContext(161, 10, true);
                WriteLiteral("Create New");
                EndContext();
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
            EndContext();
            BeginContext(175, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(268, 45, false);
#line 16 "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\Bookings\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(313, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(369, 44, false);
#line 19 "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\Bookings\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(413, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(469, 43, false);
#line 22 "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\Bookings\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(512, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(568, 41, false);
#line 25 "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\Bookings\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(609, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(665, 41, false);
#line 28 "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\Bookings\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(706, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(762, 42, false);
#line 31 "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\Bookings\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NID_No));

#line default
#line hidden
            EndContext();
            BeginContext(804, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(860, 47, false);
#line 34 "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\Bookings\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ArrivalTime));

#line default
#line hidden
            EndContext();
            BeginContext(907, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(963, 49, false);
#line 37 "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\Bookings\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DepartureDate));

#line default
#line hidden
            EndContext();
            BeginContext(1012, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1068, 41, false);
#line 40 "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\Bookings\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Notes));

#line default
#line hidden
            EndContext();
            BeginContext(1109, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1165, 41, false);
#line 43 "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\Bookings\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Adult));

#line default
#line hidden
            EndContext();
            BeginContext(1206, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1262, 47, false);
#line 46 "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\Bookings\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.BeddingType));

#line default
#line hidden
            EndContext();
            BeginContext(1309, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1365, 41, false);
#line 49 "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\Bookings\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Child));

#line default
#line hidden
            EndContext();
            BeginContext(1406, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1462, 48, false);
#line 52 "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\Bookings\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.RoomQuantity));

#line default
#line hidden
            EndContext();
            BeginContext(1510, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1566, 44, false);
#line 55 "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\Bookings\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.RoomType));

#line default
#line hidden
            EndContext();
            BeginContext(1610, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 61 "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\Bookings\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1728, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1777, 44, false);
#line 64 "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\Bookings\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(1821, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1877, 43, false);
#line 67 "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\Bookings\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(1920, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1976, 42, false);
#line 70 "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\Bookings\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
            EndContext();
            BeginContext(2018, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2074, 40, false);
#line 73 "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\Bookings\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(2114, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2170, 40, false);
#line 76 "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\Bookings\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(2210, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2266, 41, false);
#line 79 "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\Bookings\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NID_No));

#line default
#line hidden
            EndContext();
            BeginContext(2307, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2363, 46, false);
#line 82 "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\Bookings\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ArrivalTime));

#line default
#line hidden
            EndContext();
            BeginContext(2409, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2465, 48, false);
#line 85 "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\Bookings\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DepartureDate));

#line default
#line hidden
            EndContext();
            BeginContext(2513, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2569, 40, false);
#line 88 "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\Bookings\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Notes));

#line default
#line hidden
            EndContext();
            BeginContext(2609, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2665, 48, false);
#line 91 "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\Bookings\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Adult.AdultId));

#line default
#line hidden
            EndContext();
            BeginContext(2713, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2769, 62, false);
#line 94 "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\Bookings\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.BeddingType.BeddingTypeName));

#line default
#line hidden
            EndContext();
            BeginContext(2831, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2887, 48, false);
#line 97 "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\Bookings\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Child.ChildId));

#line default
#line hidden
            EndContext();
            BeginContext(2935, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2991, 62, false);
#line 100 "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\Bookings\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.RoomQuantity.RoomQuantityId));

#line default
#line hidden
            EndContext();
            BeginContext(3053, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3109, 56, false);
#line 103 "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\Bookings\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.RoomType.RoomTypeName));

#line default
#line hidden
            EndContext();
            BeginContext(3165, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3220, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "729926071ee14f2fb3ce5decd4481e0a", async() => {
                BeginContext(3272, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 106 "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\Bookings\Index.cshtml"
                                       WriteLiteral(item.BookingId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3280, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(3300, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01e86c4a571f4caa8d0df425722810b6", async() => {
                BeginContext(3355, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 107 "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\Bookings\Index.cshtml"
                                          WriteLiteral(item.BookingId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3366, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(3386, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "caeef2f2515a4121a7f6a77de01150e6", async() => {
                BeginContext(3440, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 108 "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\Bookings\Index.cshtml"
                                         WriteLiteral(item.BookingId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3450, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 111 "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\Bookings\Index.cshtml"
}

#line default
#line hidden
            BeginContext(3489, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HotelManagementSystem_CoreMvc.Models.Booking>> Html { get; private set; }
    }
}
#pragma warning restore 1591
