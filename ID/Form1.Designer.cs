namespace ID
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
            this.addbtn = new System.Windows.Forms.Button();
            this.showbtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addbtn
            // 
            this.addbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.Location = new System.Drawing.Point(59, 33);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(173, 48);
            this.addbtn.TabIndex = 0;
            this.addbtn.Text = "Add Data";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // showbtn
            // 
            this.showbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showbtn.Location = new System.Drawing.Point(59, 97);
            this.showbtn.Name = "showbtn";
            this.showbtn.Size = new System.Drawing.Size(173, 48);
            this.showbtn.TabIndex = 1;
            this.showbtn.Text = "Show or Modify";
            this.showbtn.UseVisualStyleBackColor = true;
            this.showbtn.Click += new System.EventHandler(this.showbtn_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.button4.Location = new System.Drawing.Point(59, 161);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(173, 48);
            this.button4.TabIndex = 3;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 232);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.showbtn);
            this.Controls.Add(this.addbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ID And Password";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button showbtn;
        private System.Windows.Forms.Button button4;
    }
}

