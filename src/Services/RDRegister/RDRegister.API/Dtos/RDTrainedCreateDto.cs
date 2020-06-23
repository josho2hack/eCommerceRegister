using System.ComponentModel.DataAnnotations;

namespace RDRegister.API.Dtos
{
    public class RDTrainedCreateDto
    {
        [Required]
        [MaxLength(6,ErrorMessage ="ลสก. ยาวเกินกำหนด")]
        public string OfficerId { get; set; }
    }
}
