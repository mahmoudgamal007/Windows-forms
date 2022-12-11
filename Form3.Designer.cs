namespace WinFormsApp2
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_blogname = new System.Windows.Forms.Label();
            this.dgv_owner = new System.Windows.Forms.DataGridView();
            this.txt_posttitle = new System.Windows.Forms.TextBox();
            this.txt_postbrief = new System.Windows.Forms.TextBox();
            this.txt_postdesc = new System.Windows.Forms.RichTextBox();
            this.pb_postpic = new System.Windows.Forms.PictureBox();
            this.txt_postauthor = new System.Windows.Forms.TextBox();
            this.btn_block = new System.Windows.Forms.Button();
            this.btn_deletepost = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_editblog = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_owner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_postpic)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_blogname
            // 
            this.lbl_blogname.AutoSize = true;
            this.lbl_blogname.Location = new System.Drawing.Point(367, 9);
            this.lbl_blogname.Name = "lbl_blogname";
            this.lbl_blogname.Size = new System.Drawing.Size(50, 20);
            this.lbl_blogname.TabIndex = 0;
            this.lbl_blogname.Text = "label1";
            // 
            // dgv_owner
            // 
            this.dgv_owner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_owner.Location = new System.Drawing.Point(12, 250);
            this.dgv_owner.Name = "dgv_owner";
            this.dgv_owner.RowHeadersWidth = 51;
            this.dgv_owner.RowTemplate.Height = 29;
            this.dgv_owner.Size = new System.Drawing.Size(776, 188);
            this.dgv_owner.TabIndex = 1;
            this.dgv_owner.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_owner_RowHeaderMouseClick);
            // 
            // txt_posttitle
            // 
            this.txt_posttitle.Location = new System.Drawing.Point(333, 41);
            this.txt_posttitle.Name = "txt_posttitle";
            this.txt_posttitle.Size = new System.Drawing.Size(125, 27);
            this.txt_posttitle.TabIndex = 2;
            // 
            // txt_postbrief
            // 
            this.txt_postbrief.Location = new System.Drawing.Point(114, 116);
            this.txt_postbrief.Name = "txt_postbrief";
            this.txt_postbrief.Size = new System.Drawing.Size(179, 27);
            this.txt_postbrief.TabIndex = 3;
            // 
            // txt_postdesc
            // 
            this.txt_postdesc.Location = new System.Drawing.Point(114, 149);
            this.txt_postdesc.Name = "txt_postdesc";
            this.txt_postdesc.Size = new System.Drawing.Size(524, 52);
            this.txt_postdesc.TabIndex = 4;
            this.txt_postdesc.Text = "";
            // 
            // pb_postpic
            // 
            this.pb_postpic.Location = new System.Drawing.Point(663, 83);
            this.pb_postpic.Name = "pb_postpic";
            this.pb_postpic.Size = new System.Drawing.Size(125, 118);
            this.pb_postpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_postpic.TabIndex = 5;
            this.pb_postpic.TabStop = false;
            // 
            // txt_postauthor
            // 
            this.txt_postauthor.Location = new System.Drawing.Point(114, 83);
            this.txt_postauthor.Name = "txt_postauthor";
            this.txt_postauthor.Size = new System.Drawing.Size(125, 27);
            this.txt_postauthor.TabIndex = 6;
            // 
            // btn_block
            // 
            this.btn_block.Location = new System.Drawing.Point(663, 215);
            this.btn_block.Name = "btn_block";
            this.btn_block.Size = new System.Drawing.Size(125, 29);
            this.btn_block.TabIndex = 7;
            this.btn_block.Text = "Block Author";
            this.btn_block.UseVisualStyleBackColor = true;
            this.btn_block.Click += new System.EventHandler(this.btn_block_Click);
            // 
            // btn_deletepost
            // 
            this.btn_deletepost.Location = new System.Drawing.Point(78, 215);
            this.btn_deletepost.Name = "btn_deletepost";
            this.btn_deletepost.Size = new System.Drawing.Size(133, 29);
            this.btn_deletepost.TabIndex = 8;
            this.btn_deletepost.Text = "Delete post";
            this.btn_deletepost.UseVisualStyleBackColor = true;
            this.btn_deletepost.Click += new System.EventHandler(this.btn_deletepost_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Post brief";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Title";
            // 
            // btn_editblog
            // 
            this.btn_editblog.Location = new System.Drawing.Point(694, 12);
            this.btn_editblog.Name = "btn_editblog";
            this.btn_editblog.Size = new System.Drawing.Size(94, 29);
            this.btn_editblog.TabIndex = 13;
            this.btn_editblog.Text = "Edit blog";
            this.btn_editblog.UseVisualStyleBackColor = true;
            this.btn_editblog.Click += new System.EventHandler(this.btn_editblog_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_editblog);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_deletepost);
            this.Controls.Add(this.btn_block);
            this.Controls.Add(this.txt_postauthor);
            this.Controls.Add(this.pb_postpic);
            this.Controls.Add(this.txt_postdesc);
            this.Controls.Add(this.txt_postbrief);
            this.Controls.Add(this.txt_posttitle);
            this.Controls.Add(this.dgv_owner);
            this.Controls.Add(this.lbl_blogname);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_owner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_postpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_blogname;
        private DataGridView dgv_owner;
        private TextBox txt_posttitle;
        private TextBox txt_postbrief;
        private RichTextBox txt_postdesc;
        private PictureBox pb_postpic;
        private TextBox txt_postauthor;
        private Button btn_block;
        private Button btn_deletepost;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btn_editblog;
    }
}