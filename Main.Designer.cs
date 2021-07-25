
namespace GenshinWishesPredictor
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.anyChance = new System.Windows.Forms.Label();
            this.eventChance = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(133, 190);
            this.textBox1.MaxLength = 12;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "12000";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.UpdateProbabilities);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 52);
            this.label1.TabIndex = 2;
            this.label1.Text = "Amount of primogems:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(113, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Genshin Impact";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(337, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Wishes Predictor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(101, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(353, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Your chance to get any 5* character is";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(83, 428);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(371, 26);
            this.label5.TabIndex = 6;
            this.label5.Text = "Your chance to get event 5* character is";
            // 
            // anyChance
            // 
            this.anyChance.AutoSize = true;
            this.anyChance.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anyChance.ForeColor = System.Drawing.Color.SteelBlue;
            this.anyChance.Location = new System.Drawing.Point(450, 388);
            this.anyChance.Name = "anyChance";
            this.anyChance.Size = new System.Drawing.Size(18, 26);
            this.anyChance.TabIndex = 7;
            this.anyChance.Text = "-";
            // 
            // eventChance
            // 
            this.eventChance.AutoSize = true;
            this.eventChance.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventChance.ForeColor = System.Drawing.Color.SteelBlue;
            this.eventChance.Location = new System.Drawing.Point(450, 428);
            this.eventChance.Name = "eventChance";
            this.eventChance.Size = new System.Drawing.Size(18, 26);
            this.eventChance.TabIndex = 8;
            this.eventChance.Text = "-";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(411, 190);
            this.textBox2.MaxLength = 12;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(92, 22);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "0";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.UpdateProbabilities);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(168, 264);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(253, 30);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Previous 5* wasn\'t event";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(406, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 52);
            this.label7.TabIndex = 14;
            this.label7.Text = "Amount of made wishes:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(323, 123);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(168, 310);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(276, 30);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.Text = "Calculate whole probability";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(425, 271);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(16, 16);
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(448, 317);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(16, 16);
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(575, 123);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(16, 16);
            this.pictureBox5.TabIndex = 18;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(245, 123);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(16, 16);
            this.pictureBox6.TabIndex = 19;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(614, 487);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.eventChance);
            this.Controls.Add(this.anyChance);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Wishes Predictor 1.2.1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label anyChance;
        private System.Windows.Forms.Label eventChance;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}

