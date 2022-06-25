using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace okulSistem.Entities
{
    public class Ogretmen
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ogretmenId { get; set; }
        [StringLength(50)]
        public string ogretmenAdi { get; set; }
        [StringLength(50)]
        public string ogretmenSoyadi { get; set; }
        [StringLength(50)]
        public Ders ogretmenDers { get; set; }
        public bool ogretmenDurum { get; set; }
    }
}
