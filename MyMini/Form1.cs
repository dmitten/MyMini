using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using XPLog;
using Teboscreen;
using System.Runtime.InteropServices;
using System.IO;
using System.Threading.Tasks;

namespace MyMini
{
   
    public partial class Form1 : Form
    {
        string NoteText = "";
        string LOS = "99213";
        Keys[] Ident = new Keys[7] { Keys.D, Keys.M, Keys.I, Keys.T, Keys.T, Keys.E, Keys.N };
        Keys[] Pass = new Keys[8] { Keys.J, Keys.A, Keys.N, Keys.I, Keys.O, Keys.OemSemicolon, Keys.F, Keys.D };
        int longDelay = 500;
        int shortDelay = 100;
        bool Template = false;// has basic template been sent
        bool image = false; 
        Point NoteBlueLine = new Point(0, 0);// used for start of note 
        private const UInt32 MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const UInt32 MOUSEEVENTF_LEFTUP = 0x0004;
        [DllImport("user32.dll")]
        private static extern void mouse_event(UInt32 dwFlags, UInt32 dx, UInt32 dy, UInt32 dwData, IntPtr dwExtraInfo);


        public Form1()
        {
            InitializeComponent();
            watch();
        }
       [STAThread]
        private void watch()
        {
            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = "C:\\Users\\djmit_000\\AppData\\Local\\Packages\\2ac7d836-d159-47dc-90c5-0f42f5eb793a_4j5t8z38t883m\\LocalState";
            watcher.NotifyFilter = NotifyFilters.LastWrite;
            watcher.Filter = "*.*";
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.EnableRaisingEvents = true;// kill on event
        }
        private void startFilewatcher()
        {

        }
        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            var watcher = sender as FileSystemWatcher;
            if (watcher != null)
            {
                watcher.EnableRaisingEvents = false;
            }
            // need to get back yo ui thread
            this.BeginInvoke(new MethodInvoker(delegate
            {
                logonfromfilewatcher();
            }));
            
            Thread.Sleep(10000);
            //throw new NotImplementedException();
        }
        private void LogOnBTN_Click(object sender, EventArgs e)
        {

            bool laptop = false;
            if (System.Environment.MachineName.ToString().Contains("DM"))
            {
                int iHandle = NativeWin32.FindWindow(null, "Hyperspace - URMC PRD - \\\\Remote, 128-bit SSL/TLS.");
                NativeWin32.SetForegroundWindow(iHandle);
                Thread.Sleep(250);
                laptop = true;
            }
            else
            {
                int iHandle = NativeWin32.FindWindow(null, "Hyperspace - URMC PRD - \\\\Remote");
                NativeWin32.SetForegroundWindow(iHandle);
                Thread.Sleep(250);
            }

            MySendKeys m = new MySendKeys();
            Rectangle r = new Rectangle(445, 320, 600, 400);//
            Bitmap b = new Bitmap(epicloginnamepb.Image);
            if (FindBmp(b, r, true, 50, 0, false, true)) { Thread.Sleep(10); }
            //m.PressKeyArray(Ident);
            m.PressKeyArray(Pass);
            Thread.Sleep(10);
            //m.PressKey(Keys.Tab);
            Thread.Sleep(100);


            //Rectangle r1 = new Rectangle(445, 320, 600, 400);//click password
            //Bitmap b1 = new Bitmap(epicloginpasswordpb.Image);
            //if (FindBmp(b1, r1, true, 50, 0, false, true)) { Thread.Sleep(10); }
           
            
            //m.PressKeyArray(Pass);
            //Thread.Sleep(10);
            //m.AltO();
            //Thread.Sleep(200);
            //m.AltO();

            //Rectangle r2 = new Rectangle(445, 320, 600, 400);//
            //Bitmap b2 = new Bitmap(epicloginbtnpb.Image);
            //if (FindBmp(b2, r2, true, 50, 0, false, true)) { Thread.Sleep(10); }
            //if (!laptop)
            //{
            //    if (FindBmp(b2, r2, true, 50, 0, false, true)) { Thread.Sleep(10); }// gold login same as ok on university
            //}
            //else
            //{
            //    Rectangle r3 = new Rectangle(445, 340, 600, 400);//click password
            //    Bitmap b3 = new Bitmap(epicloginokpb.Image);//laptop grey login btn.
            //    FindBmp(b3, r3, true, 50, 0, false, true);
            //}
        }


        //---------------------
        public bool FindBmp(Bitmap image, Rectangle searchrect, bool forward, int xoffset, int yoffset, bool Multiple, bool click)
        {
            int x = 0;
            int y = 0;
            bool found = false;
            string imagestring = "";
            string startingcolor;
            //get color of lead pixel
            if (forward) { startingcolor = image.GetPixel(0, 0).Name.ToString(); }
            else { startingcolor = image.GetPixel(image.Width, 0).Name.ToString(); }
            //get string of image pixels
            for (int i = 0; i < image.Width; i++)
            {
                imagestring += image.GetPixel(i, 0).Name.ToString();
            }
            //get screenshot
            // MakeeRecordActive();
            Point curPos = new Point(Cursor.Position.X, Cursor.Position.Y);
            Size curSize = new Size();
            curSize.Height = Cursor.Current.Size.Height;
            string ScreenPath = "";
            Rectangle bounds = Screen.GetBounds(Screen.GetBounds(Point.Empty));
            string fi = "";
            ScreenShot.CaptureImage(false, curSize, curPos, Point.Empty, Point.Empty, bounds, ScreenPath, fi);
            screenpb.Image = Clipboard.GetImage();
            //
            //Bitmap epicadd = new Bitmap(epicaddpb.Image);
            Bitmap screen = new Bitmap(screenpb.Image);
            if (forward)
            {
                x = screen.Width;
                if (searchrect.Right <= x) { x = searchrect.Right; }
                y = screen.Height;
                //y = searchrect.Bottom;
                if (searchrect.Bottom <= y) { y = searchrect.Bottom; }
                int X = searchrect.Left;
                int Y = searchrect.Top;
                Bitmap c = new Bitmap(image);
                do// loop x
                {
                    do
                    {
                        if (screen.GetPixel(X, Y).Name.ToString() == startingcolor)// found start
                        {
                            string screenstring = "";
                            for (int i = 0; i < image.Width; i++)
                            {
                                screenstring += screen.GetPixel(X + i, Y).Name.ToString();
                            }
                            if (screenstring == imagestring)
                            {

                                found = true;
                                NoteBlueLine.X = X; // used for notes
                                NoteBlueLine.Y = Y;
                                if (click)
                                {
                                    Cursor.Position = new Point(X + xoffset, Y + yoffset);
                                    mouseclick();
                                    Thread.Sleep(longDelay);

                                }// left click mouse
                                if (!Multiple) { X = Y = 5000; }// stop
                            }
                        }
                        X++;
                        // } while (X <= x - 15);
                    } while (X <= x - 1);
                    X = searchrect.Left;
                    Y++;
                    //} while (Y <= y - 5);   
                } while (Y <= y - 1);
            }
            return found;
        }
        private void mouseclick()
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, new IntPtr());
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, new IntPtr());
        }

        private void CopyBTN_Click(object sender, EventArgs e)
        {
            ScreenShot.saveToClipboard = false;
            SCREENCLIPPERForm f = new SCREENCLIPPERForm();
            f.Show();
        }

        private void loscb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //if (MakeeRecordActive())
            //{
            //    HistoryExamPlanToNote(".mitHbasal", ".MITRBASAL", ".mitInjectRightBasal");
            //   // HistoryExamPlanToNote("", ".MITLBASAL", ".mitInjectLeftBasal");
            //}
        }
        private void HistoryExamPlanToNote(string history, string exam, string dx, string plan)
        {
            progressBar1.PerformStep();
            if (MakeeRecordActive())
            {
               // PutInTemplate();
                progressBar1.PerformStep();
                MySendKeys m = new MySendKeys();
                if (rBAll.Checked || rBHistory.Checked)
                {
                    SendKeys.Send(history + " ***");
                    Thread.Sleep(longDelay);
                }
                progressBar1.PerformStep();
                m.PressKey(Keys.F2);
                Thread.Sleep(longDelay);
                if (rBAll.Checked||rBExam.Checked)
                {
                    SendKeys.Send(exam + " ***");
                    Thread.Sleep(longDelay);
                }
                progressBar1.PerformStep();
                m.PressKey(Keys.F2);
                Thread.Sleep(longDelay);
                if (rBAll.Checked || rBPlan.Checked)
                {
                    SendKeys.Send(dx + plan + " ***");
                    Thread.Sleep(longDelay);
                }
                progressBar1.PerformStep();
                m.PressKey(Keys.F2);// move to top
                Thread.Sleep(longDelay);
            }
            progressBar1.Value = 0;
        }
        //private void MakeErecordActiveWindow()
        //{
        //    bool laptop = false;
        //    if (System.Environment.MachineName.ToString().Contains("DM"))
        //    {
        //        int iHandle = NativeWin32.FindWindow(null, "Hyperspace - URMC PRD - \\\\Remote, 128-bit SSL/TLS.");
        //        NativeWin32.SetForegroundWindow(iHandle);
        //        Thread.Sleep(250);
        //        laptop = true;
        //    }
        //    else
        //    {
        //        int iHandle = NativeWin32.FindWindow(null, "Hyperspace - URMC PRD - \\\\Remote");
        //        NativeWin32.SetForegroundWindow(iHandle);
        //        Thread.Sleep(250);
        //    }
        //}
        private void PutInTemplate()
        {
                if (MakeeRecordActive() && !Template)
            {
                MySendKeys m = new MySendKeys();
                SendKeys.Send(".mitvisit ");
                Thread.Sleep(longDelay);
                m.PressKey(Keys.F2);// move to top
                Template = true;
            }
            
        }
        private bool MakeeRecordActive()
        {
            bool found = false;
            List<WindowProcesses> wpl = new List<WindowProcesses>();
            ActiveWindow a = new ActiveWindow();
            wpl = a.GetAllProcesses();
            int hand = 0;
            foreach (var item in wpl)
            {
                if (item.caption.Contains("Hyperspace"))
                {
                    hand = item.handlePtr.ToInt32();
                    found = true;
                }
            }
            NativeWin32.SetForegroundWindow(hand);
            Thread.Sleep(250);
            return found;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)//right Basal
        {
           
                
            
        }
        private void reset()
        {
            Template = false;
            image = false;

        }
        private void button1_Click_1(object sender, EventArgs e)// add image
        {
            if (MakeeRecordActive())
                //if (MakeeRecordActive() && !image)
            {
                PutInTemplate();
                MySendKeys m = new MySendKeys();
                m.PressKey(Keys.F2);// move 
                Thread.Sleep(longDelay);
                SendKeys.Send("*** .mitxray ");
                Thread.Sleep(longDelay);
                m.PressKey(Keys.F2);// move 
                Thread.Sleep(longDelay);
                m.PressKey(Keys.F2);// move 
                Thread.Sleep(longDelay);
                image = true;
            }
        }

        private void button12_MouseUp(object sender, MouseEventArgs e)
        {
            progressBar1.PerformStep();
            if (e.Button.ToString().Equals("Left"))
            {
                HistoryExamPlanToNote(".mitHbasal", ".MITRBASAL", ".MITRBJA ", "");
         
                  }
           
            else if(e.Button.ToString().Equals("Right"))
            {
                HistoryExamPlanToNote(".mitHbasal", ".MITRBASAL", ".MITRBJA ", ".mitInjectRightBasal");
         
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
           
            PutInTemplate();

        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            PutInTemplate();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            ScreenShot.saveToClipboard = false;
            SCREENCLIPPERForm f = new SCREENCLIPPERForm();
            f.Show();
        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            if (MakeeRecordActive())
            //if (MakeeRecordActive() && !image)
            {
                //PutInTemplate();
                MySendKeys m = new MySendKeys();
                m.PressKey(Keys.F2);// move 
                Thread.Sleep(longDelay);
                SendKeys.Send("*** .mitxray ");
                Thread.Sleep(longDelay);
                m.PressKey(Keys.F2);// move 
                Thread.Sleep(longDelay);
                m.PressKey(Keys.F2);// move 
                Thread.Sleep(longDelay);
                image = true;
            }
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            ScreenShot.saveToClipboard = false;
            SCREENCLIPPERForm f = new SCREENCLIPPERForm();
            f.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)//login
        {
              bool laptop = false;
            if (System.Environment.MachineName.ToString().Contains("DM"))
            {
                int iHandle = NativeWin32.FindWindow(null, "Hyperspace - URMC PRD - \\\\Remote, 128-bit SSL/TLS.");
                NativeWin32.SetForegroundWindow(iHandle);
                Thread.Sleep(250);
                laptop = true;
            }
            else
            {
                int iHandle = NativeWin32.FindWindow(null, "Hyperspace - URMC PRD - \\\\Remote");
                NativeWin32.SetForegroundWindow(iHandle);
                Thread.Sleep(250);
            }

            MySendKeys m = new MySendKeys();
            Rectangle r = new Rectangle(445, 320, 600, 400);//
            Bitmap b = new Bitmap(epicloginnamepb.Image);
            if (FindBmp(b, r, true, 50, 0, false, true)) { Thread.Sleep(10); }
            m.PressKeyArray(Ident);
            Thread.Sleep(10);
            m.PressKey(Keys.Tab);
            Thread.Sleep(100);

            m.PressKeyArrayPassword(Pass);
            Thread.Sleep(10);
            m.AltO();
            Thread.Sleep(200);
            m.AltO();

            //Rectangle r2 = new Rectangle(445, 320, 600, 400);//
            //Bitmap b2 = new Bitmap(epicloginbtnpb.Image);
            //if (FindBmp(b2, r2, true, 50, 0, false, true)) { Thread.Sleep(10); }
            //if (!laptop)
            //{
            //    if (FindBmp(b2, r2, true, 50, 0, false, true)) { Thread.Sleep(10); }// gold login same as ok on university
            //}
            //else
            //{
            //    Rectangle r3 = new Rectangle(445, 340, 600, 400);//click password
            //    Bitmap b3 = new Bitmap(epicloginokpb.Image);//laptop grey login btn.
            //    FindBmp(b3, r3, true, 50, 0, false, true);
            //}


        }
        [STAThread]
        private void logonfromfilewatcher()
        {
            //Thread.Sleep(5000);
            bool laptop = false;
            if (System.Environment.MachineName.ToString().Contains("DM"))
            {
                int iHandle = NativeWin32.FindWindow(null, "Hyperspace - URMC PRD - \\\\Remote, 128-bit SSL/TLS.");
                NativeWin32.SetForegroundWindow(iHandle);
                Thread.Sleep(250);
                laptop = true;
            }
            else
            {
                int iHandle = NativeWin32.FindWindow(null, "Hyperspace - URMC PRD - \\\\Remote");
                NativeWin32.SetForegroundWindow(iHandle);
                Thread.Sleep(250);
            }

            MySendKeys m = new MySendKeys();
            Rectangle r = new Rectangle(445, 320, 600, 400);//
            Bitmap b = new Bitmap(epicloginnamepb.Image);
            if (FindBmp(b, r, true, 50, 0, false, true)) { Thread.Sleep(10); }
            m.PressKeyArray(Ident);
            Thread.Sleep(10);
            m.PressKey(Keys.Tab);
            Thread.Sleep(100);

            m.PressKeyArrayPassword(Pass);
            Thread.Sleep(10);
            //m.AltO();
            //Thread.Sleep(200);
            //m.AltO();
        }
  
        private void leftthumbtrigger_Click(object sender, EventArgs e)
        {

        }

        private void leftbasal_MouseUp(object sender, MouseEventArgs e)
        {
            progressBar1.PerformStep();
            if (e.Button.ToString().Equals("Left"))
            {
                HistoryExamPlanToNote(".mitHbasal", ".MITlBASAL", ".MITlBJA ", "");

            }

            else if (e.Button.ToString().Equals("Right"))
            {
                HistoryExamPlanToNote(".mitHbasal", ".MITlBASAL", ".MITlBJA ", ".mitInjectleftBasal");

            }
        }

        private void rightBasalLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void progressBar1_MouseUp(object sender, MouseEventArgs e)//all the triggers
        {
            
            var button = (Button)sender;
            string side = "r";
            if (button.Name.Contains("left")) { side = "l"; }
            string finger = GetFinger(button.Name);
            if (e.Button == System.Windows.Forms.MouseButtons.Right)// RIGHT click
            {
                HistoryExamPlanToNote("", "",  side+" "+finger+": ", ".mitInjtrig"+side+finger[0]+" ");

            }
           
     }
        private string GetFinger(string name)
        {
            string finger = "";
            if (name.Contains("thumb")) { finger= "thumb"; }
            if (name.Contains("index")) { finger = "index"; }
            if (name.Contains("long")) { finger = "long"; }
            if (name.Contains("ring")) { finger = "ring"; }
            if (name.Contains("small")) { finger = "small"; }
            return finger;

        }
         private void markasreviewed()
        {

            MySendKeys a = new MySendKeys();
            a.AltR();
            Thread.Sleep(250);
            a.CtlShiftA();
            Thread.Sleep(1000);
            a.AltR();
            Thread.Sleep(250);

            
            
            if (cBNote.Checked)
            {
                a.CtlShiftMNewNote();
                Thread.Sleep(2000);
                a.TypeString(NoteText);
                Thread.Sleep(100);
                //a.CtlHome();
                //a.PressKey(Keys.F2);
                //Thread.Sleep(250);
            }

            a.CtlShiftL();//open level of service
            Thread.Sleep(3000);
            a.TypeString(LOS);
            Thread.Sleep(750);
            /*
                        a.CtlShiftL();//open level of service
                        Thread.Sleep(3000);
                        //a.PressKey(Keys.F9);
                        a.TypeString("99999");
                        Thread.Sleep(1000);
                        */

            a.CtlShiftP();
            Thread.Sleep(3500);
            a.AltR();
            Thread.Sleep(250);
           // MySendKeys a = new MySendKeys();
           //// a.AltR();
           // //Thread.Sleep(250);
           // a.CtlShiftA();
           // Thread.Sleep(250);
           // a.AltR();
           // Thread.Sleep(250);
           // a.CtlShiftP();
           // Thread.Sleep(1500);
           // a.AltR();
           // Thread.Sleep(250);
           //// a.AltR();
           //// Thread.Sleep(500);
           // //a.AltR();

             // find mitten problem
            Rectangle r1 = new Rectangle(1200, 180,600 , 10000);//click problem list if not already done not working100
            Bitmap b1 = new Bitmap(epicmitten.Image);
            if (FindBmp(b1, r1, true, 20, 0, false, false)) 
            { 
                Thread.Sleep(500);
                MessageBox.Show("mitten");
            }

           
        }
         private void filllos()
         {
             MakeeRecordActive();
             Thread.Sleep(1000);
             //MySendKeys a = new MySendKeys();
             //a.AltR();// catch open meds
             //Thread.Sleep(400);
             //if (loscb.SelectedItem.ToString().Contains("OR "))
             //special click every thing for procedure room
             //{
             //    a.CtlShiftMNewNote();
             //    Thread.Sleep(2000);
             //    if (cBNote.Checked)
             //    {
             //        a.TypeString(" .mitf ");
             //    }
             //    Thread.Sleep(100);
             //    a.CtlHome();
             //    a.PressKey(Keys.F2);

             //}
             //if (loscb.SelectedItem.ToString().Contains("OR "))
             ////special click every thing for procedure room
             //{
             //    markasreviewed();

             //}
             //click los
             //Rectangle r1 = new Rectangle(100, 180, 200, 10000);//click problem list if not already done not working
             //Bitmap b1 = new Bitmap(epiclospb.Image);
             //if (FindBmp(b1, r1, true, 20, 0, false, true)) { Thread.Sleep(500); }


             //Rectangle r2 = new Rectangle(500, 200, 300, 10000);// click los text box 
             //Bitmap b2 = new Bitmap(epiclostextpb.Image);
             //if (FindBmpSlow(b2, r2, true, -30, 2, false, false))// finding magic wand no click now we know we have it open so send text
             //{
             //    Thread.Sleep(200);
             //    List<Keys> icd = getnumerskeyarray(loscb.SelectedItem.ToString());//this gets only numbers and .
             //    foreach (var item in icd)
             //    {
             //        a.PressKey(item);
             //    }
             //    //click close
             //    Thread.Sleep(100);
             //    a.PressKey(Keys.F9);
             //    Thread.Sleep(250);
             //}
             // note
             // string text = "";
             // if (loscb.SelectedItem.ToString().Contains("New")) { text = ".mitnew "; }
             // if (loscb.SelectedItem.ToString().Contains("Post")) { text = ".mitpostop "; }
             // if (loscb.SelectedItem.ToString().Contains("FU")) { text = ".mitfollowup "; }
             // if (loscb.SelectedItem.ToString().Contains("SLU")) { text = ".mitfollowup "; }
             // if (loscb.SelectedItem.ToString().Contains("Estab")) { text = ".mitfollowup "; }
             // if (loscb.SelectedItem.ToString().Contains("OR")) { text = ".pdic "; }
             // //MakeeRecordActive();
             // //Thread.Sleep(500);
             //// MySendKeys a = new MySendKeys();
             // a.CtlShiftMNewNote();
             // Thread.Sleep(3000);
             // a.TypeString(text);
             // Thread.Sleep(250);
             // // SendKeys.Send(text);
             // a.CtlHome();
             // // a.PressKey(Keys.F2);
             // mark as reviewed
             // Thread.Sleep(500);

             markasreviewed();

             //Rectangle r2 = new Rectangle(350, 590, 200, 10000);//
             //Bitmap b2 = new Bitmap(epiccloselospb.Image);
             // if (FindBmp(b2, r2, true, 20, 0, false, true)) { Thread.Sleep(500); }
             //if (loscb.SelectedItem.ToString().Contains("OR "))
             ////special click every thing for procedure room
             //{
             //    Rectangle r4 = new Rectangle(100, 180, 200, 1000);
             //    Bitmap b4 = new Bitmap(epicprocedurenotepb.Image);
             //    if (FindBmp(b4, r4, true, 10, 0, false, true)) { Thread.Sleep(500); }

             //    Rectangle r5 = new Rectangle(200, 107, 450, 1000);
             //    Bitmap b5 = new Bitmap(epiccreatenotepb.Image);
             //    if (FindBmp(b5, r5, true, 10, 0, false, true)) { Thread.Sleep(shortdelay); }

             //    SendKeys.Send(".pdic ");
             //

             //  FURB.Checked = true;

         }
        private void button2_Click_1(object sender, EventArgs e)
        {
            filllos();
              
        }

        private void FURB_CheckedChanged(object sender, EventArgs e)
        {
            LOS = "99213"; //filllos();
            
        }

        private void PostOPRB_CheckedChanged(object sender, EventArgs e)
        {
            LOS = "99024";// filllos();
        }

        private void NewRB_CheckedChanged(object sender, EventArgs e)
        {
            LOS = "99203"; //filllos();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            LOS = "99213";
            NoteText = ".mitf ";
            filllos();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            NoteText = ".mitpo ";
            LOS = "99024"; filllos();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            NoteText = ".mitne ";
            LOS = "99203"; filllos();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            NoteText = ".mitnu ";
            LOS = "99203"; filllos();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            NoteText = ".mitf ";
            LOS = "99203"; filllos();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }

    }

