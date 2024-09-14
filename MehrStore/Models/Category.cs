﻿using System.ComponentModel.DataAnnotations;

namespace MehrStore.Models
{
    public class Category 
    {
        public int Id { get; set; }
        [Required]
        public String Name { get; set; }
        public int DisplayOrder { get; set; }
    }
}
