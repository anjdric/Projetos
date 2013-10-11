using System;
using System.Globalization;
using System.Net;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;

using System.Windows.Forms;

namespace BrowserPc
{
    public partial class Form1 : Form
    {
        private  string _urlAnterior = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Layout(object sender, LayoutEventArgs e)
        {
            Size sz = default(Size);
            Point p = default(Point);

            // redimensiona o groupbox para a área do formulário
            groupBox1.Width = ClientSize.Width;

            // redimensiona e reposiciona o controle TabControl no formulário
            tabControl1.Width = ClientSize.Width;
            tabControl1.Height = ClientSize.Height - groupBox1.Size.Height;

            p.X = 0;
            p.Y = groupBox1.Height;
            tabControl1.Location = p;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            PrevPage.Image = Properties.Resources.esquerda_verde;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            PrevPage.Image = Properties.Resources.esquerda_azul;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            NextPage.Image = Properties.Resources.direita_verde;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            NextPage.Image = Properties.Resources.direita_azul;
        }

        private void tabControl1_Layout(object sender, LayoutEventArgs e)
        {
            int h = tabControl1.TabPages[tabControl1.SelectedIndex].Height;
            int w = tabControl1.TabPages[tabControl1.SelectedIndex].Width;

            var tst = 50 / 100;

            TextBoxURL.Height = h;
            TextBoxURL.Width = w - 300;
            webBrowser1.Height = h;
            webBrowser1.Width = w;
            //txtURLVisitadas.Height = h;
            //txtURLVisitadas.Width = w;
        }


        // O código da função carregaHTML()  que carrega o fonte do código HTML na caixa de texto da tab Código Fonte , é o seguinte :

        // Preenche o texto HTML da URL definida na caixa de texto da tab
        private void CarregaHtml(string url)
        {

            // Não precisa recarregar o texto se for a mesma URL
            try
            {
                // inicia o leitor da stream para a pagina atual
                var myHttpWebRequest = WebRequest.Create(url);
                var myHttpWebResponse = myHttpWebRequest.GetResponse();

                Stream recvStream = myHttpWebResponse.GetResponseStream();

                // le o stream no formato "utf-8"
                Encoding encode = System.Text.Encoding.GetEncoding("utf-8");
                var readStream = new StreamReader(recvStream, encode);
                string sPagina = null;

                while ((readStream.Peek() > -1))
                {
                    sPagina += readStream.ReadLine();
                }

                TextBoxHTML.Text = sPagina;
                //static_carregaHTML_URLAnterior = URL;
            }
            catch (Exception ex)
            {
                //Interaction.Beep();
            }
        }

        // Carrega a URL definida no contole WebBrowser
        private void CarregaBrowser(string url)
        {

            Object obj = System.Reflection.Missing.Value;
            try
            {
                webBrowser1.Navigate(url);

               

                while (webBrowser1.ReadyState != WebBrowserReadyState.Complete)
                {
                    System.Threading.Thread.Sleep(5);
                    Application.DoEvents();
                }

                var x = webBrowser1.DocumentText.IndexOf("Você não está conectado à Internet.", StringComparison.Ordinal);

                if (x > 0)
                {
                    var urls = "www.google.com.br/search?q=" + _urlAnterior;
                    webBrowser1.Navigate(urls);
                    TextBoxURL.Text = urls;
                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Mensagem do Browser", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void NextPage_Click(object sender, EventArgs e)
        {
            try
            {
                webBrowser1.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem do Browser", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void PrevPage_Click(object sender, EventArgs e)
        {
            try
            {
                webBrowser1.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensagem do Browser", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void TextBoxURL_KeyPress(object sender, KeyPressEventArgs e)
        {
           //if (e.KeyChar == )
            //{}
            //Cursor.Current = Cursors.WaitCursor;

            //try
            //{
            //    if (TextBoxURL.Text.Trim().ToLower().IndexOf("anjdric", StringComparison.Ordinal) != 0)
            //    {
            //        HomeDefault();
            //        TextBoxURL.Text = "www.google.com.br/Anjdric";
            //    }
            //    else
            //    {
            //        CarregaBrowser(TextBoxURL.Text.Trim());
            //    }


            //    // Inclui http:// na string se for preciso
            //    if (String.CompareOrdinal(TextBoxURL.Text.Substring(0, 7), "http://") != 0)
            //    {
            //        TextBoxURL.Text = @"http://" + TextBoxURL.Text.ToString(CultureInfo.InvariantCulture);
            //    }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Mensagem do Browser", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}

            //Cursor.Current = Cursors.Default;
            ////}
        }

        private void HomePage_Click(object sender, EventArgs e)
        {
            HomeDefault();
        }


        private void HomeDefault()
        {
            CarregaBrowser("funnylogo.info/engines/Google/Red/Anjdric.aspx");
        }

        private void TextBoxURL_KeyDown(object sender, KeyEventArgs e)
        {
           if (e.KeyValue == 13 )
            {
                Cursor.Current = Cursors.WaitCursor;
                _urlAnterior = TextBoxURL.Text.Trim();
                try
                {
                    if (TextBoxURL.Text.Trim().ToLower().IndexOf("anjdric", StringComparison.Ordinal) >= 0)
                    {
                        HomeDefault();
                        TextBoxURL.Text = "www.google.com.br/Anjdric";
                    }
                    else
                    {
                        CarregaBrowser(TextBoxURL.Text.Trim());
                    }


                    // Inclui http:// na string se for preciso
                    if (String.CompareOrdinal(TextBoxURL.Text.Substring(0, 7), "http://") != 0)
                    {
                        TextBoxURL.Text = @"http://" + TextBoxURL.Text.ToString(CultureInfo.InvariantCulture);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Mensagem do Browser", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                Cursor.Current = Cursors.Default;
            }
        }






    }
}
