// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorAdmin.Pages.CatalogItemPage
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\_Imports.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\_Imports.razor"
using BlazorAdmin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\_Imports.razor"
using BlazorAdmin.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\_Imports.razor"
using BlazorAdmin.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\_Imports.razor"
using BlazorAdmin.JavaScript;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\_Imports.razor"
using BlazorShared.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\_Imports.razor"
using BlazorShared.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\_Imports.razor"
using BlazorShared.Models;

#line default
#line hidden
#nullable disable
    public partial class Create : BlazorAdmin.Helpers.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 123 "C:\Users\Administrator\Desktop\eShopOnWeb-master\eShopOnWeb-master\src\BlazorAdmin\Pages\CatalogItemPage\Create.razor"
       

    [Parameter]
    public IEnumerable<CatalogBrand> Brands { get; set; }
    [Parameter]
    public IEnumerable<CatalogType> Types { get; set; }

    [Parameter]
    public EventCallback<string> OnSaveClick { get; set; }

    private string LoadPicture => string.IsNullOrEmpty(_item.PictureBase64) ? string.Empty : $"data:image/png;base64, {_item.PictureBase64}";
    private bool HasPicture => !string.IsNullOrEmpty(_item.PictureBase64);
    private string _badFileMessage = string.Empty;
    private string _modalDisplay = "none;";
    private string _modalClass = "";
    private bool _showCreateModal = false;
    private CreateCatalogItemRequest _item = new CreateCatalogItemRequest();

    private async Task CreateClick()
    {
        await CatalogItemService.Create(_item);
        await OnSaveClick.InvokeAsync(null);
        await Close();
    }

    public async Task Open()
    {
        Logger.LogInformation("Now loading... /Catalog/Create");

        await new Css(JSRuntime).HideBodyOverflow();

        _item = new CreateCatalogItemRequest
        {
            CatalogTypeId = Types.First().Id,
            CatalogBrandId = Brands.First().Id
        };

        _modalDisplay = "block;";
        _modalClass = "Show";
        _showCreateModal = true;

        StateHasChanged();
    }

    private async Task Close()
    {
        await new Css(JSRuntime).ShowBodyOverflow();
        _modalDisplay = "none";
        _modalClass = "";
        _showCreateModal = false;
    }

    private async Task AddFile(IFileListEntry[] files)
    {
        _badFileMessage = string.Empty;

        var file = files.FirstOrDefault();
        _item.PictureName = file?.Name;
        _item.PictureBase64 = await CatalogItem.DataToBase64(file);

        _badFileMessage = CatalogItem.IsValidImage(_item.PictureName, _item.PictureBase64);
        if (!string.IsNullOrEmpty(_badFileMessage))
        {
            _item.PictureName = null;
            _item.PictureBase64 = null;
        }
    }

    private void RemoveImage()
    {
        _item.PictureName = null;
        _item.PictureBase64 = null;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICatalogItemService CatalogItemService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILogger<Create> Logger { get; set; }
    }
}
#pragma warning restore 1591
