namespace CoffeeShop.Models.EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GuestBook
    {
    public int Id { get; set; }

        [Required(ErrorMessage = "�m�W�O���񪺡C")]
        [StringLength(10, ErrorMessage = "�m�W����W�L10�Ӧr�šC")]
        [RegularExpression(@"^[\u4e00-\u9fa5a-zA-Z]+$", ErrorMessage = "�m�W�u��]�t����M�^��r�šC")]
        public string Name { get; set; }

    [Required(ErrorMessage = "�q�l�l��O���񪺡C")]
    [EmailAddress(ErrorMessage = "�п�J���Ī��q�l�l��a�}�C")]
    public string Email { get; set; }

        // �ϥΥ��h��F�������ҥx�W����M���ܸ��X
        [RegularExpression(@"^(09\d{8}|0[2-9]{1}\d{1,2}[- ]?\d{7})$",
            ErrorMessage = "�п�J���Ī��x�W����Υ��ܸ��X�C")]
        [StringLength(15, ErrorMessage = "�q�ܸ��X����W�L15�Ӧr�šC")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "�����O���񪺡C")]
    [StringLength(200, ErrorMessage = "��������W�L200�Ӧr�šC")]
    public string Message { get; set; }

        public DateTime Createdtime { get; set; }
    }
}
