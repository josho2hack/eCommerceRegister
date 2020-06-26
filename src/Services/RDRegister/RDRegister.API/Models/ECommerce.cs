using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace RDRegister.API.Models
{
    public class ECommerce
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "ประเภทสินค้าที่ขาย")]
        public string ProductType { get; set; }

        [Required]
        [Display(Name = "คำนำหน้าชื่อ")]
        public TitleName Title { get; set; }

        [Required]
        [Display(Name = "ชื่อ")]
        public string FirtName { get; set; }

        [Required]
        [Display(Name = "นามสกุล")]
        public string LastName { get; set; }

        [Display(Name = "เลขประจำตัวประชาชน")]
        [MaxLength(13,ErrorMessage = "ความยาวข้อมูลเกินกำหนด")]
        public string ThaiNID { get; set; }

        [Display(Name = "อาคาร")]
        public string Building { get; set; }

        [Display(Name = "เลขที่")]
        public string BuildingNumber { get; set; }

        [Display(Name = "ชั้นที่")]
        [MaxLength(10, ErrorMessage = "ความยาวข้อมูลเกินกำหนด")]
        public string Floor { get; set; }

        [Display(Name = "บ้านเลขที่")]
        public string HouseNumber { get; set; }

        [Display(Name = "หมู่ที่")]
        public string Moo { get; set; }

        [Display(Name = "ซอย")]
        public string Soi { get; set; }

        [Display(Name = "ถนน")]
        public string Road { get; set; }

        [AllowNull]
        public int SubdistrictsId { get; set; }
        [Display(Name = "ตำบล")]
        public Subdistricts Subdistricts { get; set; }

        [Display(Name = "ชื่อเว็บไซต์ผู้ประกอบการ")]
        public IEnumerable<SiteName> SiteNames { get; set; }

        [Display(Name = "Link เว็บไซต์")]
        public IEnumerable<Link> Links { get; set; }

        [Display(Name = "เบอร์โทรศัพท์")]
        public IEnumerable<Phone> Phones { get; set; }

        [Required]
        [Display(Name = "บัญชีธนาคาร")]
        public IEnumerable<BookBank> BookBanks { get; set; }

        [Display(Name = "พร้อมเพย์")]
        public IEnumerable<PromptPay> PromptPays { get; set; }
    }

    public enum TitleName
    {
        นาย,นาง,นางสาว
    }

    public class SiteName
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "ชื่อเว็บไซต์")]
        public string Name { get; set; }

        public int ECommerceId { get; set; }
        public ECommerce ECommerce { get; set; }
    }

    public class Link
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Link เว็บไซต์")]
        public string Url { get; set; }

        public int ECommerceId { get; set; }
        public ECommerce ECommerce { get; set; }
    }

    public class Phone
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "เบอร์โทรศัพท์")]
        public string Number { get; set; }

        public int ECommerceId { get; set; }
        public ECommerce ECommerce { get; set; }
    }

    public class BookBank
    {
        public int Id { get; set; }
        
        [Required]
        [Display(Name = "ธนาคาร")]
        public ThaiBank ThaiBank { get; set; }

        [Required]
        [Display(Name = "เลขที่บัญชีธนาคาร")]
        public string BankNumber { get; set; }

        public int ECommerceId { get; set; }
        public ECommerce ECommerce { get; set; }
    }

    public enum ThaiBank
    {
        ธนาคารกรุงเทพ,
        ธนาคารกสิกรไทย,
        ธนาคารกรุงไทย,
        ธนาคารทหารไทย,
        ธนาคารไทยพาณิชย์,
        ธนาคารกรุงศรีอยุธยา,
        ธนาคารเกียรตินาคิน,
        ธนาคารซีไอเอ็มบีไทย,
        ธนาคารทิสโก้,
        ธนาคารธนชาต,
        ธนาคารยูโอบี,
        ธนาคารไทยเครดิตเพื่อรายย่อย,
        ธนาคารแลนด์แอนด์เฮาส์,
        ธนาคารไอซีบีซีไทย,
        ธนาคารพัฒนาวิสาหกิจขนาดกลางและขนาดย่อมแห่งประเทศไทย,
        ธนาคารเพื่อการเกษตรและสหกรณ์การเกษตร,
        ธนาคารเพื่อการส่งออกและนำเข้าแห่งประเทศไทย,
        ธนาคารออมสิน,
        ธนาคารอาคารสงเคราะห์,
        ธนาคารอิสลามแห่งประเทศไทย
    }

    public class PromptPay
    {
        public int Id { get; set; }

        [Display(Name = "เบอร์โทรศัพท์สำหรับพร้อมเพย์")]
        public string TelPromptPay { get; set; }

        [Display(Name = "เลขประจำตัวประชาชนสำหรับพร้อมเพย์")]
        public string NidPromptPay { get; set; }

        public int ECommerceId { get; set; }
        public ECommerce ECommerce { get; set; }
    }
}
