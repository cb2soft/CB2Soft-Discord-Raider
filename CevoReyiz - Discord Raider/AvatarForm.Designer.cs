namespace CevoReyiz___Discord_Raider
{
    partial class AvatarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AvatarForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.btn_avatarInfo = new MaterialSkin.Controls.MaterialFlatButton();
            this.btn_ChangeAvatar = new MaterialSkin.Controls.MaterialFlatButton();
            this.txt_Token = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Username = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.btn_ChangeUsername = new MaterialSkin.Controls.MaterialFlatButton();
            this.txt_UserTokenUsername = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_Email = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox3 = new MetroFramework.Controls.MetroComboBox();
            this.materialFlatButton3 = new MaterialSkin.Controls.MaterialFlatButton();
            this.btn_ChangeEmail = new MaterialSkin.Controls.MaterialFlatButton();
            this.txt_EmailUserToken = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.metroComboBox1);
            this.groupBox1.Controls.Add(this.btn_avatarInfo);
            this.groupBox1.Controls.Add(this.btn_ChangeAvatar);
            this.groupBox1.Controls.Add(this.txt_Token);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 163);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CevoReyiz - Avatar Changer";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(151, 29);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(75, 19);
            this.metroLabel1.TabIndex = 12;
            this.metroLabel1.Text = "Mod Select";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "Single Mode",
            "Multi Mode"});
            this.metroComboBox1.Location = new System.Drawing.Point(6, 19);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(139, 29);
            this.metroComboBox1.TabIndex = 11;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // btn_avatarInfo
            // 
            this.btn_avatarInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_avatarInfo.Depth = 0;
            this.btn_avatarInfo.Icon = null;
            this.btn_avatarInfo.Location = new System.Drawing.Point(5, 85);
            this.btn_avatarInfo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_avatarInfo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_avatarInfo.Name = "btn_avatarInfo";
            this.btn_avatarInfo.Primary = false;
            this.btn_avatarInfo.Size = new System.Drawing.Size(353, 28);
            this.btn_avatarInfo.TabIndex = 10;
            this.btn_avatarInfo.Text = "INFO";
            this.btn_avatarInfo.UseVisualStyleBackColor = true;
            this.btn_avatarInfo.Click += new System.EventHandler(this.btn_avatarInfo_Click);
            // 
            // btn_ChangeAvatar
            // 
            this.btn_ChangeAvatar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_ChangeAvatar.Depth = 0;
            this.btn_ChangeAvatar.Icon = null;
            this.btn_ChangeAvatar.Location = new System.Drawing.Point(5, 125);
            this.btn_ChangeAvatar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_ChangeAvatar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_ChangeAvatar.Name = "btn_ChangeAvatar";
            this.btn_ChangeAvatar.Primary = false;
            this.btn_ChangeAvatar.Size = new System.Drawing.Size(353, 28);
            this.btn_ChangeAvatar.TabIndex = 4;
            this.btn_ChangeAvatar.Text = "CHANGE AVATAR";
            this.btn_ChangeAvatar.UseVisualStyleBackColor = true;
            this.btn_ChangeAvatar.Click += new System.EventHandler(this.btn_ChangeAvatar_Click);
            // 
            // txt_Token
            // 
            this.txt_Token.Depth = 0;
            this.txt_Token.Hint = "User Token";
            this.txt_Token.Location = new System.Drawing.Point(6, 53);
            this.txt_Token.MaxLength = 32767;
            this.txt_Token.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_Token.Name = "txt_Token";
            this.txt_Token.PasswordChar = '\0';
            this.txt_Token.ReadOnly = false;
            this.txt_Token.SelectedText = "";
            this.txt_Token.SelectionLength = 0;
            this.txt_Token.SelectionStart = 0;
            this.txt_Token.Size = new System.Drawing.Size(370, 23);
            this.txt_Token.TabIndex = 1;
            this.txt_Token.TabStop = false;
            this.txt_Token.UseSystemPasswordChar = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_Username);
            this.groupBox2.Controls.Add(this.metroLabel3);
            this.groupBox2.Controls.Add(this.metroComboBox2);
            this.groupBox2.Controls.Add(this.materialFlatButton1);
            this.groupBox2.Controls.Add(this.btn_ChangeUsername);
            this.groupBox2.Controls.Add(this.txt_UserTokenUsername);
            this.groupBox2.Location = new System.Drawing.Point(405, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(366, 163);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CevoReyiz - Username Changer";
            // 
            // txt_Username
            // 
            this.txt_Username.Depth = 0;
            this.txt_Username.Hint = "New Username";
            this.txt_Username.Location = new System.Drawing.Point(194, 53);
            this.txt_Username.MaxLength = 32767;
            this.txt_Username.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.PasswordChar = '\0';
            this.txt_Username.ReadOnly = false;
            this.txt_Username.SelectedText = "";
            this.txt_Username.SelectionLength = 0;
            this.txt_Username.SelectionStart = 0;
            this.txt_Username.Size = new System.Drawing.Size(165, 23);
            this.txt_Username.TabIndex = 15;
            this.txt_Username.TabStop = false;
            this.txt_Username.UseSystemPasswordChar = false;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(151, 29);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(75, 19);
            this.metroLabel3.TabIndex = 14;
            this.metroLabel3.Text = "Mod Select";
            // 
            // metroComboBox2
            // 
            this.metroComboBox2.FormattingEnabled = true;
            this.metroComboBox2.ItemHeight = 23;
            this.metroComboBox2.Items.AddRange(new object[] {
            "Single Mode",
            "Multi Mode"});
            this.metroComboBox2.Location = new System.Drawing.Point(6, 19);
            this.metroComboBox2.Name = "metroComboBox2";
            this.metroComboBox2.Size = new System.Drawing.Size(139, 29);
            this.metroComboBox2.TabIndex = 11;
            this.metroComboBox2.UseSelectable = true;
            this.metroComboBox2.SelectedIndexChanged += new System.EventHandler(this.metroComboBox2_SelectedIndexChanged);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(5, 85);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(354, 28);
            this.materialFlatButton1.TabIndex = 10;
            this.materialFlatButton1.Text = "INFO";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // btn_ChangeUsername
            // 
            this.btn_ChangeUsername.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_ChangeUsername.Depth = 0;
            this.btn_ChangeUsername.Icon = null;
            this.btn_ChangeUsername.Location = new System.Drawing.Point(5, 125);
            this.btn_ChangeUsername.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_ChangeUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_ChangeUsername.Name = "btn_ChangeUsername";
            this.btn_ChangeUsername.Primary = false;
            this.btn_ChangeUsername.Size = new System.Drawing.Size(354, 28);
            this.btn_ChangeUsername.TabIndex = 4;
            this.btn_ChangeUsername.Text = "CHANGE USERNAME";
            this.btn_ChangeUsername.UseVisualStyleBackColor = true;
            this.btn_ChangeUsername.Click += new System.EventHandler(this.btn_ChangeUsername_Click);
            // 
            // txt_UserTokenUsername
            // 
            this.txt_UserTokenUsername.Depth = 0;
            this.txt_UserTokenUsername.Hint = "User Token";
            this.txt_UserTokenUsername.Location = new System.Drawing.Point(6, 53);
            this.txt_UserTokenUsername.MaxLength = 32767;
            this.txt_UserTokenUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_UserTokenUsername.Name = "txt_UserTokenUsername";
            this.txt_UserTokenUsername.PasswordChar = '\0';
            this.txt_UserTokenUsername.ReadOnly = false;
            this.txt_UserTokenUsername.SelectedText = "";
            this.txt_UserTokenUsername.SelectionLength = 0;
            this.txt_UserTokenUsername.SelectionStart = 0;
            this.txt_UserTokenUsername.Size = new System.Drawing.Size(170, 23);
            this.txt_UserTokenUsername.TabIndex = 1;
            this.txt_UserTokenUsername.TabStop = false;
            this.txt_UserTokenUsername.UseSystemPasswordChar = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_Email);
            this.groupBox3.Controls.Add(this.metroLabel2);
            this.groupBox3.Controls.Add(this.metroComboBox3);
            this.groupBox3.Controls.Add(this.materialFlatButton3);
            this.groupBox3.Controls.Add(this.btn_ChangeEmail);
            this.groupBox3.Controls.Add(this.txt_EmailUserToken);
            this.groupBox3.Location = new System.Drawing.Point(23, 232);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(365, 163);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CevoReyiz - EMail Changer";
            // 
            // txt_Email
            // 
            this.txt_Email.Depth = 0;
            this.txt_Email.Hint = "New E-Mail";
            this.txt_Email.Location = new System.Drawing.Point(195, 53);
            this.txt_Email.MaxLength = 32767;
            this.txt_Email.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.PasswordChar = '\0';
            this.txt_Email.ReadOnly = false;
            this.txt_Email.SelectedText = "";
            this.txt_Email.SelectionLength = 0;
            this.txt_Email.SelectionStart = 0;
            this.txt_Email.Size = new System.Drawing.Size(164, 23);
            this.txt_Email.TabIndex = 14;
            this.txt_Email.TabStop = false;
            this.txt_Email.UseSystemPasswordChar = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(151, 29);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(75, 19);
            this.metroLabel2.TabIndex = 13;
            this.metroLabel2.Text = "Mod Select";
            // 
            // metroComboBox3
            // 
            this.metroComboBox3.FormattingEnabled = true;
            this.metroComboBox3.ItemHeight = 23;
            this.metroComboBox3.Items.AddRange(new object[] {
            "Single Mode",
            "Multi Mode"});
            this.metroComboBox3.Location = new System.Drawing.Point(6, 19);
            this.metroComboBox3.Name = "metroComboBox3";
            this.metroComboBox3.Size = new System.Drawing.Size(139, 29);
            this.metroComboBox3.TabIndex = 11;
            this.metroComboBox3.UseSelectable = true;
            this.metroComboBox3.SelectedIndexChanged += new System.EventHandler(this.metroComboBox3_SelectedIndexChanged);
            // 
            // materialFlatButton3
            // 
            this.materialFlatButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton3.Depth = 0;
            this.materialFlatButton3.Icon = null;
            this.materialFlatButton3.Location = new System.Drawing.Point(5, 85);
            this.materialFlatButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton3.Name = "materialFlatButton3";
            this.materialFlatButton3.Primary = false;
            this.materialFlatButton3.Size = new System.Drawing.Size(353, 28);
            this.materialFlatButton3.TabIndex = 10;
            this.materialFlatButton3.Text = "INFO";
            this.materialFlatButton3.UseVisualStyleBackColor = true;
            this.materialFlatButton3.Click += new System.EventHandler(this.materialFlatButton3_Click);
            // 
            // btn_ChangeEmail
            // 
            this.btn_ChangeEmail.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_ChangeEmail.Depth = 0;
            this.btn_ChangeEmail.Icon = null;
            this.btn_ChangeEmail.Location = new System.Drawing.Point(5, 125);
            this.btn_ChangeEmail.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_ChangeEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_ChangeEmail.Name = "btn_ChangeEmail";
            this.btn_ChangeEmail.Primary = false;
            this.btn_ChangeEmail.Size = new System.Drawing.Size(353, 28);
            this.btn_ChangeEmail.TabIndex = 4;
            this.btn_ChangeEmail.Text = "CHANGE E-MAIL";
            this.btn_ChangeEmail.UseVisualStyleBackColor = true;
            // 
            // txt_EmailUserToken
            // 
            this.txt_EmailUserToken.Depth = 0;
            this.txt_EmailUserToken.Hint = "User Token";
            this.txt_EmailUserToken.Location = new System.Drawing.Point(6, 53);
            this.txt_EmailUserToken.MaxLength = 32767;
            this.txt_EmailUserToken.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_EmailUserToken.Name = "txt_EmailUserToken";
            this.txt_EmailUserToken.PasswordChar = '\0';
            this.txt_EmailUserToken.ReadOnly = false;
            this.txt_EmailUserToken.SelectedText = "";
            this.txt_EmailUserToken.SelectionLength = 0;
            this.txt_EmailUserToken.SelectionStart = 0;
            this.txt_EmailUserToken.Size = new System.Drawing.Size(164, 23);
            this.txt_EmailUserToken.TabIndex = 1;
            this.txt_EmailUserToken.TabStop = false;
            this.txt_EmailUserToken.UseSystemPasswordChar = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(405, 232);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(366, 163);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "CevoReyiz - Others";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(677, 346);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // AvatarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 466);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AvatarForm";
            this.Text = "Profile Menu";
            this.Load += new System.EventHandler(this.AvatarForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialFlatButton btn_avatarInfo;
        private MaterialSkin.Controls.MaterialFlatButton btn_ChangeAvatar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_Token;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroComboBox metroComboBox2;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialFlatButton btn_ChangeUsername;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_UserTokenUsername;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroComboBox metroComboBox3;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton3;
        private MaterialSkin.Controls.MaterialFlatButton btn_ChangeEmail;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_EmailUserToken;
        private System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_Username;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_Email;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}