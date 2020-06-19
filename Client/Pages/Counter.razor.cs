using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using blazormovieswasm.Shared.Entities;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using static blazormovieswasm.Client.Shared.MainLayout;

namespace blazormovieswasm.Client.Pages
{
  public partial class Counter
  {
    private int currentCount = 0;

    public void IncrementCount()
    {
        currentCount++;
    }
  }
}