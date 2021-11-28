#pragma checksum "D:\Hackaton2022\E-Migrant\Frontend\Pages\Entidades\ServiciosActivos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66e7946d03d84c0250b0dac7a9f8a61c7b856b7c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Frontend.Pages.Entidades.Pages_Entidades_ServiciosActivos), @"mvc.1.0.razor-page", @"/Pages/Entidades/ServiciosActivos.cshtml")]
namespace Frontend.Pages.Entidades
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66e7946d03d84c0250b0dac7a9f8a61c7b856b7c", @"/Pages/Entidades/ServiciosActivos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"536a6345ab895acdff515eb6aa6016c76fc21d10", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Entidades_ServiciosActivos : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""row justify-content-center bg-light"">
    <div class=""col-sm-12"">
        <h3>Servicios Activos de la Entidad [<a href=""/Entidades/ServiciosEntidades"">Pagina Anterior</a>]
                <br/>
        </h3>
        <br/>
    </div>
</div>


<div class=""row justify-content-center"">
");
#nullable restore
#line 16 "D:\Hackaton2022\E-Migrant\Frontend\Pages\Entidades\ServiciosActivos.cshtml"
     if (Model._ListarServiciosEntidades is not null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table table-bordered table-striped"">
            <thead>
                <tr>
                    <td>ID</td>
                    <td>Nombre</td>
                    <td>Estado</td>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 27 "D:\Hackaton2022\E-Migrant\Frontend\Pages\Entidades\ServiciosActivos.cshtml"
                 foreach (var eme in Model._ListarServiciosEntidades)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "D:\Hackaton2022\E-Migrant\Frontend\Pages\Entidades\ServiciosActivos.cshtml"
                     if(eme.UserId == User.Identity.Name && eme.Status == "ACTIVOS")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 32 "D:\Hackaton2022\E-Migrant\Frontend\Pages\Entidades\ServiciosActivos.cshtml"
                           Write(eme.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 33 "D:\Hackaton2022\E-Migrant\Frontend\Pages\Entidades\ServiciosActivos.cshtml"
                           Write(eme.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 34 "D:\Hackaton2022\E-Migrant\Frontend\Pages\Entidades\ServiciosActivos.cshtml"
                           Write(eme.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 36 "D:\Hackaton2022\E-Migrant\Frontend\Pages\Entidades\ServiciosActivos.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "D:\Hackaton2022\E-Migrant\Frontend\Pages\Entidades\ServiciosActivos.cshtml"
                     
                    
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 41 "D:\Hackaton2022\E-Migrant\Frontend\Pages\Entidades\ServiciosActivos.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p class=\"lead\">No hay servicios activos registrados!</p>\r\n");
#nullable restore
#line 45 "D:\Hackaton2022\E-Migrant\Frontend\Pages\Entidades\ServiciosActivos.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>

<div class=""row justify-content-center bg-light"">
    <div class=""col-sm-12"">
        <h3>Servicios Activos y Cupo de Migrantes [<a href=""/Entidades/ServiciosEntidades"">Pagina Anterior</a>]
                <br/>
        </h3>
        <br/>
    </div>
</div>

<div class=""row justify-content-center"">
");
#nullable restore
#line 58 "D:\Hackaton2022\E-Migrant\Frontend\Pages\Entidades\ServiciosActivos.cshtml"
     if (Model._ListarServiciosEntidades is not null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table table-bordered table-striped"">
            <thead>
                <tr>
                    <td>ID</td>
                    <td>Nombre</td>
                    <td>CantidadMAX</td>
                    <td>Estado</td>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 70 "D:\Hackaton2022\E-Migrant\Frontend\Pages\Entidades\ServiciosActivos.cshtml"
                 foreach (var eme in Model._ListarServiciosEntidades)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "D:\Hackaton2022\E-Migrant\Frontend\Pages\Entidades\ServiciosActivos.cshtml"
                     if(eme.UserId == User.Identity.Name && eme.Status == "ACTIVOS")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 75 "D:\Hackaton2022\E-Migrant\Frontend\Pages\Entidades\ServiciosActivos.cshtml"
                           Write(eme.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 76 "D:\Hackaton2022\E-Migrant\Frontend\Pages\Entidades\ServiciosActivos.cshtml"
                           Write(eme.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 77 "D:\Hackaton2022\E-Migrant\Frontend\Pages\Entidades\ServiciosActivos.cshtml"
                           Write(eme.CapacidadMAX);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 78 "D:\Hackaton2022\E-Migrant\Frontend\Pages\Entidades\ServiciosActivos.cshtml"
                           Write(eme.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 80 "D:\Hackaton2022\E-Migrant\Frontend\Pages\Entidades\ServiciosActivos.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "D:\Hackaton2022\E-Migrant\Frontend\Pages\Entidades\ServiciosActivos.cshtml"
                     
                    
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 85 "D:\Hackaton2022\E-Migrant\Frontend\Pages\Entidades\ServiciosActivos.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p class=\"lead\">No hay servicios activos registrados!</p>\r\n");
#nullable restore
#line 89 "D:\Hackaton2022\E-Migrant\Frontend\Pages\Entidades\ServiciosActivos.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 92 "D:\Hackaton2022\E-Migrant\Frontend\Pages\Entidades\ServiciosActivos.cshtml"
  
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Frontend.Pages.Entidades.ServiciosActivosModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Frontend.Pages.Entidades.ServiciosActivosModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Frontend.Pages.Entidades.ServiciosActivosModel>)PageContext?.ViewData;
        public Frontend.Pages.Entidades.ServiciosActivosModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591