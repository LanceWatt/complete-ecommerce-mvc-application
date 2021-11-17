using eTickets.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Cinema : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        
        [Display(Name = "CinemaLogo")]
        //[Required(ErrorMessage = "Logo Is Required")]
        public string Logo { get; set; }

        
        [Display(Name = "CinemaName")]
        //[Required(ErrorMessage = "Name Is Required")]
        public string Name { get; set; }

        
        
        [Display(Name = "Description")]
        //[Required(ErrorMessage = "Description Is Required")]
        public string Description { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }

    }
}
