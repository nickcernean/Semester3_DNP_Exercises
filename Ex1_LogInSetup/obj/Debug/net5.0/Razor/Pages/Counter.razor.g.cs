#pragma checksum "D:\Semester3\DNP31Y\DNP_Exercises\Ex1_LogInSetup\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a5df66cc6375b8e0f109765853d9ce2e911b1d6"
// <auto-generated/>
#pragma warning disable 1591
namespace Ex1_LogInSetup.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Semester3\DNP31Y\DNP_Exercises\Ex1_LogInSetup\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Semester3\DNP31Y\DNP_Exercises\Ex1_LogInSetup\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Semester3\DNP31Y\DNP_Exercises\Ex1_LogInSetup\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Semester3\DNP31Y\DNP_Exercises\Ex1_LogInSetup\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Semester3\DNP31Y\DNP_Exercises\Ex1_LogInSetup\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Semester3\DNP31Y\DNP_Exercises\Ex1_LogInSetup\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Semester3\DNP31Y\DNP_Exercises\Ex1_LogInSetup\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Semester3\DNP31Y\DNP_Exercises\Ex1_LogInSetup\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Semester3\DNP31Y\DNP_Exercises\Ex1_LogInSetup\_Imports.razor"
using Ex1_LogInSetup;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Semester3\DNP31Y\DNP_Exercises\Ex1_LogInSetup\_Imports.razor"
using Ex1_LogInSetup.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Counter</h1>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Current count: ");
            __builder.AddContent(3, 
#nullable restore
#line 5 "D:\Semester3\DNP31Y\DNP_Exercises\Ex1_LogInSetup\Pages\Counter.razor"
                   currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "class", "btn btn-primary");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "D:\Semester3\DNP31Y\DNP_Exercises\Ex1_LogInSetup\Pages\Counter.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(8, "Click me");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "D:\Semester3\DNP31Y\DNP_Exercises\Ex1_LogInSetup\Pages\Counter.razor"
       
    private int currentCount = 0;

    private void IncrementCount()
    {
        currentCount++;
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
