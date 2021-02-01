using System.Collections.Generic;
using System.IO;
using System.Text.Json.Serialization;
using NotepadPlus.UI;

namespace NotepadPlus
{
    public class Configuration
    {
        [JsonPropertyName("applicationTheme")]
        public UITheme ApplicationTheme { get; set; }
        
        [JsonPropertyName("autoSavingInterval")]
        public int AutoSavingInterval { get; set; }
        
        [JsonPropertyName("openedTabs")]
        public List<Session> openedTabs { get; set; }
    }
}