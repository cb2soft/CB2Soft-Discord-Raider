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
    public partial class ReactionForm : MetroFramework.Forms.MetroForm
    {

        public bool isMulti = false;
        public static string empty = string.Empty;
        string[] tokens = null;
        public static string currd = Directory.GetCurrentDirectory();

        public ReactionForm()
        {
            InitializeComponent();
        }

        private void ReactionForm_Load(object sender, EventArgs e)
        {
            cmb_ModSelect.SelectedIndex = 0;
        }

        private void btn_SendReaction_Click(object sender, EventArgs e)
        {
            if(isMulti == true)
            {
                if (tokens == null)
                    using (var fdlg = new OpenFileDialog { Filter = "Token | tokens.txt", CheckFileExists = true, CheckPathExists = true })
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Your TOKEN List is Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (fdlg.ShowDialog() == DialogResult.OK)
                            tokens = File.ReadAllLines(fdlg.FileName);
                        else
                            return;
                    }
                else
                {
                    string channelID = txt_ChannelID.Text;
                    string messageID = txt_MessageID.Text;
                    string emoji = txt_Emoji.Text;
                    foreach (string i in tokens)
                    {
                        RaidFunctions.funcs.sendReaction(i, channelID, messageID, emoji, false, null);
                    }
                }

            }
            else
            {

                if (txt_Emoji.Text == empty || txt_ChannelID.Text == empty || txt_UserToken.Text == empty || txt_MessageID.Text == empty)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please fill all the lines.", "Some informations are missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    string emoji = txt_Emoji.Text;
                    string channelID = txt_ChannelID.Text;
                    string messageID = txt_MessageID.Text;
                    string token = txt_UserToken.Text;

                    RaidFunctions.funcs.sendReaction(token, channelID, messageID, emoji, false, null);
                }
            }        
        }

        private void cmb_ModSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_ModSelect.SelectedIndex == 0)
            {
                isMulti = false;
                txt_UserToken.Enabled = true;
            }
            else
            {
                isMulti = true;
                txt_UserToken.Enabled = false;
            }
        }
    }
}
