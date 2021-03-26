using MSharp;
using Domain;

namespace Modules
{
    public class AdminSettingsMenu : MenuModule
    {
        public AdminSettingsMenu()
        {
            SubItemBehaviour(MenuSubItemBehaviour.ExpandCollapse);
            WrapInForm(false);
            AjaxRedirect();
            IsViewComponent();
            RootCssClass("sidebar-menu");
            UlCssClass("nav flex-column");
            Using("Olive.Security");


            Item("General settings")
                .OnClick(x => x.Go<Admin.Settings.GeneralPage>());

            Item("Administrators")
                .OnClick(x => x.Go<Admin.Settings.AdministratorsPage>());

            Item("Content blocks")
                .OnClick(x => x.Go<Admin.Settings.ContentBlocksPage>());

            Item("Countries")
                .Icon(FA.Cog)
                .OnClick(x => x.Go<Country.CountriesPage>());

            Item("Customers")
                .Icon(FA.Cog)
                .OnClick(x => x.Go<Customer.CustomersPage>());
        }
    }
}