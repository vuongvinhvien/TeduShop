﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TeduShop.Model.Models
{
    [Table("Slides")]
    class Slide
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [MaxLength(256)]
        [Required]
        public string Name { set; get; }
        [MaxLength(256)]
        public string Image { set; get; }
        [MaxLength(256)]
        public string Url { set; get; }
        public int? DisplayOrder { set; get; }
        public bool Status { set; get; }
    }
}
