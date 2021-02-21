﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple.Core.Model.Entity
{
    public class UserAddress:EntityBase
    {
        public int UserId { get; set; }
        public User User { get; set; }

        public string Title { get; set; }

        public string City { get; set; }

        public string Address { get; set; }
        public bool MyPropeIsActive { get; set; }

    }
}