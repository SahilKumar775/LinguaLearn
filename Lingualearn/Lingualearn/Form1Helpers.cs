using System;
using System.Runtime.InteropServices;

internal static class Form1Helpers
{
    [DllImport("user32.DLL", EntryPoint = "SendMessage")]
    private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
}