
namespace LiveryConverter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.backupbtn = new System.Windows.Forms.Button();
            this.qmbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Reem Kufi", 21.75F);
            this.button1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Image = global::LiveryConverter.Properties.Resources.convert;
            this.button1.Location = new System.Drawing.Point(164, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 85);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F);
            this.button2.Location = new System.Drawing.Point(417, 174);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 25);
            this.button2.TabIndex = 1;
            this.button2.Text = "▪▪▪";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(95, 174);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(316, 24);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Location = new System.Drawing.Point(485, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "v.1.0";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // backupbtn
            // 
            this.backupbtn.BackColor = System.Drawing.Color.Transparent;
            this.backupbtn.Font = new System.Drawing.Font("Reem Kufi", 14.25F);
            this.backupbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.backupbtn.Image = global::LiveryConverter.Properties.Resources.rollback;
            this.backupbtn.Location = new System.Drawing.Point(411, 277);
            this.backupbtn.Name = "backupbtn";
            this.backupbtn.Size = new System.Drawing.Size(102, 44);
            this.backupbtn.TabIndex = 5;
            this.backupbtn.UseVisualStyleBackColor = false;
            this.backupbtn.Click += new System.EventHandler(this.Rollback_Click);
            // 
            // qmbtn
            // 
            this.qmbtn.AutoSize = true;
            this.qmbtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.qmbtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.qmbtn.FlatAppearance.BorderSize = 0;
            this.qmbtn.Image = global::LiveryConverter.Properties.Resources.iconnnn;
            this.qmbtn.Location = new System.Drawing.Point(12, 284);
            this.qmbtn.Name = "qmbtn";
            this.qmbtn.Size = new System.Drawing.Size(49, 49);
            this.qmbtn.TabIndex = 6;
            this.qmbtn.UseVisualStyleBackColor = false;
            this.qmbtn.Click += new System.EventHandler(this.qmbtn_click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox1.Image = global::LiveryConverter.Properties.Resources.selectyour;
            this.pictureBox1.Location = new System.Drawing.Point(95, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(364, 50);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::LiveryConverter.Properties.Resources.backgroundforprogram;
            this.ClientSize = new System.Drawing.Size(540, 345);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.qmbtn);
            this.Controls.Add(this.backupbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "LiveryConverter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button backupbtn;
        private System.Windows.Forms.Button qmbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

