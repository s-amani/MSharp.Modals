using System;
using System.Collections.Generic;
using System.Text;
using MSharp;

namespace Customer
{
    public class CustomersPage : SubPage<CustomerPage>
    {
        public CustomersPage()
        {
            Layout(Layouts.AdminDefault);

            Set(PageSettings.LeftMenu, "AdminSettingsMenu");

            Add<Modules.CustomersList>();
        }
    }
}
