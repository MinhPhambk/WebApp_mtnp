#pragma checksum "C:\Users\Ngoc Phuong\source\repo_main\WebApp\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a9bb2014ade8ba06aef458c4a76fa687c206db8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "C:\Users\Ngoc Phuong\source\repo_main\WebApp\Views\_ViewImports.cshtml"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ngoc Phuong\source\repo_main\WebApp\Views\_ViewImports.cshtml"
using WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a9bb2014ade8ba06aef458c4a76fa687c206db8", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc48f17eb9bac3476d8060730298bf398eb2fa5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link active"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Customer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "IndexCustomer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-sm-inline d-none nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:white;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("g-sidenav-show   bg-gray-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a9bb2014ade8ba06aef458c4a76fa687c206db86028", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
    <link rel=""apple-touch-icon"" sizes=""76x76"" href=""/assets/img/apple-icon.png"">
    <link rel=""icon"" type=""image/png"" href=""/assets/img/favicon.png"">
    <title>
        Heheeeee
    </title>
    <!--     Fonts and icons     -->
    <link href=""https://fonts.googleapis.com/css?family=Open+Sans:300,400,600,700"" rel=""stylesheet"" />
    <!-- Nucleo Icons -->
    <link href=""/assets/css/nucleo-icons.css"" rel=""stylesheet"" />
    <link href=""/assets/css/nucleo-svg.css"" rel=""stylesheet"" />
    <!-- Font Awesome Icons -->
    <script src=""https://kit.fontawesome.com/42d5adcbca.js"" crossorigin=""anonymous""></script>
    <link href=""/assets/css/nucleo-svg.css"" rel=""stylesheet"" />
    <!-- CSS Files -->
    <link id=""pagestyle"" href=""/assets/css/argon-dashboard.css?v=2.0.4"" rel=""stylesheet"" />
");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a9bb2014ade8ba06aef458c4a76fa687c206db87973", async() => {
                WriteLiteral(@"
    <div class=""min-height-300 bg-primary position-absolute w-100""></div>
    <aside class=""sidenav bg-white navbar navbar-vertical navbar-expand-xs border-0 border-radius-xl my-3 fixed-start ms-4 "" id=""sidenav-main"">
        <div class=""sidenav-header"">
            <i class=""fas fa-times p-3 cursor-pointer text-secondary opacity-5 position-absolute end-0 top-0 d-none d-xl-none"" aria-hidden=""true"" id=""iconSidenav""></i>
            <a class=""navbar-brand m-0"" href=""#"" target=""_blank"">
                <img src=""/assets/img/logo-ct-dark.png"" class=""navbar-brand-img h-100"" alt=""main_logo"">
                <span class=""ms-1 font-weight-bold"">HTC-ITC</span>
            </a>
        </div>
        <hr class=""horizontal dark mt-0"">
        <div class=""collapse navbar-collapse  w-auto "" id=""sidenav-collapse-main"">
            <ul class=""navbar-nav"">
                <li class=""nav-item"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a9bb2014ade8ba06aef458c4a76fa687c206db89192", async() => {
                    WriteLiteral(@"
                        <div class=""icon icon-shape icon-sm border-radius-md text-center me-2 d-flex align-items-center justify-content-center"">
                            <i class=""ni ni-tv-2 text-primary text-sm opacity-10""></i>
                        </div>
                        <span class=""nav-link-text ms-1"">Customers</span>
                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                </li>
            </ul>
        </div>
    </aside>
    <main class=""main-content position-relative border-radius-lg "">
        <!-- Navbar -->
        <nav class=""navbar navbar-main navbar-expand-lg px-0 mx-4 shadow-none border-radius-xl "" id=""navbarBlur"" data-scroll=""false"">
            <div class=""container-fluid py-1 px-3"">
                <nav aria-label=""breadcrumb"">
                    <ol class=""breadcrumb bg-transparent mb-0 pb-0 pt-1 px-0 me-sm-6 me-5"">
                        <li class=""breadcrumb-item text-sm""><a class=""opacity-5 text-white"" href=""javascript:;"">Home</a></li>
                        <li class=""breadcrumb-item text-sm text-white active"" aria-current=""page"">Welcome</li>
                    </ol>
                    <h6 class=""font-weight-bolder text-white mb-0"">Welcome</h6>
                </nav>
                <div class=""collapse navbar-collapse mt-sm-0 mt-2 me-md-0 me-sm-4"" id=""navbar"">
                    <div class=""ms-md-auto pe-md-3 d-flex al");
                WriteLiteral(@"ign-items-center"">
                        <div class=""input-group"">
                            <span class=""input-group-text text-body""><i class=""fas fa-search"" aria-hidden=""true""></i></span>
                            <input type=""text"" class=""form-control"" placeholder=""Type here..."">
                        </div>
                    </div>
                    <ul class=""navbar-nav  justify-content-end"">
                        <li class=""nav-item d-flex align-items-center"">
                            <span class=""nav-link text-white font-weight-bold px-0"">
                                <i class=""fa fa-user me-sm-1""></i>
");
#nullable restore
#line 70 "C:\Users\Ngoc Phuong\source\repo_main\WebApp\Views\Shared\_Layout.cshtml"
                                 if (@User != null && @User.Identity.Name != null)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a9bb2014ade8ba06aef458c4a76fa687c206db813178", async() => {
                    WriteLiteral("Logout");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 73 "C:\Users\Ngoc Phuong\source\repo_main\WebApp\Views\Shared\_Layout.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            </span>
                        </li>
                        <li class=""nav-item d-xl-none ps-3 d-flex align-items-center"">
                            <a href=""javascript:;"" class=""nav-link text-white p-0"" id=""iconNavbarSidenav"">
                                <div class=""sidenav-toggler-inner"">
                                    <i class=""sidenav-toggler-line bg-white""></i>
                                    <i class=""sidenav-toggler-line bg-white""></i>
                                    <i class=""sidenav-toggler-line bg-white""></i>
                                </div>
                            </a>
                        </li>
                    </ul>
                </div>
            </div>
        </nav>
        <!-- End Navbar -->
        <div class=""container-fluid py-4"">

            <!-- RenderBody  -->
            ");
#nullable restore
#line 93 "C:\Users\Ngoc Phuong\source\repo_main\WebApp\Views\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

            <!-- End RenderBody  -->


        </div>
    </main>
    <div class=""fixed-plugin"">
        <a class=""fixed-plugin-button text-dark position-fixed px-3 py-2"">
            <i class=""fa fa-cog py-2""> </i>
        </a>
        <div class=""card shadow-lg"">
            <div class=""card-header pb-0 pt-3 "">
                <div class=""float-start"">
                    <h5 class=""mt-3 mb-0"">Home Page</h5>
                </div>
                <div class=""float-end mt-4"">
                    <button class=""btn btn-link text-dark p-0 fixed-plugin-close-button"">
                        <i class=""fa fa-close""></i>
                    </button>
                </div>
                <!-- End Toggle Button -->
            </div>
            <hr class=""horizontal dark my-1"">
            <div class=""card-body pt-sm-3 pt-0 overflow-auto"">
                <!-- Sidebar Backgrounds -->
                <div>
                    <h6 class=""mb-0"">Sidebar Colors</h6>
                </div>");
                WriteLiteral(@"
                <a href=""javascript:void(0)"" class=""switch-trigger background-color"">
                    <div class=""badge-colors my-2 text-start"">
                        <span class=""badge filter bg-gradient-primary active"" data-color=""primary"" onclick=""sidebarColor(this)""></span>
                        <span class=""badge filter bg-gradient-dark"" data-color=""dark"" onclick=""sidebarColor(this)""></span>
                        <span class=""badge filter bg-gradient-info"" data-color=""info"" onclick=""sidebarColor(this)""></span>
                        <span class=""badge filter bg-gradient-success"" data-color=""success"" onclick=""sidebarColor(this)""></span>
                        <span class=""badge filter bg-gradient-warning"" data-color=""warning"" onclick=""sidebarColor(this)""></span>
                        <span class=""badge filter bg-gradient-danger"" data-color=""danger"" onclick=""sidebarColor(this)""></span>
                    </div>
                </a>
                <!-- Sidenav Type -->
         ");
                WriteLiteral(@"       <div class=""mt-3"">
                    <h6 class=""mb-0"">Sidenav Type</h6>
                    <p class=""text-sm"">Choose between 2 different sidenav types.</p>
                </div>
                <div class=""d-flex"">
                    <button class=""btn bg-gradient-primary w-100 px-3 mb-2 active me-2"" data-class=""bg-white"" onclick=""sidebarType(this)"">White</button>
                    <button class=""btn bg-gradient-primary w-100 px-3 mb-2"" data-class=""bg-default"" onclick=""sidebarType(this)"">Dark</button>
                </div>
                <p class=""text-sm d-xl-none d-block mt-2"">You can change the sidenav type just on desktop view.</p>
                <!-- Navbar Fixed -->
                <div class=""d-flex my-3"">
                    <h6 class=""mb-0"">Navbar Fixed</h6>
                    <div class=""form-check form-switch ps-0 ms-auto my-auto"">
                        <input class=""form-check-input mt-1 ms-auto"" type=""checkbox"" id=""navbarFixed"" onclick=""navbarFixed(this)"">
      ");
                WriteLiteral(@"              </div>
                </div>
                <hr class=""horizontal dark my-sm-4"">
                <div class=""mt-2 mb-5 d-flex"">
                    <h6 class=""mb-0"">Light / Dark</h6>
                    <div class=""form-check form-switch ps-0 ms-auto my-auto"">
                        <input class=""form-check-input mt-1 ms-auto"" type=""checkbox"" id=""dark-version"" onclick=""darkMode(this)"">
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!--   Core JS Files   -->
    <script src=""/assets/js/core/popper.min.js""></script>
    <script src=""/assets/js/core/bootstrap.min.js""></script>
    <script src=""/assets/js/plugins/perfect-scrollbar.min.js""></script>
    <script src=""/assets/js/plugins/smooth-scrollbar.min.js""></script>
    <script src=""/assets/js/plugins/chartjs.min.js""></script>
    <script>
        var ctx1 = document.getElementById(""chart-line"").getContext(""2d"");

        var gradientStroke1 = ctx1.createLinearGradient(0,");
                WriteLiteral(@" 230, 0, 50);

        gradientStroke1.addColorStop(1, 'rgba(94, 114, 228, 0.2)');
        gradientStroke1.addColorStop(0.2, 'rgba(94, 114, 228, 0.0)');
        gradientStroke1.addColorStop(0, 'rgba(94, 114, 228, 0)');
        new Chart(ctx1, {
            type: ""line"",
            data: {
                labels: [""Apr"", ""May"", ""Jun"", ""Jul"", ""Aug"", ""Sep"", ""Oct"", ""Nov"", ""Dec""],
                datasets: [{
                    label: ""Mobile apps"",
                    tension: 0.4,
                    borderWidth: 0,
                    pointRadius: 0,
                    borderColor: ""#5e72e4"",
                    backgroundColor: gradientStroke1,
                    borderWidth: 3,
                    fill: true,
                    data: [50, 40, 300, 220, 500, 250, 400, 230, 500],
                    maxBarThickness: 6

                }],
            },
            options: {
                responsive: true,
                maintainAspectRatio: false,
                plugins: {
");
                WriteLiteral(@"                    legend: {
                        display: false,
                    }
                },
                interaction: {
                    intersect: false,
                    mode: 'index',
                },
                scales: {
                    y: {
                        grid: {
                            drawBorder: false,
                            display: true,
                            drawOnChartArea: true,
                            drawTicks: false,
                            borderDash: [5, 5]
                        },
                        ticks: {
                            display: true,
                            padding: 10,
                            color: '#fbfbfb',
                            font: {
                                size: 11,
                                family: ""Open Sans"",
                                style: 'normal',
                                lineHeight: 2
                            },");
                WriteLiteral(@"
                        }
                    },
                    x: {
                        grid: {
                            drawBorder: false,
                            display: false,
                            drawOnChartArea: false,
                            drawTicks: false,
                            borderDash: [5, 5]
                        },
                        ticks: {
                            display: true,
                            color: '#ccc',
                            padding: 20,
                            font: {
                                size: 11,
                                family: ""Open Sans"",
                                style: 'normal',
                                lineHeight: 2
                            },
                        }
                    },
                },
            },
        });
    </script>
    <script>
        var win = navigator.platform.indexOf('Win') > -1;
        if (win && document.q");
                WriteLiteral(@"uerySelector('#sidenav-scrollbar')) {
            var options = {
                damping: '0.5'
            }
            Scrollbar.init(document.querySelector('#sidenav-scrollbar'), options);
        }
    </script>
    <!-- Github buttons -->
    <script async defer src=""https://buttons.github.io/buttons.js""></script>
    <!-- Control Center for Soft Dashboard: parallax effects, scripts for the example pages etc -->
    <script src=""/assets/js/argon-dashboard.min.js?v=2.0.4""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
