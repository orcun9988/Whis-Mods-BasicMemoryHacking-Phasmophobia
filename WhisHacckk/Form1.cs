using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//I made this program by taking rencify's c# open source project as an example. I would like to thank
//This hack complety free  it's work for 0.5.1.0v   when the game updates come u have to update pointers.cs
namespace WhisHacckk
{
    public partial class Form1 : Form
    {
        Mem mem = new Mem();
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int PID = mem.GetProcIdFromName("Phasmophobia.exe");
            if (PID > 0)
            {
                mem.OpenProcess(PID);
            }
            else
            {
                MessageBox.Show("The game is not open, the cheat will not work");
            }
        }



        //fonksiyonlarrr
        public void isinlan(double x, double y, double z)
        {
            mem.WriteMemory(pointers.xkord, "float", x.ToString());
            mem.WriteMemory(pointers.ykord, "float", y.ToString());
            mem.WriteMemory(pointers.zkord, "float", z.ToString());
        }



        public void basket(string skorr)
        {
            mem.WriteMemory(pointers.basket, "int", skorr);
        }


        public void isinlan2(double y)
        {
            mem.WriteMemory(pointers.ykord, "float", y.ToString());
        }


        public void grab(double uzaklik)
        {
            mem.WriteMemory(pointers.grab, "float", uzaklik.ToString());
        }

        public void insanityy(string insanity)
        {
            mem.WriteMemory(pointers.insanity, "float", insanity.ToString());
        }



        public void GetGhostInfo(string type, string shy, string e1, string e2, string e3)
        {
            label14.Text = type;
            label22.Text = shy;
            label18.Text = e1;
            label19.Text = e2;
            label20.Text = e3; 
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0)
            {
                MessageBox.Show("Please enter beetwen 0-9999", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                basket(textBox1.Text);
                string message = string.Format("Your Basketball score changed to: {0}!", textBox1.Text);
                MessageBox.Show(message, "Succes!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            isinlan(2.278203487, 1.9331214542, 2.729306936);  //tangelewood truck
        }

        private void button4_Click(object sender, EventArgs e)
        {
            isinlan(1.815507531, 1.836173654, 2.288045406);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            isinlan(2.347207785, -1.98968482, -2.625979662);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            isinlan(1.896301031, 1.832499862, -2.372178078);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            isinlan(2.52550602, 1.832499862, -2.351464748);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            isinlan(-2.008718252, 1.933461308, -2.746394634);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            isinlan(1.91115737, 1.875, -1.274376631);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            isinlan(-2.185822487, -1.968437433, 2.425055027);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            isinlan(-2.006616592, 1.874999881, 2.03250289);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            isinlan(2.596525192, 1.874999881, 2.561008453);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            isinlan(-2.884814978, 2.1, -2.012222767);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            isinlan(-2.154279947, 1.845303655, -1.526086688);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            isinlan(2.38692522, 2.231874943, 2.301160574);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            isinlan(2.407806396, 1.832499862, 2.018561125);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            isinlan(2.235376596, 2.428454638, -2.358367443);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            isinlan(-2.567132235, 1.967628002, 2.463145971);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            isinlan(-2.268725395, 1.89247036, 1.783697486);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            isinlan(2.173044682, 2.225358009, 2.005920649);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            isinlan(-2.15275979, 2.226339102, 2.348448753);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            isinlan(2.0592134, 1.891486526, -2.283080101);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            isinlan(-2.7970438, 1.914088011, 1.770919919);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            isinlan(-2.071150064, 1.845303655, -1.502516747);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            isinlan(2.21981287, 2.231874943, 2.293357134);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            isinlan(2.49453783, 2.231874943, 2.751256704);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            isinlan(2.199488401, 2.231874943, -2.309311152);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            isinlan(3.28006196, 1.976587892, 1.918214679);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            isinlan(3.074001312, 1.978749871, -2.181922913);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            isinlan(3.050585508, 1.9799999, -2.184454679);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            isinlan(2.11775732, 1.97874999, 2.993386507);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            isinlan(2.006438494, 1.97874999, -2.884879112);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            isinlan(-2.481226444, 1.914033771, 2.718887091);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            isinlan(-2.117536783, 1.832499981, 1.897176266);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            isinlan(-2.041127682, 1.832499743, -2.563430309);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            isinlan(-2.509404659, 1.832499981, -2.356439114);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            isinlan(-2.53841567, -2.02125001, -2.531153202);
        }

        private void button42_Click(object sender, EventArgs e)
        {
            isinlan(2.228311062, 1.976587892, 2.202212334);
        }

        private void button41_Click(object sender, EventArgs e)
        {
            isinlan(-2.855870008, -2.165849924, 2.991517782);
        }

        private void button40_Click(object sender, EventArgs e)
        {
            isinlan(-2.76150322, 1.832499862, 3.370085239);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            isinlan(-2.854246855, -2.165849924, -2.99233532);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            isinlan(-2.892100811, 1.832499862, -3.348544121);
        }

        private void button47_Click(object sender, EventArgs e)
        {
            isinlan(2.369348288, 1.651351929, -2.787190199);
        }

        private void button46_Click(object sender, EventArgs e)
        {
            isinlan(-1.628393173, 1.838695765, -2.23051548);
        }

        private void button45_Click(object sender, EventArgs e)
        {
            isinlan(2.929301739, 1.832499623, 2.756738186);
        }

        private void button43_Click(object sender, EventArgs e)
        {
            isinlan(2.918656826, 2.364374876, 3.161332607);
        }

        private void button44_Click(object sender, EventArgs e)
        {
            isinlan(-2.865234613, 1.832499743, 2.753620148);
        }

        private void button52_Click(object sender, EventArgs e)
        {
            isinlan(-2.701954603, 1.976587892, 2.464685678);
        }

        private void button51_Click(object sender, EventArgs e)
        {
            isinlan(-2.519613504, 1.833278179, 1.973723173);
        }

        private void button50_Click(object sender, EventArgs e)
        {
            isinlan(2.629023075, 1.833278179, -2.628431082);
        }

        private void button49_Click(object sender, EventArgs e)
        {
            isinlan(2.757946253, 2.014932632, 2.954420805);
        }

        private void button48_Click(object sender, EventArgs e)
        {
            isinlan(2.880916595, 1.833278179, 3.028188705);
        }

        private void button53_Click(object sender, EventArgs e)
        {
            isinlan2(3.5);
        }

        private void button54_Click(object sender, EventArgs e)
        {
            isinlan2(5);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                grab(trackBar1.Value);
            }
            else
            {
                timer1.Stop();
                grab(1.6);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                timer1.Start();
            }
            else
            {
                grab(1.6);
                timer1.Stop();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            insanityy(textBox2.Text);
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                insanityy("0");
            }
        }
        private void button55_Click(object sender, EventArgs e)
        {

            //get ghost name
            byte[] ghostname = mem.ReadBytes(pointers.ghostname, 10 * 5);
            string name = Encoding.Unicode.GetString(ghostname);
            label12.Text = name;  //set label12.text to ghost name

            //get ghost speed
            float ghostspeed = mem.ReadFloat(pointers.ghostspeed);
            textBox3.Text = ghostspeed.ToString();


            //get ghostfav room
            byte[] favroom = mem.ReadBytes(pointers.ghostfavroom, 10 * 5);
            string faavroom = Encoding.Unicode.GetString(favroom);
            label13.Text = faavroom;

            //get ghostcurrent room
            byte[] ghostcurrentroom = mem.ReadBytes(pointers.ghostcurrentroom, 10 * 5);
            string ghostroom = Encoding.Unicode.GetString(ghostcurrentroom);
            label23.Text = ghostroom;

            //get yourcurrent room
            byte[] yourcurrentroom = mem.ReadBytes(pointers.yourcurrentroom, 10 * 5);
            string yourroom = Encoding.Unicode.GetString(yourcurrentroom);
            label25.Text = yourroom;


            //get ghostishunting?
            int hunting = mem.ReadInt(pointers.ghosthunting, "");
            switch (hunting)
            {
                case 0:
                    label17.Text = "No";
                    break;
                case 1:
                    label17.Text = "Yes";
                    break;
                default:
                    label17.Text = "No";
                    break;
            }


            //get ghost type
            int type = mem.ReadInt(pointers.ghostid, "");
            switch (type)
            {
                case 1:
                    GetGhostInfo("Wraith", "No", "EMF 5", "Spirit Box", "DOTS");
                    break;
                case 2:
                    GetGhostInfo("Phantom", "No", "EMF 5", "Ghost Orb", "Freezing");
                    break;
                case 3:
                    GetGhostInfo("Poltergeist", "No", "Spirit Box", "Fingerprints", "Ghost Orb");
                    break;
                case 4:
                    GetGhostInfo("Banshee", "No", "Ghost Orb", "Fingerprints", "DOTS");
                    break;
                case 5:
                    GetGhostInfo("Jinn", "No", "EMF 5", "Fingerprints", "Freezing");
                    break;
                case 6:
                    GetGhostInfo("Mare", "No", "Spirit Box", "Ghost Orb", "Ghost Writing");
                    break;
                case 7:
                    GetGhostInfo("Revenant", "No", "EMF 5", "Fingerprints", "Ghost Writing");
                    break;
                case 8:
                    GetGhostInfo("Shade", "Yes", "EMF 5", "Ghost Orb", "Ghost Writing");
                    break;
                case 9:
                    GetGhostInfo("Demon", "No", "Spirit Box", "Ghost Writing", "Freezing");
                    break;
                case 10:
                    GetGhostInfo("Yurei", "No", "Ghost Orb", "Ghost Writing", "Freezing");
                    break;
                case 11:
                    GetGhostInfo("Oni", "No", "EMF 5", "Freezing", "DOTS");
                    break;
                case 12:
                    GetGhostInfo("Yokai", "No", "Ghost Orb", "Spirit Box", "DOTS");
                    break;
                case 13:
                    GetGhostInfo("Hantu", "No", "Freezing", "Ghost Orb", "Fingerprints");
                    break;
                case 14:
                    GetGhostInfo("Goryo", "No", "EMF 5", "DOTS", "Fingerprints");
                    break;
                case 15:
                    GetGhostInfo("Myling", "No", "EMF 5", "Ghost Writing", "Fingerprints");
                    break;
                case 16:
                    GetGhostInfo("Onryo", "No", "Freezing", "Spirit Box", "Ghost Orb");
                    break;
                case 17:
                    GetGhostInfo("The Twins", "No", "EMF 5", "Freezing", "Spirit Box");
                    break;
                case 18:
                    GetGhostInfo("Raiju", "No", "DOTS", "Ghost Orb", "EMF 5");
                    break;
                case 19:
                    GetGhostInfo("Obake", "No", "Fingerprints", "Ghost Orb", "EMF 5");
                    break;
                case 20:
                    GetGhostInfo("The Mimic", "No", "Spiritbox", "Fingerprints", "Freezing");
                    break;
                case 21:
                    GetGhostInfo("idk", "No", "x", "x", "x");
                    break;
                default:
                    GetGhostInfo("?", "?", "?", "?", "?");
                    break;
            }
        }

        private void button56_Click(object sender, EventArgs e)
        {
            try
            {
                mem.WriteMemory(pointers.ghostspeed, "float", textBox3.Text.ToString());
                textBox3.Text = "It's changed.Update again";
            }
            catch (Exception)
            {
                MessageBox.Show("Error,somethings wrong");
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            int basketskor = mem.ReadInt(pointers.basket);
            label3.Text = basketskor.ToString();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
    }
 }
