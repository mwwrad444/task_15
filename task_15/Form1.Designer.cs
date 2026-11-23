using System.Drawing;
using System.Windows.Forms;
using WebView = Microsoft.Web.WebView2.WinForms.WebView2;

namespace WebView2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            button5 = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            webView21 = new WebView();
            tabPage2 = new TabPage();
            webView22 = new WebView();
            button6 = new Button();
            panel1 = new Panel();
            label1 = new Label();
            listBox1 = new ListBox();
            label2 = new Label();
            listBox2 = new ListBox();
            button7 = new Button();

            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();

            Font ikon = new Font("Segoe UI Symbol", 10F);

            button1.Font = ikon;
            button1.SetBounds(10, 10, 34, 28);
            button1.Text = "←";
            button1.Click += button1_Click;

            button2.Font = ikon;
            button2.SetBounds(48, 10, 34, 28);
            button2.Text = "→";
            button2.Click += button2_Click;

            button3.Font = ikon;
            button3.SetBounds(86, 10, 34, 28);
            button3.Text = "↻";
            button3.Click += button3_Click;

            button4.Font = ikon;
            button4.SetBounds(124, 10, 34, 28);
            button4.Text = "⌂";
            button4.Click += button4_Click;

            textBox1.SetBounds(166, 12, 500, 23);
            textBox1.Text = "https://www.example.com";
            textBox1.KeyDown += textBox1_KeyDown;

            button5.BackColor = Color.FromArgb(170, 230, 170);
            button5.UseVisualStyleBackColor = false;
            button5.SetBounds(674, 10, 64, 28);
            button5.Text = "Get";
            button5.Click += button5_Click;

            webView21.Dock = DockStyle.Fill;
            tabPage1.Text = "Tab 1";
            tabPage1.Controls.Add(webView21);

            webView22.Dock = DockStyle.Fill;
            tabPage2.Text = "Tab 2";
            tabPage2.Controls.Add(webView22);

            tabControl1.SetBounds(10, 46, 730, 582);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;

            button6.SetBounds(138, 48, 26, 22);
            button6.Text = "+";
            button6.Click += button6_Click;

            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(10, 10);
            label1.Text = "Seçilmişlər (ListBox)";

            listBox1.SetBounds(10, 32, 226, 154);
            listBox1.Items.AddRange(new object[] { "google.com", "wikipedia.org", "youtube.com", "azertag.az" });
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;

            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(10, 200);
            label2.Text = "Tarixçə (ListBox)";

            listBox2.SetBounds(10, 222, 226, 154);
            listBox2.Items.AddRange(new object[] { "example.com", "bing.com", "github.com" });
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;

            button7.BackColor = Color.FromArgb(255, 236, 140);
            button7.UseVisualStyleBackColor = false;
            button7.SetBounds(10, 390, 226, 34);
            button7.Text = "Seçilmişlərə əlavə et";
            button7.Click += button7_Click;

            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.SetBounds(748, 10, 250, 618);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(listBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(listBox2);
            panel1.Controls.Add(button7);

            ClientSize = new Size(1008, 640);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1 - Mini Brauzer (WinForms + WebView2)";
            Controls.Add(button6);
            Controls.Add(panel1);
            Controls.Add(tabControl1);
            Controls.Add(button5);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Load += Form1_Load;

            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        private Button button1, button2, button3, button4, button5, button6, button7;
        private TextBox textBox1;
        private TabControl tabControl1;
        private TabPage tabPage1, tabPage2;
        private WebView webView21, webView22;
        private Panel panel1;
        private Label label1, label2;
        private ListBox listBox1, listBox2;
    }
}