using System;
using System.Collections.Generic;
using System.Text;
using MSharp;

namespace Customer
{
    public class CustomerPage : RootPage
    {
        public CustomerPage()
        {
            Add<Modules.MainMenu>();

            OnStart(x => x.Go<CustomersPage>());
        }
    }
}
