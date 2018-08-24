﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RMS.Models.EntityModels;

namespace RMS.App.ViewModels
{
    public class RequisitionViewModel 
    {
        public int Id { get; set; }

        [Display(Name = "Requisition Number")]
        public string RequisitionNumber { get; set; }

        [Required(ErrorMessage = "Please provide a journey start place details!")]
        [Display(Name = "From Place")]
        public string FromPlace { get; set; }

        [Required(ErrorMessage = "Please provide a journey destination details!")]
        [Display(Name = "Destination")]
        public string DestinationPlace { get; set; }

        [Required(ErrorMessage = "Please provide a journey start date and time!")]
        [Display(Name = "Start Date Time")]
        public DateTime StartDateTime { get; set; }

        [Required(ErrorMessage = "Please provide a journey end date and time!")]
        [Display(Name = "End Date Time")]
        public DateTime EndDateTime { get; set; }

        [Required(ErrorMessage = "Please provide a short journey description!")]
        public string Description { get; set; }
        
        [Display(Name = "Request For")]
        public string RequestFor { get; set; }

        [Display(Name = "Employee")]
        [Required(ErrorMessage = "Please select Employee!")]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public List<RequisitionViewModel> RequisitionViewModels { get; set; }

        public string GetRequisitionNumber()
        {
            string requestNumber = DateTime.Now.ToString("HH:mm-d-MMM/ddd/yyyy");
            return requestNumber;
        }
    }
}
