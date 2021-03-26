using System;
using System.Collections.Generic;
using System.Text;
using MSharp;

namespace Domain
{
    public class Customer : EntityType
    {
        public Customer()
        {
            String("Company name").Mandatory(false);
            String("Contract start date").Mandatory(false);
            
            OpenImage("Logo").Mandatory(false).Width(200).Height(80).Mandatory(value: false);
            OpenFile("Contract").Mandatory(false);


            // Navigation
            Associate<Country>("Country");
        }
    }
}
