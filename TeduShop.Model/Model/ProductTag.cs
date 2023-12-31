﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Model
{
    [Table("ProductTags")]
    public class ProductTag : Auditable
    {
        [Key]
        public int ProductID { get; set; }

        [Key]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string TagName { get; set; }

        [ForeignKey("ProductID")]
        public virtual Product Product { get; set; }

        [ForeignKey("TagID")]
        public virtual PostTag Tag { get; set; }
    }
}
