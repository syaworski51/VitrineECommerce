﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceProject.Models
{
    [Table("Currencies")]
    public class Currency
    {
        [Key]
        [Display(Name = "Symbol")]
        public string Symbol { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }
    }
}
