﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.WebAPI.Models
{
    /// <summary>
    /// VehicleMake View Model Class
    /// </summary>
    public class VehicleMakeVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Abrv { get; set; }
    }
}