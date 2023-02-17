namespace DFWSv1._1
{
    partial class Protein
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
            this.Protein_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Protein_Back
            // 
            this.Protein_Back.Location = new System.Drawing.Point(24, 333);
            this.Protein_Back.Name = "Protein_Back";
            this.Protein_Back.Size = new System.Drawing.Size(75, 23);
            this.Protein_Back.TabIndex = 3;
            this.Protein_Back.Text = "Back";
            this.Protein_Back.UseVisualStyleBackColor = true;
            this.Protein_Back.Click += new System.EventHandler(this.Protein_Back_Click);
            // 
            // Protein
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 384);
            this.Controls.Add(this.Protein_Back);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Protein";
            this.Text = "Protein";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Protein_Back;
    }
}