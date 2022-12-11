using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormsApp2.models
{
    public class Post
    {
        [Key]
        public int post_id { get; set; }
        public string post_title { get; set; }
        public string post_brief { get; set; }
        public string post_desc { get; set; }
        public string? post_media { get; set; }
        public DateTime post_date { get; set; }
       
        public  Blog blog { get; set; }

        [ForeignKey(nameof(Author))]
        public  int AuthorId { get; set; }
        public Author Author { get; set; }
        [ForeignKey(nameof(blog))]
        public  int BlogId { get;set; } 

    }
}
