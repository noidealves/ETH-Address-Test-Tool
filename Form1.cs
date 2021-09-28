using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using System.IO;
using System.Media;

namespace ETH_Address_Test_Tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string path = "";

        private static readonly HttpClient client = new HttpClient();

        public static SoundPlayer success = new SoundPlayer(Properties.Resources.coin2);
        public static SoundPlayer error = new SoundPlayer(Properties.Resources.error);

        private void bt_iniciar_Click(object send, EventArgs e)
        {
            if (path != "")
            {
                var files = Directory.GetFiles(path);

                if (files.Length > 0)
                {
                    bt_iniciar.Text = "Testando...";

                    ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;
                    client.Timeout = TimeSpan.FromSeconds(5);

                    for (int i = 0; i < files.Length; i++)
                    {
                        if (files[i].Contains(".txt"))
                        {
                            lb_arquivo.Text = "Arquivo: " + files[i].Substring(files[i].LastIndexOf('\\') + 1, files[i].Length - files[i].LastIndexOf('\\') - 1);

                            var lines = File.ReadAllLines(files[i]);

                            for (int j = 0; j < lines.Length; j++)
                            {
                                if (!lines[j].Contains("path"))
                                {
                                    lb_linha.Text = "Linha " + (j + 1).ToString() + " de " + lines.Length.ToString();

                                    try
                                    {
                                        string address = lines[j].Replace(',', ' ').Trim();
                                        var response = client.GetAsync("https://ethscan.app/address/" + address).Result;
                                        var responseString = response.Content.ReadAsStringAsync().Result;

                                        if (response.IsSuccessStatusCode)
                                        {
                                            lb_address.Text = address;
                                            string balance = responseString.Substring(responseString.IndexOf("pricing-card-title") + 20, 9);
                                            lb_balance.Text = balance;

                                            if (balance != "0.0000000")
                                            {
                                                File.AppendAllText(path + @"\RESULT.txt", "\r\nAddress: " + address + "   Balance: " + balance + "   Datetime: " + DateTime.Now.ToString());
                                                success.Play();
                                            }
                                        }
                                        else
                                        {
                                            lb_address.Text = address;
                                            lb_balance.Text = "Error!";
                                        }

                                        Update();
                                    }
                                    catch
                                    {

                                    }
                                }
                            }
                        }
                    }

                    bt_iniciar.Text = "Finalizado!";

                    if (File.Exists(path + @"\RESULT.txt"))
                    {
                        success.Play();
                    }
                    else
                    {
                        error.Play();
                    }
                }
                else
                {
                    MessageBox.Show("Pasta Vazia!");
                }
            }
            else
            {
                MessageBox.Show("Selecione a pasta!");
            }
        }

        private void bt_pasta_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                path = folderBrowserDialog1.SelectedPath;
                bt_pasta.Text = path;
                bt_pasta.BackColor = Color.LimeGreen;
            }
        }
    }
}
