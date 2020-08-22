using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;

namespace MVCAppDemoWithAuthtentication.Models
{
    public class Customer
    {
        public int Id{ get; set; }
        [Required]
        [StringLength(40)]
        public string  Name { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }
        
        public DateTime DateOfBirth { get; set; }
        public MemberShipType memberShipType { get; set; }
        public int  MemberShipTypeId { get; set; }
    }
}