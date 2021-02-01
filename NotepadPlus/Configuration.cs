using System.Collections.Generic;
using System.IO;
using System.Text.Json.Serialization;
using Newtonsoft.Json.Converters;
using NotepadPlus.UI;

namespace NotepadPlus
{
    public class Configuration
    {
        [JsonPropertyName("applicationTheme")]
        [JsonConverter(typeof(StringEnumConverter))]
        public UITheme ApplicationTheme { get; set; }
        
        [JsonPropertyName("autoSavingInterval")]
        public int AutoSavingInterval { get; set; }
        
        [JsonPropertyName("openedTabs")]
        public List<TabNote> OpenedTabs { get; set; }
    }
}