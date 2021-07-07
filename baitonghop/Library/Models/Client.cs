using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Collections;
namespace Library.Models{
    [Table("Client")]
    public class Client{
        [Key]
        public int ClientId { get; set; }
        public string Name { get; set; }
        public ICollection<Book> Books { get; set; }

    }
}