#pragma checksum "C:\Users\aealc\source\repos\InventarioPaginaWeb\InventarioPaginaWeb\Views\Encargado\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d18809a7e7fdbb1617aa6b7d7ba72ae979705456"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Encargado_Delete), @"mvc.1.0.view", @"/Views/Encargado/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Encargado/Delete.cshtml", typeof(AspNetCore.Views_Encargado_Delete))]
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
#line 1 "C:\Users\aealc\source\repos\InventarioPaginaWeb\InventarioPaginaWeb\Views\_ViewImports.cshtml"
using InventarioPaginaWeb;

#line default
#line hidden
#line 2 "C:\Users\aealc\source\repos\InventarioPaginaWeb\InventarioPaginaWeb\Views\_ViewImports.cshtml"
using InventarioPaginaWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d18809a7e7fdbb1617aa6b7d7ba72ae979705456", @"/Views/Encargado/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"744364d3c56445e9da57c348ab3386dfaa578dce", @"/Views/_ViewImports.cshtml")]
    public class Views_Encargado_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<InventarioPaginaWeb.Models.Encargado>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 213, true);
            WriteLiteral("\r\n<h2>Eliminar</h2>\r\n\r\n<h3>¿Estas seguro que quieres eliminar este elemento?</h3>\r\n<div>\r\n    <h4>Detalles de Encargado</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(259, 47, false);
#line 11 "C:\Users\aealc\source\repos\InventarioPaginaWeb\InventarioPaginaWeb\Views\Encargado\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.IdEncargado));

#line default
#line hidden
            EndContext();
            BeginContext(306, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(368, 43, false);
#line 14 "C:\Users\aealc\source\repos\InventarioPaginaWeb\InventarioPaginaWeb\Views\Encargado\Delete.cshtml"
       Write(Html.DisplayFor(model => model.IdEncargado));

#line default
#line hidden
            EndContext();
            BeginContext(411, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(472, 50, false);
#line 17 "C:\Users\aealc\source\repos\InventarioPaginaWeb\InventarioPaginaWeb\Views\Encargado\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ClaveEncargado));

#line default
#line hidden
            EndContext();
            BeginContext(522, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(584, 46, false);
#line 20 "C:\Users\aealc\source\repos\InventarioPaginaWeb\InventarioPaginaWeb\Views\Encargado\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ClaveEncargado));

#line default
#line hidden
            EndContext();
            BeginContext(630, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(691, 42, false);
#line 23 "C:\Users\aealc\source\repos\InventarioPaginaWeb\InventarioPaginaWeb\Views\Encargado\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(733, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(795, 38, false);
#line 26 "C:\Users\aealc\source\repos\InventarioPaginaWeb\InventarioPaginaWeb\Views\Encargado\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(833, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(894, 44, false);
#line 29 "C:\Users\aealc\source\repos\InventarioPaginaWeb\InventarioPaginaWeb\Views\Encargado\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Apellido));

#line default
#line hidden
            EndContext();
            BeginContext(938, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1000, 40, false);
#line 32 "C:\Users\aealc\source\repos\InventarioPaginaWeb\InventarioPaginaWeb\Views\Encargado\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Apellido));

#line default
#line hidden
            EndContext();
            BeginContext(1040, 30, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n\r\n");
            EndContext();
#line 36 "C:\Users\aealc\source\repos\InventarioPaginaWeb\InventarioPaginaWeb\Views\Encargado\Delete.cshtml"
     using (Html.BeginForm())
    {
        

#line default
#line hidden
            BeginContext(1117, 23, false);
#line 38 "C:\Users\aealc\source\repos\InventarioPaginaWeb\InventarioPaginaWeb\Views\Encargado\Delete.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(1142, 101, true);
            WriteLiteral("<div class=\"form-group\">\r\n    <input type=\"submit\" value=\"Eliminar\" class=\"btn btn-danger\" /> |\r\n    ");
            EndContext();
            BeginContext(1244, 45, false);
#line 41 "C:\Users\aealc\source\repos\InventarioPaginaWeb\InventarioPaginaWeb\Views\Encargado\Delete.cshtml"
Write(Html.ActionLink("Volver a la lista", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(1289, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
#line 43 "C:\Users\aealc\source\repos\InventarioPaginaWeb\InventarioPaginaWeb\Views\Encargado\Delete.cshtml"
    }

#line default
#line hidden
            BeginContext(1306, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<InventarioPaginaWeb.Models.Encargado> Html { get; private set; }
    }
}
#pragma warning restore 1591
