#pragma checksum "D:\Semester3\DNP31Y\DNP_Exercises\Ex3_FourthCoffee\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43133dd67820f01af7ee16aa2f0aa50dd42f2c1c"
// <auto-generated/>
#pragma warning disable 1591
namespace Ex3_FourthCoffee.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Semester3\DNP31Y\DNP_Exercises\Ex3_FourthCoffee\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Semester3\DNP31Y\DNP_Exercises\Ex3_FourthCoffee\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Semester3\DNP31Y\DNP_Exercises\Ex3_FourthCoffee\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Semester3\DNP31Y\DNP_Exercises\Ex3_FourthCoffee\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Semester3\DNP31Y\DNP_Exercises\Ex3_FourthCoffee\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Semester3\DNP31Y\DNP_Exercises\Ex3_FourthCoffee\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Semester3\DNP31Y\DNP_Exercises\Ex3_FourthCoffee\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Semester3\DNP31Y\DNP_Exercises\Ex3_FourthCoffee\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Semester3\DNP31Y\DNP_Exercises\Ex3_FourthCoffee\_Imports.razor"
using Ex3_FourthCoffee;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Semester3\DNP31Y\DNP_Exercises\Ex3_FourthCoffee\_Imports.razor"
using Ex3_FourthCoffee.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-7g35t7nbal");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-7g35t7nbal");
            __builder.OpenComponent<Ex3_FourthCoffee.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-7g35t7nbal");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "top-row px-4");
            __builder.AddAttribute(13, "b-7g35t7nbal");
            __builder.AddMarkupContent(14, "<a class=\"navbar-brand\" asp-page=\"/Index\" b-7g35t7nbal><img class=\"img-fluid\" src=\"/images/brand.png\" alt=\"Fourth Coffee\" b-7g35t7nbal></a>\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(15);
            __builder.AddAttribute(16, "href", "about");
            __builder.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(18, "About");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n\r\n        ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "content px-4");
            __builder.AddAttribute(22, "b-7g35t7nbal");
            __builder.AddContent(23, 
#nullable restore
#line 17 "D:\Semester3\DNP31Y\DNP_Exercises\Ex3_FourthCoffee\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
