using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsRegistration
{
    public class User
    {
      
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Username { get; set; }
        [Required]
        [MaxLength(50)]
        public string Password { get; set; }
        [Required]
        [MaxLength(30)]
        public string Firstname { get; set; }
        [Required]
        public string Lastname { get; set; }
        
        public decimal Balance { get; set; }
        [ForeignKey(nameof(City))]
        public int CityId { get; set; }
        public virtual City City { get; set; }
    }
}
