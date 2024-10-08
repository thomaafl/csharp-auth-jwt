﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace exercise.wwwapi.Models
{
    public class BlogPost
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }
        public User User { get; set; }

        public ICollection<BlogComment> ?BlogComments { get; set; }

        public string Text { get; set; }
        public DateTime Posted { get; set; }
    }
}
