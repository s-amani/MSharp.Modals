using System;
using System.Collections.Generic;
using System.Text;
using MSharp;

namespace Country
{
    public class CountriesPage : SubPage<CountryPage>
    {
        public CountriesPage()
        {
            Layout(Layouts.AdminDefault);

            Set(PageSettings.LeftMenu, "AdminSettingsMenu");

            Add<Modules.CountriesList>();
        }
    }
}
