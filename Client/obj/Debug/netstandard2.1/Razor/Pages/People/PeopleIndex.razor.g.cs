#pragma checksum "/home/monchkrit/Code-House/blazormovieswasm/Client/Pages/People/PeopleIndex.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "861c5b975c92cb38bc0b61ea39851b178a06789c"
// <auto-generated/>
#pragma warning disable 1591
namespace blazormovieswasm.Client.Pages.People
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/monchkrit/Code-House/blazormovieswasm/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/monchkrit/Code-House/blazormovieswasm/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/monchkrit/Code-House/blazormovieswasm/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/monchkrit/Code-House/blazormovieswasm/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/monchkrit/Code-House/blazormovieswasm/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/monchkrit/Code-House/blazormovieswasm/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/monchkrit/Code-House/blazormovieswasm/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/monchkrit/Code-House/blazormovieswasm/Client/_Imports.razor"
using blazormovieswasm.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/monchkrit/Code-House/blazormovieswasm/Client/_Imports.razor"
using blazormovieswasm.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/monchkrit/Code-House/blazormovieswasm/Client/_Imports.razor"
using blazormovieswasm.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/home/monchkrit/Code-House/blazormovieswasm/Client/_Imports.razor"
using blazormovieswasm.Shared.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/home/monchkrit/Code-House/blazormovieswasm/Client/_Imports.razor"
using blazormovieswasm.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/home/monchkrit/Code-House/blazormovieswasm/Client/_Imports.razor"
using blazormovieswasm.Client.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/home/monchkrit/Code-House/blazormovieswasm/Client/_Imports.razor"
using blazormovieswasm.Shared.Dtos;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/people")]
    public partial class PeopleIndex : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>People Index</h3>\r\n");
            __builder.AddMarkupContent(1, "<div class=\"form-group\">\r\n  <a class=\"btn btn-info\" href=\"person/create\">New Person</a>\r\n</div>\r\n\r\n");
            __Blazor.blazormovieswasm.Client.Pages.People.PeopleIndex.TypeInference.CreateGenericList_0(__builder, 2, 3, 
#nullable restore
#line 9 "/home/monchkrit/Code-House/blazormovieswasm/Client/Pages/People/PeopleIndex.razor"
                   People

#line default
#line hidden
#nullable disable
            , 4, (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenElement(6, "table");
                __builder2.AddAttribute(7, "class", "table table-striped");
                __builder2.AddMarkupContent(8, "\r\n      ");
                __builder2.AddMarkupContent(9, "<thead>\r\n        <tr>\r\n          <th></th>\r\n          <th>Name</th>\r\n        </tr>\r\n      </thead>\r\n      ");
                __builder2.OpenElement(10, "tbody");
                __builder2.AddMarkupContent(11, "\r\n");
#nullable restore
#line 19 "/home/monchkrit/Code-House/blazormovieswasm/Client/Pages/People/PeopleIndex.razor"
         foreach (var item in People)
        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(12, "          ");
                __builder2.OpenElement(13, "tr");
                __builder2.AddMarkupContent(14, "\r\n            ");
                __builder2.OpenElement(15, "td");
                __builder2.AddMarkupContent(16, "\r\n              ");
                __builder2.OpenElement(17, "a");
                __builder2.AddAttribute(18, "class", "btn btn-success");
                __builder2.AddAttribute(19, "href", "/genre/edit/" + (
#nullable restore
#line 23 "/home/monchkrit/Code-House/blazormovieswasm/Client/Pages/People/PeopleIndex.razor"
                                                            item.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(20, "Edit");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n              ");
                __builder2.AddMarkupContent(22, "<button class=\"btn btn-danger\">Del</button>\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n            ");
                __builder2.OpenElement(24, "td");
                __builder2.AddContent(25, 
#nullable restore
#line 26 "/home/monchkrit/Code-House/blazormovieswasm/Client/Pages/People/PeopleIndex.razor"
                 item.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n          ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n");
#nullable restore
#line 28 "/home/monchkrit/Code-House/blazormovieswasm/Client/Pages/People/PeopleIndex.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(28, "      ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n  ");
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "/home/monchkrit/Code-House/blazormovieswasm/Client/Pages/People/PeopleIndex.razor"
       
  List<Person> People;

  protected async override Task OnInitializedAsync()
  {
    try
    {
      People = await personRepository.GetPeople();
    }
    catch(Exception ex)
    {

    }
  }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPersonRepository personRepository { get; set; }
    }
}
namespace __Blazor.blazormovieswasm.Client.Pages.People.PeopleIndex
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateGenericList_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.List<TItem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::blazormovieswasm.Client.Shared.GenericList<TItem>>(seq);
        __builder.AddAttribute(__seq0, "List", __arg0);
        __builder.AddAttribute(__seq1, "WholeListTemplate", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
