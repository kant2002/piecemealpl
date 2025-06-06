﻿using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Win32;
using Windows.Win32.Foundation;
using Windows.Win32.UI.WindowsAndMessaging;
//using Foundation;
using static Windows.Win32.PInvoke;

unsafe internal class Program
{
    // Register the window class.
    const string CLASS_NAME = "Sample Window Class";
    private static void Main()
    {
        fixed (char* pClassName = CLASS_NAME)
        {
            WNDCLASSW wc = new WNDCLASSW();

            wc.lpfnWndProc = &WindowProc;
            wc.hInstance = default;
            wc.lpszClassName = new PCWSTR(pClassName);

            RegisterClass(wc);
        }

        // Create the window.

        HWND hwnd = CreateWindowEx(
            0,                              // Optional window styles.
            CLASS_NAME,                     // Window class
            "Hello, world!",    // Window text
            WINDOW_STYLE.WS_OVERLAPPEDWINDOW,            // Window style

            // Size and position
            CW_USEDEFAULT, CW_USEDEFAULT, CW_USEDEFAULT, CW_USEDEFAULT,

            HWND.Null,       // Parent window    
            default,       // Menu
            default,  // Instance handle
            null        // Additional application data
        );

        if (hwnd == HWND.Null)
        {
            return;
        }

        ShowWindow(hwnd, SHOW_WINDOW_CMD.SW_NORMAL);
        UpdateWindow(hwnd);

        // Run the message loop.
        while (GetMessage(out MSG msg, default, 0, 0))
        {
            TranslateMessage(msg);
            DispatchMessage(msg);
        }

        // See https://aka.ms/new-console-template for more information
        Console.WriteLine("Hello, World!");
    }

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)])]
    unsafe static LRESULT WindowProc(HWND hwnd, uint uMsg, WPARAM wParam, LPARAM lParam)
    {
        switch (uMsg)
        {
            case WM_DESTROY:
                PostQuitMessage(0);
                return new LRESULT(0);


            //case WM_PAINT:
            //{
            //    PAINTSTRUCT ps;
            //    HDC hdc = BeginPaint(hwnd, &ps);

            //    // All painting occurs here, between BeginPaint and EndPaint.
            //    FillRect(hdc, &ps.rcPaint, (HBRUSH)(COLOR_WINDOW + 1));
            //    EndPaint(hwnd, &ps);
            //}
            //return 0;
        }

        return DefWindowProc(hwnd, uMsg, wParam, lParam);
    }

}