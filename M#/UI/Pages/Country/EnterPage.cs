using System;
using System.Collections.Generic;
using System.Text;
using MSharp;

namespace Country
{
    public class EnterPage : SubPage<CountriesPage>
    {
        public EnterPage()
        {
            Layout(Layouts.AdminDefaultModal);

            Set(PageSettings.LeftMenu, "AdminSettingsMenu");

            Add<Modules.CountryForm>();
        }
    }
}
