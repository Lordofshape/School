using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WinFormsRegistration
{
    public class City
    {
        public City()
        {
            this.Users = new HashSet<User>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(40)]
        public string Name { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
