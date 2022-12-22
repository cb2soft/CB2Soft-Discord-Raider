namespace CevoReyiz___Discord_Raider
{
    partial class Raider
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Raider));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Invite_ID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_INFO = new MaterialSkin.Controls.MaterialFlatButton();
            this.mtrchck_RaidMod = new MetroFramework.Controls.MetroCheckBox();
            this.btn_SendDM = new MaterialSkin.Controls.MaterialFlatButton();
            this.StopBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.txt_dmMessage = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_dmID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.RaidBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.Message_Send = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Channel_ID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btn_sendMessage = new MaterialSkin.Controls.MaterialFlatButton();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.RaidTimer = new System.Windows.Forms.Timer(this.components);
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.msnMain = new MetroFramework.Components.MetroStyleManager(this.components);
            this.btn_ReactionMenu = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msnMain)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(171, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Invite_ID
            // 
            this.Invite_ID.Depth = 0;
            this.Invite_ID.Hint = "Invite ID";
            this.Invite_ID.Location = new System.Drawing.Point(6, 19);
            this.Invite_ID.MaxLength = 32767;
            this.Invite_ID.MouseState = MaterialSkin.MouseState.HOVER;
            this.Invite_ID.Name = "Invite_ID";
            this.Invite_ID.PasswordChar = '\0';
            this.Invite_ID.ReadOnly = false;
            this.Invite_ID.SelectedText = "";
            this.Invite_ID.SelectionLength = 0;
            this.Invite_ID.SelectionStart = 0;
            this.Invite_ID.Size = new System.Drawing.Size(442, 23);
            this.Invite_ID.TabIndex = 1;
            this.Invite_ID.TabStop = false;
            this.Invite_ID.UseSystemPasswordChar = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_INFO);
            this.groupBox1.Controls.Add(this.mtrchck_RaidMod);
            this.groupBox1.Controls.Add(this.btn_SendDM);
            this.groupBox1.Controls.Add(this.StopBtn);
            this.groupBox1.Controls.Add(this.materialFlatButton1);
            this.groupBox1.Controls.Add(this.txt_dmMessage);
            this.groupBox1.Controls.Add(this.txt_dmID);
            this.groupBox1.Controls.Add(this.RaidBtn);
            this.groupBox1.Controls.Add(this.Message_Send);
            this.groupBox1.Controls.Add(this.Channel_ID);
            this.groupBox1.Controls.Add(this.btn_sendMessage);
            this.groupBox1.Controls.Add(this.Invite_ID);
            this.groupBox1.Location = new System.Drawing.Point(3, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 448);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CevoReyiz Discord - Interface";
            // 
            // btn_INFO
            // 
            this.btn_INFO.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_INFO.Depth = 0;
            this.btn_INFO.Icon = null;
            this.btn_INFO.Location = new System.Drawing.Point(5, 211);
            this.btn_INFO.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_INFO.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_INFO.Name = "btn_INFO";
            this.btn_INFO.Primary = false;
            this.btn_INFO.Size = new System.Drawing.Size(442, 28);
            this.btn_INFO.TabIndex = 10;
            this.btn_INFO.Text = "INFO";
            this.btn_INFO.UseVisualStyleBackColor = true;
            this.btn_INFO.Click += new System.EventHandler(this.btn_INFO_Click);
            // 
            // mtrchck_RaidMod
            // 
            this.mtrchck_RaidMod.AutoSize = true;
            this.mtrchck_RaidMod.Location = new System.Drawing.Point(20, 163);
            this.mtrchck_RaidMod.Name = "mtrchck_RaidMod";
            this.mtrchck_RaidMod.Size = new System.Drawing.Size(74, 15);
            this.mtrchck_RaidMod.Style = MetroFramework.MetroColorStyle.Silver;
            this.mtrchck_RaidMod.TabIndex = 12;
            this.mtrchck_RaidMod.Text = "Raid Mod";
            this.mtrchck_RaidMod.UseSelectable = true;
            this.mtrchck_RaidMod.CheckedChanged += new System.EventHandler(this.mtrchck_RaidMod_CheckedChanged);
            // 
            // btn_SendDM
            // 
            this.btn_SendDM.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_SendDM.Depth = 0;
            this.btn_SendDM.Icon = null;
            this.btn_SendDM.Location = new System.Drawing.Point(5, 415);
            this.btn_SendDM.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_SendDM.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_SendDM.Name = "btn_SendDM";
            this.btn_SendDM.Primary = false;
            this.btn_SendDM.Size = new System.Drawing.Size(442, 28);
            this.btn_SendDM.TabIndex = 9;
            this.btn_SendDM.Text = "SEND DM";
            this.btn_SendDM.UseVisualStyleBackColor = true;
            this.btn_SendDM.Click += new System.EventHandler(this.btn_SendDM_Click);
            // 
            // StopBtn
            // 
            this.StopBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.StopBtn.Depth = 0;
            this.StopBtn.Icon = null;
            this.StopBtn.Location = new System.Drawing.Point(6, 291);
            this.StopBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.StopBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Primary = false;
            this.StopBtn.Size = new System.Drawing.Size(442, 28);
            this.StopBtn.TabIndex = 5;
            this.StopBtn.Text = "STOP";
            this.StopBtn.UseVisualStyleBackColor = true;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(6, 331);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(442, 28);
            this.materialFlatButton1.TabIndex = 6;
            this.materialFlatButton1.Text = "JOIN SERVER";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.MaterialFlatButton1_Click);
            // 
            // txt_dmMessage
            // 
            this.txt_dmMessage.Depth = 0;
            this.txt_dmMessage.Hint = "DM Message";
            this.txt_dmMessage.Location = new System.Drawing.Point(6, 134);
            this.txt_dmMessage.MaxLength = 32767;
            this.txt_dmMessage.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_dmMessage.Name = "txt_dmMessage";
            this.txt_dmMessage.PasswordChar = '\0';
            this.txt_dmMessage.ReadOnly = false;
            this.txt_dmMessage.SelectedText = "";
            this.txt_dmMessage.SelectionLength = 0;
            this.txt_dmMessage.SelectionStart = 0;
            this.txt_dmMessage.Size = new System.Drawing.Size(442, 23);
            this.txt_dmMessage.TabIndex = 8;
            this.txt_dmMessage.TabStop = false;
            this.txt_dmMessage.UseSystemPasswordChar = false;
            // 
            // txt_dmID
            // 
            this.txt_dmID.Depth = 0;
            this.txt_dmID.Hint = "DM ID";
            this.txt_dmID.Location = new System.Drawing.Point(7, 105);
            this.txt_dmID.MaxLength = 32767;
            this.txt_dmID.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_dmID.Name = "txt_dmID";
            this.txt_dmID.PasswordChar = '\0';
            this.txt_dmID.ReadOnly = false;
            this.txt_dmID.SelectedText = "";
            this.txt_dmID.SelectionLength = 0;
            this.txt_dmID.SelectionStart = 0;
            this.txt_dmID.Size = new System.Drawing.Size(442, 23);
            this.txt_dmID.TabIndex = 7;
            this.txt_dmID.TabStop = false;
            this.txt_dmID.UseSystemPasswordChar = false;
            // 
            // RaidBtn
            // 
            this.RaidBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RaidBtn.Depth = 0;
            this.RaidBtn.Icon = null;
            this.RaidBtn.Location = new System.Drawing.Point(5, 251);
            this.RaidBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RaidBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.RaidBtn.Name = "RaidBtn";
            this.RaidBtn.Primary = false;
            this.RaidBtn.Size = new System.Drawing.Size(442, 28);
            this.RaidBtn.TabIndex = 4;
            this.RaidBtn.Text = "RAID";
            this.RaidBtn.UseVisualStyleBackColor = true;
            this.RaidBtn.Click += new System.EventHandler(this.RaidBtn_Click);
            // 
            // Message_Send
            // 
            this.Message_Send.Depth = 0;
            this.Message_Send.Hint = "Message";
            this.Message_Send.Location = new System.Drawing.Point(6, 76);
            this.Message_Send.MaxLength = 32767;
            this.Message_Send.MouseState = MaterialSkin.MouseState.HOVER;
            this.Message_Send.Name = "Message_Send";
            this.Message_Send.PasswordChar = '\0';
            this.Message_Send.ReadOnly = false;
            this.Message_Send.SelectedText = "";
            this.Message_Send.SelectionLength = 0;
            this.Message_Send.SelectionStart = 0;
            this.Message_Send.Size = new System.Drawing.Size(442, 23);
            this.Message_Send.TabIndex = 3;
            this.Message_Send.TabStop = false;
            this.Message_Send.UseSystemPasswordChar = false;
            // 
            // Channel_ID
            // 
            this.Channel_ID.Depth = 0;
            this.Channel_ID.Hint = "Channel ID";
            this.Channel_ID.Location = new System.Drawing.Point(6, 47);
            this.Channel_ID.MaxLength = 32767;
            this.Channel_ID.MouseState = MaterialSkin.MouseState.HOVER;
            this.Channel_ID.Name = "Channel_ID";
            this.Channel_ID.PasswordChar = '\0';
            this.Channel_ID.ReadOnly = false;
            this.Channel_ID.SelectedText = "";
            this.Channel_ID.SelectionLength = 0;
            this.Channel_ID.SelectionStart = 0;
            this.Channel_ID.Size = new System.Drawing.Size(442, 23);
            this.Channel_ID.TabIndex = 2;
            this.Channel_ID.TabStop = false;
            this.Channel_ID.UseSystemPasswordChar = false;
            // 
            // btn_sendMessage
            // 
            this.btn_sendMessage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_sendMessage.Depth = 0;
            this.btn_sendMessage.Icon = null;
            this.btn_sendMessage.Location = new System.Drawing.Point(7, 371);
            this.btn_sendMessage.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_sendMessage.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_sendMessage.Name = "btn_sendMessage";
            this.btn_sendMessage.Primary = false;
            this.btn_sendMessage.Size = new System.Drawing.Size(442, 28);
            this.btn_sendMessage.TabIndex = 7;
            this.btn_sendMessage.Text = "SEND MESSAGE";
            this.btn_sendMessage.UseVisualStyleBackColor = true;
            this.btn_sendMessage.Click += new System.EventHandler(this.btn_sendMessage_Click);
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "Single Message Mode",
            "Multi Message Mode",
            "Single DM Mode",
            "Multi DM Mode"});
            this.metroComboBox1.Location = new System.Drawing.Point(3, 131);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(162, 29);
            this.metroComboBox1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroComboBox1.TabIndex = 11;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // RaidTimer
            // 
            this.RaidTimer.Interval = 1000;
            this.RaidTimer.Tick += new System.EventHandler(this.RaidTimer_Tick);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(277, 131);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(173, 29);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton1.TabIndex = 13;
            this.metroButton1.Text = "OPEN PROFILE MENU";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // msnMain
            // 
            this.msnMain.Owner = null;
            // 
            // btn_ReactionMenu
            // 
            this.btn_ReactionMenu.Location = new System.Drawing.Point(277, 96);
            this.btn_ReactionMenu.Name = "btn_ReactionMenu";
            this.btn_ReactionMenu.Size = new System.Drawing.Size(173, 29);
            this.btn_ReactionMenu.Style = MetroFramework.MetroColorStyle.Blue;
            this.btn_ReactionMenu.TabIndex = 14;
            this.btn_ReactionMenu.Text = "OPEN REACTION MENU";
            this.btn_ReactionMenu.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btn_ReactionMenu.UseCustomBackColor = true;
            this.btn_ReactionMenu.UseSelectable = true;
            this.btn_ReactionMenu.Click += new System.EventHandler(this.btn_ReactionMenu_Click);
            // 
            // Raider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 617);
            this.Controls.Add(this.btn_ReactionMenu);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Raider";
            this.Resizable = false;
            this.ShowIcon = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "CevoReyiz Discord Raider";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Raider_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msnMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField Invite_ID;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialFlatButton RaidBtn;
        private MaterialSkin.Controls.MaterialSingleLineTextField Message_Send;
        private MaterialSkin.Controls.MaterialSingleLineTextField Channel_ID;
        private MaterialSkin.Controls.MaterialFlatButton StopBtn;
        private System.Windows.Forms.Timer RaidTimer;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialFlatButton btn_sendMessage;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_dmID;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_dmMessage;
        private MaterialSkin.Controls.MaterialFlatButton btn_SendDM;
        private MaterialSkin.Controls.MaterialFlatButton btn_INFO;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroCheckBox mtrchck_RaidMod;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Components.MetroStyleManager msnMain;
        private MetroFramework.Controls.MetroButton btn_ReactionMenu;
    }
}

