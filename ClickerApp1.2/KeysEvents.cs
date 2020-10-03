using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using static KeysEvents.KeyEvents;

namespace EventManager
{
    partial class ClickerApp
    {
        //private readonly KeysEvents.KeyEvents keys;

        private int GetPosX() => Control.MousePosition.X;

        private int GetPosY() => Control.MousePosition.Y;

        private void NewPosition(int x, int y) => Cursor.Position = new Point(x, y);

        private new void MouseClick()
        {
            mouse_event(MOUSEEVENTFEVENTF_LEFTDOWN, (uint) GetPosX(), (uint) GetPosY(), 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, (uint) GetPosX(), (uint) GetPosY(), 0, 0);
        }

        private new void MouseDoubleClick()
        {
            for (int i = 0; i < 2; i++)
            {
                mouse_event(MOUSEEVENTFEVENTF_LEFTDOWN, (uint) GetPosX(), (uint) GetPosY(), 0, 0);
                mouse_event(MOUSEEVENTF_LEFTUP, (uint) GetPosX(), (uint) GetPosY(), 0, 0);
            }
        }

        private void MouseRightClick()
        {
            mouse_event(MOUSEEVENTF_RIGHTDOWN, (uint) GetPosX(), (uint) GetPosY(), 0, 0);
            mouse_event(MOUSEEVENTF_RIGHTUP, (uint) GetPosX(), (uint) GetPosY(), 0, 0);
        }

        private void ControlV()
        {
            keybd_event(VK_LCONTROL, 0, KEYEVENTF_KEYDOWN, 0);
            keybd_event(VK_KEY_V, 0, KEYEVENTF_KEYDOWN, 0);
            keybd_event(VK_KEY_V, 0, KEYEVENTF_KEYUP, 0); 
            keybd_event(VK_LCONTROL, 0, KEYEVENTF_KEYUP, 0);
        }

        private void ShiftTab()
        {
            for (int i = 0; i < 2; i++)
            {
                keybd_event(VK_LSHIFT, 0, KEYEVENTF_KEYDOWN, 0);
                keybd_event(VK_TAB, 0, KEYEVENTF_KEYDOWN, 0);
                keybd_event(VK_TAB, 0, KEYEVENTF_KEYUP, 0);
                keybd_event(VK_LSHIFT, 0, KEYEVENTF_KEYUP, 0);
            }
        }

        private void Return()
        {
            keybd_event(VK_RETURN, 0, KEYEVENTF_KEYDOWN, 0);
            keybd_event(VK_RETURN, 0, KEYEVENTF_KEYUP, 0);
        }

        private void InsertText(int index)
        {
            BeginInvoke((MethodInvoker) delegate
            {
                SendKeys.Send(InsertTextComboBox.Items[index].ToString());
            });
        }

        private void InsertJobs()
        {
            BeginInvoke((MethodInvoker) delegate
            {
                SendKeys.Send(JobsComboBox.Items[0].ToString());
            });
        }


        private void Numbers(int n)
        {
            switch(n)
            {
                case 0: Zero(); break;
                case 1: One(); break;
            }
        }

        //Numbers
        private void Zero()
        {
            keybd_event(VK_KEY_0, 0, KEYEVENTF_KEYDOWN, 0);
            keybd_event(VK_KEY_0, 0, KEYEVENTF_KEYUP, 0);
        }
        private void One()
        {
            keybd_event(VK_KEY_1, 0, KEYEVENTF_KEYDOWN, 0);
            keybd_event(VK_KEY_1, 0, KEYEVENTF_KEYUP, 0);
        }
        private void Two()
        {
            keybd_event(VK_KEY_2, 0, KEYEVENTF_KEYDOWN, 0);
            keybd_event(VK_KEY_2, 0, KEYEVENTF_KEYUP, 0);
        }
        private void Three()
        {
            keybd_event(VK_KEY_3, 0, KEYEVENTF_KEYDOWN, 0);
            keybd_event(VK_KEY_3, 0, KEYEVENTF_KEYUP, 0);
        }
        private void Four()
        {
            keybd_event(VK_KEY_4, 0, KEYEVENTF_KEYDOWN, 0);
            keybd_event(VK_KEY_4, 0, KEYEVENTF_KEYUP, 0);
        }
        private void Five()
        {
            keybd_event(VK_KEY_5, 0, KEYEVENTF_KEYDOWN, 0);
            keybd_event(VK_KEY_5, 0, KEYEVENTF_KEYUP, 0);
        }
        private void Six()
        {
            keybd_event(VK_KEY_6, 0, KEYEVENTF_KEYDOWN, 0);
            keybd_event(VK_KEY_6, 0, KEYEVENTF_KEYUP, 0);
        }
        private void Seven()
        {
            keybd_event(VK_KEY_7, 0, KEYEVENTF_KEYDOWN, 0);
            keybd_event(VK_KEY_7, 0, KEYEVENTF_KEYUP, 0);
        }
    }
}
