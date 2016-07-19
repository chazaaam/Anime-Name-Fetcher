using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace anime_name_fetcher
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        public string profile;
        public int status;

        public static string edit_txt;

        public string location;


        public Color color_success = Color.Green;
        public Color color_fail = Color.Red;
        public Color color_skipped = Color.Yellow;

        private void main_Load(object sender, EventArgs e)
        {
            cmb_status.SelectedIndex = 0;
            status = 7;
            profile = txt_profile.Text;

            txt_profile.Text = Properties.Settings.Default.user;
            txt_location.Text = Properties.Settings.Default.location;
        }

        private void btn_fetch_Click(object sender, EventArgs e)
        {
            btn_fetch.Enabled = false;
            try
            {               
                profile = txt_profile.Text;
                string url = "http://myanimelist.net/animelist/" + profile + "?status=" + status;
                WebClient client = new WebClient();
                client.Proxy = null;
                string source = client.DownloadString(url);

                extract_names(source);            
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while loading your anime list.");
            }
            btn_fetch.Enabled = true;
        }
   
        private void extract_names(string source)
        {
            for (int i = 0; i <= lst_names.Items.Count; i++)
            {
                try
                {
                    lst_names.Items.RemoveAt(0);
                }
                catch(Exception ex)
                {
                    //
                }
                
            }

            source = source.Remove(0, source.IndexOf("&quot;anime_title&quot;:&quot;"));

            string[] tokens = source.Split(new[] { "&quot;anime_title&quot;:&quot;" }, StringSplitOptions.None);

            List<string> lst = tokens.OfType<string>().ToList();

            lst.RemoveAt(0);

            for (int i = 0; i < lst.Count(); i++)
            {
                lst[i] = lst[i].Remove(lst[i].IndexOf("&quot"));
                lst_names.Items.Add(lst[i]);
            }
        }

        private void cmb_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmb_status.SelectedIndex)
            {
                case 0:
                    status = 7;
                    break;
                case 1:
                case 2:
                case 3:
                case 4:
                    status = cmb_status.SelectedIndex;
                    break;
                case 5:
                    status = 6;
                    break;
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                lst_names.FocusedItem.Remove();
            }
            catch(Exception ex)
            {
                //
            }

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                edit_txt = lst_names.FocusedItem.Text;

                edit_input edit = new edit_input();
                edit.ShowDialog();

                lst_names.FocusedItem.Text = edit_txt;
            }
            catch (Exception ex)
            {
                //
            }

        }

        private void txt_location_MouseClick(object sender, MouseEventArgs e)
        {
            FolderBrowserDialog chose_location = new FolderBrowserDialog();

            chose_location.Description = "Chose the location for the created folders";

            if (chose_location.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                location = chose_location.SelectedPath;
                txt_location.Text = location;
            }
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            if(!Directory.Exists(location))
            {
                MessageBox.Show("Invalid save location");
                return;
            }
            for (int i = 0; i < lst_names.Items.Count; i++)
            {
                string folder = location + "/" + lst_names.Items[i].Text;
                if (Directory.Exists(folder))
                {
                    lst_names.Items[i].BackColor = color_skipped;
                    continue;
                }

                try
                {
                    DirectoryInfo di = Directory.CreateDirectory(folder);
                    lst_names.Items[i].BackColor = color_success;
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString());
                    lst_names.Items[i].BackColor = color_fail;
                }
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lst_names.Items.Count; i++)
            {
                lst_names.Items[i].Text = lst_names.Items[i].Text.Replace(":", "");
                lst_names.Items[i].Text = lst_names.Items[i].Text.Replace("<", "");
                lst_names.Items[i].Text = lst_names.Items[i].Text.Replace(">", "");
                lst_names.Items[i].Text = lst_names.Items[i].Text.Replace("/", "");
                lst_names.Items[i].Text = lst_names.Items[i].Text.Replace("*", "");
                lst_names.Items[i].Text = lst_names.Items[i].Text.Replace("?", "");
                lst_names.Items[i].Text = lst_names.Items[i].Text.Replace("\"", "");
                lst_names.Items[i].Text = lst_names.Items[i].Text.Replace("|", "");

                if(lst_names.Items[i].Text.Contains("\\"))
                {
                    try
                    {
                        lst_names.Items[i].Text = System.Text.RegularExpressions.Regex.Unescape(lst_names.Items[i].Text);
                    }
                    catch (Exception ex)
                    {
                        lst_names.Items[i].Text = lst_names.Items[i].Text.Replace("\\", "");
                    }
                }
            }         
        }

        private void txt_location_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.location = txt_location.Text;
            Properties.Settings.Default.Save();
        }

        private void txt_profile_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.user = txt_profile.Text;
            Properties.Settings.Default.Save();
        }
    }
}
