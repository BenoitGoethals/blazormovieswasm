#pragma checksum "/home/monchkrit/Code-House/blazormovieswasm/Client/Shared/MultipleSelectorTypeahead.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "599749c68a15331f6cc138412a0162b261be228c"
// <auto-generated/>
#pragma warning disable 1591
namespace blazormovieswasm.Client.Shared
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
    public partial class MultipleSelectorTypeahead<T> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __Blazor.blazormovieswasm.Client.Shared.MultipleSelectorTypeahead.TypeInference.CreateCustomTypeahead_0(__builder, 0, 1, 
#nullable restore
#line 3 "/home/monchkrit/Code-House/blazormovieswasm/Client/Shared/MultipleSelectorTypeahead.razor"
                                 (string searchText) => SearchMethod(searchText)

#line default
#line hidden
#nullable disable
            , 2, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 4 "/home/monchkrit/Code-House/blazormovieswasm/Client/Shared/MultipleSelectorTypeahead.razor"
                    (T item) => SelectedElement(item)

#line default
#line hidden
#nullable disable
            ), 3, (context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    ");
                __builder2.AddContent(5, 
#nullable restore
#line 6 "/home/monchkrit/Code-House/blazormovieswasm/Client/Shared/MultipleSelectorTypeahead.razor"
     MyResultTemplate(context)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(6, "\r\n  ");
            }
            );
            __builder.AddMarkupContent(7, "\r\n\r\n");
            __builder.OpenElement(8, "ul");
            __builder.AddAttribute(9, "class", "list-group");
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 11 "/home/monchkrit/Code-House/blazormovieswasm/Client/Shared/MultipleSelectorTypeahead.razor"
   foreach (var item in SelectedElements)
  {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "    ");
            __builder.OpenElement(12, "li");
            __builder.AddAttribute(13, "draggable", "true");
            __builder.AddAttribute(14, "ondragstart", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.DragEventArgs>(this, 
#nullable restore
#line 13 "/home/monchkrit/Code-House/blazormovieswasm/Client/Shared/MultipleSelectorTypeahead.razor"
                                         () => HandleDragStart(item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "ondragover", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.DragEventArgs>(this, 
#nullable restore
#line 13 "/home/monchkrit/Code-House/blazormovieswasm/Client/Shared/MultipleSelectorTypeahead.razor"
                                                                                      () => HandleDragOver(item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "class", "list-group-item list-group-item-action");
            __builder.AddMarkupContent(17, "\r\n      ");
            __builder.AddContent(18, 
#nullable restore
#line 15 "/home/monchkrit/Code-House/blazormovieswasm/Client/Shared/MultipleSelectorTypeahead.razor"
       MyListTemplate(item)

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(19, "\r\n      ");
            __builder.OpenElement(20, "span");
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "/home/monchkrit/Code-House/blazormovieswasm/Client/Shared/MultipleSelectorTypeahead.razor"
                        () => SelectedElements.Remove(item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "class", "badge badge-primary badge-pill");
            __builder.AddAttribute(23, "style", "cursor: pointer");
            __builder.AddContent(24, "X");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n");
#nullable restore
#line 18 "/home/monchkrit/Code-House/blazormovieswasm/Client/Shared/MultipleSelectorTypeahead.razor"
  }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "/home/monchkrit/Code-House/blazormovieswasm/Client/Shared/MultipleSelectorTypeahead.razor"
       
  [Parameter]
  public List<T> SelectedElements { get; set; }
  [Parameter]
  public Func<string, Task<IEnumerable<T>>> SearchMethod { get; set; }
  [Parameter]
  public RenderFragment<T> MyResultTemplate { get; set; }
  [Parameter]
  public RenderFragment<T> MyListTemplate { get; set; }

  T draggedItem;

  private void SelectedElement(T item)
  {
    if (!SelectedElements.Any(x => x.Equals(item)))
    {
      SelectedElements.Add(item);
    }
  }

  private void HandleDragStart(T item)
  {
    draggedItem = item;
  }

  private void HandleDragOver(T item)
  {
    if (!item.Equals(draggedItem))
    {
      var dragElementIndex = SelectedElements.IndexOf(draggedItem);
      var elementIndex = SelectedElements.IndexOf(item);

      SelectedElements[elementIndex] = draggedItem;
      SelectedElements[dragElementIndex] = item;
    }
  }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.blazormovieswasm.Client.Shared.MultipleSelectorTypeahead
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCustomTypeahead_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Func<global::System.String, global::System.Threading.Tasks.Task<global::System.Collections.Generic.IEnumerable<TItem>>> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TItem> __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment<TItem> __arg2)
        {
        __builder.OpenComponent<global::blazormovieswasm.Client.Shared.CustomTypeahead<TItem>>(seq);
        __builder.AddAttribute(__seq0, "SearchMethod", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ResultTemplate", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
