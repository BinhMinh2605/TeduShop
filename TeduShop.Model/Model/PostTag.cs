﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TeduShop.Model.Abstract;
namespace TeduShop.Model.Model
{
    [Table("PostTags")]
    public class PostTag : Auditable
    {
        [Key]
        public int PostID { get; set; }

        [Key]
        [Column(TypeName ="varchar")]
        [MaxLength(50)]
        public string TagID { get; set; }

        [ForeignKey("PostID")]
        public virtual Post Post { get; set; }

        [ForeignKey("TagID")]
        public virtual PostTag Tag { get; set; }
    }
}
