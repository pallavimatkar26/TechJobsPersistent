﻿
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {
        [Required(ErrorMessage = "A Name is required")]
        public string Name { get; set; }

        public int EmployerId { get; set; }

        public List<SelectListItem> Employers { get; set; } // null

        public List<Skill> Skills { get; set; } // null

        public AddJobViewModel()
        {
        }

        public AddJobViewModel(List<Employer> employers, List<Skill> skills)
        {
            this.Skills = skills;

            // This is the fix:
            this.createSelectListItems(employers);

            // This is the pre-existing answer
            // this.Employers = new List<SelectListItem>();

            // foreach (Employer employer in employers)
            // {
            //     this.Employers.Add(
            //         new SelectListItem
            //         {
            //             Value = employer.Id.ToString(),
            //             Text = employer.Name
            //         });
            // }

        }

        public void createSelectListItems(List<Employer> employers)
        {
            this.Employers = new List<SelectListItem>();

            foreach (Employer employer in employers)
            {
                this.Employers.Add(
                    new SelectListItem
                    {
                        Value = employer.Id.ToString(),
                        Text = employer.Name
                    });
            }
        }
    }
}
