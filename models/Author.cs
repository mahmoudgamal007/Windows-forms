using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WinFormsApp2.models
{
    public class Author

    {
        public Author()
        {
            Posts = new List<Post>();
        }
        [Key]
        public int author_id { get; set; }
        public string author_name { get; set; } 
        public int author_age { get; set; }
        public string author_password { get; set; }
        public string author_username { get; set; }
        public string author_email { get; set; }
        public bool author_isBlocked { get; set; }
        public virtual List<Post> Posts { get; set; }
    }
}
