#pragma checksum "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\Admin\RoleWithUserList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b04ed1be23136345e993b85e4c6cb8c270cec4c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_RoleWithUserList), @"mvc.1.0.view", @"/Views/Admin/RoleWithUserList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/RoleWithUserList.cshtml", typeof(AspNetCore.Views_Admin_RoleWithUserList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b04ed1be23136345e993b85e4c6cb8c270cec4c", @"/Views/Admin/RoleWithUserList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27a05c3478fa7695a36c8c1154752c1e005bb52f", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_RoleWithUserList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HotelManagementSystem_CoreMvc.Models.ApplicationUserRole>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(78, 124, true);
            WriteLiteral("\r\n\r\n\r\n<h2>Role With User List</h2>\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(203, 40, false);
#line 12 "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\Admin\RoleWithUserList.cshtml"
           Write(Html.DisplayNameFor(model => model.User));

#line default
#line hidden
            EndContext();
            BeginContext(243, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(299, 40, false);
#line 15 "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\Admin\RoleWithUserList.cshtml"
           Write(Html.DisplayNameFor(model => model.Role));

#line default
#line hidden
            EndContext();
            BeginContext(339, 21, true);
            WriteLiteral("\r\n            </th>\r\n");
            EndContext();
            BeginContext(387, 42, true);
            WriteLiteral("        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 21 "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\Admin\RoleWithUserList.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(478, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(539, 48, false);
#line 25 "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\Admin\RoleWithUserList.cshtml"
               Write(Html.DisplayFor(modelItem => item.User.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(587, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(655, 44, false);
#line 28 "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\Admin\RoleWithUserList.cshtml"
               Write(Html.DisplayFor(modelItem => item.Role.Name));

#line default
#line hidden
            EndContext();
            BeginContext(699, 25, true);
            WriteLiteral("\r\n                </td>\r\n");
            EndContext();
            BeginContext(1051, 19, true);
            WriteLiteral("            </tr>\r\n");
            EndContext();
#line 36 "C:\Users\ESAD-CS\Desktop\New folder\New folder\1251184-Robiul Hossain(Core Mvc)\HotelManagementSystem_CoreMvc\Views\Admin\RoleWithUserList.cshtml"
        }

#line default
#line hidden
            BeginContext(1081, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HotelManagementSystem_CoreMvc.Models.ApplicationUserRole>> Html { get; private set; }
    }
}
#pragma warning restore 1591
