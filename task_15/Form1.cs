using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using CoreWebView2NavigationCompletedEventArgs = global::Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs;
using WebView = global::Microsoft.Web.WebView2.WinForms.WebView2;

namespace WebView2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        WebView? Cari()
        {
            if (tabControl1.SelectedTab == null || tabControl1.SelectedTab.Controls.Count == 0)
                return null;

            WebView? w = tabControl1.SelectedTab.Controls[0] as WebView;
            if (w == null || w.CoreWebView2 == null)
                return null;

            return w;
        }

        void Ac(ListBox list)
        {
            if (list.SelectedItem == null)
                return;

            textBox1.Text = list.SelectedItem.ToString();
            button5.PerformClick();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await webView21.EnsureCoreWebView2Async(null);
            await webView22.EnsureCoreWebView2Async(null);
            webView21.NavigationCompleted += webView21_NavigationCompleted;
            webView22.NavigationCompleted += webView21_NavigationCompleted;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebView? w = Cari();
            if (w != null && w.CoreWebView2.CanGoBack)
                w.CoreWebView2.GoBack();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WebView? w = Cari();
            if (w != null && w.CoreWebView2.CanGoForward)
                w.CoreWebView2.GoForward();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WebView? w = Cari();
            if (w != null)
                w.CoreWebView2.Reload();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "https://www.example.com";
            button5.PerformClick();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WebView? w = Cari();
            if (w == null)
                return;

            string url = textBox1.Text.Trim();
            if (url == "")
                return;

            if (!url.StartsWith("http://") && !url.StartsWith("https://"))
                url = "https://" + url;

            textBox1.Text = url;
            w.CoreWebView2.Navigate(url);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            button5.PerformClick();
            e.SuppressKeyPress = true;
        }

        private async void button6_Click(object sender, EventArgs e)
        {
            TabPage tab = new TabPage("Tab " + (tabControl1.TabPages.Count + 1));
            WebView wv = new WebView();
            wv.Dock = DockStyle.Fill;
            wv.NavigationCompleted += webView21_NavigationCompleted;
            tab.Controls.Add(wv);
            tabControl1.TabPages.Add(tab);
            tabControl1.SelectedTab = tab;
            await wv.EnsureCoreWebView2Async(null);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text.Trim();
            if (s != "")
                listBox1.Items.Add(s);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ac(listBox1);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ac(listBox2);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            WebView? w = Cari();
            if (w != null && w.CoreWebView2.Source != "")
                textBox1.Text = w.CoreWebView2.Source;
        }

        private void webView21_NavigationCompleted(object? sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            if (sender is WebView w && w.CoreWebView2 != null)
                textBox1.Text = w.CoreWebView2.Source;
        }
    }
}