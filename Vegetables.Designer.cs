namespace DFWSv1._1
{
    partial class Vegetables
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
            this.Vegetables_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Vegetables_Back
            // 
            this.Vegetables_Back.Location = new System.Drawing.Point(24, 333);
            this.Vegetables_Back.Name = "Vegetables_Back";
            this.Vegetables_Back.Size = new System.Drawing.Size(75, 23);
            this.Vegetables_Back.TabIndex = 3;
            this.Vegetables_Back.Text = "Back";
            this.Vegetables_Back.UseVisualStyleBackColor = true;
            this.Vegetables_Back.Click += new System.EventHandler(this.Vegetables_Back_Click);
            // 
            // Vegetables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 384);
            this.Controls.Add(this.Vegetables_Back);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Vegetables";
            this.Text = "Vegetables";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Vegetables_Back;
    }
}