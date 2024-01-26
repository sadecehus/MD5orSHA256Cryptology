namespace example
{
    partial class SifrelemePaneli
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
            this.label1 = new System.Windows.Forms.Label();
            this.shalengthlabel = new System.Windows.Forms.Label();
            this.md5lengthlabel = new System.Windows.Forms.Label();
            this.shaLabel = new System.Windows.Forms.Label();
            this.md5label = new System.Windows.Forms.Label();
            this.shaBox = new System.Windows.Forms.RichTextBox();
            this.md5Box = new System.Windows.Forms.RichTextBox();
            this.sifreLabel = new System.Windows.Forms.Label();
            this.sifreBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(118, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 38);
            this.label1.TabIndex = 23;
            this.label1.Text = "Şifreleme Paneli";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shalengthlabel
            // 
            this.shalengthlabel.AutoSize = true;
            this.shalengthlabel.Location = new System.Drawing.Point(422, 341);
            this.shalengthlabel.Name = "shalengthlabel";
            this.shalengthlabel.Size = new System.Drawing.Size(35, 16);
            this.shalengthlabel.TabIndex = 22;
            this.shalengthlabel.Text = "SHA";
            // 
            // md5lengthlabel
            // 
            this.md5lengthlabel.AutoSize = true;
            this.md5lengthlabel.Location = new System.Drawing.Point(422, 201);
            this.md5lengthlabel.Name = "md5lengthlabel";
            this.md5lengthlabel.Size = new System.Drawing.Size(35, 16);
            this.md5lengthlabel.TabIndex = 21;
            this.md5lengthlabel.Text = "MD5";
            // 
            // shaLabel
            // 
            this.shaLabel.AutoSize = true;
            this.shaLabel.Location = new System.Drawing.Point(74, 341);
            this.shaLabel.Name = "shaLabel";
            this.shaLabel.Size = new System.Drawing.Size(35, 16);
            this.shaLabel.TabIndex = 20;
            this.shaLabel.Text = "SHA";
            // 
            // md5label
            // 
            this.md5label.AutoSize = true;
            this.md5label.Location = new System.Drawing.Point(74, 201);
            this.md5label.Name = "md5label";
            this.md5label.Size = new System.Drawing.Size(35, 16);
            this.md5label.TabIndex = 19;
            this.md5label.Text = "MD5";
            // 
            // shaBox
            // 
            this.shaBox.Location = new System.Drawing.Point(144, 286);
            this.shaBox.Name = "shaBox";
            this.shaBox.Size = new System.Drawing.Size(240, 100);
            this.shaBox.TabIndex = 18;
            this.shaBox.Text = "";
            // 
            // md5Box
            // 
            this.md5Box.Location = new System.Drawing.Point(144, 156);
            this.md5Box.Name = "md5Box";
            this.md5Box.Size = new System.Drawing.Size(240, 100);
            this.md5Box.TabIndex = 17;
            this.md5Box.Text = "";
            // 
            // sifreLabel
            // 
            this.sifreLabel.AutoSize = true;
            this.sifreLabel.Location = new System.Drawing.Point(74, 109);
            this.sifreLabel.Name = "sifreLabel";
            this.sifreLabel.Size = new System.Drawing.Size(34, 16);
            this.sifreLabel.TabIndex = 16;
            this.sifreLabel.Text = "Şifre";
            // 
            // sifreBox
            // 
            this.sifreBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreBox.Location = new System.Drawing.Point(144, 103);
            this.sifreBox.Name = "sifreBox";
            this.sifreBox.Size = new System.Drawing.Size(238, 27);
            this.sifreBox.TabIndex = 15;
            this.sifreBox.TextChanged += new System.EventHandler(this.sifreBox_TextChanged_1);
            // 
            // SifrelemePaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shalengthlabel);
            this.Controls.Add(this.md5lengthlabel);
            this.Controls.Add(this.shaLabel);
            this.Controls.Add(this.md5label);
            this.Controls.Add(this.shaBox);
            this.Controls.Add(this.md5Box);
            this.Controls.Add(this.sifreLabel);
            this.Controls.Add(this.sifreBox);
            this.Name = "SifrelemePaneli";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label shalengthlabel;
        private System.Windows.Forms.Label md5lengthlabel;
        private System.Windows.Forms.Label shaLabel;
        private System.Windows.Forms.Label md5label;
        private System.Windows.Forms.RichTextBox shaBox;
        private System.Windows.Forms.RichTextBox md5Box;
        private System.Windows.Forms.Label sifreLabel;
        private System.Windows.Forms.TextBox sifreBox;
    }
}

