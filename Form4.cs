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
    public partial class Form4 : Form
    {
        ITIDbcontext db;
        public Form4()
        {
            InitializeComponent();
            db=new ITIDbcontext();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            int id = db.Blogs.Select(b => b.Id).SingleOrDefault();
            Blog b = db.Blogs.Where(b=>b.Id == id).SingleOrDefault();
            txt_blogid.Text=b.Id.ToString();
            txt_blogid.Enabled=false;
            txt_blogname.Text=b.blog_name;
            txt_blogdesc.Text=b.blog_desc;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = db.Blogs.Select(b => b.Id).SingleOrDefault();
            Blog b = db.Blogs.Where(b => b.Id == id).SingleOrDefault();
            b.blog_name=txt_blogname.Text;
            b.blog_desc=txt_blogdesc.Text;
            db.SaveChanges();
            MessageBox.Show("Changes are saved");
            txt_blogid.Text=b.Id.ToString();
            txt_blogid.Enabled=false;
            txt_blogname.Text=b.blog_name;
            txt_blogdesc.Text=b.blog_desc;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 backtoposts = new Form3();
            this.Hide();
            backtoposts.ShowDialog();
        }
    }
}
