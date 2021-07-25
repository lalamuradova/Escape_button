
namespace Escape_button
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
            this.catchmebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // catchmebtn
            // 
            this.catchmebtn.AutoSize = true;
            this.catchmebtn.BackColor = System.Drawing.Color.Teal;
            this.catchmebtn.Font = new System.Drawing.Font("Segoe Script", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catchmebtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.catchmebtn.Location = new System.Drawing.Point(463, 151);
            this.catchmebtn.Name = "catchmebtn";
            this.catchmebtn.Size = new System.Drawing.Size(190, 63);
            this.catchmebtn.TabIndex = 0;
            this.catchmebtn.Text = "Catch me";
            this.catchmebtn.UseVisualStyleBackColor = false;
            this.catchmebtn.MouseEnter += new System.EventHandler(this.catchmebtn_MouseEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 698);
            this.Controls.Add(this.catchmebtn);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button catchmebtn;
    }
}

