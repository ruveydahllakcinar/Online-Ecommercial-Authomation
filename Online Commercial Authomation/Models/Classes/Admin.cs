﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Online_Commercial_Authomation.Models.Classes
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string UserName { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string Password { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(20)]
        public string Authority { get; set; }
    }

}