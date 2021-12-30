using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CV_Siten.Models
{
    public class UserAccount
    {
        [Key]
        public int UserID { get; set; }

        [Required(ErrorMessage = "Du måste ange ett förnamn")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Du måste ange ett efternamn")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Du måste ange en mailadress")]
        [RegularExpression(@"^[\w!#$%&'+-/=?^_`{|}~]+(.[\w!#$%&'+-/=?^_`{|}~]+)*"+ "@"+ @"((([-\w]+.)+[a-zA-Z]{2,4})|(([0-9]{1,3}.){3}[0-9]{1,3}))$", ErrorMessage = "Du måste ange en giltlig email")]
        

        public string Email { get; set; }

        [Required(ErrorMessage = "Du måste ange ett Username")]

        public string Username { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public virtual ICollection<Workplace> Workplaces { get; set; }
    }
}