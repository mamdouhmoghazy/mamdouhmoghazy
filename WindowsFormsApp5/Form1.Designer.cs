namespace WindowsFormsApp5
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.select = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.previous = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(22, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(588, 454);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // select
            // 
            this.select.BackColor = System.Drawing.Color.CadetBlue;
            this.select.Cursor = System.Windows.Forms.Cursors.Hand;
            this.select.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.select.Location = new System.Drawing.Point(244, 494);
            this.select.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(133, 41);
            this.select.TabIndex = 1;
            this.select.Text = "Select";
            this.select.UseVisualStyleBackColor = false;
            this.select.Click += new System.EventHandler(this.select_Click_1);
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.Color.CadetBlue;
            this.next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.next.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.next.Location = new System.Drawing.Point(389, 510);
            this.next.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(133, 41);
            this.next.TabIndex = 2;
            this.next.Text = "Next";
            this.next.UseVisualStyleBackColor = false;
            this.next.Click += new System.EventHandler(this.next_Click_1);
            // 
            // previous
            // 
            this.previous.BackColor = System.Drawing.Color.CadetBlue;
            this.previous.Cursor = System.Windows.Forms.Cursors.Hand;
            this.previous.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.previous.Location = new System.Drawing.Point(99, 510);
            this.previous.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(133, 41);
            this.previous.TabIndex = 3;
            this.previous.Text = "Previous";
            this.previous.UseVisualStyleBackColor = false;
            this.previous.Click += new System.EventHandler(this.previous_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(633, 574);
            this.Controls.Add(this.previous);
            this.Controls.Add(this.next);
            this.Controls.Add(this.select);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button previous;
    }
}

