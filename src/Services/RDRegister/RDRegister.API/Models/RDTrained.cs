using System.ComponentModel.DataAnnotations;

namespace RDRegister.API.Models
{
    public class RDTrained
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name ="ลสก.")]
        [MaxLength(6,ErrorMessage = "ความยาวเกินกำหนด")]
        public string OfficerId { get; set; }
    }
}
