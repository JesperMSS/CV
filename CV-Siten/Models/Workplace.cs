using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CV_Siten.Models
{
    public class Workplace
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public string City { get; set; }

        public virtual ICollection<UserAccount> Workers { get; set; }
    }
}