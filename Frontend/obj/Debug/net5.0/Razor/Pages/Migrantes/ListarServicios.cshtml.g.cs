#pragma checksum "D:\Hackaton2022\E-Migrant\Frontend\Pages\Migrantes\ListarServicios.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c5311dadeeffc0fb38758aea3a502e70a972beb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Frontend.Pages.Migrantes.Pages_Migrantes_ListarServicios), @"mvc.1.0.razor-page", @"/Pages/Migrantes/ListarServicios.cshtml")]
namespace Frontend.Pages.Migrantes
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
#line 1 "D:\Hackaton2022\E-Migrant\Frontend\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Hackaton2022\E-Migrant\Frontend\Pages\_ViewImports.cshtml"
using Frontend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Hackaton2022\E-Migrant\Frontend\Pages\_ViewImports.cshtml"
using Frontend.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c5311dadeeffc0fb38758aea3a502e70a972beb", @"/Pages/Migrantes/ListarServicios.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"536a6345ab895acdff515eb6aa6016c76fc21d10", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Migrantes_ListarServicios : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "SolicitarServicios", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row justify-content-center bg-light\">\r\n    <div class=\"col-sm-12\">\r\n        <h3>Servicios Disponibles [<a href=\"/Migrantes\">Pagina Principal</a>]\r\n                <br/>\r\n");
            WriteLiteral("        <br/>            \r\n        </h3>\r\n        <br/>\r\n    </div>\r\n\r\n</div>\r\n\r\n\r\n<div class=\"row justify-content-center\">\r\n");
#nullable restore
#line 21 "D:\Hackaton2022\E-Migrant\Frontend\Pages\Migrantes\ListarServicios.cshtml"
     if (Model._ListarServicesEntidades is not null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table table-bordered table-striped"">
            <thead>
                <tr>
                    <td>ID</td>
                    <td>Nombre</td>
                    <td>Capacidad</td>
                    <td>Categoria</td>
                    <td>Estado</td>
                    <td>Qué desea hacer?</td>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 35 "D:\Hackaton2022\E-Migrant\Frontend\Pages\Migrantes\ListarServicios.cshtml"
                 foreach (var eme in Model._ListarServicesEntidades)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "D:\Hackaton2022\E-Migrant\Frontend\Pages\Migrantes\ListarServicios.cshtml"
                     if(eme.Status != "SIN_CUPO" && eme.Status != "CERRADOS")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 40 "D:\Hackaton2022\E-Migrant\Frontend\Pages\Migrantes\ListarServicios.cshtml"
                           Write(eme.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 41 "D:\Hackaton2022\E-Migrant\Frontend\Pages\Migrantes\ListarServicios.cshtml"
                           Write(eme.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 42 "D:\Hackaton2022\E-Migrant\Frontend\Pages\Migrantes\ListarServicios.cshtml"
                           Write(eme.CapacidadMAX);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 43 "D:\Hackaton2022\E-Migrant\Frontend\Pages\Migrantes\ListarServicios.cshtml"
                           Write(eme.Categoria);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 44 "D:\Hackaton2022\E-Migrant\Frontend\Pages\Migrantes\ListarServicios.cshtml"
                           Write(eme.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c5311dadeeffc0fb38758aea3a502e70a972beb7005", async() => {
                WriteLiteral("Solicitar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-emeId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 46 "D:\Hackaton2022\E-Migrant\Frontend\Pages\Migrantes\ListarServicios.cshtml"
                                                                                                      WriteLiteral(eme.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["emeId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-emeId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["emeId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 49 "D:\Hackaton2022\E-Migrant\Frontend\Pages\Migrantes\ListarServicios.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "D:\Hackaton2022\E-Migrant\Frontend\Pages\Migrantes\ListarServicios.cshtml"
                     
                    
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 54 "D:\Hackaton2022\E-Migrant\Frontend\Pages\Migrantes\ListarServicios.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p class=\"lead\">No hay Servicios disponibles!</p>\r\n");
#nullable restore
#line 58 "D:\Hackaton2022\E-Migrant\Frontend\Pages\Migrantes\ListarServicios.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 61 "D:\Hackaton2022\E-Migrant\Frontend\Pages\Migrantes\ListarServicios.cshtml"
  
await Html.RenderPartialAsync("_ValidationScriptsPartial");

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Frontend.Pages.Migrantes.ListarServiciosModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Frontend.Pages.Migrantes.ListarServiciosModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Frontend.Pages.Migrantes.ListarServiciosModel>)PageContext?.ViewData;
        public Frontend.Pages.Migrantes.ListarServiciosModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
