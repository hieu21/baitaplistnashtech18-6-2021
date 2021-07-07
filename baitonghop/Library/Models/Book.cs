using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Collections;
namespace Library.Models{
    [Table("Book")]
    public class Book{
        [Key]
        public int BookId { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public DateTime PublishedYear { get; set; }
        public ICollection<Author> Authors { get; set; }
    }
}