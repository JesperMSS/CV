using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CV_Siten.Models
{
    public class Competences
    {
        [Key]
        public int CompetenceID { get; set; }

        [Required(ErrorMessage = "Du måste ange ett kompetensnamn")]
        public string Name { get; set; } 


    }
}