using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormsApp2.models
{
    public class Blog
    {
        public Blog()
        {
            posts=new List<Post>();
        }


        [Key]
        public int Id { get; set; } 
        public string blog_name { get; set; }
        public string blog_desc { get; set; }
      
        public virtual List<Post> posts { get; set; }

        [ForeignKey(nameof(owner))]
        public  int ownerid { get; set; }
        public virtual Owner owner { get; set; }

    }
}
