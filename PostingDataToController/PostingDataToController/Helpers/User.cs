﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PostingDataToController.Helpers
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public string Country { get; set; }
    }
}