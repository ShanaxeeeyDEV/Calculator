using Microsoft.AspNetCore.Components;

namespace Calculator.Components.Pages
{
    public partial class Home
    {
        [Inject] protected NavigationManager Navigation { get; set; } = default!;

        protected string ActiveTab { get; set; } = "dashboard";

        protected void ChangeTab(string tabName)
        {
            ActiveTab = tabName;
        }

        protected void Logout()
        {
            Navigation.NavigateTo("/login");
        }

    }
}