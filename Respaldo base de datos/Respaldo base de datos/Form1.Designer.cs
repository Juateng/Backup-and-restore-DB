namespace Respaldo_base_de_datos
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
            this.Browse_Button = new System.Windows.Forms.Button();
            this.Backup_button = new System.Windows.Forms.Button();
            this.Restore_button = new System.Windows.Forms.Button();
            this.Browse_button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Browse_Button
            // 
            this.Browse_Button.Location = new System.Drawing.Point(630, 80);
            this.Browse_Button.Name = "Browse_Button";
            this.Browse_Button.Size = new System.Drawing.Size(93, 40);
            this.Browse_Button.TabIndex = 0;
            this.Browse_Button.Text = "Browse";
            this.Browse_Button.UseVisualStyleBackColor = true;
            this.Browse_Button.Click += new System.EventHandler(this.Browse_Button_Click);
            // 
            // Backup_button
            // 
            this.Backup_button.Location = new System.Drawing.Point(630, 126);
            this.Backup_button.Name = "Backup_button";
            this.Backup_button.Size = new System.Drawing.Size(93, 40);
            this.Backup_button.TabIndex = 1;
            this.Backup_button.Text = "Backup";
            this.Backup_button.UseVisualStyleBackColor = true;
            this.Backup_button.Click += new System.EventHandler(this.Backup_button_Click);
            // 
            // Restore_button
            // 
            this.Restore_button.Location = new System.Drawing.Point(630, 268);
            this.Restore_button.Name = "Restore_button";
            this.Restore_button.Size = new System.Drawing.Size(93, 40);
            this.Restore_button.TabIndex = 3;
            this.Restore_button.Text = "Restore";
            this.Restore_button.UseVisualStyleBackColor = true;
            this.Restore_button.Click += new System.EventHandler(this.Restore_button_Click);
            // 
            // Browse_button2
            // 
            this.Browse_button2.Location = new System.Drawing.Point(630, 222);
            this.Browse_button2.Name = "Browse_button2";
            this.Browse_button2.Size = new System.Drawing.Size(93, 40);
            this.Browse_button2.TabIndex = 2;
            this.Browse_button2.Text = "Browse";
            this.Browse_button2.UseVisualStyleBackColor = true;
            this.Browse_button2.Click += new System.EventHandler(this.Browse_button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(171, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(397, 26);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(171, 236);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(397, 26);
            this.textBox2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Backup Database";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Backup Database";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Restore_button);
            this.Controls.Add(this.Browse_button2);
            this.Controls.Add(this.Backup_button);
            this.Controls.Add(this.Browse_Button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Browse_Button;
        private System.Windows.Forms.Button Backup_button;
        private System.Windows.Forms.Button Restore_button;
        private System.Windows.Forms.Button Browse_button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

