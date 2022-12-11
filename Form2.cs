using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp2.models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace WinFormsApp2
{
    
    public partial class Form2 : Form
    {
        ITIDbcontext db;
        public static int authorid;
        public static int ownerid;
        
        
        public Form2()
        {
            InitializeComponent();
            db = new ITIDbcontext();

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            int uservalid=0;
            int ownervalid = 0;
            uservalid=db.Authors.Select(a => new { a.author_username }).Where(a => a.author_username==txt_username.Text).Count();
            ownervalid=db.Owners.Select(o => new { o.owner_name }).Where(o => o.owner_name==txt_username.Text).Count();
           
            Author a = db.Authors.Where(a => a.author_username == txt_username.Text).SingleOrDefault();
            Owner o = db.Owners.Where(o => o.owner_name==txt_username.Text).SingleOrDefault();
            


            if (uservalid==1&&a.author_password==txt_password.Text&&a.author_isBlocked==false&&!check_owner.Checked)
            {
                authorid= a.author_id;
                posts_form postsf = new posts_form();
                postsf.ShowDialog();
            
            }
           else if (uservalid==1&&a.author_password==txt_password.Text&&a.author_isBlocked==true&&!check_owner.Checked)
            {
                MessageBox.Show("sorry the owner blocked your account");
            }
            else if(ownervalid==1&&o.owner_password==txt_password.Text&&check_owner.Checked)
            {
                ownerid= o.owner_id;
                Form3 ownerform = new Form3();
                ownerform.ShowDialog();
            }
            else
            {
                MessageBox.Show("wrong credintials");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
