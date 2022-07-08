using System;

namespace StudentInfo
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.idnumlbl = new System.Windows.Forms.Label();
            this.fnamelbl = new System.Windows.Forms.Label();
            this.lnamelbl = new System.Windows.Forms.Label();
            this.milbl = new System.Windows.Forms.Label();
            this.courselbl = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtfn = new System.Windows.Forms.TextBox();
            this.txtln = new System.Windows.Forms.TextBox();
            this.txtmi = new System.Windows.Forms.TextBox();
            this.txtcrs = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btndisplay = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.EnterRecordLbl = new System.Windows.Forms.Label();
            this.Displaylbl = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btndelete = new System.Windows.Forms.Button();
            this.SearchIDtxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnclearsearch = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // idnumlbl
            // 
            this.idnumlbl.AutoSize = true;
            this.idnumlbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idnumlbl.Location = new System.Drawing.Point(43, 131);
            this.idnumlbl.Name = "idnumlbl";
            this.idnumlbl.Size = new System.Drawing.Size(64, 15);
            this.idnumlbl.TabIndex = 2;
            this.idnumlbl.Text = "Id Number";
            // 
            // fnamelbl
            // 
            this.fnamelbl.AutoSize = true;
            this.fnamelbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnamelbl.Location = new System.Drawing.Point(43, 164);
            this.fnamelbl.Name = "fnamelbl";
            this.fnamelbl.Size = new System.Drawing.Size(64, 15);
            this.fnamelbl.TabIndex = 4;
            this.fnamelbl.Text = "First Name";
            // 
            // lnamelbl
            // 
            this.lnamelbl.AutoSize = true;
            this.lnamelbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnamelbl.Location = new System.Drawing.Point(229, 164);
            this.lnamelbl.Name = "lnamelbl";
            this.lnamelbl.Size = new System.Drawing.Size(63, 15);
            this.lnamelbl.TabIndex = 6;
            this.lnamelbl.Text = "Last Name";
            // 
            // milbl
            // 
            this.milbl.AutoSize = true;
            this.milbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.milbl.Location = new System.Drawing.Point(421, 164);
            this.milbl.Name = "milbl";
            this.milbl.Size = new System.Drawing.Size(76, 15);
            this.milbl.TabIndex = 8;
            this.milbl.Text = "Middle Initial";
            // 
            // courselbl
            // 
            this.courselbl.AutoSize = true;
            this.courselbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courselbl.Location = new System.Drawing.Point(63, 194);
            this.courselbl.Name = "courselbl";
            this.courselbl.Size = new System.Drawing.Size(44, 15);
            this.courselbl.TabIndex = 10;
            this.courselbl.Text = "Course";
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.Color.Lavender;
            this.txtid.Location = new System.Drawing.Point(113, 126);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(107, 20);
            this.txtid.TabIndex = 3;
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            this.txtid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtid_KeyPress);
            // 
            // txtfn
            // 
            this.txtfn.BackColor = System.Drawing.Color.Lavender;
            this.txtfn.Location = new System.Drawing.Point(113, 161);
            this.txtfn.Name = "txtfn";
            this.txtfn.Size = new System.Drawing.Size(107, 20);
            this.txtfn.TabIndex = 5;
            this.txtfn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfn_KeyPress);
            // 
            // txtln
            // 
            this.txtln.BackColor = System.Drawing.Color.Lavender;
            this.txtln.Location = new System.Drawing.Point(298, 161);
            this.txtln.Name = "txtln";
            this.txtln.Size = new System.Drawing.Size(107, 20);
            this.txtln.TabIndex = 7;
            this.txtln.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtln_KeyPress);
            // 
            // txtmi
            // 
            this.txtmi.BackColor = System.Drawing.Color.Lavender;
            this.txtmi.Location = new System.Drawing.Point(503, 161);
            this.txtmi.Name = "txtmi";
            this.txtmi.Size = new System.Drawing.Size(29, 20);
            this.txtmi.TabIndex = 9;
            this.txtmi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmi_KeyPress);
            // 
            // txtcrs
            // 
            this.txtcrs.BackColor = System.Drawing.Color.Lavender;
            this.txtcrs.Location = new System.Drawing.Point(113, 192);
            this.txtcrs.Name = "txtcrs";
            this.txtcrs.Size = new System.Drawing.Size(419, 20);
            this.txtcrs.TabIndex = 11;
            this.txtcrs.TextChanged += new System.EventHandler(this.txtcrs_TextChanged);
            this.txtcrs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcrs_KeyPress);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Teal;
            this.btnsave.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Location = new System.Drawing.Point(81, 108);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(56, 39);
            this.btnsave.TabIndex = 12;
            this.btnsave.Text = "&Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.Teal;
            this.btnsearch.Image = ((System.Drawing.Image)(resources.GetObject("btnsearch.Image")));
            this.btnsearch.Location = new System.Drawing.Point(184, 31);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(39, 26);
            this.btnsearch.TabIndex = 16;
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Teal;
            this.btnclear.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.Color.White;
            this.btnclear.Location = new System.Drawing.Point(32, 595);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(62, 39);
            this.btnclear.TabIndex = 13;
            this.btnclear.Text = "&Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // dgv
            // 
            this.dgv.BackgroundColor = System.Drawing.Color.Lavender;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(8, 10);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(767, 174);
            this.dgv.TabIndex = 21;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // btndisplay
            // 
            this.btndisplay.BackColor = System.Drawing.Color.Teal;
            this.btndisplay.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndisplay.ForeColor = System.Drawing.Color.White;
            this.btndisplay.Location = new System.Drawing.Point(355, 190);
            this.btndisplay.Name = "btndisplay";
            this.btndisplay.Size = new System.Drawing.Size(57, 37);
            this.btndisplay.TabIndex = 22;
            this.btndisplay.Text = "&Display";
            this.btndisplay.UseVisualStyleBackColor = false;
            this.btndisplay.Click += new System.EventHandler(this.btndisplay_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Teal;
            this.btnupdate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(16, 108);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(65, 41);
            this.btnupdate.TabIndex = 17;
            this.btnupdate.Text = "&Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.Location = new System.Drawing.Point(237, 9);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(397, 40);
            this.TitleLbl.TabIndex = 0;
            this.TitleLbl.Text = "Student Information Registry";
            this.TitleLbl.Click += new System.EventHandler(this.label6_Click);
            // 
            // EnterRecordLbl
            // 
            this.EnterRecordLbl.AutoSize = true;
            this.EnterRecordLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterRecordLbl.Location = new System.Drawing.Point(28, 77);
            this.EnterRecordLbl.Name = "EnterRecordLbl";
            this.EnterRecordLbl.Size = new System.Drawing.Size(167, 21);
            this.EnterRecordLbl.TabIndex = 1;
            this.EnterRecordLbl.Text = "Enter Student Record";
            // 
            // Displaylbl
            // 
            this.Displaylbl.AutoSize = true;
            this.Displaylbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Displaylbl.Location = new System.Drawing.Point(28, 311);
            this.Displaylbl.Name = "Displaylbl";
            this.Displaylbl.Size = new System.Drawing.Size(126, 21);
            this.Displaylbl.TabIndex = 20;
            this.Displaylbl.Text = "Display Records";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Teal;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(753, 595);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(67, 41);
            this.btnExit.TabIndex = 23;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.btnsave);
            this.panel1.Location = new System.Drawing.Point(32, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 176);
            this.panel1.TabIndex = 20;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Teal;
            this.btndelete.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(174, 108);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(62, 41);
            this.btndelete.TabIndex = 19;
            this.btndelete.Text = "&Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // SearchIDtxt
            // 
            this.SearchIDtxt.BackColor = System.Drawing.Color.Lavender;
            this.SearchIDtxt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchIDtxt.ForeColor = System.Drawing.Color.Black;
            this.SearchIDtxt.Location = new System.Drawing.Point(28, 31);
            this.SearchIDtxt.Name = "SearchIDtxt";
            this.SearchIDtxt.Size = new System.Drawing.Size(159, 25);
            this.SearchIDtxt.TabIndex = 15;
            this.SearchIDtxt.Text = "Enter ID number to search";
            this.SearchIDtxt.TextChanged += new System.EventHandler(this.SearchIDtxt_TextChanged);
            this.SearchIDtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchIDtxt_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(567, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "Search-Update-Delete Record";
            // 
            // btnclearsearch
            // 
            this.btnclearsearch.BackColor = System.Drawing.Color.Teal;
            this.btnclearsearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclearsearch.ForeColor = System.Drawing.Color.White;
            this.btnclearsearch.Location = new System.Drawing.Point(87, 108);
            this.btnclearsearch.Name = "btnclearsearch";
            this.btnclearsearch.Size = new System.Drawing.Size(81, 41);
            this.btnclearsearch.TabIndex = 18;
            this.btnclearsearch.Text = "Clear Sea&rch";
            this.btnclearsearch.UseVisualStyleBackColor = false;
            this.btnclearsearch.Click += new System.EventHandler(this.btnclearsearch_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.btndisplay);
            this.panel2.Controls.Add(this.dgv);
            this.panel2.Location = new System.Drawing.Point(32, 338);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(786, 231);
            this.panel2.TabIndex = 25;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Navy;
            this.panel3.Controls.Add(this.btnclearsearch);
            this.panel3.Controls.Add(this.btnupdate);
            this.panel3.Controls.Add(this.btndelete);
            this.panel3.Controls.Add(this.SearchIDtxt);
            this.panel3.Controls.Add(this.btnsearch);
            this.panel3.Location = new System.Drawing.Point(571, 110);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(247, 176);
            this.panel3.TabIndex = 26;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(630, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 46);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(181, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 46);
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(855, 648);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.EnterRecordLbl);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Displaylbl);
            this.Controls.Add(this.TitleLbl);
            this.Controls.Add(this.txtcrs);
            this.Controls.Add(this.txtmi);
            this.Controls.Add(this.txtln);
            this.Controls.Add(this.txtfn);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.courselbl);
            this.Controls.Add(this.milbl);
            this.Controls.Add(this.lnamelbl);
            this.Controls.Add(this.fnamelbl);
            this.Controls.Add(this.idnumlbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "Form1";
            this.Text = "Student Information Registry";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idnumlbl;
        private System.Windows.Forms.Label fnamelbl;
        private System.Windows.Forms.Label lnamelbl;
        private System.Windows.Forms.Label milbl;
        private System.Windows.Forms.Label courselbl;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtfn;
        private System.Windows.Forms.TextBox txtln;
        private System.Windows.Forms.TextBox txtmi;
        private System.Windows.Forms.TextBox txtcrs;
        private System.Windows.Forms.Button btnsave;
      
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btndisplay;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.Label EnterRecordLbl;
        private System.Windows.Forms.Label Displaylbl;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.TextBox SearchIDtxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnclearsearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

