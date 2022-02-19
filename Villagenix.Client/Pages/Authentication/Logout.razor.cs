using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Villagenix.Client.Service.IService;

namespace Villagenix.Client.Pages.Authentication
{
    public partial class Logout
    {
        [Inject]
        public IAuthenticationService authenticationService { get; set; }
        [Inject]
        public NavigationManager navigationManager { get; set; }

        protected async override Task OnInitializedAsync()
        {
            await authenticationService.Logout();
            navigationManager.NavigateTo("/");
        }
    }
}
