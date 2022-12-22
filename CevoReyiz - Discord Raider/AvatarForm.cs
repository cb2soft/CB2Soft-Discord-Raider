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
    public partial class AvatarForm : MetroFramework.Forms.MetroForm
    {

        public bool isMulti = false;
        string[] filePaths = null;
        string[] tokens = null;

        public AvatarForm()
        {
            InitializeComponent();
        }

        private void AvatarForm_Load(object sender, EventArgs e)
        {
            metroComboBox1.SelectedIndex = 0;
            metroComboBox2.SelectedIndex = 0;
            metroComboBox3.SelectedIndex = 0;
            string[] tokens = null;
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metroComboBox1.SelectedIndex == 0)
            {
                txt_Token.Enabled = true;
                isMulti = false;
            }
            else
            {
                txt_Token.Enabled = false;
                isMulti = true;
            }
        }

        private void btn_avatarInfo_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "-In Single Mode you need to fill User Token then select the Png File \n-In Multi Mode you need to fill tokens.txt file and it will loop in every token and going to change theirs profile avatars. \n-In MULTI Mode you need to copy files to avatars directory and give them a name 1 to 100 for example '1.png' '2.png' etc.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_ChangeAvatar_Click(object sender, EventArgs e)
        {
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

                string pt = Directory.GetCurrentDirectory() + "/pictures";
                if (!Directory.Exists(pt))
                    return;

                filePaths = Directory.GetFiles(pt, "*.png");

                Random random = new Random();
                    foreach (string token in tokens)
                    {
                        string encoded = System.Convert.ToBase64String(File.ReadAllBytes(filePaths[random.Next(0,filePaths.Length-1)]));
                        RaidFunctions.funcs.sendMultipleUserData(token, new { avatar = "data:image/png;base64," + encoded });   //Changes multi avatars
                    }
            }
            else
            {

                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.Filter = "Png fls | *.png";

                string encoded = string.Empty;
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    encoded = System.Convert.ToBase64String(File.ReadAllBytes(fileDialog.FileName));
                }
                else
                    return;

                string token = txt_Token.Text;
                RaidFunctions.funcs.sendSingleUserData(token,new { avatar = "data:image/png;base64," + encoded });  //Changes single avatar
            }
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "-In Single Mode you need to enter User Token and new Username.\n-In Multi Mod you need to fill tokens.txt and usernames.txt.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "-Same with Username changer but in Multi Mod fill emails.txt", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metroComboBox2.SelectedIndex == 0)
            {
                txt_UserTokenUsername.Enabled = true;
                txt_Username.Enabled = true;
            }
            else
            {
                txt_UserTokenUsername.Enabled = false;
                txt_Username.Enabled = false;
            }
        }

        private void metroComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(metroComboBox3.SelectedIndex == 0)
            {
                txt_EmailUserToken.Enabled = true;
                txt_Email.Enabled = true;
            }
            else
            {
                txt_EmailUserToken.Enabled = false;
                txt_Email.Enabled = false;
            }
        }

        private void btn_ChangeUsername_Click(object sender, EventArgs e)
        {

        }
    }
}
