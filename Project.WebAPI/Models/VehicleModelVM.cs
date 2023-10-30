﻿using Project.DAL.Entities;
using Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.WebAPI.Models
{
    /// <summary>
    /// VehicleModel View Model Class
    /// </summary>
    public class VehicleModelVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Abrv { get; set; }
        public int MakeId { get; set; }
    }
}