#pragma checksum "c:\Users\Adeniyi Mary A\Desktop\dotnet work\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7de905fef1b99bb3eb44b3c6a3d2f6f1e3538312"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
#line 1 "c:\Users\Adeniyi Mary A\Desktop\dotnet work\Views\_ViewImports.cshtml"
using Code360StudentApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\Adeniyi Mary A\Desktop\dotnet work\Views\_ViewImports.cshtml"
using Code360StudentApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\Adeniyi Mary A\Desktop\dotnet work\Views\_ViewImports.cshtml"
using Code360StudentApp.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7de905fef1b99bb3eb44b3c6a3d2f6f1e3538312", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de443335ec7c6a71b484c388a3d5799e90e61197", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeDetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "guarantor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("list-group-item list-group-item-action"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-thumbnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Card image cap"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreatePayment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "c:\Users\Adeniyi Mary A\Desktop\dotnet work\Views\Home\Details.cshtml"
  
    ViewBag.Title = "Employee Details";
    var photoPath = "~/img/" + (Model.student.Photo ?? "no-image.png");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n<section id=\"breacrumb\">\r\n    <div class=\"container\">\r\n        <ol class=\"breadcrumb\">\r\n            <li class=\"active\">Dashboard / ");
#nullable restore
#line 17 "c:\Users\Adeniyi Mary A\Desktop\dotnet work\Views\Home\Details.cshtml"
                                      Write(Model.PageTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
        </ol>
    </div>
</section>

<section id=""main"">
    <div class=""container"">
        <div class=""row"">

            <div class=""col-md-3"">
                <div class=""list-group"">
                    <a href=""#"" class=""list-group-item list-group-item-action active main-color-bg"">
                        <i class=""fa fa-cog""></i> Student Details
                    </a>
                    
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7de905fef1b99bb3eb44b3c6a3d2f6f1e35383127583", async() => {
                WriteLiteral(" <i class=\"fa fa-book\"></i> Add Guarantor <span class=\"badge badge-primary badge-pill\">3</span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "c:\Users\Adeniyi Mary A\Desktop\dotnet work\Views\Home\Details.cshtml"
                                                                      WriteLiteral(Model.student.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    <a href=""users.html"" class=""list-group-item list-group-item-action""><i class=""fa fa-user-circle"" aria-hidden=""true""></i> Users <span class=""badge badge-primary badge-pill"">14</span></a>
                    <a href=""posts.html"" class=""list-group-item list-group-item-action""><i class=""fa fa-money""></i> Payment <span class=""badge badge-primary badge-pill"">20</span></a>

                </div>

                <div class=""card card-body mt-3"">
                    <h4>Disk Space Used</h4>
                    <div class=""progress"">
                        <div class=""progress-bar"" role=""progressbar"" style=""wid.th: 65%;"" aria-valuenow=""65"" aria-valuemin=""0"" aria-valuemax=""100"">65%</div>
                    </div>
                </div>
                
            </div>
            <div class=""col-md-9"">


                <!-- user table  -->

                <div class=""panel-body"">
                    


");
            WriteLiteral(@"
                    <ul class=""nav nav-tabs"" id=""accordionExample"">
                        <li>
                            <div class=""card-header"" id=""headingOne"">
                                <h2 class=""mb-0"">
                                    <button class=""btn btn-dark"" type=""button"" data-toggle=""collapse"" data-target=""#collapseOne"" aria-expanded=""true"" aria-controls=""collapseOne"">
                                        Sudent Biodata
                                    </button>
                                </h2>
                            </div>

                            <div id=""collapseOne"" class=""collapse show"" aria-labelledby=""headingOne"" data-parent=""#accordionExample"">
                                <div class=""card-body"">
                                    <div class=""row"">
                                        <div class=""col-md-4 col-sm-12"">
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7de905fef1b99bb3eb44b3c6a3d2f6f1e353831212153", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 71 "c:\Users\Adeniyi Mary A\Desktop\dotnet work\Views\Home\Details.cshtml"
                                                                WriteLiteral(photoPath);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
#nullable restore
#line 71 "c:\Users\Adeniyi Mary A\Desktop\dotnet work\Views\Home\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            <h2 class=\"h2 text-capitalize text-center mt-3\">");
#nullable restore
#line 72 "c:\Users\Adeniyi Mary A\Desktop\dotnet work\Views\Home\Details.cshtml"
                                                                                       Write(Model.student.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                                        </div>
                                        <div class=""col-md-8 col-sm-12"">
                                            <ul class=""list-group"">
                                                <li class=""list-group-item""><strong>Email</strong> ");
#nullable restore
#line 76 "c:\Users\Adeniyi Mary A\Desktop\dotnet work\Views\Home\Details.cshtml"
                                                                                              Write(Model.student.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                                <li class=\"list-group-item\"><strong>Phone:</strong>");
#nullable restore
#line 77 "c:\Users\Adeniyi Mary A\Desktop\dotnet work\Views\Home\Details.cshtml"
                                                                                              Write(Model.student.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                                <li class=\"list-group-item\"><strong>Address</strong>");
#nullable restore
#line 78 "c:\Users\Adeniyi Mary A\Desktop\dotnet work\Views\Home\Details.cshtml"
                                                                                               Write(Model.student.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                                <li class=\"list-group-item\"><strong>Marital Status</strong>");
#nullable restore
#line 79 "c:\Users\Adeniyi Mary A\Desktop\dotnet work\Views\Home\Details.cshtml"
                                                                                                      Write(Model.student.MaritalStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                                <li class=\"list-group-item\"><strong>Nationality</strong>");
#nullable restore
#line 80 "c:\Users\Adeniyi Mary A\Desktop\dotnet work\Views\Home\Details.cshtml"
                                                                                                   Write(Model.student.Nationalty);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                                <li class=\"list-group-item\"><strong>Status:</strong>");
#nullable restore
#line 81 "c:\Users\Adeniyi Mary A\Desktop\dotnet work\Views\Home\Details.cshtml"
                                                                                               Write(Model.student.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                                <li class=\"list-group-item\"><strong>Admission Type:</strong>");
#nullable restore
#line 82 "c:\Users\Adeniyi Mary A\Desktop\dotnet work\Views\Home\Details.cshtml"
                                                                                                       Write(Model.student.AdmissionType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n\r\n                                                <li class=\"list-group-item\"><strong>Health:</strong>");
#nullable restore
#line 84 "c:\Users\Adeniyi Mary A\Desktop\dotnet work\Views\Home\Details.cshtml"
                                                                                               Write(Model.student.HealthCondition);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                                            </ul>
                                            
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </li>
                        <li>
                            <div class=""card-header"" id=""headingTwo"">
                                <h2 class=""mb-0"">
                                    <button class=""btn btn-dark collapsed"" type=""button"" data-toggle=""collapse"" data-target=""#collapseTwo"" aria-expanded=""false"" aria-controls=""collapseTwo"">
                                        NEXT OF KIN
                                    </button>
                                </h2>
                            </div>
                            <div id=""collapseTwo"" class=""collapse"" aria-labelledby=""headingTwo"" data-parent=""#accordionExample"">
                                <div class=""card-body"">
                ");
            WriteLiteral("                    <div class=\"text-center\">\r\n                                    <div class=\"h3\">Name: <strong>");
#nullable restore
#line 103 "c:\Users\Adeniyi Mary A\Desktop\dotnet work\Views\Home\Details.cshtml"
                                                             Write(Model.student.NextOFKinName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></div>\r\n                                    <div class=\"h3\">Phone Number: <strong>");
#nullable restore
#line 104 "c:\Users\Adeniyi Mary A\Desktop\dotnet work\Views\Home\Details.cshtml"
                                                                     Write(Model.student.NextOfKinNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></div>\r\n                                    <div class=\"h3\">Address: <strong>");
#nullable restore
#line 105 "c:\Users\Adeniyi Mary A\Desktop\dotnet work\Views\Home\Details.cshtml"
                                                                Write(Model.student.NextOfKinAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong></div>
                                        </div>
                                </div>
                            </div>
                        </li>
                        <li>
                            <div class=""card-header"" id=""headingThree"">
                                <h2 class=""mb-0"">
                                    <button class=""btn btn-dark collapsed"" type=""button"" data-toggle=""collapse"" data-target=""#collapseThree"" aria-expanded=""false"" aria-controls=""collapseThree"">
                                        Guarantors
                                    </button>
                                </h2>
                            </div>   
                            <div id=""collapseThree"" class=""collapse"" aria-labelledby=""headingThree"" data-parent=""#accordionExample"">
                                <div class=""card-body"">
");
#nullable restore
#line 120 "c:\Users\Adeniyi Mary A\Desktop\dotnet work\Views\Home\Details.cshtml"
                                     foreach (var g in Model.guarantors)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <ul class=\"list-group mb-5\">\r\n                                            <li class=\"list-group-item\">Name: <strong>");
#nullable restore
#line 123 "c:\Users\Adeniyi Mary A\Desktop\dotnet work\Views\Home\Details.cshtml"
                                                                                 Write(g.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></li>\r\n                                            <li class=\"list-group-item\">Address: <strong>");
#nullable restore
#line 124 "c:\Users\Adeniyi Mary A\Desktop\dotnet work\Views\Home\Details.cshtml"
                                                                                    Write(g.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </strong></li>\r\n                                            <li class=\"list-group-item\"> <strong>");
#nullable restore
#line 125 "c:\Users\Adeniyi Mary A\Desktop\dotnet work\Views\Home\Details.cshtml"
                                                                            Write(g.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </strong></li>\r\n                                            <li class=\"list-group-item\"> <strong>");
#nullable restore
#line 126 "c:\Users\Adeniyi Mary A\Desktop\dotnet work\Views\Home\Details.cshtml"
                                                                            Write(g.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </strong></li>\r\n\r\n                                        </ul>\r\n");
#nullable restore
#line 129 "c:\Users\Adeniyi Mary A\Desktop\dotnet work\Views\Home\Details.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </div>   
                            </div>
                        </li>
                        <li>
                            <div class=""card-header"" id=""headingFour"">
                                <h2 class=""mb-0"">
                                    <button class=""btn btn-dark collapsed"" type=""button"" data-toggle=""collapse"" data-target=""#collapseThree"" aria-expanded=""false"" aria-controls=""collapseThree"">
                                        Payments
                                    </button>
                                </h2>
                            </div>
                            <div id=""collapseThree"" class=""collapse"" aria-labelledby=""headingThree"" data-parent=""#accordionExample"">
                                <div class=""card-body"">
");
#nullable restore
#line 143 "c:\Users\Adeniyi Mary A\Desktop\dotnet work\Views\Home\Details.cshtml"
                                     if (Model.payment != null && Model.payment.Count > 0)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 145 "c:\Users\Adeniyi Mary A\Desktop\dotnet work\Views\Home\Details.cshtml"
                                         foreach (var g in Model.payment)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <ul class=\"list-group mb-5\">\r\n                                                <li class=\"list-group-item\">Amount: <strong>");
#nullable restore
#line 148 "c:\Users\Adeniyi Mary A\Desktop\dotnet work\Views\Home\Details.cshtml"
                                                                                       Write(g.AmouontPaid);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></li>\r\n                                                <li class=\"list-group-item\">D/T: <strong>");
#nullable restore
#line 149 "c:\Users\Adeniyi Mary A\Desktop\dotnet work\Views\Home\Details.cshtml"
                                                                                    Write(g.PaymentDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </strong></li>\r\n                                                <li class=\"list-group-item\">Method: <strong>");
#nullable restore
#line 150 "c:\Users\Adeniyi Mary A\Desktop\dotnet work\Views\Home\Details.cshtml"
                                                                                       Write(g.PaymentMethod);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </strong></li>\r\n                                                \r\n                                            </ul>\r\n");
#nullable restore
#line 153 "c:\Users\Adeniyi Mary A\Desktop\dotnet work\Views\Home\Details.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7de905fef1b99bb3eb44b3c6a3d2f6f1e353831226851", async() => {
                WriteLiteral("Add Payment");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 154 "c:\Users\Adeniyi Mary A\Desktop\dotnet work\Views\Home\Details.cshtml"
                                                                                                                                       WriteLiteral(Model.student.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n");
#nullable restore
#line 155 "c:\Users\Adeniyi Mary A\Desktop\dotnet work\Views\Home\Details.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <h3>No Payment Yet</h3>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7de905fef1b99bb3eb44b3c6a3d2f6f1e353831229884", async() => {
                WriteLiteral("Add Payment");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 159 "c:\Users\Adeniyi Mary A\Desktop\dotnet work\Views\Home\Details.cshtml"
                                                                                                                   WriteLiteral(Model.student.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n");
#nullable restore
#line 160 "c:\Users\Adeniyi Mary A\Desktop\dotnet work\Views\Home\Details.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n                            </div>\r\n                        </li>\r\n                        \r\n                    </ul>\r\n");
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 181 "c:\Users\Adeniyi Mary A\Desktop\dotnet work\Views\Home\Details.cshtml"
     if (ViewBag.Message != null)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <script>\r\n        window.onload = function () {\r\n            alert(\"");
#nullable restore
#line 185 "c:\Users\Adeniyi Mary A\Desktop\dotnet work\Views\Home\Details.cshtml"
              Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
                WriteLiteral("\");\r\n        }\r\n        </script>\r\n");
#nullable restore
#line 188 "c:\Users\Adeniyi Mary A\Desktop\dotnet work\Views\Home\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
