using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ForumWebApplication
{
    public partial class Post
    {
        public int Id { get; set; }
        [Display(Name = "Topic")]
        public int TopicId { get; set; }
        [Display(Name = "Post")]
        [Required(ErrorMessage = "The field mustn`t be empty")]
        public string Description { get; set; } = null!;
        [Display(Name = "Date and time")]
        [Required(ErrorMessage = "The field mustn`t be empty")]
        public DateTime Date { get; set; } = DateTime.Now;
        public virtual Topic Topic { get; set; } = null!;
    }
}
