#pragma checksum "E:\VS_Projetos\VitrineVirtual.Portal.Core\VitrineVirtual.Portal.Core\Views\Catalogo_Produto_Loja\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2b2a51ef91637b68c87e3807f944f6590415bc4952bf253b174c666b0c20f460"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalogo_Produto_Loja_Index), @"mvc.1.0.view", @"/Views/Catalogo_Produto_Loja/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Catalogo_Produto_Loja/Index.cshtml", typeof(AspNetCore.Views_Catalogo_Produto_Loja_Index))]
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
#line 1 "E:\VS_Projetos\VitrineVirtual.Portal.Core\VitrineVirtual.Portal.Core\Views\_ViewImports.cshtml"
using VitrineVirtual.Portal.Core;

#line default
#line hidden
#line 2 "E:\VS_Projetos\VitrineVirtual.Portal.Core\VitrineVirtual.Portal.Core\Views\_ViewImports.cshtml"
using VitrineVirtual.Portal.Core.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"2b2a51ef91637b68c87e3807f944f6590415bc4952bf253b174c666b0c20f460", @"/Views/Catalogo_Produto_Loja/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"2a03b367a7de2ae6de9c684619047b7fa6e1875ed14a7f6ffb385d82d377cc66", @"/Views/_ViewImports.cshtml")]
    public class Views_Catalogo_Produto_Loja_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<VitrineVirtual.Model.Cadastro_Produto_Loja>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(64, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\VS_Projetos\VitrineVirtual.Portal.Core\VitrineVirtual.Portal.Core\Views\Catalogo_Produto_Loja\Index.cshtml"
  
    ViewBag.Title = "Index";

#line default
#line hidden
            BeginContext(103, 421, true);
            WriteLiteral(@"
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.11.4/jquery-ui.min.css"" />
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/metisMenu/3.0.4/metisMenu.css"" />

<h2>Catalogo Produtos</h2>

<div class=""row wrapper wrapper-content border-bottom white-bg"">
    <div class=""animated fadeInRight"">
        <div class=""col-sm-12"">
            <div class=""form-group"">
");
            EndContext();
#line 16 "E:\VS_Projetos\VitrineVirtual.Portal.Core\VitrineVirtual.Portal.Core\Views\Catalogo_Produto_Loja\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(589, 351, true);
            WriteLiteral(@"                    <div class=""col-md-3 form-group"">
                        <div class=""ibox-block"">
                            <div class=""ibox-block-content product-box"">
                                <div class=""product-imitation"">
                                    <span class=""product-images"">
                                        ");
            EndContext();
            BeginContext(941, 49, false);
#line 23 "E:\VS_Projetos\VitrineVirtual.Portal.Core\VitrineVirtual.Portal.Core\Views\Catalogo_Produto_Loja\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Foto_Produto_1));

#line default
#line hidden
            EndContext();
            BeginContext(990, 287, true);
            WriteLiteral(@"
                                    </span>
                                </div>
                                <div class=""product-desc"">
                                    <span class=""product-price"" style=""background-color: #3872a2"">
                                        ");
            EndContext();
            BeginContext(1278, 48, false);
#line 28 "E:\VS_Projetos\VitrineVirtual.Portal.Core\VitrineVirtual.Portal.Core\Views\Catalogo_Produto_Loja\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Preco_Produto));

#line default
#line hidden
            EndContext();
            BeginContext(1326, 153, true);
            WriteLiteral("\r\n                                    </span>\r\n                                    <small class=\"product-name\">\r\n                                        ");
            EndContext();
            BeginContext(1480, 47, false);
#line 31 "E:\VS_Projetos\VitrineVirtual.Portal.Core\VitrineVirtual.Portal.Core\Views\Catalogo_Produto_Loja\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Nome_Produto));

#line default
#line hidden
            EndContext();
            BeginContext(1527, 148, true);
            WriteLiteral("\r\n                                    </small>\r\n                                    <a class=\"text-muted\">\r\n                                        ");
            EndContext();
            BeginContext(1676, 49, false);
#line 34 "E:\VS_Projetos\VitrineVirtual.Portal.Core\VitrineVirtual.Portal.Core\Views\Catalogo_Produto_Loja\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Modelo_Produto));

#line default
#line hidden
            EndContext();
            BeginContext(1725, 148, true);
            WriteLiteral("\r\n                                    </a>\r\n                                    <small class=\"text-muted\">\r\n                                        ");
            EndContext();
            BeginContext(1874, 52, false);
#line 37 "E:\VS_Projetos\VitrineVirtual.Portal.Core\VitrineVirtual.Portal.Core\Views\Catalogo_Produto_Loja\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Descricao_Produto));

#line default
#line hidden
            EndContext();
            BeginContext(1926, 152, true);
            WriteLiteral("\r\n                                    </small>\r\n                                    <div class=\"small m-t-xs\">\r\n                                        ");
            EndContext();
            BeginContext(2079, 53, false);
#line 40 "E:\VS_Projetos\VitrineVirtual.Portal.Core\VitrineVirtual.Portal.Core\Views\Catalogo_Produto_Loja\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Quantidade_Produto));

#line default
#line hidden
            EndContext();
            BeginContext(2132, 150, true);
            WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"small m-t-xs\">\r\n                                        ");
            EndContext();
            BeginContext(2283, 49, false);
#line 43 "E:\VS_Projetos\VitrineVirtual.Portal.Core\VitrineVirtual.Portal.Core\Views\Catalogo_Produto_Loja\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Status_Produto));

#line default
#line hidden
            EndContext();
            BeginContext(2332, 193, true);
            WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"m-t text-righ\">\r\n                                        <a class=\"btn btn-xs btn-outline btn-info\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2525, "\"", 2620, 1);
#line 46 "E:\VS_Projetos\VitrineVirtual.Portal.Core\VitrineVirtual.Portal.Core\Views\Catalogo_Produto_Loja\Index.cshtml"
WriteAttributeValue("", 2532, Url.Action("Details", "Catalogo_Produto_Loja", new { id = item.ID_Cadastro_Prod_Loja }), 2532, 88, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2621, 229, true);
            WriteLiteral(">Info<i class=\"fa fa-long-arrow-right\"></i></a>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 52 "E:\VS_Projetos\VitrineVirtual.Portal.Core\VitrineVirtual.Portal.Core\Views\Catalogo_Produto_Loja\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(2869, 361, true);
            WriteLiteral(@"            </div>
        </div>
    </div>
</div>

<script src=""https://ajax.googleapis.com/ajax/libs/jquery/2.1.3/jquery.min.js"" type=""text/javascript""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.11.4/jquery-ui.min.js""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/metisMenu/3.0.4/metisMenu.js""></script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<VitrineVirtual.Model.Cadastro_Produto_Loja>> Html { get; private set; }
    }
}
#pragma warning restore 1591