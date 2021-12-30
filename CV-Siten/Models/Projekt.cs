using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CV_Siten.Models
{
    public class Projekt
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        [ForeignKey("UserAccount")]
        public int ProjektManager { get; set; }
        public virtual UserAccount UserAccount { get; set; }
    }
}
