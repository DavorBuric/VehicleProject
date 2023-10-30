using Project.DAL.Entities;
using Project.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Model
{
    /// <summary>
    /// VehicleModel model class.
    /// </summary>
    public class VehicleModel : IVehicleModel
    {
        public int Id { get; set; }

        /// <summary>
        /// VehicleModel name.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// VehicleModel abbreviation.
        /// </summary>
        public string Abrv { get; set; }

        /// <summary>
        /// VehicleModel's Make Id.
        /// </summary>
        public int MakeId { get; set; }
    }
}
