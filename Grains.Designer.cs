namespace DFWSv1._1
{
    partial class Grains
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
            this.Grains_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Grains_Back
            // 
            this.Grains_Back.Location = new System.Drawing.Point(24, 333);
            this.Grains_Back.Name = "Grains_Back";
            this.Grains_Back.Size = new System.Drawing.Size(75, 23);
            this.Grains_Back.TabIndex = 2;
            this.Grains_Back.Text = "Back";
            this.Grains_Back.UseVisualStyleBackColor = true;
            this.Grains_Back.Click += new System.EventHandler(this.Grains_Back_Click);
            // 
            // Grains
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 384);
            this.Controls.Add(this.Grains_Back);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Grains";
            this.Text = "Grains";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Grains_Back;
    }
}