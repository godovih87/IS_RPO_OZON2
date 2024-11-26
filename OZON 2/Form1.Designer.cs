namespace OZON_2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.radioButtonBuyer = new System.Windows.Forms.RadioButton();
            this.radioButtonSeller = new System.Windows.Forms.RadioButton();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panelSeller = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSellerPassword = new System.Windows.Forms.TextBox();
            this.textBoxSellerLogin = new System.Windows.Forms.TextBox();
            this.panelBuyer = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxBuyerPassword = new System.Windows.Forms.TextBox();
            this.textBoxBuyerLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.panelSeller.SuspendLayout();
            this.panelBuyer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButtonBuyer
            // 
            this.radioButtonBuyer.AutoSize = true;
            this.radioButtonBuyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonBuyer.Location = new System.Drawing.Point(17, 68);
            this.radioButtonBuyer.Name = "radioButtonBuyer";
            this.radioButtonBuyer.Size = new System.Drawing.Size(175, 33);
            this.radioButtonBuyer.TabIndex = 0;
            this.radioButtonBuyer.TabStop = true;
            this.radioButtonBuyer.Text = "Покупатель";
            this.radioButtonBuyer.UseVisualStyleBackColor = true;
            this.radioButtonBuyer.CheckedChanged += new System.EventHandler(this.radioButtonBuyer_CheckedChanged_1);
            // 
            // radioButtonSeller
            // 
            this.radioButtonSeller.AutoSize = true;
            this.radioButtonSeller.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonSeller.Location = new System.Drawing.Point(17, 41);
            this.radioButtonSeller.Name = "radioButtonSeller";
            this.radioButtonSeller.Size = new System.Drawing.Size(154, 33);
            this.radioButtonSeller.TabIndex = 1;
            this.radioButtonSeller.TabStop = true;
            this.radioButtonSeller.Text = "Продавец";
            this.radioButtonSeller.UseVisualStyleBackColor = true;
            this.radioButtonSeller.CheckedChanged += new System.EventHandler(this.radioButtonSeller_CheckedChanged_1);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSubmit.Location = new System.Drawing.Point(184, 358);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(188, 44);
            this.buttonSubmit.TabIndex = 2;
            this.buttonSubmit.Text = "Register";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Выбор режима.";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panelSeller
            // 
            this.panelSeller.Controls.Add(this.checkBox2);
            this.panelSeller.Controls.Add(this.label4);
            this.panelSeller.Controls.Add(this.label5);
            this.panelSeller.Controls.Add(this.textBoxSellerPassword);
            this.panelSeller.Controls.Add(this.textBoxSellerLogin);
            this.panelSeller.Location = new System.Drawing.Point(184, 198);
            this.panelSeller.Name = "panelSeller";
            this.panelSeller.Size = new System.Drawing.Size(202, 154);
            this.panelSeller.TabIndex = 8;
            this.panelSeller.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSeller_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Login";
            // 
            // textBoxSellerPassword
            // 
            this.textBoxSellerPassword.Location = new System.Drawing.Point(3, 89);
            this.textBoxSellerPassword.Name = "textBoxSellerPassword";
            this.textBoxSellerPassword.Size = new System.Drawing.Size(191, 22);
            this.textBoxSellerPassword.TabIndex = 8;
            // 
            // textBoxSellerLogin
            // 
            this.textBoxSellerLogin.Location = new System.Drawing.Point(8, 35);
            this.textBoxSellerLogin.Name = "textBoxSellerLogin";
            this.textBoxSellerLogin.Size = new System.Drawing.Size(191, 22);
            this.textBoxSellerLogin.TabIndex = 7;
            // 
            // panelBuyer
            // 
            this.panelBuyer.Controls.Add(this.checkBox1);
            this.panelBuyer.Controls.Add(this.label6);
            this.panelBuyer.Controls.Add(this.label7);
            this.panelBuyer.Controls.Add(this.textBoxBuyerPassword);
            this.panelBuyer.Controls.Add(this.textBoxBuyerLogin);
            this.panelBuyer.Location = new System.Drawing.Point(176, 197);
            this.panelBuyer.Name = "panelBuyer";
            this.panelBuyer.Size = new System.Drawing.Size(202, 151);
            this.panelBuyer.TabIndex = 9;
            this.panelBuyer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBuyer_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(3, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 29);
            this.label7.TabIndex = 9;
            this.label7.Text = "Login";
            // 
            // textBoxBuyerPassword
            // 
            this.textBoxBuyerPassword.Location = new System.Drawing.Point(8, 89);
            this.textBoxBuyerPassword.Name = "textBoxBuyerPassword";
            this.textBoxBuyerPassword.Size = new System.Drawing.Size(191, 22);
            this.textBoxBuyerPassword.TabIndex = 8;
            // 
            // textBoxBuyerLogin
            // 
            this.textBoxBuyerLogin.Location = new System.Drawing.Point(8, 35);
            this.textBoxBuyerLogin.Name = "textBoxBuyerLogin";
            this.textBoxBuyerLogin.Size = new System.Drawing.Size(191, 22);
            this.textBoxBuyerLogin.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(101, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Уже есть аккаунт?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Location = new System.Drawing.Point(326, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Войти";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(225, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 159);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(430, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 52);
            this.label8.TabIndex = 13;
            this.label8.Text = "2";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(8, 117);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(144, 20);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Проверка пароля";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(7, 127);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(144, 20);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.Text = "Проверка пароля";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(501, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelBuyer);
            this.Controls.Add(this.panelSeller);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.radioButtonSeller);
            this.Controls.Add(this.radioButtonBuyer);
            this.Name = "Form1";
            this.Text = "OZON 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSeller.ResumeLayout(false);
            this.panelSeller.PerformLayout();
            this.panelBuyer.ResumeLayout(false);
            this.panelBuyer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonBuyer;
        private System.Windows.Forms.RadioButton radioButtonSeller;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelSeller;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSellerPassword;
        private System.Windows.Forms.TextBox textBoxSellerLogin;
        private System.Windows.Forms.Panel panelBuyer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxBuyerPassword;
        private System.Windows.Forms.TextBox textBoxBuyerLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}

