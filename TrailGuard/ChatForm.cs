using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrailGuard
{
    public partial class ChatForm : Form
    {
        public ChatForm()
        {
            InitializeComponent();
        }

        private async void ChatForm_Load(object sender, EventArgs e)
        {
            try
            {
                await webView21.EnsureCoreWebView2Async(null);
                webView21.Source = new Uri("https://www.chatbase.co/chatbot-iframe/uNGy_sUMYBrElQBbQ6IjO");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not load the chat assistant. Please check that WebView2 Runtime is installed.\n\n" + ex.Message,
                    "Chat Unavailable",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}
