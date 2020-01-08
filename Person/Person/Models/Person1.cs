﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonExample.Models
{
    [Table("Person_1")]
    public partial class Person1
    {
        public Person1()
        {
            Phone = new HashSet<Phone>();
        }

        [StringLength(36)]
        public string Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public short? Age { get; set; }

        [InverseProperty("Person")]
        public virtual ICollection<Phone> Phone { get; set; }
    }
}