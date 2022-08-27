namespace notetakingversion
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txttitle = new System.Windows.Forms.TextBox();
            this.txtmessage = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bttnnew = new System.Windows.Forms.Button();
            this.bttnsave = new System.Windows.Forms.Button();
            this.bttnread = new System.Windows.Forms.Button();
            this.bttndelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "message";
            // 
            // txttitle
            // 
            this.txttitle.Location = new System.Drawing.Point(162, 57);
            this.txttitle.Name = "txttitle";
            this.txttitle.Size = new System.Drawing.Size(200, 38);
            this.txttitle.TabIndex = 2;
            // 
            // txtmessage
            // 
            this.txtmessage.Location = new System.Drawing.Point(162, 133);
            this.txtmessage.Multiline = true;
            this.txtmessage.Name = "txtmessage";
            this.txtmessage.Size = new System.Drawing.Size(280, 274);
            this.txtmessage.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(459, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(369, 341);
            this.dataGridView1.TabIndex = 4;
            // 
            // bttnnew
            // 
            this.bttnnew.Location = new System.Drawing.Point(46, 471);
            this.bttnnew.Name = "bttnnew";
            this.bttnnew.Size = new System.Drawing.Size(150, 46);
            this.bttnnew.TabIndex = 5;
            this.bttnnew.Text = "New";
            this.bttnnew.UseVisualStyleBackColor = true;
            this.bttnnew.Click += new System.EventHandler(this.bttnnew_Click);
            // 
            // bttnsave
            // 
            this.bttnsave.Location = new System.Drawing.Point(248, 471);
            this.bttnsave.Name = "bttnsave";
            this.bttnsave.Size = new System.Drawing.Size(150, 46);
            this.bttnsave.TabIndex = 6;
            this.bttnsave.Text = "Save";
            this.bttnsave.UseVisualStyleBackColor = true;
            this.bttnsave.Click += new System.EventHandler(this.bttnsave_Click);
            // 
            // bttnread
            // 
            this.bttnread.Location = new System.Drawing.Point(459, 471);
            this.bttnread.Name = "bttnread";
            this.bttnread.Size = new System.Drawing.Size(150, 46);
            this.bttnread.TabIndex = 7;
            this.bttnread.Text = "Read";
            this.bttnread.UseVisualStyleBackColor = true;
            this.bttnread.Click += new System.EventHandler(this.bttnread_Click);
            // 
            // bttndelete
            // 
            this.bttndelete.Location = new System.Drawing.Point(678, 471);
            this.bttndelete.Name = "bttndelete";
            this.bttndelete.Size = new System.Drawing.Size(150, 46);
            this.bttndelete.TabIndex = 8;
            this.bttndelete.Text = "Delete";
            this.bttndelete.UseVisualStyleBackColor = true;
            this.bttndelete.Click += new System.EventHandler(this.bttndelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 602);
            this.Controls.Add(this.bttndelete);
            this.Controls.Add(this.bttnread);
            this.Controls.Add(this.bttnsave);
            this.Controls.Add(this.bttnnew);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtmessage);
            this.Controls.Add(this.txttitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txttitle;
        private TextBox txtmessage;
        private DataGridView dataGridView1;
        private Button bttnnew;
        private Button bttnsave;
        private Button bttnread;
        private Button bttndelete;
    }
}