namespace DFWSv1._1
{
    partial class Dairy
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
            this.Dairy_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Dairy_Back
            // 
            this.Dairy_Back.Location = new System.Drawing.Point(24, 333);
            this.Dairy_Back.Name = "Dairy_Back";
            this.Dairy_Back.Size = new System.Drawing.Size(75, 23);
            this.Dairy_Back.TabIndex = 1;
            this.Dairy_Back.Text = "Back";
            this.Dairy_Back.UseVisualStyleBackColor = true;
            this.Dairy_Back.Click += new System.EventHandler(this.Dairy_Back_Click);
            // 
            // Dairy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 384);
            this.Controls.Add(this.Dairy_Back);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Dairy";
            this.Text = "Dairy";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Dairy_Back;
    }
}