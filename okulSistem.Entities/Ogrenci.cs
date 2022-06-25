using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace okulSistem.Entities
{
    public class Ogrenci
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ogrenciId { get; set; }
        [StringLength(50)]
        public string ogrenciAdi { get; set; }
        [StringLength(50)]
        public string ogreniciSoyadi { get; set; }
        [StringLength(50)]
        public string ogreniciNo { get; set; }
        public string ogreniDersler { get; set; }
        public bool ogreniciDurum { get; set; }
    }
}
