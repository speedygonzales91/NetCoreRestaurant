#pragma checksum "C:\Users\zsolt\source\repos\PluraSightNetCore01\PluraSightNetCore01\Pages\Restaurants\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13fc6bf307334ac5f62e94cc8a210a567fd6d077"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PluraSightNetCore01.Pages.Restaurants.Pages_Restaurants_List), @"mvc.1.0.razor-page", @"/Pages/Restaurants/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Restaurants/List.cshtml", typeof(PluraSightNetCore01.Pages.Restaurants.Pages_Restaurants_List), null)]
namespace PluraSightNetCore01.Pages.Restaurants
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\zsolt\source\repos\PluraSightNetCore01\PluraSightNetCore01\Pages\_ViewImports.cshtml"
using PluraSightNetCore01;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13fc6bf307334ac5f62e94cc8a210a567fd6d077", @"/Pages/Restaurants/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91aa2aac4fbcd155a724aca328450cb0b1df8c1a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Restaurants_List : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\zsolt\source\repos\PluraSightNetCore01\PluraSightNetCore01\Pages\Restaurants\List.cshtml"
  
    ViewData["Title"] = "List";

#line default
#line hidden
            BeginContext(103, 26, true);
            WriteLiteral("\r\n<h2>Restaurants</h2>\r\n\r\n");
            EndContext();
            BeginContext(130, 13, false);
#line 9 "C:\Users\zsolt\source\repos\PluraSightNetCore01\PluraSightNetCore01\Pages\Restaurants\List.cshtml"
Write(Model.Message);

#line default
#line hidden
            EndContext();
            BeginContext(143, 243, true);
            WriteLiteral("\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th scope=\"col\">#</th>\r\n            <th scope=\"col\">Name</th>\r\n            <th scope=\"col\">Location</th>\r\n            <th scope=\"col\">Cuisine</th>\r\n        </tr>\r\n    </thead>\r\n");
            EndContext();
#line 20 "C:\Users\zsolt\source\repos\PluraSightNetCore01\PluraSightNetCore01\Pages\Restaurants\List.cshtml"
     foreach (var restaurant in Model.Restaurants)
    {

#line default
#line hidden
            BeginContext(445, 42, true);
            WriteLiteral("        <tr>\r\n            <th scope=\"row\">");
            EndContext();
            BeginContext(488, 13, false);
#line 23 "C:\Users\zsolt\source\repos\PluraSightNetCore01\PluraSightNetCore01\Pages\Restaurants\List.cshtml"
                       Write(restaurant.Id);

#line default
#line hidden
            EndContext();
            BeginContext(501, 23, true);
            WriteLiteral("</th>\r\n            <td>");
            EndContext();
            BeginContext(525, 15, false);
#line 24 "C:\Users\zsolt\source\repos\PluraSightNetCore01\PluraSightNetCore01\Pages\Restaurants\List.cshtml"
           Write(restaurant.Name);

#line default
#line hidden
            EndContext();
            BeginContext(540, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(564, 19, false);
#line 25 "C:\Users\zsolt\source\repos\PluraSightNetCore01\PluraSightNetCore01\Pages\Restaurants\List.cshtml"
           Write(restaurant.Location);

#line default
#line hidden
            EndContext();
            BeginContext(583, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(607, 18, false);
#line 26 "C:\Users\zsolt\source\repos\PluraSightNetCore01\PluraSightNetCore01\Pages\Restaurants\List.cshtml"
           Write(restaurant.Cuisine);

#line default
#line hidden
            EndContext();
            BeginContext(625, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 28 "C:\Users\zsolt\source\repos\PluraSightNetCore01\PluraSightNetCore01\Pages\Restaurants\List.cshtml"
    }

#line default
#line hidden
            BeginContext(654, 8, true);
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PluraSightNetCore01.Pages.Restaurants.ListModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PluraSightNetCore01.Pages.Restaurants.ListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PluraSightNetCore01.Pages.Restaurants.ListModel>)PageContext?.ViewData;
        public PluraSightNetCore01.Pages.Restaurants.ListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
