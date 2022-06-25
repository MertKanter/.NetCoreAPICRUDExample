using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace okulSistem.Entities
{
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int userId { get; set; }
        [StringLength(50)]
        public string userAd { get; set; }
        [StringLength(50)]
        public string userSoyad { get; set; }
        [StringLength(150)]
        public string userMail { get; set; }
        [MinLength(6)]
        public string userPassword { get; set; }
    }
}
