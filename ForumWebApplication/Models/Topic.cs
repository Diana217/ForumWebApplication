using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ForumWebApplication
{
    public partial class Topic
    {
        public Topic()
        {
            Posts = new HashSet<Post>();
        }

        public int Id { get; set; }
        [Display(Name = "Topic")]
        [Required(ErrorMessage = "The field mustn`t be empty")]
        public string Name { get; set; } = null!;

        public virtual ICollection<Post> Posts { get; set; }
    }
}
