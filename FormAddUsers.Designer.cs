namespace WindowsFormsApp1
{
    partial class FormAddUsers
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
            this.components = new System.ComponentModel.Container();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox2 = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.first_NameTextBox = new System.Windows.Forms.TextBox();
            this.second_NameTextBox = new System.Windows.Forms.TextBox();
            this.roleIDComboBox = new System.Windows.Forms.ComboBox();
            this.BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.radioButtonMen = new System.Windows.Forms.RadioButton();
            this.radioButtonWoman = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.PhonemaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonBack
            // 
            this.ButtonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonBack.Location = new System.Drawing.Point(37, 26);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(115, 41);
            this.ButtonBack.TabIndex = 0;
            this.ButtonBack.Text = "Back";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAdd.Location = new System.Drawing.Point(636, 374);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(115, 42);
            this.ButtonAdd.TabIndex = 1;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(297, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adding new user";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTextBox.Location = new System.Drawing.Point(174, 139);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(188, 24);
            this.loginTextBox.TabIndex = 3;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextBox.Location = new System.Drawing.Point(174, 187);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(188, 24);
            this.passwordTextBox.TabIndex = 4;
            // 
            // passwordTextBox2
            // 
            this.passwordTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextBox2.Location = new System.Drawing.Point(174, 232);
            this.passwordTextBox2.Name = "passwordTextBox2";
            this.passwordTextBox2.PasswordChar = '*';
            this.passwordTextBox2.Size = new System.Drawing.Size(188, 24);
            this.passwordTextBox2.TabIndex = 5;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailTextBox.Location = new System.Drawing.Point(174, 274);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(188, 24);
            this.emailTextBox.TabIndex = 6;
            // 
            // first_NameTextBox
            // 
            this.first_NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.first_NameTextBox.Location = new System.Drawing.Point(547, 133);
            this.first_NameTextBox.Name = "first_NameTextBox";
            this.first_NameTextBox.Size = new System.Drawing.Size(162, 24);
            this.first_NameTextBox.TabIndex = 8;
            // 
            // second_NameTextBox
            // 
            this.second_NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.second_NameTextBox.Location = new System.Drawing.Point(547, 187);
            this.second_NameTextBox.Name = "second_NameTextBox";
            this.second_NameTextBox.Size = new System.Drawing.Size(162, 24);
            this.second_NameTextBox.TabIndex = 9;
            // 
            // roleIDComboBox
            // 
            this.roleIDComboBox.DataSource = this.BindingSource1;
            this.roleIDComboBox.DisplayMember = "Name";
            this.roleIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleIDComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roleIDComboBox.FormattingEnabled = true;
            this.roleIDComboBox.Location = new System.Drawing.Point(547, 235);
            this.roleIDComboBox.Name = "roleIDComboBox";
            this.roleIDComboBox.Size = new System.Drawing.Size(162, 26);
            this.roleIDComboBox.TabIndex = 10;
            this.roleIDComboBox.ValueMember = "ID";
            // 
            // BindingSource1
            // 
            this.BindingSource1.DataSource = typeof(WindowsFormsApp1.DBContext.Roles);
            // 
            // radioButtonMen
            // 
            this.radioButtonMen.AutoSize = true;
            this.radioButtonMen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonMen.Location = new System.Drawing.Point(547, 291);
            this.radioButtonMen.Name = "radioButtonMen";
            this.radioButtonMen.Size = new System.Drawing.Size(58, 22);
            this.radioButtonMen.TabIndex = 11;
            this.radioButtonMen.Text = "Male";
            this.radioButtonMen.UseVisualStyleBackColor = true;
            // 
            // radioButtonWoman
            // 
            this.radioButtonWoman.AutoSize = true;
            this.radioButtonWoman.Checked = true;
            this.radioButtonWoman.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonWoman.Location = new System.Drawing.Point(634, 291);
            this.radioButtonWoman.Name = "radioButtonWoman";
            this.radioButtonWoman.Size = new System.Drawing.Size(75, 22);
            this.radioButtonWoman.TabIndex = 12;
            this.radioButtonWoman.TabStop = true;
            this.radioButtonWoman.Text = "Female";
            this.radioButtonWoman.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(34, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Login:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(34, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(34, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Password again:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(34, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Your gmail:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(34, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "Phone number:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(458, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(458, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 18);
            this.label8.TabIndex = 19;
            this.label8.Text = "Surname:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(461, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 18);
            this.label9.TabIndex = 20;
            this.label9.Text = "Role:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(461, 295);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 18);
            this.label10.TabIndex = 21;
            this.label10.Text = "Gender:";
            // 
            // PhonemaskedTextBox
            // 
            this.PhonemaskedTextBox.Location = new System.Drawing.Point(174, 316);
            this.PhonemaskedTextBox.Mask = "+7 (000) 000-00-00";
            this.PhonemaskedTextBox.Name = "PhonemaskedTextBox";
            this.PhonemaskedTextBox.Size = new System.Drawing.Size(188, 20);
            this.PhonemaskedTextBox.TabIndex = 22;
            // 
            // FormAddUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PhonemaskedTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButtonWoman);
            this.Controls.Add(this.radioButtonMen);
            this.Controls.Add(this.roleIDComboBox);
            this.Controls.Add(this.second_NameTextBox);
            this.Controls.Add(this.first_NameTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.passwordTextBox2);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.ButtonBack);
            this.Name = "FormAddUsers";
            this.Text = "FormAddUsers";
            this.Load += new System.EventHandler(this.FormAddUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox passwordTextBox2;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox first_NameTextBox;
        private System.Windows.Forms.TextBox second_NameTextBox;
        private System.Windows.Forms.ComboBox roleIDComboBox;
        private System.Windows.Forms.RadioButton radioButtonMen;
        private System.Windows.Forms.RadioButton radioButtonWoman;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox PhonemaskedTextBox;
        private System.Windows.Forms.BindingSource BindingSource1;
    }
}