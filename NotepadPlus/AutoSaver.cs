using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Timer = System.Threading.Timer;

namespace NotepadPlus
{
    /// <summary>
    /// Класс реализует автоматическое сохранение
    /// открытых файлов с определенным интервалом.
    /// Сохраняются только те файлы, которые имеют
    /// путь в файловой системе (т.е. новые файлы
    /// автосохранение не затрагивает).
    /// </summary>
    public class AutoSaver
    {
        private readonly TabControl _control;
        private readonly int _interval;

        public AutoSaver(TabControl tabControl, int interval)
        {
            _control = tabControl;
            _interval = interval;
        }

        public void Start()
        {
            new Timer((obj) =>
                {
                    foreach (Session s in _control.Controls)
                    {
                        if (s.HasPath) s.WriteChangesToFile();
                    }
                },
                null, 0, _interval);
        }
    }
}