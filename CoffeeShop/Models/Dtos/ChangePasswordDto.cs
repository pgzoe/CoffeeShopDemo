﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoffeeShop.Models.Dtos
{
    public class ChangePasswordDto
    {
        public string OriginPassword { get; set; }

        public string ChangePassword { get; set; }

        public string ConfirmPassword { get; set; }
    }
}