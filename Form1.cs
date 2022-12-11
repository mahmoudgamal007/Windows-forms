using WinFormsApp2.models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace WinFormsApp2
  
{
    public partial class posts_form : Form
    {
        ITIDbcontext db;
        public posts_form()
        {
            InitializeComponent();
            db = new ITIDbcontext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            dgv_posts.DataSource=db.Posts.Select(p => new {ID=p.post_id, title = p.post_title,Brief=p.post_brief,Description=p.post_desc,Date=p.post_date,p.AuthorId }).Where(p=>p.AuthorId==Form2.authorid).ToList();
          
            
            btn_delete.Visible=false;
            btn_modify.Visible=false;
            btn_add.Visible=true;
            btn_pic.Visible=true;
        }

        private void dgv_posts_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = (int)dgv_posts.SelectedRows[0].Cells[0].Value;
            Post p = db.Posts.Where(n => n.post_id == id).SingleOrDefault();
            txt_title.Text=p.post_title;
            txt_brief.Text=p.post_brief;
            rtb_desc.Text=p.post_desc;
            pb_pic.ImageLocation=p.post_media;
            btn_delete.Visible=true;
            btn_modify.Visible=true;
            btn_add.Visible=false;
            btn_pic.Visible=true;


        }

        private void btn_pic_Click(object sender, EventArgs e)
        {
            string imagelocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter="jpg files(*.jpg)|*.jpg| png files(*.png)|*.png| All files(*.*)|*.*";
                if(dialog.ShowDialog()==System.Windows.Forms.DialogResult.OK)
                {
                    imagelocation = dialog.FileName;
                    pb_pic.ImageLocation=imagelocation;
                   
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sorry an error occured!","Error",MessageBoxButtons.OK);

            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Post p=new Post() { post_title=txt_title.Text
                , post_brief=txt_brief.Text
                ,post_desc=rtb_desc.Text
                ,post_date=DateTime.Now
                ,post_media=pb_pic.ImageLocation};
            int blogid = db.Blogs.Select(b => b.Id).SingleOrDefault();
            Blog b = db.Blogs.Where(b => b.Id == blogid).SingleOrDefault();
            p.AuthorId =Form2.authorid;
            p.BlogId=blogid;
            db.Posts.Add(p);
            db.SaveChanges();
            btn_delete.Visible=false;
            btn_modify.Visible=false;
            btn_add.Visible=true;
            btn_pic.Visible=true;
            dgv_posts.DataSource=db.Posts.Select(p => new { ID = p.post_id, title = p.post_title, Brief = p.post_brief, Description = p.post_desc, Date = p.post_date, p.AuthorId }).Where(p => p.AuthorId==Form2.authorid).ToList();
            txt_title.Text=txt_brief.Text=rtb_desc.Text=pb_pic.ImageLocation="";

        }

        private void btn_modify_Click(object sender, EventArgs e)
        {
            int id = (int)dgv_posts.SelectedRows[0].Cells[0].Value;
            Post p = db.Posts.Where(n => n.post_id == id).SingleOrDefault();
            p.post_brief=txt_brief.Text;
            p.post_title=txt_title.Text;
            p.post_date=DateTime.Now;
            p.post_desc=rtb_desc.Text;
            p.post_media=pb_pic.ImageLocation;
            db.SaveChanges();
            btn_delete.Visible=false;
            btn_modify.Visible=false;
            btn_add.Visible=true;
            btn_pic.Visible=true;
            dgv_posts.DataSource=db.Posts.Select(p => new { ID = p.post_id, title = p.post_title, Brief = p.post_brief, Description = p.post_desc, Date = p.post_date, p.AuthorId }).Where(p => p.AuthorId==Form2.authorid).ToList();
            txt_title.Text=txt_brief.Text=rtb_desc.Text=pb_pic.ImageLocation="";
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int id = (int)dgv_posts.SelectedRows[0].Cells[0].Value;
            Post p = db.Posts.Where(n => n.post_id == id).SingleOrDefault();
            db.Posts.Remove(p);
            db.SaveChanges();
            btn_delete.Visible=false;
            btn_modify.Visible=false;
            btn_add.Visible=true;
            btn_pic.Visible=true;
            dgv_posts.DataSource=db.Posts.Select(p => new { ID = p.post_id, title = p.post_title, Brief = p.post_brief, Description = p.post_desc, Date = p.post_date, p.AuthorId }).Where(p => p.AuthorId==Form2.authorid).ToList();
            txt_title.Text=txt_brief.Text=rtb_desc.Text=pb_pic.ImageLocation="";

        }
    }
}