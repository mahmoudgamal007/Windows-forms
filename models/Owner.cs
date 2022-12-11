using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WinFormsApp2.models
{
    public class Owner
    {
        [Key]
        public int owner_id { get; set; }
        public string owner_name { get; set; }
        public string owner_password { get; set; }
        public int owner_age { get; set; }


        public  Blog blog { get; set; }  
    }
}
