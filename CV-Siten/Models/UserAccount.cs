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
    //[RegularExpression(@"^([a - zA - Z0 - 9_\-\.] +)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{ 1,3}\.)| (([a - zA - Z0 - 9\-] +\.)+))([a - zA - Z]{ 2,4}|[0 - 9]{ 1,3})(\]?)$)", ErrorMessage = "Du måste ange en giltlig email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Du måste ange ett Username")]

        public string Username { get; set; } 

        [Required(ErrorMessage = "Du måste ange ett Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Var vänlig verifiera Passwordet")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }

}