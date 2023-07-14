using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Data.Models
{
    [Table("Book")]
    public partial class Book
    {
        [Key]
        public int Id { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? Title { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? Author { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? Description { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? Category { get; set; }
        public int? TotalPages { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? Language { get; set; }
    }
}
