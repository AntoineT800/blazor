#pragma checksum "C:\Users\antoi\OneDrive\Bureau\timer\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0f78c02de7b4b9236561e0d5cf58ba1687e79b6"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace timer.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\antoi\OneDrive\Bureau\timer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\antoi\OneDrive\Bureau\timer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Users\antoi\OneDrive\Bureau\timer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "C:\Users\antoi\OneDrive\Bureau\timer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "C:\Users\antoi\OneDrive\Bureau\timer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\Users\antoi\OneDrive\Bureau\timer\_Imports.razor"
using timer;

#line default
#line hidden
#line 7 "C:\Users\antoi\OneDrive\Bureau\timer\_Imports.razor"
using timer.Shared;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 18 "C:\Users\antoi\OneDrive\Bureau\timer\Pages\Index.razor"
       
    int nombre = 10;
    private void StartTimer()
    {
        Timer.SetTimer(nombre * 1000);
        Timer.OnElapsed += TimerElapsedHandler;
        Console.WriteLine("Timer Started.");
        aTimer.SetTimer(1000);
        aTimer.OnElapsed += afficher;
    }

    private void afficher()
    {
        Console.WriteLine("Test : " + nombre);
        nombre--;
        this.StateHasChanged();
        if (nombre == -1)
        {
            aTimer.StopTimer();
        }
    }

    private void TimerElapsedHandler()
    {
        Console.WriteLine("Timer Elapsed.");
        NavManager.NavigateTo("Counter");
        Timer.StopTimer();
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.BlazorTimer aTimer { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.BlazorTimer Timer { get; set; }
    }
}
#pragma warning restore 1591
