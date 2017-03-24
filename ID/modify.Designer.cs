namespace ID
{
    partial class modify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modify));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.modifybtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(29, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(12, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("SketchFlow Print", 14.25F);
            this.textBox1.Location = new System.Drawing.Point(112, 61);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 25);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("SketchFlow Print", 14.25F);
            this.textBox2.Location = new System.Drawing.Point(112, 111);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 25);
            this.textBox2.TabIndex = 3;
            // 
            // modifybtn
            // 
            this.modifybtn.Font = new System.Drawing.Font("Buxton Sketch", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifybtn.Location = new System.Drawing.Point(87, 163);
            this.modifybtn.Name = "modifybtn";
            this.modifybtn.Size = new System.Drawing.Size(112, 33);
            this.modifybtn.TabIndex = 4;
            this.modifybtn.Text = "Modify";
            this.modifybtn.UseVisualStyleBackColor = true;
            this.modifybtn.Click += new System.EventHandler(this.modifybtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Font = new System.Drawing.Font("Buxton Sketch", 14.25F);
            this.deletebtn.Location = new System.Drawing.Point(87, 202);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(112, 33);
            this.deletebtn.TabIndex = 5;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // backbtn
            // 
            this.backbtn.Font = new System.Drawing.Font("Buxton Sketch", 14.25F);
            this.backbtn.Location = new System.Drawing.Point(87, 241);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(112, 33);
            this.backbtn.TabIndex = 6;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(29, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Site";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("SketchFlow Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(112, 12);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(150, 28);
            this.textBox3.TabIndex = 8;
            // 
            // modify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 276);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.modifybtn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "modify";
            this.Text = "MODIFY";
            this.Load += new System.EventHandler(this.modify_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button modifybtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
    }
}