using System;
using System.Collections.Generic;
using System.Text;
using MSharp;

namespace Domain
{
    public class Country : EntityType
    {
        public Country()
        {
            String("Name", 64).Mandatory();
        }
    }
}
