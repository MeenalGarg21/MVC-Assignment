using MVCAppDemoWithAuthtentication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace MVCAppDemoWithAuthtentication.ViewModel
{
    public class NewCustomerViewModel
    {
        public IEnumerable<MemberShipType> MemberShipTypes { get; set; }
        public Customer Customers { get; set; }



        
    }
}