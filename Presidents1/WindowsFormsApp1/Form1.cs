using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        


        public Form1()
        {
            InitializeComponent();
            try
            {
                RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\\\WOW6432Node\\\\Microsoft\\\\Internet Explorer\\\\MAIN\\\\FeatureControl\\\\FEATURE_BROWSER_EMULATION", true);
                registryKey.SetValue(Application.ExecutablePath.Replace(Application.StartupPath + "\\", ""), (object)12001, RegistryValueKind.DWord);
                registryKey.Close();
            }
            catch
            {
            }

            foreach (Control control in this.Controls)
            {

                if (control.GetType() == typeof(PictureBox))
                {
                    PictureBox pictureBox = control as PictureBox;
                    pictureBox.MouseEnter += new EventHandler(this.PictureBox__MouseEnter);
                    pictureBox.MouseLeave += new EventHandler(this.PictureBox__MouseLeave);
                }

                if (control.GetType() == typeof(RadioButton))
                {
                    RadioButton radioButton = (control as RadioButton);
                    Console.WriteLine(radioButton.ToString());
                    radioButton.CheckedChanged += new EventHandler(this.RadioButton__CheckedChanged);
                }

                if (control.GetType() == typeof(RadioButton) == false)
                {
                    RadioButton radioButton = (control as RadioButton);
                }
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
            pictureBox.Height/= 2;
            pictureBox.Width/= 2;
        }
        
        private void RadioButton__CheckedChanged(object sender, EventArgs e)
        {
            RadioButton button = (RadioButton)sender;
            if (!button.Checked) { return; }
            foreach (Presidents pic in photographs)
            {
                if(pic.name == button.Text)
                {
                    pictureBox1.Image = pic.portrait;
                }
            }
            if (button.Tag == "filter")
            {
                
            }
        }



        public struct Presidents
        {
            public string name;
            public Image portrait;
            public string party;
            public string url;

            
        }

        public Presidents[] photographs = new Presidents[]
        {
            new Presidents {name = "Benjamin Harrison", portrait = Image.FromFile("C:\\Users\\Owner\\OneDrive\\Documents\\GitHub\\myIGME-201\\Presidents1\\WindowsFormsApp1\\Resources\\BenjaminHarrison.jpeg") },
            new Presidents {name = "William McKinley", portrait = Image.FromFile("C:\\Users\\Owner\\OneDrive\\Documents\\GitHub\\myIGME-201\\Presidents1\\WindowsFormsApp1\\Resources\\WilliamMcKinley.jpeg") },
            new Presidents {name = "Dwight D Eisenhower", portrait = Image.FromFile("C:\\Users\\Owner\\OneDrive\\Documents\\GitHub\\myIGME-201\\Presidents1\\WindowsFormsApp1\\Resources\\DwightDEisenhower.jpeg") },
            new Presidents {name = "Franklin D Roosevelt", portrait = Image.FromFile("C:\\Users\\Owner\\OneDrive\\Documents\\GitHub\\myIGME-201\\Presidents1\\WindowsFormsApp1\\Resources\\FranklinDRoosevelt.jpeg") },
            new Presidents {name = "Ronald Reagan", portrait = Image.FromFile("C:\\Users\\Owner\\OneDrive\\Documents\\GitHub\\myIGME-201\\Presidents1\\WindowsFormsApp1\\Resources\\RonaldReagan.jpeg") },
            new Presidents {name = "William J Clinton", portrait = Image.FromFile("C:\\Users\\Owner\\OneDrive\\Documents\\GitHub\\myIGME-201\\Presidents1\\WindowsFormsApp1\\Resources\\WilliamJClinton.jpeg") },
            new Presidents {name = "James Buchanan", portrait = Image.FromFile("C:\\Users\\Owner\\OneDrive\\Documents\\GitHub\\myIGME-201\\Presidents1\\WindowsFormsApp1\\Resources\\JamesBuchanan.jpeg") },
            new Presidents {name = "Martin VanBuren", portrait = Image.FromFile("C:\\Users\\Owner\\OneDrive\\Documents\\GitHub\\myIGME-201\\Presidents1\\WindowsFormsApp1\\Resources\\MartinVanBuren.jpeg") },
            new Presidents {name = "Franklin Pierce", portrait = Image.FromFile("C:\\Users\\Owner\\OneDrive\\Documents\\GitHub\\myIGME-201\\Presidents1\\WindowsFormsApp1\\Resources\\FranklinPierce.jpeg") },
            new Presidents {name = "George Washington", portrait = Image.FromFile("C:\\Users\\Owner\\OneDrive\\Documents\\GitHub\\myIGME-201\\Presidents1\\WindowsFormsApp1\\Resources\\GeorgeWashington.jpeg") },
            new Presidents {name = "George W Bush", portrait = Image.FromFile("C:\\Users\\Owner\\OneDrive\\Documents\\GitHub\\myIGME-201\\Presidents1\\WindowsFormsApp1\\Resources\\GeorgeWBush.jpeg") },
            new Presidents {name = "John Adams", portrait = Image.FromFile("C:\\Users\\Owner\\OneDrive\\Documents\\GitHub\\myIGME-201\\Presidents1\\WindowsFormsApp1\\Resources\\JohnAdams.jpeg") },
            new Presidents {name = "Barrack Obama", portrait = Image.FromFile("C:\\Users\\Owner\\OneDrive\\Documents\\GitHub\\myIGME-201\\Presidents1\\WindowsFormsApp1\\Resources\\BarackObama.png") },
            new Presidents {name = "Theodore Rosevelt", portrait = Image.FromFile("C:\\Users\\Owner\\OneDrive\\Documents\\GitHub\\myIGME-201\\Presidents1\\WindowsFormsApp1\\Resources\\TheodoreRoosevelt.jpeg") },
            new Presidents {name = "John F Kennedy", portrait = Image.FromFile("C:\\Users\\Owner\\OneDrive\\Documents\\GitHub\\myIGME-201\\Presidents1\\WindowsFormsApp1\\Resources\\DwightDEisenhower.jpeg") },
            new Presidents {name = "Thomas Jefferson", portrait = Image.FromFile("C:\\Users\\Owner\\OneDrive\\Documents\\GitHub\\myIGME-201\\Presidents1\\WindowsFormsApp1\\Resources\\ThomasJefferson.jpeg") },


        };

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
