﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCAppDemoWithAuthtentication.Models
{
    public class MemberShipType
    {

        public int Id { get; set; }
        [Required]
        
        public string  Name { get; set; }
        public short SignUpFree { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }
        //public DateTime DOB {get; set;}
      //  public int MyProperty { get; set; }

    }
}