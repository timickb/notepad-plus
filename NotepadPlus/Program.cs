using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using NotepadPlus.UI;


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

        public static string UserAppDataPath => Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

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

            var config = ReadConfig();
            Console.WriteLine(config.ApplicationTheme);
            Console.WriteLine(config.AutoSavingInterval);
            Console.WriteLine(config.OpenedTabs.Count);
            Application.Run(new MainFrame(config));
        }

        /// <summary>
        /// Метод десериализует JSON конфигурацию
        /// из файла appsettings.json
        /// </summary>
        /// <returns>Объект конфигурации</returns>
        /// <exception cref="Exception">Исключение выбрасывается в случае, если
        /// содержимое файла не соответствует формату настроек.</exception>
        private static Configuration ReadConfig()
        {
            try
            {
                StreamReader sr = new StreamReader($"{UserAppDataPath}\\npp-settings.json");
                string jsonData = sr.ReadToEnd();
                sr.Close();
                return JsonConvert.DeserializeObject<Configuration>(jsonData);
            }
            catch (Exception)
            {
                return FixConfig();
            }
        }

        /// <summary>
        /// Метод создает дефолтную конфигурацию и
        /// записывает ее в файл. Использовать в случае,
        /// если файл конфигурации был поврежден.
        /// </summary>
        /// <returns>Объект конфигурации</returns>
        private static Configuration FixConfig()
        {
            Configuration newConfig = new Configuration()
            {
                ApplicationTheme = UITheme.Default,
                AutoSavingInterval = 30000,
                OpenedTabs = new List<TabNote>()
            };
            try
            {
                StreamWriter sw = new StreamWriter($"{UserAppDataPath}\\npp-settings.json");
                sw.Write(JsonConvert.SerializeObject(newConfig));
                sw.Close();
            }
            catch (Exception)
            {
                // жесть просто, даже не знаю, что в такой ситуации делать :(
            }

            return newConfig;
        }
    }
}