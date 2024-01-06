﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMPTUIWinForm.Model
{
  
        public class Address
        {
              public int Id { get; set; }
            public string Street { get; set; }
            public string HouseNumber { get; set; }
            public string PostalCode { get; set; }
            public string City { get; set; }
        }
}
