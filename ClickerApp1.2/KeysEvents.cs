using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Xml.Schema;
using Microsoft.VisualStudio.TestTools.UITesting;

namespace ClickerApp1._2
{
    public class KeysEvents

    {
        //Подключение windows библиотеки для эмуляции кликов

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        private const int MOUSE_LEFTDOWN = 0x02;
        private const int MOUSE_LEFTUP = 0x04;
        private const int MOUSE_RIGHTDOWN = 0x08;
        private const int MOUSE_RIGHTUP = 0x10;

        //Эмуляция клавиатуры

        [DllImport("user32.dll", SetLastError = true)]
        public static extern void keybd_event(byte kVk, byte bScan, uint dwFlags, int dwExtraInfo);

        private const int KEYEVENTF_KEYDOWN = 0x0000;
        private const int KEYEVENTF_EXTENDEDKEY = 0x0001;
        private const int KEYEVENTF_KEYUP = 0x0002;
        private const int VK_LCONTROL = 0xA2;
        private const int V = 0x56;

        public static int GetPosX() => Control.MousePosition.X;

        public static int GetPosY() => Control.MousePosition.Y;

        public static void NewPosition(int x, int y) => Cursor.Position = new Point(x, y);

        public static void MouseClick(int n = 0)
        {
            mouse_event(MOUSE_LEFTDOWN, (uint) GetPosX(), (uint) GetPosY(), 0, 0);
            //Thread.Sleep(3);
            mouse_event(MOUSE_LEFTUP, (uint) GetPosX(), (uint) GetPosY(), 0, 0);
            //Thread.Sleep(3);
        }

        public  static void MouseDoubleClick(int n = 0)
        {
            for (int i = 0; i < 2; i++)
            {
                mouse_event(MOUSE_LEFTDOWN, (uint) GetPosX(), (uint) GetPosY(), 0, 0);
                Thread.Sleep(8);
                mouse_event(MOUSE_LEFTUP, (uint) GetPosX(), (uint) GetPosY(), 0, 0);
                Thread.Sleep(8);
            }
        }

        public  static void MouseRightClick(int n = 0)
        {
            mouse_event(MOUSE_RIGHTDOWN, (uint) GetPosX(), (uint) GetPosY(), 0, 0);
            Thread.Sleep(8);
            mouse_event(MOUSE_RIGHTUP, (uint) GetPosX(), (uint) GetPosY(), 0, 0);
            Thread.Sleep(8);
        }

        public  static void PressKeys()
        {
            keybd_event(VK_LCONTROL, 0, KEYEVENTF_KEYDOWN, 0);
            //Thread.Sleep(8);
            keybd_event(V, 0, KEYEVENTF_KEYDOWN, 0);
            //Thread.Sleep(8);
            keybd_event(V, 0, KEYEVENTF_KEYUP, 0);
            //Thread.Sleep(8);
            keybd_event(VK_LCONTROL, 0, KEYEVENTF_KEYUP, 0);
            //Thread.Sleep(8);
        }

        public static void InsertText(int index, ComboBox.ObjectCollection source)
        {
            Clipboard.SetText(source[index].ToString());
            PressKeys();
#if DEBUG
            File.AppendAllText(Repeater.PathIn, $"\t\t\t Text {source[index]} inserted\n");
#endif

            //Thread.Sleep(8);
        }

        public static void InsertJobs(/*int index = 0, */ComboBox.ObjectCollection source)
        {
            Clipboard.SetText(source[0].ToString());
            PressKeys();
#if DEBUG
            File.AppendAllText(Repeater.PathIn, $"\t\t\t Text {source[0]} inserted\n");
#endif
            //Thread.Sleep(8);
        }
    }
}
