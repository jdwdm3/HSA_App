﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HSA_REST.Models
{
    public class User
    {
        public long ID { get; set; }
        public int AccountNumber{ get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public DateTime Birthday { get; set; }
        public String HashedPassword { get; set; }
        public String UserName { get; set; }

    }
}