#pragma checksum "C:\Users\thiag\Desktop\AluguelCarro\AluguelCarro\Views\Shared\Components\Aluguel\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "409737da65f44e109af4cda8dc0d62b882f00021"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Aluguel_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Aluguel/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Aluguel/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_Aluguel_Default))]
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
#line 1 "C:\Users\thiag\Desktop\AluguelCarro\AluguelCarro\Views\_ViewImports.cshtml"
using AluguelCarro;

#line default
#line hidden
#line 2 "C:\Users\thiag\Desktop\AluguelCarro\AluguelCarro\Views\_ViewImports.cshtml"
using AluguelCarro.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"409737da65f44e109af4cda8dc0d62b882f00021", @"/Views/Shared/Components/Aluguel/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d2238d675ed3ec8fac612f13c4b1dbea016e2f7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Aluguel_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AluguelCarro.Models.Carro>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 97, true);
            WriteLiteral("\r\n\r\n<div class=\"jumbotron\">\r\n    <div class=\"row\">\r\n        <div class=\"col-6\">\r\n            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 131, "\"", 161, 1);
#line 7 "C:\Users\thiag\Desktop\AluguelCarro\AluguelCarro\Views\Shared\Components\Aluguel\Default.cshtml"
WriteAttributeValue("", 137, Url.Content(Model.Foto), 137, 24, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(162, 174, true);
            WriteLiteral(" height=\"300\" width=\"300\" />\r\n        </div>\r\n\r\n        <div class=\"col-6\">\r\n            <div class=\"col-4\">\r\n                <h3 class=\"titulo row\"><strong>Marca : </strong>");
            EndContext();
            BeginContext(337, 11, false);
#line 12 "C:\Users\thiag\Desktop\AluguelCarro\AluguelCarro\Views\Shared\Components\Aluguel\Default.cshtml"
                                                           Write(Model.Marca);

#line default
#line hidden
            EndContext();
            BeginContext(348, 123, true);
            WriteLiteral("</h3>\r\n            </div>\r\n            <div class=\"col-4\">\r\n                <h3 class=\"titulo row\"><strong>Nome : </strong>");
            EndContext();
            BeginContext(472, 10, false);
#line 15 "C:\Users\thiag\Desktop\AluguelCarro\AluguelCarro\Views\Shared\Components\Aluguel\Default.cshtml"
                                                          Write(Model.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(482, 133, true);
            WriteLiteral("</h3>\r\n            </div>\r\n            <div class=\"col-4\">\r\n                <h3 class=\"titulo row\"><strong>Preço Diária : </strong>R$");
            EndContext();
            BeginContext(616, 17, false);
#line 18 "C:\Users\thiag\Desktop\AluguelCarro\AluguelCarro\Views\Shared\Components\Aluguel\Default.cshtml"
                                                                    Write(Model.PrecoDiaria);

#line default
#line hidden
            EndContext();
            BeginContext(633, 66, true);
            WriteLiteral(",00</h3>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AluguelCarro.Models.Carro> Html { get; private set; }
    }
}
#pragma warning restore 1591