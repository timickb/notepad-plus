using System.Text.Json.Serialization;

namespace NotepadPlus
{
    /// <summary>
    /// Честно говоря, это костыль: дубликат Session для
    /// сериализации в JSON.
    /// Можно было сериализовать напрямую объекты
    /// Session, но там почему-то вылетал Stack Overflow.
    /// Времени разбираться за 2 часа до дедлайна не было :)
    /// </summary>
    public class TabNote
    {
        [JsonPropertyName("filePath")]
        public string FilePath { get; set; }
        
        [JsonPropertyName("fileType")]
        public FileType FileType { get; set; }
    }
}