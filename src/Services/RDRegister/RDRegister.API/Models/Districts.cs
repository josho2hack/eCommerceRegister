using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RDRegister.API.Models
{
    public class Districts
    {
        public int Id { get; set; }

        [Required]
        public int Code { get; set; }

        [Required]
        [Display(Name = "อำเภอ")]
        [MaxLength(150, ErrorMessage = "ความยาวข้อมูลเกินกำหนด")]
        public string NameInThai { get; set; }

        [Required]
        [Display(Name = "อำเภอภาษาอังกฤษ")]
        [MaxLength(150, ErrorMessage = "ความยาวข้อมูลเกินกำหนด")]
        public string NameInEnglish { get; set; }

        public int ProvincesId { get; set; }
        [Display(Name = "จังหวัด")]
        public Provinces Provinces { get; set; }

        [Display(Name = "ตำบลภายในอำเภอ")]
        public IEnumerable<Subdistricts> Subdistricts { get; set; }
    }
}
