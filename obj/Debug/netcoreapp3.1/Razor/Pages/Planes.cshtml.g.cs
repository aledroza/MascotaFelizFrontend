#pragma checksum "C:\MascotaFeliz\MascotaFeliz.App\MascotaFelizWeb.App.Frontend\Pages\Planes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1381fab132ec4f7b791692c3ff0eeec822005b07"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MascotaFelizWeb.App.Frontend.Pages.Pages_Planes), @"mvc.1.0.razor-page", @"/Pages/Planes.cshtml")]
namespace MascotaFelizWeb.App.Frontend.Pages
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
#line 1 "C:\MascotaFeliz\MascotaFeliz.App\MascotaFelizWeb.App.Frontend\Pages\_ViewImports.cshtml"
using MascotaFelizWeb.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1381fab132ec4f7b791692c3ff0eeec822005b07", @"/Pages/Planes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bcbba2225b3b6fbd3d3cd2fce3a20508b15bcbf6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Planes : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\MascotaFeliz\MascotaFeliz.App\MascotaFelizWeb.App.Frontend\Pages\Planes.cshtml"
  
    ViewData["Title"] = "Planes";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 6 "C:\MascotaFeliz\MascotaFeliz.App\MascotaFelizWeb.App.Frontend\Pages\Planes.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1><br><br>

<section class=""form-register"">
    <h4>Planes de la Veterinaria Mascota Feliz</h4>

    <table class=""table"">

        <colgroup>
            <col style=""background-color: rgb(184, 210, 245);"">
            <col style=""background-color: rgb(169, 237, 237);"">
            <col style=""background-color: rgb(255, 255, 255);"">
            <col style=""background-color: rgb(169, 237, 237);"">

        </colgroup>



");
#nullable restore
#line 23 "C:\MascotaFeliz\MascotaFeliz.App\MascotaFelizWeb.App.Frontend\Pages\Planes.cshtml"
         foreach (var plan in Model.planes)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 26 "C:\MascotaFeliz\MascotaFeliz.App\MascotaFelizWeb.App.Frontend\Pages\Planes.cshtml"
               Write(plan.Bienestar);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "C:\MascotaFeliz\MascotaFeliz.App\MascotaFelizWeb.App.Frontend\Pages\Planes.cshtml"
               Write(plan.Elite);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "C:\MascotaFeliz\MascotaFeliz.App\MascotaFelizWeb.App.Frontend\Pages\Planes.cshtml"
               Write(plan.Diamante);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 30 "C:\MascotaFeliz\MascotaFeliz.App\MascotaFelizWeb.App.Frontend\Pages\Planes.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MascotaFelizWeb.App.Frontend.Pages.PlanesModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MascotaFelizWeb.App.Frontend.Pages.PlanesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MascotaFelizWeb.App.Frontend.Pages.PlanesModel>)PageContext?.ViewData;
        public MascotaFelizWeb.App.Frontend.Pages.PlanesModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
