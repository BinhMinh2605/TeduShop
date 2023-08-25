using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Model
{
    [Table("Footers")]
    public class Footer
    {
        [Key]
        [MaxLength(256)]
        public string ID { get; set; } //cho phép vừa lấy giá trị, vừa cài giá trị
        [Required]
        public string Content { get; set; }

    }
}
