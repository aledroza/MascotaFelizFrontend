#pragma checksum "C:\MascotaFeliz\MascotaFeliz.App\MascotaFelizWeb.App.Frontend\Pages\Agendamiento.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72b7a829d7d833109d3226b4b0a2a846aac5d3f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MascotaFelizWeb.App.Frontend.Pages.Pages_Agendamiento), @"mvc.1.0.razor-page", @"/Pages/Agendamiento.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72b7a829d7d833109d3226b4b0a2a846aac5d3f3", @"/Pages/Agendamiento.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bcbba2225b3b6fbd3d3cd2fce3a20508b15bcbf6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Agendamiento : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\MascotaFeliz\MascotaFeliz.App\MascotaFelizWeb.App.Frontend\Pages\Agendamiento.cshtml"
  
    ViewData["Title"] = "Reserva tu visita";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 6 "C:\MascotaFeliz\MascotaFeliz.App\MascotaFelizWeb.App.Frontend\Pages\Agendamiento.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1><br><br>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "72b7a829d7d833109d3226b4b0a2a846aac5d3f34292", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "72b7a829d7d833109d3226b4b0a2a846aac5d3f34558", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
            WriteLiteral(@"
    <section class=""form-register"">
    <h4>Citas</h4>
    <input class=""controls"" type=""text"" name=""nombres"" id=""nombres"" placeholder=""Ingrese su Nombre"">
    <input class=""controls"" type=""text"" name=""apellidos"" id=""apellidos"" placeholder=""Ingrese su Apellido"">
    <input class=""controls"" type=""text"" name=""nombres"" id=""nombres"" placeholder=""Ingrese el Nombre de su mascota"">

    <input class=""controls"" type=""text"" name=""nombres"" id=""nombres"" placeholder=""Ingrese la edad de su mascota"">

    <h>tipo de mascota</h4>
    <input class=""luzmi"" type=""radio"" name=""plkm"" value=""perro"" >
    <label for=""radio"">perro</label>
    <input class=""luzmi"" type=""radio"" name=""plkm"" value=""gato"">
    <label for=""radio"">gato</label>

    <input class=""controls"" type=""number"" name=""nombres"" id=""nombres"" placeholder=""Ingrese esu telefono"">
    <input class=""controls"" type=""text"" name=""nombres"" id=""nombres"" placeholder=""Ingrese su direccion"">
    
  

    
    <b>fecha</b>
    <input type=""date"" name = ""dia""");
            WriteLiteral("></b><br><br> <!--fecha-->\r\n    <br>\r\n    <input class=\"controls\" type=\"email\" name=\"correo\" id=\"correo\" placeholder=\"Ingrese identificacion\">\r\n    <input class=\"botons\" type=\"submit\" value=\"Registrar\">\r\n    <br>\r\n    \r\n\r\n\r\n  </section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MascotaFelizWeb.App.Frontend.Pages.AgendamientoModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MascotaFelizWeb.App.Frontend.Pages.AgendamientoModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MascotaFelizWeb.App.Frontend.Pages.AgendamientoModel>)PageContext?.ViewData;
        public MascotaFelizWeb.App.Frontend.Pages.AgendamientoModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
