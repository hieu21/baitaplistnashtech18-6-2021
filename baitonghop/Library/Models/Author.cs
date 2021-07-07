using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Collections;
namespace Library.Models{
    [Table("Author")]
    public class Author{
        [Key]
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public DateTime BirthYear { get; set; }
        public ICollection<Book> Books{ get; set;}


    }
}