#pragma checksum "D:\OneDrive\OneDrive - Farmer's Edge Inc\Documents\GitHub\WebResume\WebResume.MVC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cef904fb57c9e5c84e1776038a49c22a10e5458a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\OneDrive\OneDrive - Farmer's Edge Inc\Documents\GitHub\WebResume\WebResume.MVC\Views\_ViewImports.cshtml"
using WebResume.MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\OneDrive\OneDrive - Farmer's Edge Inc\Documents\GitHub\WebResume\WebResume.MVC\Views\_ViewImports.cshtml"
using WebResume.MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cef904fb57c9e5c84e1776038a49c22a10e5458a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9513bed534f54b21f645bf40d55c2c7a3c076655", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\OneDrive\OneDrive - Farmer's Edge Inc\Documents\GitHub\WebResume\WebResume.MVC\Views\Home\Index.cshtml"
  
    Layout = "~/Views/Shared/_LayoutMenu1.cshtml";
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""home"">
</section>
<div style=""height: 1000px"">
    <!-- just to make scrolling effect possible -->
    <h2 class=""myH2"">What is this ?</h2>
    <p class=""myP"">This is a responsive fixed navbar animated on scroll</p>
    <p class=""myP"">
        I took inspiration from  ABDO STEIF (<a href=""https://codepen.io/abdosteif/pen/bRoyMb?editors=1100"">https://codepen.io/abdosteif/pen/bRoyMb?editors=1100</a>)
        and Dicson <a href=""https://codepen.io/dicson/pen/waKPgQ"">(https://codepen.io/dicson/pen/waKPgQ)</a>
    </p>
    <p class=""myP"">I HOPE YOU FIND THIS USEFULL</p>
    <p class=""myP"">Albi</p>
    <p class=""myP"">

        Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ipsum ratione facere animi impedit rem labore sint repellendus ipsa sapiente voluptatem aut excepturi quo itaque, ab earum cumque. Voluptatem beatae id inventore quod voluptate qui deserunt, quis placeat, tempora ex totam, dolore sequi harum eos voluptatibus animi labore officiis minus laboriosam
      ");
            WriteLiteral(@"  Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ipsum ratione facere animi impedit rem labore sint repellendus ipsa sapiente voluptatem aut excepturi quo itaque, ab earum cumque. Voluptatem beatae id inventore quod voluptate qui deserunt, quis placeat, tempora ex totam, dolore sequi harum eos voluptatibus animi labore officiis minus laboriosam
        Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ipsum ratione facere animi impedit rem labore sint repellendus ipsa sapiente voluptatem aut excepturi quo itaque, ab earum cumque. Voluptatem beatae id inventore quod voluptate qui deserunt, quis placeat, tempora ex totam, dolore sequi harum eos voluptatibus animi labore officiis minus laboriosam
        Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ipsum ratione facere animi impedit rem labore sint repellendus ipsa sapiente voluptatem aut excepturi quo itaque, ab earum cumque. Voluptatem beatae id inventore quod voluptate qui deserunt, quis placeat, tempora ex totam, dolore sequ");
            WriteLiteral(@"i harum eos voluptatibus animi labore officiis minus laboriosam
        Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ipsum ratione facere animi impedit rem labore sint repellendus ipsa sapiente voluptatem aut excepturi quo itaque, ab earum cumque. Voluptatem beatae id inventore quod voluptate qui deserunt, quis placeat, tempora ex totam, dolore sequi harum eos voluptatibus animi labore officiis minus laboriosam
    </p>
</div>

<!-- Jquery needed -->
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js""></script>
<script src=""js/scripts.js""></script>

<!-- Function used to shrink nav bar removing paddings and adding black background -->
<script>$(window).scroll(function() {
            if ($(document).scrollTop() > 50) {
                $('.nav').addClass('affix');
                console.log(""OK"");
            } else {
                $('.nav').removeClass('affix');
            }
        });</script>");
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
