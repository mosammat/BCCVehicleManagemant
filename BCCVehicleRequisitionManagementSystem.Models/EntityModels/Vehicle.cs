﻿using System.ComponentModel.DataAnnotations;

namespace BCCVehicleRequisitionManagementSystem.Models.EntityModels
{
    public class Vehicle
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please input vehicle name!")]
        [Display(Name = "Vehicle Name"),StringLength(250)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Select vehicle type")]
        [Display(Name = "Vehicle Type")]
        public int VehicleTypeId { get; set; }
        public VehicleType VehicleType { get; set; }

        [Required(ErrorMessage = "Length 4 to 6 digit")]
        [Display(Name = "Registration No")]
        [MinLength(4),MaxLength(6)]
        public string RegistrationNo { get; set; }

        public string Description { get; set; }

        public bool IsDelete { get; set; }
    }
}