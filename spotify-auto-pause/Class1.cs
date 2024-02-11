using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spotify_auto_pause
{
    internal class Class1
    {
        // https://learn.microsoft.com/en-us/windows/win32/inputdev/wm-appcommand
        // 0x319 APPCOMMAND

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        public static void SendPlayPause(int hWnd)
        {
            SendMessage((IntPtr)hWnd, 0x319, IntPtr.Zero, (IntPtr)(14 << 16)); // APPCOMMAND_MEDIA_PLAY_PAUSE
        }

        public static void SendPlay(int hWnd)
        {
            SendMessage((IntPtr)hWnd, 0x319, IntPtr.Zero, (IntPtr)(46 << 16)); // APPCOMMAND_MEDIA_PLAY
        }

        public static void SendPause(int hWnd)
        {
            SendMessage((IntPtr)hWnd, 0x319, IntPtr.Zero, (IntPtr)(47 << 16)); // APPCOMMAND_MEDIA_PAUSE
        }

        public static void SendP(int hWnd, bool state)
        {
            if (state)
                SendPlay(hWnd);
            else
                SendPause(hWnd);
        }
    }
}
