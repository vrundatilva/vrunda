#pragma checksum "C:\Vrunda\Project_Hospital\Project_Hospital\Areas\Hospital\Views\Hospital\PatientDelete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b17178e3fcd6f88ca6b8fef09b656cf79860891e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Hospital_Views_Hospital_PatientDelete), @"mvc.1.0.view", @"/Areas/Hospital/Views/Hospital/PatientDelete.cshtml")]
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
#line 1 "C:\Vrunda\Project_Hospital\Project_Hospital\Areas\Hospital\Views\_ViewImports.cshtml"
using Project_Hospital;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Vrunda\Project_Hospital\Project_Hospital\Areas\Hospital\Views\_ViewImports.cshtml"
using Project_Hospital.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b17178e3fcd6f88ca6b8fef09b656cf79860891e", @"/Areas/Hospital/Views/Hospital/PatientDelete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7ef1ddc78c1496e158e7e1b9796c19d55867cbc", @"/Areas/Hospital/Views/_ViewImports.cshtml")]
    public class Areas_Hospital_Views_Hospital_PatientDelete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Project_Hospital.EDM.Patient>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PatientDelete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Vrunda\Project_Hospital\Project_Hospital\Areas\Hospital\Views\Hospital\PatientDelete.cshtml"
  
    ViewData["Title"] = "PatientDelete";
    Layout = "~/Areas/Hospital/Views/Hospital_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Patient Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div >\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
#nullable restore
#line 15 "C:\Vrunda\Project_Hospital\Project_Hospital\Areas\Hospital\Views\Hospital\PatientDelete.cshtml"
       Write(Html.DisplayNameFor(model => model.PatId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 18 "C:\Vrunda\Project_Hospital\Project_Hospital\Areas\Hospital\Views\Hospital\PatientDelete.cshtml"
       Write(Html.DisplayFor(model => model.PatId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 21 "C:\Vrunda\Project_Hospital\Project_Hospital\Areas\Hospital\Views\Hospital\PatientDelete.cshtml"
       Write(Html.DisplayNameFor(model => model.Fname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 24 "C:\Vrunda\Project_Hospital\Project_Hospital\Areas\Hospital\Views\Hospital\PatientDelete.cshtml"
       Write(Html.DisplayFor(model => model.Fname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 27 "C:\Vrunda\Project_Hospital\Project_Hospital\Areas\Hospital\Views\Hospital\PatientDelete.cshtml"
       Write(Html.DisplayNameFor(model => model.Lname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 30 "C:\Vrunda\Project_Hospital\Project_Hospital\Areas\Hospital\Views\Hospital\PatientDelete.cshtml"
       Write(Html.DisplayFor(model => model.Lname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 33 "C:\Vrunda\Project_Hospital\Project_Hospital\Areas\Hospital\Views\Hospital\PatientDelete.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 36 "C:\Vrunda\Project_Hospital\Project_Hospital\Areas\Hospital\Views\Hospital\PatientDelete.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 39 "C:\Vrunda\Project_Hospital\Project_Hospital\Areas\Hospital\Views\Hospital\PatientDelete.cshtml"
       Write(Html.DisplayNameFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 42 "C:\Vrunda\Project_Hospital\Project_Hospital\Areas\Hospital\Views\Hospital\PatientDelete.cshtml"
       Write(Html.DisplayFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 45 "C:\Vrunda\Project_Hospital\Project_Hospital\Areas\Hospital\Views\Hospital\PatientDelete.cshtml"
       Write(Html.DisplayNameFor(model => model.PImg));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 48 "C:\Vrunda\Project_Hospital\Project_Hospital\Areas\Hospital\Views\Hospital\PatientDelete.cshtml"
       Write(Html.DisplayFor(model => model.PImg));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 51 "C:\Vrunda\Project_Hospital\Project_Hospital\Areas\Hospital\Views\Hospital\PatientDelete.cshtml"
       Write(Html.DisplayNameFor(model => model.Mobile));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 54 "C:\Vrunda\Project_Hospital\Project_Hospital\Areas\Hospital\Views\Hospital\PatientDelete.cshtml"
       Write(Html.DisplayFor(model => model.Mobile));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 57 "C:\Vrunda\Project_Hospital\Project_Hospital\Areas\Hospital\Views\Hospital\PatientDelete.cshtml"
       Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 60 "C:\Vrunda\Project_Hospital\Project_Hospital\Areas\Hospital\Views\Hospital\PatientDelete.cshtml"
       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 63 "C:\Vrunda\Project_Hospital\Project_Hospital\Areas\Hospital\Views\Hospital\PatientDelete.cshtml"
       Write(Html.DisplayNameFor(model => model.SId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 66 "C:\Vrunda\Project_Hospital\Project_Hospital\Areas\Hospital\Views\Hospital\PatientDelete.cshtml"
       Write(Html.DisplayFor(model => model.SId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 69 "C:\Vrunda\Project_Hospital\Project_Hospital\Areas\Hospital\Views\Hospital\PatientDelete.cshtml"
       Write(Html.DisplayNameFor(model => model.CId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 72 "C:\Vrunda\Project_Hospital\Project_Hospital\Areas\Hospital\Views\Hospital\PatientDelete.cshtml"
       Write(Html.DisplayFor(model => model.CId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b17178e3fcd6f88ca6b8fef09b656cf79860891e10429", async() => {
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-info\" /> \r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </br>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Project_Hospital.EDM.Patient> Html { get; private set; }
    }
}
#pragma warning restore 1591