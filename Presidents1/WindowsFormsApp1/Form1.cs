using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;
using WindowsFormsApp1.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using RadioButton = System.Windows.Forms.RadioButton;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
            try
            {
                
                Microsoft.Win32.RegistryKey key =
                Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"SOFTWARE\\WOW6432Node\\Microsoft\\Internet Explorer\\MAIN\\FeatureControl\\FEATURE_BROWSER_EMULATION", true);
                key.SetValue(Application.ExecutablePath.Replace(Application.StartupPath + "\\", ""), 12001, Microsoft.Win32.RegistryValueKind.DWord);
                key.Close();
            }
            catch
            {
            }
            foreach (Control control in this.Controls)
            {

                if (control.GetType() == typeof(TextBox))
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Validating += new CancelEventHandler(this.TxtBox__Validator);
                }
                if (control.GetType() == typeof(PictureBox))
                {
                    PictureBox pictureBox = control as PictureBox;
                    pictureBox.MouseEnter += new EventHandler(this.PictureBox__MouseEnter);
                    pictureBox.MouseLeave += new EventHandler(this.PictureBox__MouseLeave);
                }
                if (control.GetType() == typeof(RadioButton))
                {
                    RadioButton radioButton = (control as RadioButton);
                    radioButton.CheckedChanged += new EventHandler(this.RadioButton__CheckedChanged);

                }
            }
            foreach (Control filter in this.groupBox1.Controls)
            {
                RadioButton filterButton = (filter as RadioButton);
                filterButton.CheckedChanged += new EventHandler(this.FilterRadioButton__CheckedChanged);
            }
        }

        private void PictureBox__MouseEnter(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            pictureBox.Height *= 2;
            pictureBox.Width *= 2;
            pictureBox.BringToFront();
        }

        private void PictureBox__MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            pictureBox.Height /= 2;
            pictureBox.Width /= 2;
        }

        private void RadioButton__CheckedChanged(object sender, EventArgs e)
        {
            RadioButton button = (RadioButton)sender;
            if (!button.Checked) { return; }
            string path = "https://en.m.wikipedia.org/wiki/";
            foreach (Presidents guy in presidents)
            {
                if (guy.name == button.Text)
                {
                    path += guy.name;
                    pictureBox1.Image = guy.portrait;
                    webBrowser1.Navigate(path);
                }
            }
        }

        private void FilterRadioButton__CheckedChanged(Object sender, EventArgs e)
        {
            string all = "all";
            RadioButton filterButton = (sender as RadioButton);
            if (filterButton.Checked)
                {
                foreach (Control control in this.Controls)
                {
                    if (control.GetType() == typeof(RadioButton))
                    {
                        control.Visible = true;
                        control.Enabled = true;
                        foreach (Presidents guy in presidents)
                        {
                            if (guy.party != filterButton.Tag && control.Text == guy.name && filterButton.Tag != all)
                            {
                                control.Visible = false;
                                control.Enabled = false;
                            }
                        }
                    }
                    if ((string)filterButton.Tag == all)
                    {
                        control.Visible = true;
                        control.Enabled = true;
                    }
                }
            }
        }

        private void RadioButton__CheckedChanged1(object sender, EventArgs e)
        {
            RadioButton button = (RadioButton)sender;
            foreach (Presidents guy in presidents)
            {
                if (guy.party != button.Tag)
                {
                    button.Enabled= false;
                    button.Visible= false;
                }
            }
        }

        private void TxtBox__Validator(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            bool valid = true;
            
        }

        public struct Presidents
        {
            public string name;
            public Image portrait;
            public string party;
            public int num;
            
        }

        public Presidents[] presidents = new Presidents[]
        {
            new Presidents 
            {
                name = "Benjamin Harrison",
                portrait = Image.FromFile("C:\\Users\\Owner\\OneDrive\\Documents\\GitHub\\myIGME-201\\Presidents1\\WindowsFormsApp1\\Resources\\BenjaminHarrison.jpeg"),
                party = "r",
                num = 23
            }
,           new Presidents 
            {
               name = "William McKinley",
               portrait = Image.FromFile("C:\\Users\\Owner\\OneDrive\\Documents\\GitHub\\myIGME-201\\Presidents1\\WindowsFormsApp1\\Resources\\WilliamMcKinley.jpeg"),
               party = "r",
               num = 25
            }
,           new Presidents 
            {
               name = "Dwight D Eisenhower",
               portrait = Image.FromFile("C:\\Users\\Owner\\OneDrive\\Documents\\GitHub\\myIGME-201\\Presidents1\\WindowsFormsApp1\\Resources\\DwightDEisenhower.jpeg"),
               party = "r",
               num = 34
            }
,           new Presidents 
            {
               name = "Franklin D Roosevelt",
               portrait = Image.FromFile("C:\\Users\\Owner\\OneDrive\\Documents\\GitHub\\myIGME-201\\Presidents1\\WindowsFormsApp1\\Resources\\FranklinDRoosevelt.jpeg"),
               party = "d",
               num = 32
            }
,           new Presidents
            {
               name = "Ronald Reagan",
               portrait = Image.FromFile("C:\\Users\\Owner\\OneDrive\\Documents\\GitHub\\myIGME-201\\Presidents1\\WindowsFormsApp1\\Resources\\RonaldReagan.jpeg"),
               party = "r",
               num = 40
            }
,           new Presidents
            {
               name = "William J Clinton",
               portrait = Image.FromFile("C:\\Users\\Owner\\OneDrive\\Documents\\GitHub\\myIGME-201\\Presidents1\\WindowsFormsApp1\\Resources\\WilliamJClinton.jpeg"),
               party = "d",
               num = 42
            }
,           new Presidents
            {
               name = "James Buchanan",
               portrait = Image.FromFile("C:\\Users\\Owner\\OneDrive\\Documents\\GitHub\\myIGME-201\\Presidents1\\WindowsFormsApp1\\Resources\\JamesBuchanan.jpeg"),
               party = "d",
               num = 15
            }
,           new Presidents
            {
               name = "Martin VanBuren",
               portrait = Image.FromFile("C:\\Users\\Owner\\OneDrive\\Documents\\GitHub\\myIGME-201\\Presidents1\\WindowsFormsApp1\\Resources\\MartinVanBuren.jpeg"),
               party = "d",
               num = 8
            }
,           new Presidents
            {
               name = "Franklin Pierce",
               portrait = Image.FromFile("C:\\Users\\Owner\\OneDrive\\Documents\\GitHub\\myIGME-201\\Presidents1\\WindowsFormsApp1\\Resources\\FranklinPierce.jpeg"),
               party = "d",
               num = 14
            }
,           new Presidents
            {
               name = "George Washington",
               portrait = Image.FromFile("C:\\Users\\Owner\\OneDrive\\Documents\\GitHub\\myIGME-201\\Presidents1\\WindowsFormsApp1\\Resources\\GeorgeWashington.jpeg"),
               party = "f",
               num = 1
            }
,           new Presidents
            {
               name = "George W Bush",
               portrait = Image.FromFile("C:\\Users\\Owner\\OneDrive\\Documents\\GitHub\\myIGME-201\\Presidents1\\WindowsFormsApp1\\Resources\\GeorgeWBush.jpeg"),
               party = "r",
               num = 43
            }
,           new Presidents
            {
               name = "John Adams",
               portrait = Image.FromFile("C:\\Users\\Owner\\OneDrive\\Documents\\GitHub\\myIGME-201\\Presidents1\\WindowsFormsApp1\\Resources\\JohnAdams.jpeg"),
               party = "f",
               num = 2
            }
,           new Presidents
            {
               name = "Barrack Obama",
               portrait = Image.FromFile("C:\\Users\\Owner\\OneDrive\\Documents\\GitHub\\myIGME-201\\Presidents1\\WindowsFormsApp1\\Resources\\BarackObama.png"),
               party = "d",
               num = 44
            }
,           new Presidents
            {
               name = "Theodore Rosevelt",
               portrait = Image.FromFile("C:\\Users\\Owner\\OneDrive\\Documents\\GitHub\\myIGME-201\\Presidents1\\WindowsFormsApp1\\Resources\\TheodoreRoosevelt.jpeg"),
               party = "r",
               num = 26
            }
,           new Presidents
            {
               name = "John F Kennedy",
               portrait = Image.FromFile("C:\\Users\\Owner\\OneDrive\\Documents\\GitHub\\myIGME-201\\Presidents1\\WindowsFormsApp1\\Resources\\DwightDEisenhower.jpeg"),
               party = "d",
               num = 35
            },
            new Presidents
            {
               name = "Thomas Jefferson",
               portrait = Image.FromFile("C:\\Users\\Owner\\OneDrive\\Documents\\GitHub\\myIGME-201\\Presidents1\\WindowsFormsApp1\\Resources\\ThomasJefferson.jpeg"),
               party = "dr",
               num = 3
            }
        };
            

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
