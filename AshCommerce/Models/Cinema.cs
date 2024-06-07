﻿using System.ComponentModel.DataAnnotations;

namespace AshCommerce.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Cinema Logo")]
        [Required(ErrorMessage = "Cinema logo is required")]
        public string? Logo { get; set; }

        [Display(Name = "Cinema Name")]
        [Required(ErrorMessage = "Cinema name is required")]
        public string? Name { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "Cinema description is required")]
        public string? Description { get; set; }

        //relations 
        public List<Movie>? Movies { get; set; }
    }
}
