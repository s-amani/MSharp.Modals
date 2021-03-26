using System;
using System.Collections.Generic;
using System.Text;
using MSharp;

namespace Customer
{
    public class EnterPage : SubPage<CustomersPage>
    {
        public EnterPage()
        {
            Layout(Layouts.AdminDefaultModal);

            Set(PageSettings.LeftMenu, "AdminSettingsMenu");

            Add<Modules.CustomerForm>();
        }
    }
}
