namespace ID
{
    partial class add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add));
            this.namelabel = new System.Windows.Forms.Label();
            this.passwordlabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.savebtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic);
            this.namelabel.Location = new System.Drawing.Point(12, 60);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(35, 25);
            this.namelabel.TabIndex = 0;
            this.namelabel.Text = "ID";
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic);
            this.passwordlabel.Location = new System.Drawing.Point(3, 102);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(84, 25);
            this.passwordlabel.TabIndex = 1;
            this.passwordlabel.Text = "Password";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("SketchFlow Print", 14.25F);
            this.textBox1.Location = new System.Drawing.Point(105, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 27);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("SketchFlow Print", 14.25F);
            this.textBox2.Location = new System.Drawing.Point(105, 102);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(143, 27);
            this.textBox2.TabIndex = 3;
            // 
            // savebtn
            // 
            this.savebtn.Font = new System.Drawing.Font("Buxton Sketch", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebtn.Location = new System.Drawing.Point(88, 143);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(86, 33);
            this.savebtn.TabIndex = 4;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Site";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("SketchFlow Print", 14.25F);
            this.textBox3.Location = new System.Drawing.Point(105, 12);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(143, 27);
            this.textBox3.TabIndex = 6;
            // 
            // add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 188);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.passwordlabel);
            this.Controls.Add(this.namelabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADD";
            this.Load += new System.EventHandler(this.add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label passwordlabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
    }
}