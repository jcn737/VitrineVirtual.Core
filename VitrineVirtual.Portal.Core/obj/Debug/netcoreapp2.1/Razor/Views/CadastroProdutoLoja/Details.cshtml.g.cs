#pragma checksum "E:\VS_Projetos\VitrineVirtual.Portal.Core\VitrineVirtual.Portal.Core\Views\CadastroProdutoLoja\Details.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3ff15240dc16560f149f0b1baadedfb4796886071906c1c4f70100b1ccad738d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CadastroProdutoLoja_Details), @"mvc.1.0.view", @"/Views/CadastroProdutoLoja/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CadastroProdutoLoja/Details.cshtml", typeof(AspNetCore.Views_CadastroProdutoLoja_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"3ff15240dc16560f149f0b1baadedfb4796886071906c1c4f70100b1ccad738d", @"/Views/CadastroProdutoLoja/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"2a03b367a7de2ae6de9c684619047b7fa6e1875ed14a7f6ffb385d82d377cc66", @"/Views/_ViewImports.cshtml")]
    public class Views_CadastroProdutoLoja_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VitrineVirtual.Model.Cadastro_Produto_Loja>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
#line 5 "E:\VS_Projetos\VitrineVirtual.Portal.Core\VitrineVirtual.Portal.Core\Views\CadastroProdutoLoja\Details.cshtml"
  
    ViewBag.Title = "Details";

#line default
#line hidden
            BeginContext(96, 468, true);
            WriteLiteral(@"
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/slick-carousel/1.9.0/slick.min.css"" />
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/slick-carousel/1.9.0/slick-theme.css"" />
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/jasny-bootstrap/4.0.0/css/jasny-bootstrap.css"" />
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.11.4/jquery-ui.min.css"" />
<link rel=""stylesheet""");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 564, "\"", 630, 1);
#line 13 "E:\VS_Projetos\VitrineVirtual.Portal.Core\VitrineVirtual.Portal.Core\Views\CadastroProdutoLoja\Details.cshtml"
WriteAttributeValue("", 571, Url.Content("~/wwwroot/lib/plugins/slick/slick-theme.css"), 571, 59, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(631, 27, true);
            WriteLiteral(" />\r\n<link rel=\"stylesheet\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 658, "\"", 718, 1);
#line 14 "E:\VS_Projetos\VitrineVirtual.Portal.Core\VitrineVirtual.Portal.Core\Views\CadastroProdutoLoja\Details.cshtml"
WriteAttributeValue("", 665, Url.Content("~/wwwroot/lib/plugins/slick/slick.css"), 665, 53, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(719, 7, true);
            WriteLiteral(" />\r\n\r\n");
            EndContext();
#line 16 "E:\VS_Projetos\VitrineVirtual.Portal.Core\VitrineVirtual.Portal.Core\Views\CadastroProdutoLoja\Details.cshtml"
 using (Html.BeginForm("Details", "CadastroProdutoLoja", null, FormMethod.Post))
{


#line default
#line hidden
            BeginContext(813, 493, true);
            WriteLiteral(@"    <div class=""row wrapper border-bottom white-bg page-heading"">
        <div class=""col-lg-10"">
            <h2>Detalhes do Produto</h2>
            <ol class=""breadcrumb"">
                <li>
                    <a>Detalhes</a>
                </li>
                <li class=""active"">
                    <strong>Detalhes do Produto</strong>
                </li>
            </ol>

        </div>
        <div class=""col-lg-2"">
        </div>
    </div>
    <p>
        ");
            EndContext();
            BeginContext(1307, 75, false);
#line 36 "E:\VS_Projetos\VitrineVirtual.Portal.Core\VitrineVirtual.Portal.Core\Views\CadastroProdutoLoja\Details.cshtml"
   Write(Html.ActionLink("Editar", "Edit", new { id = Model.ID_Cadastro_Prod_Loja }));

#line default
#line hidden
            EndContext();
            BeginContext(1382, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1393, 108, false);
#line 37 "E:\VS_Projetos\VitrineVirtual.Portal.Core\VitrineVirtual.Portal.Core\Views\CadastroProdutoLoja\Details.cshtml"
   Write(Html.ActionLink("Voltar", "Index", new { @class = "btn btn-success", @style = "background-color: #3872a2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1501, 516, true);
            WriteLiteral(@"

    </p>
    <div class=""wrapper wrapper-content animated fadeInRight"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""ibox product-detail"">
                    <div class=""ibox-content"">
                        <div class=""row"">
                            <div class=""col-md-5"">

                                <div class=""product-images"">
                                    <div>

                                        <div class=""image-imitation"">
");
            EndContext();
            BeginContext(2192, 261, true);
            WriteLiteral(@"                                        </div>
                                    </div>
                                    <div>
                                        <div class=""image-imitation"">
                                            [IMAGE 2]
");
            EndContext();
            BeginContext(2554, 261, true);
            WriteLiteral(@"                                        </div>
                                    </div>
                                    <div>
                                        <div class=""image-imitation"">
                                            [IMAGE 3]
");
            EndContext();
            BeginContext(2916, 321, true);
            WriteLiteral(@"                                        </div>
                                    </div>

                                </div>
                            </div>
                            <div class=""col-md-7"">
                                <h2 class=""font-bold m-b-xs"">
                                    ");
            EndContext();
            BeginContext(3238, 48, false);
#line 72 "E:\VS_Projetos\VitrineVirtual.Portal.Core\VitrineVirtual.Portal.Core\Views\CadastroProdutoLoja\Details.cshtml"
                               Write(Html.DisplayFor(modelItem => Model.Nome_Produto));

#line default
#line hidden
            EndContext();
            BeginContext(3286, 80, true);
            WriteLiteral("\r\n                                </h2>\r\n                                <small>");
            EndContext();
            BeginContext(3367, 50, false);
#line 74 "E:\VS_Projetos\VitrineVirtual.Portal.Core\VitrineVirtual.Portal.Core\Views\CadastroProdutoLoja\Details.cshtml"
                                  Write(Html.DisplayFor(modelItem => Model.Modelo_Produto));

#line default
#line hidden
            EndContext();
            BeginContext(3417, 131, true);
            WriteLiteral("</small>\r\n                                <div class=\"m-t-md\">\r\n                                    <h2 class=\"product-main-price\">");
            EndContext();
            BeginContext(3549, 49, false);
#line 76 "E:\VS_Projetos\VitrineVirtual.Portal.Core\VitrineVirtual.Portal.Core\Views\CadastroProdutoLoja\Details.cshtml"
                                                              Write(Html.DisplayFor(modelItem => Model.Preco_Produto));

#line default
#line hidden
            EndContext();
            BeginContext(3598, 294, true);
            WriteLiteral(@" <small class=""text -muted"">Sem frete</small> </h2>
                                </div>
                                <hr>
                                <h4>Descrição do Produto</h4>
                                <div class=""small text-muted"">
                                    ");
            EndContext();
            BeginContext(3893, 53, false);
#line 81 "E:\VS_Projetos\VitrineVirtual.Portal.Core\VitrineVirtual.Portal.Core\Views\CadastroProdutoLoja\Details.cshtml"
                               Write(Html.DisplayFor(modelItem => Model.Descricao_Produto));

#line default
#line hidden
            EndContext();
            BeginContext(3946, 1735, true);
            WriteLiteral(@"
                                </div>
                                <dl class=""small m-t-md"">
                                    <dt>Lista de Descrição</dt>
                                    <dd>A description list is perfect for defining terms.</dd>
                                    <dt>Euismod</dt>
                                    <dd>Vestibulum id ligula porta felis euismod semper eget lacinia odio sem nec elit.</dd>
                                    <dd>Donec id elit non mi porta gravida at eget metus.</dd>
                                    <dt>Malesuada porta</dt>
                                    <dd>Etiam porta sem malesuada magna mollis euismod.</dd>
                                </dl>
                                <hr>
                                <div>
                                    <div class=""btn-group"">
                                        <button class=""btn btn-info btn-sm""><i class=""fa fa-cart-plus""></i> Adicionar a Mala</button>
                  ");
            WriteLiteral(@"                      <button class=""btn btn-white btn-sm""><i class=""fa fa-star""></i> Add to wishlist </button>
                                    </div>
                                </div>

                            </div>
                        </div>
                    </div>
                    <div class=""ibox-footer"">
                        <span class=""pull-right"">
                            Full stock - <i class=""fa fa-clock-o""></i> 14.04.2016 10:04 pm
                        </span>
                        The generated Lorem Ipsum is therefore always free
                    </div>
                </div>
            </div>
        </div>
    </div>
    <p>
        ");
            EndContext();
            BeginContext(5682, 73, false);
#line 114 "E:\VS_Projetos\VitrineVirtual.Portal.Core\VitrineVirtual.Portal.Core\Views\CadastroProdutoLoja\Details.cshtml"
   Write(Html.ActionLink("Edit", "Edit", new { id = Model.ID_Cadastro_Prod_Loja }));

#line default
#line hidden
            EndContext();
            BeginContext(5755, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(5766, 108, false);
#line 115 "E:\VS_Projetos\VitrineVirtual.Portal.Core\VitrineVirtual.Portal.Core\Views\CadastroProdutoLoja\Details.cshtml"
   Write(Html.ActionLink("Voltar", "Index", new { @class = "btn btn-success", @style = "background-color: #3872a2" }));

#line default
#line hidden
            EndContext();
            BeginContext(5874, 12, true);
            WriteLiteral("\r\n    </p>\r\n");
            EndContext();
#line 117 "E:\VS_Projetos\VitrineVirtual.Portal.Core\VitrineVirtual.Portal.Core\Views\CadastroProdutoLoja\Details.cshtml"

}

#line default
#line hidden
            BeginContext(5891, 105, true);
            WriteLiteral("<script src=\"https://cdnjs.cloudflare.com/ajax/libs/slick-carousel/1.9.0/slick.min.js\"></script>\r\n<script");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 5996, "\"", 6058, 1);
#line 120 "E:\VS_Projetos\VitrineVirtual.Portal.Core\VitrineVirtual.Portal.Core\Views\CadastroProdutoLoja\Details.cshtml"
WriteAttributeValue("", 6002, Url.Content("~/wwwroot/js/pluggins/slick/slick.min.js"), 6002, 56, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6059, 240, true);
            WriteLiteral(" type=\"text/javascript\"></script>\r\n<script src=\"https://cdnjs.cloudflare.com/ajax/libs/jasny-bootstrap/4.0.0/js/jasny-bootstrap.js\"></script>\r\n<script src=\"https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.11.4/jquery-ui.min.js\"></script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VitrineVirtual.Model.Cadastro_Produto_Loja> Html { get; private set; }
    }
}
#pragma warning restore 1591
