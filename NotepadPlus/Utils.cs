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
            return Path.GetExtension(filePath) == "rtf" ? FileType.RichText : FileType.PlainText;
        }
    }
}