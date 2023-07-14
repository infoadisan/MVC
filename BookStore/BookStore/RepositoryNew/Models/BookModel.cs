using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BookStore.RepositoryNew.Models
{
    [Keyless]
    [Table("BookModel")]
    public partial class BookModel
    {
        public int Id { get; set; }
        [StringLength(20)]
        public string Title { get; set; } = null!;
        [StringLength(20)]
        public string? Author { get; set; }
        [StringLength(20)]
        public string? Description { get; set; }
        [StringLength(20)]
        public string? Category { get; set; }
        public int? TotalPages { get; set; }
        [StringLength(20)]
        public string? Language { get; set; }
    }
}
