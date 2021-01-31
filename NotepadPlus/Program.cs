using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;


/* ИНФА ДЛЯ ПРОВЕРЯЮЩЕГО
 * Привет, друг! Хочу сразу прояснить несколько моментов,
 * которые, возможно, могут быть неочевидны:
 * 1. Горячие клавиши для создания документа в новом окне существуют -
 * это те же самые клавиши, что используются для создания нового окна,
 * ведь в новом окне по умолчанию создается один новый документ!
 * 2. Штуки из Microsoft.Extensions использовать разрешено.
 */

namespace NotepadPlus
{
    static class Program
    {

        public const int MaxOpenedFramesAmount = 5;

        public const int AutoSaveInterval = 30000;

        public static IConfiguration Configuration { get; set; }
        
        /// <summary>
        /// В этом списке хранятся все открытые в одно время
        /// окна редактора.
        /// </summary>
        public static List<MainFrame> OpenedFrames { get; set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            OpenedFrames = new List<MainFrame>();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainFrame());
        }
    }
}
