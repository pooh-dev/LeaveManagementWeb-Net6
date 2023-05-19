﻿using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Web.Models
{
    public class LeaveTypeViewModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Leave Type Name")]
        public string Name { get; set; }

        [Required]
        [Range(1, 25, ErrorMessage = "Please enter a valid number")]
        [Display(Name = "Default Number of Days")]
        public int DefaultDays { get; set; }
    }
}
