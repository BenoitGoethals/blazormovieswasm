#pragma checksum "/home/monchkrit/Code-House/blazormovieswasm/Client/Shared/CustomTypeahead.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb138dc30fd6173f26a3a52cbf81281ee2ecf91b"
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
#nullable restore
#line 1 "/home/monchkrit/Code-House/blazormovieswasm/Client/Shared/CustomTypeahead.razor"
using System.Timers;

#line default
#line hidden
#nullable disable
    public partial class CustomTypeahead<TItem> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "blazored-typeahead");
            __builder.AddMarkupContent(2, "\r\n  ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "blazored-typeahead__controls");
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenElement(6, "input");
            __builder.AddAttribute(7, "type", "text");
            __builder.AddAttribute(8, "class", "blazored-typeahead__input");
            __builder.AddAttribute(9, "autocomplete", "off");
            __builder.AddAttribute(10, "placeholder", 
#nullable restore
#line 6 "/home/monchkrit/Code-House/blazormovieswasm/Client/Shared/CustomTypeahead.razor"
                                                                                          Placeholder

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "/home/monchkrit/Code-House/blazormovieswasm/Client/Shared/CustomTypeahead.razor"
                                                                     ShowSuggestions

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "onfocusout", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.FocusEventArgs>(this, 
#nullable restore
#line 7 "/home/monchkrit/Code-House/blazormovieswasm/Client/Shared/CustomTypeahead.razor"
                                                                                                   onfocusout

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 7 "/home/monchkrit/Code-House/blazormovieswasm/Client/Shared/CustomTypeahead.razor"
                  SearchText

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SearchText = __value, SearchText));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n");
#nullable restore
#line 9 "/home/monchkrit/Code-House/blazormovieswasm/Client/Shared/CustomTypeahead.razor"
   if (IsSearching)
  {

#line default
#line hidden
#nullable disable
            __builder.AddContent(17, "    ");
            __builder.AddMarkupContent(18, "<div class=\"blazored-typeahead__results\">\r\n      <div class=\"blazored-typeahead__results\">\r\n        <span>Loading...</span>\r\n      </div>\r\n    </div>\r\n");
#nullable restore
#line 16 "/home/monchkrit/Code-House/blazormovieswasm/Client/Shared/CustomTypeahead.razor"
  }
  else if (ShouldShowSuggestions())
  {

#line default
#line hidden
#nullable disable
            __builder.AddContent(19, "    ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "blazored-typeahead__results");
            __builder.AddMarkupContent(22, "\r\n");
#nullable restore
#line 20 "/home/monchkrit/Code-House/blazormovieswasm/Client/Shared/CustomTypeahead.razor"
       foreach (var item in Suggestions)
      {

#line default
#line hidden
#nullable disable
            __builder.AddContent(23, "        ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "blazored-typeahead__result");
            __builder.AddAttribute(26, "tabindex", "0");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "/home/monchkrit/Code-House/blazormovieswasm/Client/Shared/CustomTypeahead.razor"
                      () => SelectSuggestion(item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "onmouseover", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "/home/monchkrit/Code-House/blazormovieswasm/Client/Shared/CustomTypeahead.razor"
                                                                   OnmouseoverSuggestion

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "onmouseout", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "/home/monchkrit/Code-House/blazormovieswasm/Client/Shared/CustomTypeahead.razor"
                                                                                                       OnmouseoutSuggestion

#line default
#line hidden
#nullable disable
            ));
            __builder.SetKey(
#nullable restore
#line 22 "/home/monchkrit/Code-House/blazormovieswasm/Client/Shared/CustomTypeahead.razor"
                   item

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(30, "\r\n          ");
            __builder.AddContent(31, 
#nullable restore
#line 24 "/home/monchkrit/Code-House/blazormovieswasm/Client/Shared/CustomTypeahead.razor"
           ResultTemplate(item)

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n");
#nullable restore
#line 26 "/home/monchkrit/Code-House/blazormovieswasm/Client/Shared/CustomTypeahead.razor"
      }

#line default
#line hidden
#nullable disable
            __builder.AddContent(34, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n");
#nullable restore
#line 28 "/home/monchkrit/Code-House/blazormovieswasm/Client/Shared/CustomTypeahead.razor"
  }
  else if (ShowNotFound())
  {

#line default
#line hidden
#nullable disable
            __builder.AddContent(36, "    ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "blazored-typeahead__results");
            __builder.AddMarkupContent(39, "\r\n");
#nullable restore
#line 32 "/home/monchkrit/Code-House/blazormovieswasm/Client/Shared/CustomTypeahead.razor"
       if (NotFoundTemplate != null)
      {

#line default
#line hidden
#nullable disable
            __builder.AddContent(40, "        ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "blazored-typeahead__notfound");
            __builder.AddMarkupContent(43, "\r\n          ");
            __builder.AddContent(44, 
#nullable restore
#line 35 "/home/monchkrit/Code-House/blazormovieswasm/Client/Shared/CustomTypeahead.razor"
           NotFoundTemplate

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(45, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n");
#nullable restore
#line 37 "/home/monchkrit/Code-House/blazormovieswasm/Client/Shared/CustomTypeahead.razor"
      }
      else
      {

#line default
#line hidden
#nullable disable
            __builder.AddContent(47, "        ");
            __builder.AddMarkupContent(48, "<div class=\"blazored-typeahead__notfound\">\r\n          No results found\r\n        </div>\r\n");
#nullable restore
#line 43 "/home/monchkrit/Code-House/blazormovieswasm/Client/Shared/CustomTypeahead.razor"
      }

#line default
#line hidden
#nullable disable
            __builder.AddContent(49, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n");
#nullable restore
#line 45 "/home/monchkrit/Code-House/blazormovieswasm/Client/Shared/CustomTypeahead.razor"
  }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "/home/monchkrit/Code-House/blazormovieswasm/Client/Shared/CustomTypeahead.razor"
       
  [Parameter] 
  public string Placeholder { get; set; }
  [Parameter]
  public int MinimumLength { get; set; } = 3;
  [Parameter]
  public int Debounce { get; set; } = 300;
  [Parameter]
  public Func<string, Task<IEnumerable<TItem>>> SearchMethod { get; set; }
  [Parameter] 
  public RenderFragment<TItem> ResultTemplate { get; set; }
  [Parameter]
  public RenderFragment NotFoundTemplate { get; set; }
  [Parameter]
  public EventCallback<TItem> ValueChanged { get; set; }

  private Timer _debounceTimer;
  private bool IsSearching = false;
  private bool IsShowingSuggestions = false;
  private string _searchText = string.Empty;
  protected TItem[] Suggestions { get; set; } = new TItem[0];

  protected override void OnInitialized()
  {
    _debounceTimer = new Timer();
    _debounceTimer.Interval = Debounce;
    _debounceTimer.AutoReset = false;
    _debounceTimer.Elapsed += Search;

    base.OnInitialized();
  }

  private bool ShowNotFound()
  {
    return !Suggestions.Any() && IsShowingSuggestions;
  }

  private async Task SelectSuggestion(TItem item)
  {
    SearchText = "";
    await ValueChanged.InvokeAsync(item);
  }

  protected async void Search(Object source, ElapsedEventArgs e)
  {
    IsSearching = true;
    IsShowingSuggestions = false;
    await InvokeAsync(StateHasChanged);

    Suggestions = (await SearchMethod.Invoke(_searchText)).ToArray();

    IsSearching = false;
    IsShowingSuggestions = true;
    await InvokeAsync(StateHasChanged);
  }

  private string SearchText
  {
    get => _searchText;
    set
    {
      _searchText = value;

      if (value.Length == 0)
      {
        IsShowingSuggestions = false;
        _debounceTimer.Stop();
        Suggestions = new TItem[0];
      }
      else if (value.Length >= MinimumLength)
      {
        _debounceTimer.Stop();
        _debounceTimer.Start();
      }
    }
  }

  private void ShowSuggestions()
  {
    if (Suggestions.Any())
    {
      IsShowingSuggestions = true;
    }
  }

  private void onfocusout()
  {
    if (!IsMouseInSuggestion)
    {      
      IsShowingSuggestions = false;
    }
  }

  private bool ShouldShowSuggestions()
  {
    return IsShowingSuggestions && Suggestions.Any();
  }

  bool IsMouseInSuggestion = false;

  private void OnmouseoverSuggestion()
  {
    IsMouseInSuggestion = true;
  }

  private void OnmouseoutSuggestion()
  {
    IsMouseInSuggestion = false;
  }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
