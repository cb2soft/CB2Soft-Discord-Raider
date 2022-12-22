namespace CevoReyiz___Discord_Raider
{
    partial class ReactionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReactionForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Emoji = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.txt_MessageID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_ChannelID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cmb_ModSelect = new MetroFramework.Controls.MetroComboBox();
            this.btn_avatarInfo = new MaterialSkin.Controls.MaterialFlatButton();
            this.btn_SendReaction = new MaterialSkin.Controls.MaterialFlatButton();
            this.txt_UserToken = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(677, 330);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Emoji);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroComboBox2);
            this.groupBox1.Controls.Add(this.txt_MessageID);
            this.groupBox1.Controls.Add(this.txt_ChannelID);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.cmb_ModSelect);
            this.groupBox1.Controls.Add(this.btn_avatarInfo);
            this.groupBox1.Controls.Add(this.btn_SendReaction);
            this.groupBox1.Controls.Add(this.txt_UserToken);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 253);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CevoReyiz - Avatar Changer";
            // 
            // txt_Emoji
            // 
            this.txt_Emoji.Depth = 0;
            this.txt_Emoji.Hint = "Reaction Emoji";
            this.txt_Emoji.Location = new System.Drawing.Point(6, 140);
            this.txt_Emoji.MaxLength = 32767;
            this.txt_Emoji.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_Emoji.Name = "txt_Emoji";
            this.txt_Emoji.PasswordChar = '\0';
            this.txt_Emoji.ReadOnly = false;
            this.txt_Emoji.SelectedText = "";
            this.txt_Emoji.SelectionLength = 0;
            this.txt_Emoji.SelectionStart = 0;
            this.txt_Emoji.Size = new System.Drawing.Size(365, 23);
            this.txt_Emoji.TabIndex = 18;
            this.txt_Emoji.TabStop = false;
            this.txt_Emoji.UseSystemPasswordChar = false;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(190, 29);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(12, 19);
            this.metroLabel3.TabIndex = 17;
            this.metroLabel3.Text = "|";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Enabled = false;
            this.metroLabel2.Location = new System.Drawing.Point(204, 29);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(59, 19);
            this.metroLabel2.TabIndex = 16;
            this.metroLabel2.Text = "Reaction";
            // 
            // metroComboBox2
            // 
            this.metroComboBox2.Enabled = false;
            this.metroComboBox2.FormattingEnabled = true;
            this.metroComboBox2.ItemHeight = 23;
            this.metroComboBox2.Items.AddRange(new object[] {
            "Single Mode",
            "Multi Mode"});
            this.metroComboBox2.Location = new System.Drawing.Point(269, 19);
            this.metroComboBox2.Name = "metroComboBox2";
            this.metroComboBox2.Size = new System.Drawing.Size(102, 29);
            this.metroComboBox2.TabIndex = 15;
            this.metroComboBox2.UseSelectable = true;
            // 
            // txt_MessageID
            // 
            this.txt_MessageID.Depth = 0;
            this.txt_MessageID.Hint = "Message ID";
            this.txt_MessageID.Location = new System.Drawing.Point(6, 111);
            this.txt_MessageID.MaxLength = 32767;
            this.txt_MessageID.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_MessageID.Name = "txt_MessageID";
            this.txt_MessageID.PasswordChar = '\0';
            this.txt_MessageID.ReadOnly = false;
            this.txt_MessageID.SelectedText = "";
            this.txt_MessageID.SelectionLength = 0;
            this.txt_MessageID.SelectionStart = 0;
            this.txt_MessageID.Size = new System.Drawing.Size(365, 23);
            this.txt_MessageID.TabIndex = 14;
            this.txt_MessageID.TabStop = false;
            this.txt_MessageID.UseSystemPasswordChar = false;
            // 
            // txt_ChannelID
            // 
            this.txt_ChannelID.Depth = 0;
            this.txt_ChannelID.Hint = "Channel ID";
            this.txt_ChannelID.Location = new System.Drawing.Point(6, 82);
            this.txt_ChannelID.MaxLength = 32767;
            this.txt_ChannelID.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_ChannelID.Name = "txt_ChannelID";
            this.txt_ChannelID.PasswordChar = '\0';
            this.txt_ChannelID.ReadOnly = false;
            this.txt_ChannelID.SelectedText = "";
            this.txt_ChannelID.SelectionLength = 0;
            this.txt_ChannelID.SelectionStart = 0;
            this.txt_ChannelID.Size = new System.Drawing.Size(365, 23);
            this.txt_ChannelID.TabIndex = 13;
            this.txt_ChannelID.TabStop = false;
            this.txt_ChannelID.UseSystemPasswordChar = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(114, 29);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(75, 19);
            this.metroLabel1.TabIndex = 12;
            this.metroLabel1.Text = "Mod Select";
            // 
            // cmb_ModSelect
            // 
            this.cmb_ModSelect.FormattingEnabled = true;
            this.cmb_ModSelect.ItemHeight = 23;
            this.cmb_ModSelect.Items.AddRange(new object[] {
            "Single Mode",
            "Multi Mode"});
            this.cmb_ModSelect.Location = new System.Drawing.Point(6, 19);
            this.cmb_ModSelect.Name = "cmb_ModSelect";
            this.cmb_ModSelect.Size = new System.Drawing.Size(102, 29);
            this.cmb_ModSelect.TabIndex = 11;
            this.cmb_ModSelect.UseSelectable = true;
            this.cmb_ModSelect.SelectedIndexChanged += new System.EventHandler(this.cmb_ModSelect_SelectedIndexChanged);
            // 
            // btn_avatarInfo
            // 
            this.btn_avatarInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_avatarInfo.Depth = 0;
            this.btn_avatarInfo.Icon = null;
            this.btn_avatarInfo.Location = new System.Drawing.Point(6, 174);
            this.btn_avatarInfo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_avatarInfo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_avatarInfo.Name = "btn_avatarInfo";
            this.btn_avatarInfo.Primary = false;
            this.btn_avatarInfo.Size = new System.Drawing.Size(365, 28);
            this.btn_avatarInfo.TabIndex = 10;
            this.btn_avatarInfo.Text = "INFO";
            this.btn_avatarInfo.UseVisualStyleBackColor = true;
            // 
            // btn_SendReaction
            // 
            this.btn_SendReaction.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_SendReaction.Depth = 0;
            this.btn_SendReaction.Icon = null;
            this.btn_SendReaction.Location = new System.Drawing.Point(6, 214);
            this.btn_SendReaction.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_SendReaction.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_SendReaction.Name = "btn_SendReaction";
            this.btn_SendReaction.Primary = false;
            this.btn_SendReaction.Size = new System.Drawing.Size(365, 28);
            this.btn_SendReaction.TabIndex = 4;
            this.btn_SendReaction.Text = "SEND REACTION";
            this.btn_SendReaction.UseVisualStyleBackColor = true;
            this.btn_SendReaction.Click += new System.EventHandler(this.btn_SendReaction_Click);
            // 
            // txt_UserToken
            // 
            this.txt_UserToken.Depth = 0;
            this.txt_UserToken.Hint = "User Token";
            this.txt_UserToken.Location = new System.Drawing.Point(6, 53);
            this.txt_UserToken.MaxLength = 32767;
            this.txt_UserToken.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_UserToken.Name = "txt_UserToken";
            this.txt_UserToken.PasswordChar = '\0';
            this.txt_UserToken.ReadOnly = false;
            this.txt_UserToken.SelectedText = "";
            this.txt_UserToken.SelectionLength = 0;
            this.txt_UserToken.SelectionStart = 0;
            this.txt_UserToken.Size = new System.Drawing.Size(365, 23);
            this.txt_UserToken.TabIndex = 1;
            this.txt_UserToken.TabStop = false;
            this.txt_UserToken.UseSystemPasswordChar = false;
            // 
            // ReactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ReactionForm";
            this.Text = "Reactions Menu";
            this.Load += new System.EventHandler(this.ReactionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_ChannelID;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cmb_ModSelect;
        private MaterialSkin.Controls.MaterialFlatButton btn_avatarInfo;
        private MaterialSkin.Controls.MaterialFlatButton btn_SendReaction;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_UserToken;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_MessageID;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox metroComboBox2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_Emoji;
    }
}