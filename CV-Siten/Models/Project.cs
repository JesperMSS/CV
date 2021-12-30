using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CV_Siten.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public string desc { get; set; }

        [ForeignKey("UserAccount")]
        public int ProjektManager { get; set; }
        public virtual UserAccount UserAccount { get; set; }

    }
}