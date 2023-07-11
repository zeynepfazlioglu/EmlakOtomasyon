using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emlak.Otomasyon.Core.Enums;

namespace Emlak.Otomasyon.Model.Entity
{
    public class Emlak
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Display(Name = "Başlık")]
        public string Baslik { get; set; }
        public EmlakTipi EmlakTipi { get; set; }
        public string Sehir { get; set; }
        public string Ilce { get; set; }
        public int alan { get; set; }
        public int odasayisi { get; set; }
        public Durum durum { get; set; }
        public int fiyat { get; set; }
    }
}
