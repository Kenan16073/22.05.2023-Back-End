﻿using System.ComponentModel.DataAnnotations;

namespace P138AllupProject.Models
{
    public class Tag : BaseEntity
    {
        [StringLength(255)]
        public string Name { get; set; }
    }
}
