#pragma checksum "C:\Users\Dan\source\repos\BlazorCrud\BlazorCrud\Pages\Eliminar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c6953a84a96bc6b575845871665728a33f2388b"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorCrud.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "C:\Users\Dan\source\repos\BlazorCrud\BlazorCrud\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Dan\source\repos\BlazorCrud\BlazorCrud\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Dan\source\repos\BlazorCrud\BlazorCrud\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Dan\source\repos\BlazorCrud\BlazorCrud\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Dan\source\repos\BlazorCrud\BlazorCrud\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Dan\source\repos\BlazorCrud\BlazorCrud\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Dan\source\repos\BlazorCrud\BlazorCrud\_Imports.razor"
using BlazorCrud;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Dan\source\repos\BlazorCrud\BlazorCrud\_Imports.razor"
using BlazorCrud.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dan\source\repos\BlazorCrud\BlazorCrud\Pages\Eliminar.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Dan\source\repos\BlazorCrud\BlazorCrud\Pages\Eliminar.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Dan\source\repos\BlazorCrud\BlazorCrud\Pages\Eliminar.razor"
using Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/eliminar/{Id:int}")]
    public partial class Eliminar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "C:\Users\Dan\source\repos\BlazorCrud\BlazorCrud\Pages\Eliminar.razor"
       
    [Parameter]
    public int Id { get; set; }

    Respuesta<object> oRespuesta = new Respuesta<object>();
    public string Url = "/api/Cerveza";


    private async Task Eliminador()
    {

        var response = await Http.DeleteAsync(Url+"/"+Id);
        oRespuesta = response.Content.ReadFromJsonAsync<Respuesta<object>>().Result;
        NavigationManager.NavigateTo("/cervezas");

    }

    private void Cancelar()
    {

       
        NavigationManager.NavigateTo("/cervezas");

    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591