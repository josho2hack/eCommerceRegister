using System.ComponentModel.DataAnnotations;

namespace RDRegister.API.Dtos
{
    public class RDTrainedUpdateDto
    {
        [Required]
        [MaxLength(6,ErrorMessage ="ลสก. ยาวเกินกำหนด")]
        public string OfficerId { get; set; }
    }
}
