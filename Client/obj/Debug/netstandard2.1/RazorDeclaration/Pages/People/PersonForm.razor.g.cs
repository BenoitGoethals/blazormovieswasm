#pragma checksum "/home/monchkrit/Code-House/blazormovieswasm/Client/Pages/People/PersonForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f1b5d17c9c1317d666574f6e08efe455a3ffb00"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
using blazormovieswasm.Shared.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/home/monchkrit/Code-House/blazormovieswasm/Client/_Imports.razor"
using blazormovieswasm.Client.Helpers;

#line default
#line hidden
#nullable disable
    public partial class PersonForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "/home/monchkrit/Code-House/blazormovieswasm/Client/Pages/People/PersonForm.razor"
       
  [Parameter]
  public Person Person { get; set; }
  [Parameter]
  public EventCallback OnValidSubmit { get; set; }
  string imageURL;

  protected override void OnInitialized()
  {
    if (!string.IsNullOrEmpty(Person.Picture))
    {
      imageURL = Person.Picture;
      Person.Picture = null;
    }
  }

  private void PictureSelected(string imageBase64)
  {
    Person.Picture = imageBase64;
    imageURL = null;
    System.Console.WriteLine(imageBase64);
  }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
