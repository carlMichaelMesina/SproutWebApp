#pragma checksum "C:\Users\Koropi\Desktop\TEST\SproutProject\SproutWebApp\Views\Employee\ApprovedEmployeeSalary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0501b927b3ea3efd652f9e33c014700c84bd87b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_ApprovedEmployeeSalary), @"mvc.1.0.view", @"/Views/Employee/ApprovedEmployeeSalary.cshtml")]
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
#line 1 "C:\Users\Koropi\Desktop\TEST\SproutProject\SproutWebApp\Views\_ViewImports.cshtml"
using SproutWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Koropi\Desktop\TEST\SproutProject\SproutWebApp\Views\_ViewImports.cshtml"
using SproutWebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0501b927b3ea3efd652f9e33c014700c84bd87b", @"/Views/Employee/ApprovedEmployeeSalary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0d72c8cd1c4bbfc1b5bedbead34fe12c56c4891", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_ApprovedEmployeeSalary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SproutWebApp.Models.Employee>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0501b927b3ea3efd652f9e33c014700c84bd87b3390", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\r\n    <title>Add Employee</title>\r\n\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0501b927b3ea3efd652f9e33c014700c84bd87b4572", async() => {
                WriteLiteral(@"
    <div class=""table-wrapper"">
        <div class=""table-title"">
            <div class=""row"">
                <div class=""col-sm-6""><h2><b>Calculate</b> Salary</h2></div>
                <div class=""col-sm-6""></div>
            </div>
        </div>
        Name: ");
#nullable restore
#line 21 "C:\Users\Koropi\Desktop\TEST\SproutProject\SproutWebApp\Views\Employee\ApprovedEmployeeSalary.cshtml"
         Write(Html.Label("Name", Model.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n        Birthdate: ");
#nullable restore
#line 22 "C:\Users\Koropi\Desktop\TEST\SproutProject\SproutWebApp\Views\Employee\ApprovedEmployeeSalary.cshtml"
              Write(Html.Label("Birthdate", Model.Birthdate.ToShortDateString()));

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n        TIN: ");
#nullable restore
#line 23 "C:\Users\Koropi\Desktop\TEST\SproutProject\SproutWebApp\Views\Employee\ApprovedEmployeeSalary.cshtml"
        Write(Html.Label("TIN", Model.TIN));

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n\r\n        Employee Type: ");
#nullable restore
#line 25 "C:\Users\Koropi\Desktop\TEST\SproutProject\SproutWebApp\Views\Employee\ApprovedEmployeeSalary.cshtml"
                        if (Model.EmployeeType == "R")
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\Koropi\Desktop\TEST\SproutProject\SproutWebApp\Views\Employee\ApprovedEmployeeSalary.cshtml"
       Write(Html.Label("Type", "Regular"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\Koropi\Desktop\TEST\SproutProject\SproutWebApp\Views\Employee\ApprovedEmployeeSalary.cshtml"
                                          
        }
        else
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\Koropi\Desktop\TEST\SproutProject\SproutWebApp\Views\Employee\ApprovedEmployeeSalary.cshtml"
       Write(Html.Label("Type", "Contractual"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\Koropi\Desktop\TEST\SproutProject\SproutWebApp\Views\Employee\ApprovedEmployeeSalary.cshtml"
                                              
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n\r\n        Basic Salary: ");
#nullable restore
#line 34 "C:\Users\Koropi\Desktop\TEST\SproutProject\SproutWebApp\Views\Employee\ApprovedEmployeeSalary.cshtml"
                 Write(Html.Label("BasicSalary", "PHP " + Convert.ToDecimal(Model.Salary).ToString("N")));

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n\r\n");
#nullable restore
#line 36 "C:\Users\Koropi\Desktop\TEST\SproutProject\SproutWebApp\Views\Employee\ApprovedEmployeeSalary.cshtml"
         if (Model.EmployeeType == "R")
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div>Number of Absent:\r\n            ");
#nullable restore
#line 39 "C:\Users\Koropi\Desktop\TEST\SproutProject\SproutWebApp\Views\Employee\ApprovedEmployeeSalary.cshtml"
       Write(Html.Label("Type", Model.Absences.ToString()));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n");
#nullable restore
#line 40 "C:\Users\Koropi\Desktop\TEST\SproutProject\SproutWebApp\Views\Employee\ApprovedEmployeeSalary.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div>Number of Working Days:\r\n            ");
#nullable restore
#line 44 "C:\Users\Koropi\Desktop\TEST\SproutProject\SproutWebApp\Views\Employee\ApprovedEmployeeSalary.cshtml"
       Write(Html.Label("Type", Model.Attendance.ToString()));

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n");
#nullable restore
#line 45 "C:\Users\Koropi\Desktop\TEST\SproutProject\SproutWebApp\Views\Employee\ApprovedEmployeeSalary.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        Computed Salary: ");
#nullable restore
#line 47 "C:\Users\Koropi\Desktop\TEST\SproutProject\SproutWebApp\Views\Employee\ApprovedEmployeeSalary.cshtml"
                    Write(Html.Label("ComputedSalary", "PHP " + Convert.ToDecimal(Model.ComputedSalary).ToString("N")));

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 50 "C:\Users\Koropi\Desktop\TEST\SproutProject\SproutWebApp\Views\Employee\ApprovedEmployeeSalary.cshtml"
       Write(Html.ActionLink(" Back ", "ViewAllEmployees", new { id = "btnBack" }, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n\r\n    </div>\r\n\r\n");
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
            WriteLiteral("\r\n</html> ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SproutWebApp.Models.Employee> Html { get; private set; }
    }
}
#pragma warning restore 1591