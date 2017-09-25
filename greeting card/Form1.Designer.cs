namespace greeting_card
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
            this.horoscope = new System.Windows.Forms.Label();
            this.nameTag = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // horoscope
            // 
            this.horoscope.AutoSize = true;
            this.horoscope.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horoscope.Location = new System.Drawing.Point(270, 9);
            this.horoscope.Name = "horoscope";
            this.horoscope.Size = new System.Drawing.Size(183, 30);
            this.horoscope.TabIndex = 0;
            this.horoscope.Text = "Pisces Horoscope";
            // 
            // nameTag
            // 
            this.nameTag.AutoSize = true;
            this.nameTag.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.nameTag.Location = new System.Drawing.Point(155, 446);
            this.nameTag.Name = "nameTag";
            this.nameTag.Size = new System.Drawing.Size(141, 30);
            this.nameTag.TabIndex = 1;
            this.nameTag.Text = "Devin Mcneil";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::greeting_card.Properties.Resources.pisces_png;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(465, 485);
            this.Controls.Add(this.nameTag);
            this.Controls.Add(this.horoscope);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label horoscope;
        private System.Windows.Forms.Label nameTag;
    }
}

