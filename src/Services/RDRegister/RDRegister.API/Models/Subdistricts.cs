using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RDRegister.API.Models
{
    public class Subdistricts
    {
        public int Id { get; set; }

        [Required]
        public int Code { get; set; }

        [Required]
        [Display(Name = "ตำบล")]
        [MaxLength(150, ErrorMessage = "ความยาวข้อมูลเกินกำหนด")]
        public string NameInThai { get; set; }

        [Display(Name = "ตำบลภาษาอังกฤษ")]
        [MaxLength(150, ErrorMessage = "ความยาวข้อมูลเกินกำหนด")]
        public string NameInEnglish { get; set; }

        [Required]
        [Column(TypeName = "decimal(6, 3)")]
        public decimal Latitude { get; set; }

        [Required]
        [Column(TypeName = "decimal(6, 3)")]
        public decimal Longitude { get; set; }

        public int DistrictsId { get; set; }
        [Display(Name = "อำเภอ")]
        public Districts Districts { get; set; }

        [Display(Name = "รหัสไปรษณีย์")]
        public int ZipCode { get; set; }
    }
}
