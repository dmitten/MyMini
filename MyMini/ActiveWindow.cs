using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Threading;
using System.Text.RegularExpressions;

namespace MyMini
{
    
    class ActiveWindow
    {
        public string WindowCaption { get; set; }
        public IntPtr WindowHandle { get; set; }
       // public List<WindowProcesses> ActiveProc { get; set; }
       // public List< Process> ActiveProcs;

        [ DllImport("user32.dll") ]
		static extern IntPtr GetForegroundWindow();
		[ DllImport("user32.dll") ]
		static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);
        [DllImport("user32.dll")]
         public static extern Int32 SetForegroundWindow(int hWnd);
        [DllImport("user32.dll")]
        public static extern int FindWindow(string lpClassName, string lpWindowName);
        
        public struct Rect
        {
            public int Bottom { get; set; }
            public int Right { get; set; }
            public int Left { get; set; }
            public int Top { get; set; }
        }

        public List<WindowProcesses> GetAllProcesses()
        {
            const int nChars = 256;
            StringBuilder Buff = new StringBuilder(nChars);
            List<WindowProcesses> ActiveProc1 = new List<WindowProcesses>();
            Process[] procs = Process.GetProcesses();
            IntPtr hWnd;
            foreach (Process proc in procs)
            {
                if ((hWnd = proc.MainWindowHandle) != IntPtr.Zero)
                {
                    WindowProcesses wp = new WindowProcesses();
                    wp.name = proc.ProcessName.ToString();
                    wp.handlePtr = hWnd;
                    wp.caption = "";
                   // NativeWin32.SetForegroundWindow(hWnd.ToInt32());
                   // Thread.Sleep(1000);
                    if (GetWindowText(hWnd, Buff, nChars) > 0)
                    {
                        wp.caption = Buff.ToString();
                    }
                    ActiveProc1.Add(wp);
                }
            }
            return ActiveProc1;
        }

        public string  GetActiveWindowCaption()
        {
            WindowCaption = "not found";
            const int nChars = 256;
            IntPtr handle; 
            StringBuilder Buff = new StringBuilder(nChars);
            handle = GetForegroundWindow();
            if (GetWindowText(handle, Buff, nChars) > 0)
            {
                WindowCaption = Buff.ToString();
                WindowHandle = handle;
            }
            return WindowCaption;
        }
        public string GetEpicUserName()//for some reason cant get name when not active window
        {
            string name  = "not found";
            WindowCaption = "";
            const int nChars = 256;
            IntPtr handle;
            StringBuilder Buff = new StringBuilder(nChars);
            handle = GetForegroundWindow();
            if (GetWindowText(handle, Buff, nChars) > 0)
            {
                WindowCaption = Buff.ToString();
                WindowHandle = handle;
            }
            if (WindowCaption.Contains("Hyper"))// active window is erecord
            {
                Regex regex = new Regex(@"PRD - \w+ \w");
                name = (regex.Match(WindowCaption).ToString());
                if (name.Count() >= 4)
                {
                    string[] n = name.Split(' ');
                   // name = "*" + n[2].Substring(0, 1) + n[3] + "*";// this adds two stars
                    name =  n[2].Substring(0, 1) + n[3];
                }
                else
                {
                    name = "not loged in";
                }

            }
            return name;
        }
       
        class NativeWin32
        {
            public const int WM_SYSCOMMAND = 0x0112;
            public const int SC_CLOSE = 0xF060;

            [DllImport("user32.dll")]
            public static extern int FindWindow(
                string lpClassName, // class name 
                string lpWindowName // window name 
            );
            [DllImport("user32.dll")]
            public static extern int SendMessage(
                int hWnd, // handle to destination window 
                uint Msg, // message 
                int wParam, // first message parameter 
                int lParam // second message parameter 
            );

            [DllImport("user32.dll")]
            public static extern int SetForegroundWindow(
                int hWnd // handle to window
                );

            private const int GWL_EXSTYLE = (-20);
            private const int WS_EX_TOOLWINDOW = 0x80;
            private const int WS_EX_APPWINDOW = 0x40000;

            public const int GW_HWNDFIRST = 0;
            public const int GW_HWNDLAST = 1;
            public const int GW_HWNDNEXT = 2;
            public const int GW_HWNDPREV = 3;
            public const int GW_OWNER = 4;
            public const int GW_CHILD = 5;

            public delegate int EnumWindowsProcDelegate(int hWnd, int lParam);

            [DllImport("user32")]
            public static extern int EnumWindows(EnumWindowsProcDelegate lpEnumFunc, int lParam);

            [DllImport("User32.Dll")]
            public static extern void GetWindowText(int h, StringBuilder s, int nMaxCount);

            [DllImport("user32", EntryPoint = "GetWindowLongA")]
            public static extern int GetWindowLongPtr(int hwnd, int nIndex);

            [DllImport("user32")]
            public static extern int GetParent(int hwnd);

            [DllImport("user32")]
            public static extern int GetWindow(int hwnd, int wCmd);

            [DllImport("user32")]
            public static extern int IsWindowVisible(int hwnd);

            [DllImport("user32")]
            public static extern int GetDesktopWindow();
        }

        class NativeMethods
        {
            // http://msdn.microsoft.com/en-us/library/ms633519(VS.85).aspx
            [DllImport("user32.dll", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool GetWindowRect(IntPtr hWnd, ref RECT lpRect);

            // http://msdn.microsoft.com/en-us/library/a5ch4fda(VS.80).aspx
            [StructLayout(LayoutKind.Sequential)]
            public struct RECT
            {
                public int Left;
                public int Top;
                public int Right;
                public int Bottom;
            }
        }
    
    }
}
