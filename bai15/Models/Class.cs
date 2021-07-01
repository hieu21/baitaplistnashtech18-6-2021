using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Collections;
namespace bai15.Models{
    [Table("Class")]
    public class Class{
        [Key]
        public int Id{get;set;}
        public string ClassName{get;set;}
        public ICollection<Student> Students{get;set;}

    }
}