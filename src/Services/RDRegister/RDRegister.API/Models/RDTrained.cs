using System.ComponentModel.DataAnnotations;

namespace RDRegister.API.Models
{
    public class RDTrained
    {
        [Key]
        [Display(Name ="ลสก.")]
        [MaxLength(10,ErrorMessage = "ความยาวเกินกำหนด")]
        public string OfficerId { get; set; }
    }
}
