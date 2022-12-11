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
    public partial class Form3 : Form
    {
        ITIDbcontext db;
        public Form3()
        {
           
            InitializeComponent();
            db=new ITIDbcontext();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            dgv_owner.DataSource=db.Posts.Include(p => p.Author).Select(p => new {Post_id=p.post_id
            ,Post_title=p.post_title
            ,Post_brief=p.post_brief
            ,Description=p.post_desc
            ,Auhor_id=p.Author.author_id
            ,Author_name=p.Author.author_name
            ,Image=p.post_media}).ToList();


        }

        private void dgv_owner_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = (int)dgv_owner.SelectedRows[0].Cells[0].Value;
            Post p = db.Posts.Where(n => n.post_id == id).SingleOrDefault();
            txt_posttitle.Text=p.post_title;
            txt_postbrief.Text=p.post_brief;
            txt_postdesc.Text=p.post_desc;
            pb_postpic.ImageLocation=p.post_media;
            txt_postauthor.Text=db.Authors.Where(a=>a.author_id==p.AuthorId).Select(a=>a.author_username).SingleOrDefault().ToString();
        }

        private void btn_deletepost_Click(object sender, EventArgs e)
        {
            int id = (int)dgv_owner.SelectedRows[0].Cells[0].Value;
            Post p = db.Posts.Where(n => n.post_id == id).SingleOrDefault();
            db.Posts.Remove(p);
            db.SaveChanges();
            dgv_owner.DataSource=db.Posts.Include(p => p.Author).Select(p => new {
                Post_id = p.post_id,
                Post_title = p.post_title,
                Post_brief = p.post_brief,
                Description = p.post_desc,
                Author_name = p.Author.author_name,
                Image = p.post_media
            }).ToList();
            txt_posttitle.Text=txt_postbrief.Text= txt_postdesc.Text=  pb_postpic.ImageLocation="";
        }

        private void btn_block_Click(object sender, EventArgs e)
        {
            int id = (int)dgv_owner.SelectedRows[0].Cells[4].Value;
            Author a = db.Authors.Where(n => n.author_id == id).SingleOrDefault();
            a.author_isBlocked=true;
            db.SaveChanges();

        }

        private void btn_editblog_Click(object sender, EventArgs e)
        {
            Form4 editblog = new Form4();
            this.Hide();
            editblog.ShowDialog();
        }
    }
}
