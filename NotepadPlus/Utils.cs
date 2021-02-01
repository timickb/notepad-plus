using System;
using System.IO;

namespace NotepadPlus
{
    /// <summary>
    /// Набор разных полезных штук.
    /// </summary>
    public class Utils
    {
        // TODO
        public static FileType DetermineFileType(StreamReader sr, string filePath)
        {
            return Path.GetExtension(filePath) == ".rtf" ? FileType.RichText : FileType.PlainText;
        }

        public static bool CheckFileAccessibility(string path)
        {
            if (!File.Exists(Path.GetFullPath(path))) return false;
                try
                {
                    StreamReader sr = new StreamReader(path);
                    sr.Close();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
        }
    }
}