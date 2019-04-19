namespace oldestDogOrCat
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGetPet = new System.Windows.Forms.Button();
            this.rbDog = new System.Windows.Forms.RadioButton();
            this.Cat = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnWalk = new System.Windows.Forms.Button();
            this.btnSound = new System.Windows.Forms.Button();
            this.btnSleep = new System.Windows.Forms.Button();
            this.lblEnergy = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose Dog or Cat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(375, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "You will be given the oldest Pet of which you have  chosen";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGetPet);
            this.groupBox1.Controls.Add(this.rbDog);
            this.groupBox1.Controls.Add(this.Cat);
            this.groupBox1.Location = new System.Drawing.Point(478, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 115);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose Pet";
            // 
            // btnGetPet
            // 
            this.btnGetPet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetPet.Location = new System.Drawing.Point(139, 32);
            this.btnGetPet.Name = "btnGetPet";
            this.btnGetPet.Size = new System.Drawing.Size(120, 46);
            this.btnGetPet.TabIndex = 2;
            this.btnGetPet.Text = "Get Pet";
            this.btnGetPet.UseVisualStyleBackColor = true;
            this.btnGetPet.Click += new System.EventHandler(this.btnGetPet_Click);
            // 
            // rbDog
            // 
            this.rbDog.AutoSize = true;
            this.rbDog.Location = new System.Drawing.Point(23, 31);
            this.rbDog.Name = "rbDog";
            this.rbDog.Size = new System.Drawing.Size(55, 21);
            this.rbDog.TabIndex = 1;
            this.rbDog.TabStop = true;
            this.rbDog.Text = "Dog";
            this.rbDog.UseVisualStyleBackColor = true;
            // 
            // Cat
            // 
            this.Cat.AutoSize = true;
            this.Cat.Location = new System.Drawing.Point(23, 58);
            this.Cat.Name = "Cat";
            this.Cat.Size = new System.Drawing.Size(50, 21);
            this.Cat.TabIndex = 0;
            this.Cat.TabStop = true;
            this.Cat.Text = "Cat";
            this.Cat.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox1.Font = new System.Drawing.Font("Bookman Old Style", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(101, 175);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(516, 170);
            this.textBox1.TabIndex = 3;
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.Color.Red;
            this.btnRun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRun.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.ForeColor = System.Drawing.Color.White;
            this.btnRun.Location = new System.Drawing.Point(101, 383);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(98, 29);
            this.btnRun.TabIndex = 4;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnWalk
            // 
            this.btnWalk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnWalk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWalk.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWalk.Location = new System.Drawing.Point(245, 383);
            this.btnWalk.Name = "btnWalk";
            this.btnWalk.Size = new System.Drawing.Size(98, 29);
            this.btnWalk.TabIndex = 5;
            this.btnWalk.Text = "Walk";
            this.btnWalk.UseVisualStyleBackColor = false;
            this.btnWalk.Click += new System.EventHandler(this.btnWalk_Click);
            // 
            // btnSound
            // 
            this.btnSound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSound.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSound.Location = new System.Drawing.Point(383, 383);
            this.btnSound.Name = "btnSound";
            this.btnSound.Size = new System.Drawing.Size(98, 28);
            this.btnSound.TabIndex = 6;
            this.btnSound.Text = "Sound";
            this.btnSound.UseVisualStyleBackColor = true;
            this.btnSound.Click += new System.EventHandler(this.btnSound_Click);
            // 
            // btnSleep
            // 
            this.btnSleep.BackColor = System.Drawing.Color.Blue;
            this.btnSleep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSleep.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSleep.ForeColor = System.Drawing.Color.White;
            this.btnSleep.Location = new System.Drawing.Point(519, 383);
            this.btnSleep.Name = "btnSleep";
            this.btnSleep.Size = new System.Drawing.Size(98, 28);
            this.btnSleep.TabIndex = 7;
            this.btnSleep.Text = "Sleep";
            this.btnSleep.UseVisualStyleBackColor = false;
            this.btnSleep.Click += new System.EventHandler(this.btnSleep_Click);
            // 
            // lblEnergy
            // 
            this.lblEnergy.AutoSize = true;
            this.lblEnergy.Font = new System.Drawing.Font("Bookman Old Style", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnergy.Location = new System.Drawing.Point(622, 204);
            this.lblEnergy.Name = "lblEnergy";
            this.lblEnergy.Size = new System.Drawing.Size(200, 93);
            this.lblEnergy.TabIndex = 8;
            this.lblEnergy.Text = "  00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(834, 459);
            this.Controls.Add(this.lblEnergy);
            this.Controls.Add(this.btnSleep);
            this.Controls.Add(this.btnSound);
            this.Controls.Add(this.btnWalk);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Oldest Dog or Oldest Cat";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGetPet;
        private System.Windows.Forms.RadioButton rbDog;
        private System.Windows.Forms.RadioButton Cat;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnWalk;
        private System.Windows.Forms.Button btnSound;
        private System.Windows.Forms.Button btnSleep;
        private System.Windows.Forms.Label lblEnergy;
    }
}

