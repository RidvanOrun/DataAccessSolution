﻿using Lab4_CodeFirst_NorthwindMigration.EntityLayer.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_CodeFirst_NorthwindMigration.EntityLayer.Entity.Concrete
{
    public class Shippers : BaseEntity<int>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public override int Id { get; set; }
        [Required]
        public string CompanyName { get; set; }
        public string Phone { get; set; }

        public virtual List<Orders> Orders { get; set; }

    }
}
