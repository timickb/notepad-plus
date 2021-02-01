using System.Windows.Forms;

namespace NotepadPlus
{
    public partial class SettingsFrame : Form
    {
        private Configuration _config;
        public SettingsFrame(Configuration config)
        {
            _config = config;
            
            InitializeComponent();
        }
        
    }
}