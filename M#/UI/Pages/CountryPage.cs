using System;
using System.Collections.Generic;
using System.Text;
using MSharp;

namespace Country
{
    public class CountryPage : RootPage
    {
        public CountryPage()
        {
            Add<Modules.MainMenu>();

            OnStart(x => x.Go<CountriesPage>());
        }
    }
}
