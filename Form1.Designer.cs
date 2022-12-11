namespace WinFormsApp2
{
    partial class posts_form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_posts = new System.Windows.Forms.DataGridView();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_modify = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.txt_brief = new System.Windows.Forms.TextBox();
            this.rtb_desc = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_pic = new System.Windows.Forms.Button();
            this.pb_pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_posts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_posts
            // 
            this.dgv_posts.BackgroundColor = System.Drawing.Color.Pink;
            this.dgv_posts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_posts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dgv_posts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_posts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_posts.Location = new System.Drawing.Point(12, 182);
            this.dgv_posts.Name = "dgv_posts";
            this.dgv_posts.RowHeadersWidth = 51;
            this.dgv_posts.RowTemplate.Height = 29;
            this.dgv_posts.Size = new System.Drawing.Size(750, 256);
            this.dgv_posts.TabIndex = 0;
            this.dgv_posts.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_posts_RowHeaderMouseClick);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(290, 74);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(107, 29);
            this.btn_delete.TabIndex = 1;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_modify
            // 
            this.btn_modify.Location = new System.Drawing.Point(290, 32);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Size = new System.Drawing.Size(107, 29);
            this.btn_modify.TabIndex = 2;
            this.btn_modify.Text = "Modify post";
            this.btn_modify.UseVisualStyleBackColor = true;
            this.btn_modify.Click += new System.EventHandler(this.btn_modify_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(290, 147);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(107, 29);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "Add Post";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_title
            // 
            this.txt_title.Location = new System.Drawing.Point(115, 29);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(125, 27);
            this.txt_title.TabIndex = 4;
            // 
            // txt_brief
            // 
            this.txt_brief.Location = new System.Drawing.Point(115, 71);
            this.txt_brief.Name = "txt_brief";
            this.txt_brief.Size = new System.Drawing.Size(125, 27);
            this.txt_brief.TabIndex = 5;
            // 
            // rtb_desc
            // 
            this.rtb_desc.Location = new System.Drawing.Point(115, 104);
            this.rtb_desc.Name = "rtb_desc";
            this.rtb_desc.Size = new System.Drawing.Size(171, 72);
            this.rtb_desc.TabIndex = 6;
            this.rtb_desc.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Brief";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Description";
            // 
            // btn_pic
            // 
            this.btn_pic.Location = new System.Drawing.Point(292, 112);
            this.btn_pic.Name = "btn_pic";
            this.btn_pic.Size = new System.Drawing.Size(105, 29);
            this.btn_pic.TabIndex = 11;
            this.btn_pic.Text = "Add picture";
            this.btn_pic.UseVisualStyleBackColor = true;
            this.btn_pic.Click += new System.EventHandler(this.btn_pic_Click);
            // 
            // pb_pic
            // 
            this.pb_pic.Location = new System.Drawing.Point(426, 29);
            this.pb_pic.Name = "pb_pic";
            this.pb_pic.Size = new System.Drawing.Size(159, 134);
            this.pb_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_pic.TabIndex = 12;
            this.pb_pic.TabStop = false;
            // 
            // posts_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pb_pic);
            this.Controls.Add(this.btn_pic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtb_desc);
            this.Controls.Add(this.txt_brief);
            this.Controls.Add(this.txt_title);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_modify);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.dgv_posts);
            this.Name = "posts_form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_posts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgv_posts;
        private Button btn_delete;
        private Button btn_modify;
        private Button btn_add;
        private TextBox txt_title;
        private TextBox txt_brief;
        private RichTextBox rtb_desc;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btn_pic;
        private PictureBox pb_pic;
    }
}