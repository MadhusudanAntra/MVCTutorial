﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class Genre
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Genre Name is required")]
        [Column(TypeName ="varchar(50)")]
        public string Name { get; set; }=string.Empty;

        public IEnumerable<Movie> Movies { get; set; } = new List<Movie>();
    }
}
