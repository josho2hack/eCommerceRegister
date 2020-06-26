using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RDRegister.API.Models
{
    public class Provinces
    {
        public int Id { get; set; }

        [Required]
        public int Code { get; set; }

        [Required]
        [Display(Name = "จังหวัด")]
        [MaxLength(150, ErrorMessage = "ความยาวข้อมูลเกินกำหนด")]
        public string NameInThai { get; set; }

        [Required]
        [Display(Name = "จังหวัดภาษาอังกฤษ")]
        [MaxLength(150, ErrorMessage = "ความยาวข้อมูลเกินกำหนด")]
        public string NameInEnglish { get; set; }

        [Display(Name = "อำเภอภายในจังหวัด")]
        public IEnumerable<Districts> Districts { get; set; }
    }
}
