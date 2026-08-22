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

        // Loads the Chatbase AI assistant when the form opens
        private async void ChatForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Makes sure WebView2 is ready before loading the website
                await webView21.EnsureCoreWebView2Async(null);

                // Checks if the Chatbase page finished loading successfully, incase no internet
                webView21.CoreWebView2.NavigationCompleted += WebView21_NavigationCompleted;

                // Loads the TrailGuard AI chatbot inside the WebView control using nuget
                webView21.Source = new Uri("https://www.chatbase.co/chatbot-iframe/uNGy_sUMYBrElQBbQ6IjO");
            }
            catch (Exception ex)
            {
                // Shows an error message if the chatbot could not be loaded
                MessageBox.Show(
                    "Could not load the chat assistant. \n\n" + ex.Message,
                    "Chat Unavailable",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        // Check whether the chatbot page loaded correctly
        private void WebView21_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
        {
            if (!e.IsSuccess)
            {
                // Tells the ranger if the webpage could not be loaded
                MessageBox.Show(
                    "Could not load the chat assistant. Please check your internet connection.",
                    "Chat Unavailable",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}