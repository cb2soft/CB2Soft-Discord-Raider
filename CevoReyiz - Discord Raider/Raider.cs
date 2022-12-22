using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace CevoReyiz___Discord_Raider
{
    //https://discord.com/api/v8/channels/940592907436556405/messages/940593000575287346/reactions/🗨️/@me
    public partial class Raider : MetroFramework.Forms.MetroForm
    {
        public static string invite;
        public static string message;
        public static string channelid;
        public static string dmMessage;
        public static string dmId;
        public static string empty = string.Empty;
        public bool isMulti = false;
        public static string currd = Directory.GetCurrentDirectory();
        string[] tokens = null;
        string[] invites = null;
        string[] channels = null;
        string[] dmChannels = null;
        string[] filePaths = null;


        public Raider()
        {
            InitializeComponent();
            this.StyleManager = msnMain;
        }

        private void RaidBtn_Click(object sender, EventArgs e)
        {
            if (Message_Send.Text == empty)
            {
                MetroFramework.MetroMessageBox.Show(this, "You can't send an Empty message.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (Invite_ID.Text == empty)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please provide a correct Invite ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (Channel_ID.Text == empty)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please provide a correct Channel ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            RaidTimer.Start();
        }

        private void SendMessage()
        {

            message = Message_Send.Text;

            if (isMulti == true)
            {
                #region tarique Checkfile
                if (tokens == null)
                    using (var fdlg = new OpenFileDialog { Filter = "Tokens | tokens.txt", CheckFileExists = true, CheckPathExists = true })
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Your TOKEN List is Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (fdlg.ShowDialog() == DialogResult.OK)
                            tokens = File.ReadAllLines(fdlg.FileName);
                        else
                            return;
                    }

                if (invites == null)
                    using (var fdlg = new OpenFileDialog { Filter = "Invites | invites.txt", CheckFileExists = true, CheckPathExists = true })
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Your INVITE List is Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (fdlg.ShowDialog() == DialogResult.OK)
                            invites = File.ReadAllLines(fdlg.FileName);
                        else
                            return;
                    }

                if (channels == null)
                    using (var fdlg = new OpenFileDialog { Filter = "Channel | channels.txt", CheckFileExists = true, CheckPathExists = true })
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Your CHANNEL List is Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (fdlg.ShowDialog() == DialogResult.OK)
                            channels = File.ReadAllLines(fdlg.FileName);
                        else
                            return;
                    }
                #endregion

                /*foreach (string b in invites)   //MULTI SERVER JOINER
                {
                    foreach (string i in tokens)
                    {
                        RaidFunctions.funcs.joinguild(i, b, false, null); //joins multi sv
                    }
                }*/

                foreach (string b in channels)
                {
                    foreach (string i in tokens)
                    {
                        RaidFunctions.funcs.sendmessage(i, b, message, false, false); // sends multi msg 
                    }
                }

            }

            else
            {
                invite = Invite_ID.Text;
                channelid = Channel_ID.Text;
                tokens = File.ReadAllLines(currd + @"/tokens.txt");

                foreach (string i in tokens) { RaidFunctions.funcs.joinguild(i, invite, false, null); } // joins srv

                    foreach (string i in tokens)
                    {
                        RaidFunctions.funcs.sendmessage(i, channelid, message, false, false); // send msg 
                    }
            }

            


        }

        private void SendDM()
        {
            //string[] dmChannels = null;
            dmMessage = txt_dmMessage.Text;

            if (isMulti == true)
            {
                if (tokens == null)
                    using (var fdlg = new OpenFileDialog { Filter = "Tokens | tokens.txt", CheckFileExists = true, CheckPathExists = true })
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Your TOKEN List is Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (fdlg.ShowDialog() == DialogResult.OK)
                            tokens = File.ReadAllLines(fdlg.FileName);
                        else
                            return;
                    }
                if (dmChannels == null)
                    using (var fdlg = new OpenFileDialog { Filter = "DmChannels | dmChannels.txt", CheckFileExists = true, CheckPathExists = true })
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Your DM CHANNEL List is Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (fdlg.ShowDialog() == DialogResult.OK)
                            tokens = File.ReadAllLines(fdlg.FileName);
                        else
                            return;
                    }

                foreach (string b in dmChannels)
                {
                    foreach (string i in tokens)
                    {
                        RaidFunctions.funcs.sendmessage(i, b, dmMessage, false, false); //Sends multi DM
                    }
                    
                }
            }
            else
            {

                dmId = txt_dmID.Text;
                tokens = File.ReadAllLines(currd + @"/tokens.txt");

                foreach (string i in tokens)
                {
                    RaidFunctions.funcs.sendmessage(i, dmId, dmMessage, false, false); // Sends Single DM
                }
            }
        }

        private void RaidTimer_Tick(object sender, EventArgs e)
        {

            invite = Invite_ID.Text;
            channelid = Channel_ID.Text;
            message = Message_Send.Text;


            string currd = Directory.GetCurrentDirectory();
            string[] tokens = File.ReadAllLines(currd + @"/tokens.txt");
            //string[] servers = File.ReadAllLines(currd + @"/serverlist.txt");

            foreach (string i in tokens) { RaidFunctions.funcs.joinguild(i, invite, false, null); } // joins srv

            foreach (string i in tokens)
            {
                RaidFunctions.funcs.sendmessage(i, channelid, message, false, false); // send msg 
            }

        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            RaidTimer.Stop();
        }

        private void MaterialFlatButton1_Click(object sender, EventArgs e)
        {
            invite = Invite_ID.Text;

            string currd = Directory.GetCurrentDirectory();
            string[] tokens = File.ReadAllLines(currd + @"/tokens.txt");

            foreach (string i in tokens) { RaidFunctions.funcs.joinguild(i, invite, false, null); } // joins srv
        }

        private void btn_sendMessage_Click(object sender, EventArgs e)
        {
            SendMessage();
        }

        private void Raider_Load(object sender, EventArgs e)
        {
            RaidBtn.Enabled = false;
            txt_dmID.Enabled = false;
            txt_dmMessage.Enabled = false;
            btn_SendDM.Enabled = false;
            metroComboBox1.SelectedIndex = 0;
            StopBtn.Enabled = false;
        }

        private void btn_SendDM_Click(object sender, EventArgs e)
        {
            SendDM();
        }

        private void btn_INFO_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "-In Single Mod you can only send and join 1 channel\n-In Multi Mod you can join multi servers and send single message to multi channels. \n-In Dm Mod you can send DM to a single user. \n-In Multi DM mod you can send a single message to multi users.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metroComboBox1.SelectedIndex == 0)
            {
                isMulti = false;
                txt_dmID.Enabled = false;
                txt_dmMessage.Enabled = false;
                Invite_ID.Enabled = true;
                Channel_ID.Enabled = true;
                Message_Send.Enabled = true;
                btn_sendMessage.Enabled = true;
                btn_SendDM.Enabled = false;
            }
            else if (metroComboBox1.SelectedIndex == 1)
            {
                isMulti = true;
                txt_dmID.Enabled = false;
                txt_dmMessage.Enabled = false;
                Invite_ID.Enabled = false;
                Channel_ID.Enabled = false;
                Message_Send.Enabled = true;
                btn_sendMessage.Enabled = true;
                btn_SendDM.Enabled = false;
            }
            else if (metroComboBox1.SelectedIndex == 2)
            {
                isMulti = false;
                txt_dmID.Enabled = true;
                txt_dmMessage.Enabled = true;
                Invite_ID.Enabled = true;
                Channel_ID.Enabled = false;
                Message_Send.Enabled = false;
                btn_sendMessage.Enabled = false;
                btn_SendDM.Enabled = true;
            }
            else if (metroComboBox1.SelectedIndex == 3)
            {
                isMulti = true;
                txt_dmID.Enabled = false;
                txt_dmMessage.Enabled = true;
                Invite_ID.Enabled = false;
                Channel_ID.Enabled = false;
                Message_Send.Enabled = false;
                btn_sendMessage.Enabled = false;
                btn_SendDM.Enabled = true;
            }
        }

        private void mtrchck_RaidMod_CheckedChanged(object sender, EventArgs e)
        {
            if (mtrchck_RaidMod.Checked == true)
            {
                MetroFramework.MetroMessageBox.Show(this, "-Raid mod spams a single message to a single server channel.\n-WARNING ITS STILL WORK IN PROGRESS", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                RaidBtn.Enabled = true;
                StopBtn.Enabled = true;
            }
            else
            {
                RaidBtn.Enabled = false;
                StopBtn.Enabled = false;
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            AvatarForm _avatarForm = new AvatarForm();
            _avatarForm.StyleManager = this.StyleManager;
            _avatarForm.ShowDialog();
            _avatarForm.Dispose();
        }

        private void AvatarChange()
        {
           /*var res = RaidFunctions.funcs.sendMultipleUserData("","");
            MessageBox.Show(res.Content.ReadAsStringAsync().Result);*/
        }

        private void btn_ReactionMenu_Click(object sender, EventArgs e)
        {
            ReactionForm _ReactionForm = new ReactionForm();
            _ReactionForm.StyleManager = this.StyleManager;
            _ReactionForm.ShowDialog();
            _ReactionForm.Dispose();
        }
    }
}
