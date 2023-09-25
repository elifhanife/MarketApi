namespace AppUI
{
	partial class LoginPage
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
			pictureBoxLogo = new PictureBox();
			pictureBoxUser = new PictureBox();
			panel1 = new Panel();
			panel2 = new Panel();
			pictureBoxPassword = new PictureBox();
			btnLogin = new Button();
			label2 = new Label();
			txtUserName = new TextBox();
			txtPassword = new TextBox();
			txtPhoneNumber = new TextBox();
			panel3 = new Panel();
			pictureBoxPhone = new PictureBox();
			txtAddress = new TextBox();
			panel4 = new Panel();
			pictureBoxAddress = new PictureBox();
			panel5 = new Panel();
			pictureBoxBasketWindow = new PictureBox();
			pictureBoxProductWindow = new PictureBox();
			pictureBoxSignUpWindow = new PictureBox();
			txtSurname = new TextBox();
			panel6 = new Panel();
			pictureBoxSurname = new PictureBox();
			((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBoxUser).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBoxPassword).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBoxPhone).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBoxAddress).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBoxBasketWindow).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBoxProductWindow).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBoxSignUpWindow).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBoxSurname).BeginInit();
			SuspendLayout();
			// 
			// pictureBoxLogo
			// 
			pictureBoxLogo.BorderStyle = BorderStyle.FixedSingle;
			pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
			pictureBoxLogo.Location = new Point(53, 33);
			pictureBoxLogo.Name = "pictureBoxLogo";
			pictureBoxLogo.Size = new Size(330, 91);
			pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBoxLogo.TabIndex = 0;
			pictureBoxLogo.TabStop = false;
			// 
			// pictureBoxUser
			// 
			pictureBoxUser.Image = (Image)resources.GetObject("pictureBoxUser.Image");
			pictureBoxUser.Location = new Point(50, 264);
			pictureBoxUser.Name = "pictureBoxUser";
			pictureBoxUser.Size = new Size(34, 36);
			pictureBoxUser.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBoxUser.TabIndex = 2;
			pictureBoxUser.TabStop = false;
			// 
			// panel1
			// 
			panel1.BackColor = SystemColors.ControlText;
			panel1.Location = new Point(50, 306);
			panel1.Name = "panel1";
			panel1.Size = new Size(330, 1);
			panel1.TabIndex = 3;
			// 
			// panel2
			// 
			panel2.BackColor = SystemColors.ControlText;
			panel2.Location = new Point(50, 579);
			panel2.Name = "panel2";
			panel2.Size = new Size(330, 1);
			panel2.TabIndex = 5;
			// 
			// pictureBoxPassword
			// 
			pictureBoxPassword.Image = (Image)resources.GetObject("pictureBoxPassword.Image");
			pictureBoxPassword.Location = new Point(50, 538);
			pictureBoxPassword.Name = "pictureBoxPassword";
			pictureBoxPassword.Size = new Size(34, 35);
			pictureBoxPassword.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBoxPassword.TabIndex = 4;
			pictureBoxPassword.TabStop = false;
			// 
			// btnLogin
			// 
			btnLogin.BackColor = SystemColors.ControlText;
			btnLogin.FlatAppearance.BorderSize = 0;
			btnLogin.FlatStyle = FlatStyle.Flat;
			btnLogin.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
			btnLogin.ForeColor = SystemColors.ButtonFace;
			btnLogin.Location = new Point(50, 648);
			btnLogin.Name = "btnLogin";
			btnLogin.Size = new Size(330, 47);
			btnLogin.TabIndex = 6;
			btnLogin.Text = "SIGN UP";
			btnLogin.UseVisualStyleBackColor = false;
			btnLogin.Click += btnLogin_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(193, 709);
			label2.Name = "label2";
			label2.Size = new Size(33, 20);
			label2.TabIndex = 7;
			label2.Text = "Exit";
			label2.Click += label2_Click;
			// 
			// txtUserName
			// 
			txtUserName.BorderStyle = BorderStyle.None;
			txtUserName.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
			txtUserName.Location = new Point(90, 275);
			txtUserName.Multiline = true;
			txtUserName.Name = "txtUserName";
			txtUserName.PlaceholderText = "Name";
			txtUserName.Size = new Size(290, 25);
			txtUserName.TabIndex = 8;
			// 
			// txtPassword
			// 
			txtPassword.BorderStyle = BorderStyle.None;
			txtPassword.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
			txtPassword.Location = new Point(90, 549);
			txtPassword.Multiline = true;
			txtPassword.Name = "txtPassword";
			txtPassword.PasswordChar = '*';
			txtPassword.PlaceholderText = "Password";
			txtPassword.Size = new Size(290, 24);
			txtPassword.TabIndex = 9;
			// 
			// txtPhoneNumber
			// 
			txtPhoneNumber.BorderStyle = BorderStyle.None;
			txtPhoneNumber.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
			txtPhoneNumber.Location = new Point(90, 408);
			txtPhoneNumber.Multiline = true;
			txtPhoneNumber.Name = "txtPhoneNumber";
			txtPhoneNumber.PlaceholderText = "Phone Number";
			txtPhoneNumber.Size = new Size(290, 25);
			txtPhoneNumber.TabIndex = 12;
			// 
			// panel3
			// 
			panel3.BackColor = SystemColors.ControlText;
			panel3.Location = new Point(50, 439);
			panel3.Name = "panel3";
			panel3.Size = new Size(330, 1);
			panel3.TabIndex = 11;
			// 
			// pictureBoxPhone
			// 
			pictureBoxPhone.Image = (Image)resources.GetObject("pictureBoxPhone.Image");
			pictureBoxPhone.Location = new Point(50, 397);
			pictureBoxPhone.Name = "pictureBoxPhone";
			pictureBoxPhone.Size = new Size(34, 36);
			pictureBoxPhone.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBoxPhone.TabIndex = 10;
			pictureBoxPhone.TabStop = false;
			// 
			// txtAddress
			// 
			txtAddress.BorderStyle = BorderStyle.None;
			txtAddress.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
			txtAddress.Location = new Point(90, 480);
			txtAddress.Multiline = true;
			txtAddress.Name = "txtAddress";
			txtAddress.PlaceholderText = "Address";
			txtAddress.Size = new Size(290, 25);
			txtAddress.TabIndex = 15;
			// 
			// panel4
			// 
			panel4.BackColor = SystemColors.ControlText;
			panel4.Location = new Point(50, 511);
			panel4.Name = "panel4";
			panel4.Size = new Size(330, 1);
			panel4.TabIndex = 14;
			// 
			// pictureBoxAddress
			// 
			pictureBoxAddress.Image = (Image)resources.GetObject("pictureBoxAddress.Image");
			pictureBoxAddress.Location = new Point(50, 469);
			pictureBoxAddress.Name = "pictureBoxAddress";
			pictureBoxAddress.Size = new Size(34, 36);
			pictureBoxAddress.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBoxAddress.TabIndex = 13;
			pictureBoxAddress.TabStop = false;
			// 
			// panel5
			// 
			panel5.BackColor = SystemColors.ControlText;
			panel5.Location = new Point(53, 224);
			panel5.Name = "panel5";
			panel5.Size = new Size(330, 2);
			panel5.TabIndex = 4;
			// 
			// pictureBoxBasketWindow
			// 
			pictureBoxBasketWindow.BorderStyle = BorderStyle.FixedSingle;
			pictureBoxBasketWindow.Image = (Image)resources.GetObject("pictureBoxBasketWindow.Image");
			pictureBoxBasketWindow.Location = new Point(279, 152);
			pictureBoxBasketWindow.Name = "pictureBoxBasketWindow";
			pictureBoxBasketWindow.Size = new Size(104, 72);
			pictureBoxBasketWindow.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBoxBasketWindow.TabIndex = 16;
			pictureBoxBasketWindow.TabStop = false;
			pictureBoxBasketWindow.Click += pictureBoxBasketWindow_Click;
			// 
			// pictureBoxProductWindow
			// 
			pictureBoxProductWindow.BorderStyle = BorderStyle.FixedSingle;
			pictureBoxProductWindow.Image = (Image)resources.GetObject("pictureBoxProductWindow.Image");
			pictureBoxProductWindow.Location = new Point(53, 152);
			pictureBoxProductWindow.Name = "pictureBoxProductWindow";
			pictureBoxProductWindow.Size = new Size(104, 72);
			pictureBoxProductWindow.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBoxProductWindow.TabIndex = 17;
			pictureBoxProductWindow.TabStop = false;
			pictureBoxProductWindow.Click += pictureBoxProductWindow_Click;
			// 
			// pictureBoxSignUpWindow
			// 
			pictureBoxSignUpWindow.BorderStyle = BorderStyle.FixedSingle;
			pictureBoxSignUpWindow.Image = (Image)resources.GetObject("pictureBoxSignUpWindow.Image");
			pictureBoxSignUpWindow.Location = new Point(166, 152);
			pictureBoxSignUpWindow.Name = "pictureBoxSignUpWindow";
			pictureBoxSignUpWindow.Size = new Size(104, 72);
			pictureBoxSignUpWindow.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBoxSignUpWindow.TabIndex = 18;
			pictureBoxSignUpWindow.TabStop = false;
			pictureBoxSignUpWindow.Click += pictureBoxSignUpWindow_Click;
			// 
			// txtSurname
			// 
			txtSurname.BorderStyle = BorderStyle.None;
			txtSurname.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
			txtSurname.Location = new Point(90, 342);
			txtSurname.Multiline = true;
			txtSurname.Name = "txtSurname";
			txtSurname.PlaceholderText = "Surname";
			txtSurname.Size = new Size(290, 25);
			txtSurname.TabIndex = 21;
			// 
			// panel6
			// 
			panel6.BackColor = SystemColors.ControlText;
			panel6.Location = new Point(50, 373);
			panel6.Name = "panel6";
			panel6.Size = new Size(330, 1);
			panel6.TabIndex = 20;
			// 
			// pictureBoxSurname
			// 
			pictureBoxSurname.Image = (Image)resources.GetObject("pictureBoxSurname.Image");
			pictureBoxSurname.Location = new Point(50, 331);
			pictureBoxSurname.Name = "pictureBoxSurname";
			pictureBoxSurname.Size = new Size(34, 36);
			pictureBoxSurname.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBoxSurname.TabIndex = 19;
			pictureBoxSurname.TabStop = false;
			// 
			// LoginPage
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(432, 755);
			Controls.Add(txtSurname);
			Controls.Add(panel6);
			Controls.Add(pictureBoxSurname);
			Controls.Add(pictureBoxSignUpWindow);
			Controls.Add(pictureBoxProductWindow);
			Controls.Add(pictureBoxBasketWindow);
			Controls.Add(panel5);
			Controls.Add(txtAddress);
			Controls.Add(panel4);
			Controls.Add(pictureBoxAddress);
			Controls.Add(txtPhoneNumber);
			Controls.Add(panel3);
			Controls.Add(pictureBoxPhone);
			Controls.Add(txtPassword);
			Controls.Add(txtUserName);
			Controls.Add(label2);
			Controls.Add(btnLogin);
			Controls.Add(panel2);
			Controls.Add(pictureBoxPassword);
			Controls.Add(panel1);
			Controls.Add(pictureBoxUser);
			Controls.Add(pictureBoxLogo);
			FormBorderStyle = FormBorderStyle.None;
			Name = "LoginPage";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Sign Up";
			((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBoxUser).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBoxPassword).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBoxPhone).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBoxAddress).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBoxBasketWindow).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBoxProductWindow).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBoxSignUpWindow).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBoxSurname).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox pictureBoxLogo;
		private PictureBox pictureBoxUser;
		private Panel panel1;
		private Panel panel2;
		private PictureBox pictureBoxPassword;
		private Button btnLogin;
		private Label label2;
		private TextBox txtUserName;
		private TextBox txtPassword;
		private TextBox txtPhoneNumber;
		private Panel panel3;
		private PictureBox pictureBoxPhone;
		private TextBox txtAddress;
		private Panel panel4;
		private PictureBox pictureBoxAddress;
		private Panel panel5;
		private PictureBox pictureBoxBasketWindow;
		private PictureBox pictureBoxProductWindow;
		private PictureBox pictureBoxSignUpWindow;
		private TextBox txtSurname;
		private Panel panel6;
		private PictureBox pictureBoxSurname;
	}
}