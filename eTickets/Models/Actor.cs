using eTickets.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Actor : IEntityBaseRepository
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture Url")]
        public string ProfilePictureUrl { get; set; }

        [Required(ErrorMessage ="Full Name Is Required")]
        [Display(Name = "Full Name")]
        [StringLength(50, MinimumLength =3, ErrorMessage ="Too long or too short")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Bio Is Required")]
        [Display(Name = "Bio")]
        public string Bio { get; set; }

        //Relationships
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
