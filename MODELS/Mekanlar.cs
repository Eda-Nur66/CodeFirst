using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELS
{
    [Table("tblMekanlar")]
    class Mekanlar
    {
        public int MekanId { get; set; }
        [Column(TypeName = "int")]
        [MaxLength(1)]
        [Required]
        public string OnemliNoktalar { get; set; }
        [Column(TypeName = "varchar")]
        [MaxLength(1)]
        [Required]
        public string TarihiYerler { get; set; }
        [Column(TypeName = "varchar")]
        [MaxLength(1)]
        [Required]
        public string Eglence { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(1)]
        [Required]

        public Kategori Kategorisi { get; set; }

    }

}
