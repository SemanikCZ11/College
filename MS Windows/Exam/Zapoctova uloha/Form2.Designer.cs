
namespace Zapoctova_uloha
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.otazka = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.bprev = new System.Windows.Forms.Button();
            this.bnext = new System.Windows.Forms.Button();
            this.bsend = new System.Windows.Forms.Button();
            this.pozice = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // otazka
            // 
            resources.ApplyResources(this.otazka, "otazka");
            this.otazka.Name = "otazka";
            // 
            // checkBox2
            // 
            resources.ApplyResources(this.checkBox2, "checkBox2");
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            resources.ApplyResources(this.checkBox3, "checkBox3");
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // bprev
            // 
            resources.ApplyResources(this.bprev, "bprev");
            this.bprev.Name = "bprev";
            this.bprev.UseVisualStyleBackColor = true;
            this.bprev.Click += new System.EventHandler(this.bprev_Click);
            // 
            // bnext
            // 
            resources.ApplyResources(this.bnext, "bnext");
            this.bnext.Name = "bnext";
            this.bnext.UseVisualStyleBackColor = true;
            this.bnext.Click += new System.EventHandler(this.bnext_Click);
            // 
            // bsend
            // 
            resources.ApplyResources(this.bsend, "bsend");
            this.bsend.Name = "bsend";
            this.bsend.UseVisualStyleBackColor = true;
            this.bsend.Click += new System.EventHandler(this.bsend_Click);
            // 
            // pozice
            // 
            resources.ApplyResources(this.pozice, "pozice");
            this.pozice.Name = "pozice";
            // 
            // user
            // 
            resources.ApplyResources(this.user, "user");
            this.user.Name = "user";
            // 
            // Form2
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Controls.Add(this.user);
            this.Controls.Add(this.pozice);
            this.Controls.Add(this.bsend);
            this.Controls.Add(this.bnext);
            this.Controls.Add(this.bprev);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.otazka);
            this.Controls.Add(this.checkBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label otazka;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button bprev;
        private System.Windows.Forms.Button bnext;
        private System.Windows.Forms.Button bsend;
        private System.Windows.Forms.Label pozice;
        private System.Windows.Forms.Label user;
    }
}