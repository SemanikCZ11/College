
namespace FOrm1
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
            this.name = new System.Windows.Forms.Label();
            this.B1 = new System.Windows.Forms.Button();
            this.TB1 = new System.Windows.Forms.TextBox();
            this.vitej = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft YaHei Light", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.name.Location = new System.Drawing.Point(185, 154);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(74, 28);
            this.name.TabIndex = 0;
            this.name.Text = "Jméno";
            // 
            // B1
            // 
            this.B1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.B1.Location = new System.Drawing.Point(179, 231);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(389, 38);
            this.B1.TabIndex = 1;
            this.B1.Text = "Odeslat";
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.B1_Click);
            // 
            // TB1
            // 
            this.TB1.BackColor = System.Drawing.SystemColors.Menu;
            this.TB1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB1.ForeColor = System.Drawing.Color.Teal;
            this.TB1.Location = new System.Drawing.Point(278, 153);
            this.TB1.Name = "TB1";
            this.TB1.Size = new System.Drawing.Size(226, 29);
            this.TB1.TabIndex = 2;
            // 
            // vitej
            // 
            this.vitej.AutoSize = true;
            this.vitej.Font = new System.Drawing.Font("Snap ITC", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vitej.Location = new System.Drawing.Point(306, 43);
            this.vitej.Name = "vitej";
            this.vitej.Size = new System.Drawing.Size(143, 51);
            this.vitej.TabIndex = 3;
            this.vitej.Text = "Vítej";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(749, 404);
            this.Controls.Add(this.vitej);
            this.Controls.Add(this.TB1);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.name);
            this.ForeColor = System.Drawing.Color.DarkViolet;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.TextBox TB1;
        private System.Windows.Forms.Label vitej;
    }
}

