#pragma checksum "C:\Users\Koropi\Desktop\TEST\SproutProject\SproutWebApp\Views\Employee\ViewAllEmployees.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9b67997f2de2349ab78682ed4fdfbf37d642225"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_ViewAllEmployees), @"mvc.1.0.view", @"/Views/Employee/ViewAllEmployees.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9b67997f2de2349ab78682ed4fdfbf37d642225", @"/Views/Employee/ViewAllEmployees.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0d72c8cd1c4bbfc1b5bedbead34fe12c56c4891", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_ViewAllEmployees : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SproutWebApp.Models.Employee>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/javascript.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9b67997f2de2349ab78682ed4fdfbf37d6422253879", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\r\n    <title>View All Employees</title>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9b67997f2de2349ab78682ed4fdfbf37d6422255063", async() => {
                WriteLiteral(@"
    <div class=""table-wrapper"">
        <div class=""table-title"">
            <div class=""row"">
                <div class=""col-sm-6""><h2>Employee <b>List</b></h2></div>
                <div class=""col-sm-6"">
                    <div class=""btn-group"" data-toggle=""buttons"">
                        <label class=""btn btn-info active"">
                            <input type=""radio"" name=""status"" value=""all"" checked=""checked""> All
                        </label>
                        <label class=""btn btn-success"">
                            <input type=""radio"" name=""status"" value=""P""> Pending
                        </label>
                        <label class=""btn btn-warning"">
                            <input type=""radio"" name=""status"" value=""A""> Approved
                        </label>
                    </div>
                </div>
            </div>
        </div>
        <table class=""table table-striped table-hover"">
            <thead>
                <tr>
             ");
                WriteLiteral("       <th>ID</th>\r\n                    <th>Name</th>\r\n                    <th>Employee Type</th>\r\n                    <th>Status</th>\r\n                    <th>Action</th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 41 "C:\Users\Koropi\Desktop\TEST\SproutProject\SproutWebApp\Views\Employee\ViewAllEmployees.cshtml"
                 foreach (var employeeItem in Model)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr data-status=\"");
#nullable restore
#line 43 "C:\Users\Koropi\Desktop\TEST\SproutProject\SproutWebApp\Views\Employee\ViewAllEmployees.cshtml"
                                Write(Html.DisplayFor(modelItem => employeeItem.Status));

#line default
#line hidden
#nullable disable
                WriteLiteral("\">\r\n                        <td>\r\n                            ");
#nullable restore
#line 45 "C:\Users\Koropi\Desktop\TEST\SproutProject\SproutWebApp\Views\Employee\ViewAllEmployees.cshtml"
                       Write(Html.DisplayFor(modelItem => employeeItem.EmployeeId));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 48 "C:\Users\Koropi\Desktop\TEST\SproutProject\SproutWebApp\Views\Employee\ViewAllEmployees.cshtml"
                       Write(Html.DisplayFor(modelItem => employeeItem.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n");
#nullable restore
#line 51 "C:\Users\Koropi\Desktop\TEST\SproutProject\SproutWebApp\Views\Employee\ViewAllEmployees.cshtml"
                             if (employeeItem.EmployeeType == "C")
                            {
                                

#line default
#line hidden
#nullable disable
                WriteLiteral("Contractual");
#nullable restore
#line 53 "C:\Users\Koropi\Desktop\TEST\SproutProject\SproutWebApp\Views\Employee\ViewAllEmployees.cshtml"
                                                         }
                            else
                            {
                                

#line default
#line hidden
#nullable disable
                WriteLiteral("Regular");
#nullable restore
#line 56 "C:\Users\Koropi\Desktop\TEST\SproutProject\SproutWebApp\Views\Employee\ViewAllEmployees.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </td>\r\n                        <td>\r\n");
#nullable restore
#line 59 "C:\Users\Koropi\Desktop\TEST\SproutProject\SproutWebApp\Views\Employee\ViewAllEmployees.cshtml"
                             if (employeeItem.Status == "P")
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <span class=\"label label-warning\"><text>Pending</text></span> ");
#nullable restore
#line 61 "C:\Users\Koropi\Desktop\TEST\SproutProject\SproutWebApp\Views\Employee\ViewAllEmployees.cshtml"
                                                                                              }
                            else
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <span class=\"label label-success\"><text>Approved</text></span>");
#nullable restore
#line 64 "C:\Users\Koropi\Desktop\TEST\SproutProject\SproutWebApp\Views\Employee\ViewAllEmployees.cshtml"
                                                                                              }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </td>\r\n                        <td class=\"centerItem\">\r\n");
#nullable restore
#line 67 "C:\Users\Koropi\Desktop\TEST\SproutProject\SproutWebApp\Views\Employee\ViewAllEmployees.cshtml"
                             if (employeeItem.Status == "P")
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "C:\Users\Koropi\Desktop\TEST\SproutProject\SproutWebApp\Views\Employee\ViewAllEmployees.cshtml"
                           Write(Html.ActionLink(" Calculate ", "CalculateEmployeeSalary", new { id = "btnCalculate", employeeID = employeeItem.EmployeeId }, new { @class = "btn btn-sm manage" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "C:\Users\Koropi\Desktop\TEST\SproutProject\SproutWebApp\Views\Employee\ViewAllEmployees.cshtml"
                                                                                                                                                                                                   
                            }
                            else
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "C:\Users\Koropi\Desktop\TEST\SproutProject\SproutWebApp\Views\Employee\ViewAllEmployees.cshtml"
                           Write(Html.ActionLink(" Review ", "ReviewEmployeeSalary", new { id = "btnCalculate", employeeID = employeeItem.EmployeeId }, new { @class = "btn btn-sm manage" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "C:\Users\Koropi\Desktop\TEST\SproutProject\SproutWebApp\Views\Employee\ViewAllEmployees.cshtml"
                                                                                                                                                                                             
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 78 "C:\Users\Koropi\Desktop\TEST\SproutProject\SproutWebApp\Views\Employee\ViewAllEmployees.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tbody>\r\n\r\n        </table>\r\n        ");
#nullable restore
#line 82 "C:\Users\Koropi\Desktop\TEST\SproutProject\SproutWebApp\Views\Employee\ViewAllEmployees.cshtml"
   Write(Html.ActionLink(" New Employee ", "AddEmployee", new { id = "btnAdd" }, new { @class = "btn btn-success" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n       \r\n    </div>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9b67997f2de2349ab78682ed4fdfbf37d64222513144", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SproutWebApp.Models.Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
