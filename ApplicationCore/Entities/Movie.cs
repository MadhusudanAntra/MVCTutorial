using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class Movie
    {

        public int Id { get; set; }
        [Required]
        [Column(TypeName="varchar(50)")]
        public string Title { get; set; } = string.Empty;
        [Column(TypeName ="varchar(150)")]
        public string Description { get; set; } = string.Empty;
        [Required]
        public double Length { get; set;  }
        [Required]
        [Column(TypeName ="varchar(250)")]
        public string ImageUrl { get; set; }=string.Empty;
        [Required]
        public double Ratings { get; set; }

        public IEnumerable<Genre> Genres { get; set; }
    }
}
