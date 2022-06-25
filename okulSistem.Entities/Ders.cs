using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace okulSistem.Entities
{
    public class Ders
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int dersId { get; set; }
        [StringLength(50)]
        public string dersAdi { get; set; }
        [StringLength(250)]
        public string dersAciklama { get; set; }
        public bool dersDurum { get; set; }
    }
}