// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TheStoreLoginFrontEnd.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\lloyd\Desktop\PSF\TheStoreLoginFrontEnd\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lloyd\Desktop\PSF\TheStoreLoginFrontEnd\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lloyd\Desktop\PSF\TheStoreLoginFrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\lloyd\Desktop\PSF\TheStoreLoginFrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\lloyd\Desktop\PSF\TheStoreLoginFrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\lloyd\Desktop\PSF\TheStoreLoginFrontEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\lloyd\Desktop\PSF\TheStoreLoginFrontEnd\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\lloyd\Desktop\PSF\TheStoreLoginFrontEnd\_Imports.razor"
using TheStoreLoginFrontEnd;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\lloyd\Desktop\PSF\TheStoreLoginFrontEnd\_Imports.razor"
using TheStoreLoginFrontEnd.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lloyd\Desktop\PSF\TheStoreLoginFrontEnd\Pages\LoginPage.razor"
using StoreLogin.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class LoginPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "C:\Users\lloyd\Desktop\PSF\TheStoreLoginFrontEnd\Pages\LoginPage.razor"
       
    private string UsernameField;
    private string PasswordField;

    private async Task LoginValidation()
    {
        if(System.Text.ASCIIEncoding.Unicode.GetByteCount(UsernameField) < 1000 && System.Text.ASCIIEncoding.Unicode.GetByteCount(PasswordField) < 1000)
        {
            var taintedUser = new TaintedUserModel()
            {
                username = UsernameField,
                password = PasswordField
            };
            await publicApi.ValidateLogin(taintedUser);
        }
        else
        {

        }

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PublicApiService publicApi { get; set; }
    }
}
#pragma warning restore 1591