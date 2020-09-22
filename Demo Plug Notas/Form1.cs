
using System.Windows.Forms;
using RestSharp;
using System;



using System.IO;


using Newtonsoft.Json;
using System.Diagnostics;

namespace Demo_Plug_Notas
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
           
           
            }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("SendBox");
            comboBox1.Items.Add("Produção");

           



            }

    


        private async void button2_Click(object sender, EventArgs e)
        {
            String token = textToken.Text;

            if (comboBox1.SelectedIndex.Equals(-1))
            {
                label1.Text = "Deve ser selecionado um Ambiente";
                label1.ForeColor = System.Drawing.Color.Red;


            }
            else
            {
                label1.Text = "Ambient";
                label1.ForeColor = System.Drawing.Color.Black;
            }

            if (comboBox1.Text == "SendBox")
            {

                var client = new RestClient("https://api.sandbox.plugnotas.com.br/");
                client.Timeout = -1;
                var request = new RestRequest("nfe/"+idNota.Text+"/resumo", Method.GET);
                request.AddHeader("x-api-key", "2da392a6-79d2-4304-a8b7-959572c7e44d");
                request.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };
                IRestResponse response = client.Execute(request);
                var requestStatus = response.StatusCode.ToString();


                if (response.StatusCode.ToString() == "OK")
                {
                    statusReq.Text = "200 Ok";
                    statusReq.ForeColor = System.Drawing.Color.Green;
                    responseJsonNfe.Text = response.Content;
                }


                if (response.StatusCode.ToString() == "Bad Request")
                {
                    MessageBox.Show(response.Content);
                    statusReq.Text = "400 Bad Request";
                    statusReq.ForeColor = System.Drawing.Color.Red;
                }

                if (response.StatusCode.ToString() == "Accepted")
                {
                    MessageBox.Show("Message :" + response.Content);
                    statusReq.Text = "202 Accepted";
                    statusReq.ForeColor = System.Drawing.Color.Green;
                }

                if (response.StatusCode.ToString() == "Unauthorized")
                {
                    MessageBox.Show("Message:" + response.Content);
                    statusReq.Text = "401 Unauthorized";
                    statusReq.ForeColor = System.Drawing.Color.Orange;
                }
                if (response.StatusCode.ToString() == "NotFound")
                {
                    MessageBox.Show("Message:" + response.Content);
                    statusReq.Text = "404 NotFound";
                    statusReq.ForeColor = System.Drawing.Color.Orange;
                }




            }
        

            if (comboBox1.Text == "Produção")
            {
                var client = new RestClient("https://api.plugnotas.com.br/");
                client.Timeout = -1;
                var request = new RestRequest("nfe/" + idNota.Text + "/resumo", Method.GET);
                request.AddHeader("x-api-key", textToken.Text);
                request.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };
                IRestResponse response = client.Execute(request);
                var requestStatus = response.StatusCode.ToString();

                if (response.StatusCode.ToString() == "OK")
                {
                    statusReq.Text = "200 Ok";
                    statusReq.ForeColor = System.Drawing.Color.Green;
                    responseJsonNfe.Text = response.Content;
                }


                if (response.StatusCode.ToString() == "Bad Request")
                {
                    MessageBox.Show(response.Content);
                    statusReq.Text = "400 Bad Request";
                    statusReq.ForeColor = System.Drawing.Color.Red;
                }

                if (response.StatusCode.ToString() == "Accepted")
                {
                    MessageBox.Show("Message :" + response.Content);
                    statusReq.Text = "202 Accepted";
                    statusReq.ForeColor = System.Drawing.Color.Green;
                }

                if (response.StatusCode.ToString() == "Unauthorized")
                {
                    MessageBox.Show("Message:" + response.Content);
                    statusReq.Text = "401 Unauthorized";
                    statusReq.ForeColor = System.Drawing.Color.Orange;
                }
                if (response.StatusCode.ToString() == "NotFound")
                {
                    MessageBox.Show("Message:" + response.Content);
                    statusReq.Text = "404 NotFound";
                    statusReq.ForeColor = System.Drawing.Color.Orange;
                }

            }


        }

      

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {






        }

     

  

        private void printNfe_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex.Equals(-1))
            {
                label1.Text = "Deve ser selecionado um Ambiente";
                label1.ForeColor = System.Drawing.Color.Red;


            }
            else
            {
                label1.Text = "Ambient";
                label1.ForeColor = System.Drawing.Color.Black;
            }

            if (idNota.Text == string.Empty)
            {
                MessageBox.Show("Deve ser Informado o Id da Nota");
            }
            if (comboBox1.Text == "SendBox")
                {
                    var client = new RestClient("https://api.sandbox.plugnotas.com.br/");
                client.Timeout = -1;
                var request = new RestRequest("nfe/" + idNota.Text + "/pdf", Method.GET);
                request.AddHeader("x-api-key", "2da392a6-79d2-4304-a8b7-959572c7e44d");
                request.OnBeforeDeserialization = resp => { resp.ContentType = "application/pdf"; };

                IRestResponse retorno = client.Execute(request);

                if (retorno.StatusCode.ToString() == "Bad Request")
                {
                    MessageBox.Show(retorno.Content);
                    statusReq.Text = "400 Bad Request";
                    statusReq.ForeColor = System.Drawing.Color.Red;
                }

                if (retorno.StatusCode.ToString() == "Accepted")
                {
                    MessageBox.Show("Message :" + retorno.Content);
                    statusReq.Text = "202 Accepted";
                    statusReq.ForeColor = System.Drawing.Color.Green;
                }

                if (retorno.StatusCode.ToString() == "Unauthorized")
                {
                    MessageBox.Show("Message:" + retorno.Content);
                    statusReq.Text = "401 Unauthorized";
                    statusReq.ForeColor = System.Drawing.Color.Orange;
                }
                if (retorno.StatusCode.ToString() == "NotFound")
                {
                    MessageBox.Show("Message:" + retorno.Content);
                    statusReq.Text = "404 NotFound";
                    statusReq.ForeColor = System.Drawing.Color.Orange;
                }

                if (retorno.StatusCode.ToString() == "OK")
                {
                    statusReq.Text = "200 Ok";
                    statusReq.ForeColor = System.Drawing.Color.Green;
                    byte[] response = client.DownloadData(request);

                    File.WriteAllBytes(@"C:/folder/" + idNota.Text + ".pdf", response);

                    using (var form3 = new Form3(@"C:/folder/" + idNota.Text + ".pdf"))
                    {
                        form3.ShowDialog();
                    }
                }

            }

            if (comboBox1.Text == "Produção")
            {
                var client = new RestClient("https://api.plugnotas.com.br/");
                client.Timeout = -1;
                var request = new RestRequest("nfe/" + idNota.Text + "/pdf", Method.GET);
                request.AddHeader("x-api-key", textToken.Text);
                request.OnBeforeDeserialization = resp => { resp.ContentType = "application/pdf"; };

                IRestResponse retorno = client.Execute(request);

                if (retorno.StatusCode.ToString() == "Accepted")
                {
                    statusReq.Text = "202 Accepted";
                    statusReq.ForeColor = System.Drawing.Color.Green;
                    MessageBox.Show("Message: Documento em processamento, aguarde alguns minutos e tente novamente.");
                }
         
                if (retorno.StatusCode.ToString() == "NotFound")
                {
                    statusReq.Text = "404 Not Found";
                    statusReq.ForeColor = System.Drawing.Color.Red;
                    MessageBox.Show("Message:Não localizamos qualquer NFe com os parâmetros informados");
                }
                if (retorno.StatusCode.ToString() == "OK")
                {
                    statusReq.Text = "200 Ok";
                    statusReq.ForeColor = System.Drawing.Color.Green;
                    byte[] response = client.DownloadData(request);

                    File.WriteAllBytes(@"C:/folder/" + idNota.Text + ".pdf", response);

                    using (var form3 = new Form3(@"C:/folder/" + idNota.Text + ".pdf"))
                    {
                        form3.ShowDialog();
                    }
                }

                if(retorno.StatusCode.ToString() == "Bad Request")
                {
                    MessageBox.Show(retorno.Content);
                    statusReq.Text = "400 Bad Request";
                    statusReq.ForeColor = System.Drawing.Color.Red;
                }

                if (retorno.StatusCode.ToString() == "Accepted")
                {
                    MessageBox.Show("Message :" + retorno.Content);
                    statusReq.Text = "202 Accepted";
                    statusReq.ForeColor = System.Drawing.Color.Green;
                }

                if (retorno.StatusCode.ToString() == "Unauthorized")
                {
                    MessageBox.Show("Message:" + retorno.Content);
                    statusReq.Text = "401 Unauthorized";
                    statusReq.ForeColor = System.Drawing.Color.Orange;
                }
                if (retorno.StatusCode.ToString() == "NotFound")
                {
                    MessageBox.Show("Message:"+retorno.Content);
                    statusReq.Text = "404 NotFound";
                    statusReq.ForeColor = System.Drawing.Color.Orange;
                }
           



            }
        }

        private void parcerJson_Click(object sender, EventArgs e)
        {


            if (comboBox1.Text == "SendBox")
            {

                var client = new RestClient("https://api.sandbox.plugnotas.com.br/");
                client.Timeout = -1;
                var request = new RestRequest("nfe/" + idNota.Text + "/resumo", Method.GET);
                request.AddHeader("x-api-key", "2da392a6-79d2-4304-a8b7-959572c7e44d");
                request.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };
                IRestResponse response = client.Execute(request);
                Console.WriteLine(response.Content);

                responseJsonNfe.Text = response.Content.ToString();

                string json = response.Content;

                dynamic dynJson = JsonConvert.DeserializeObject(json);
                foreach (var item in dynJson)
                {
                    if (response.StatusCode.ToString() == "Accepted")
                    {
                        MessageBox.Show("Message :" + item.message);
                        statusReq.Text = "202 Accepted";
                        statusReq.ForeColor = System.Drawing.Color.Green;
                    }

                    if (response.StatusCode.ToString() == "Unauthorized")
                    {
                        MessageBox.Show("Message: Token inválido");
                        statusReq.Text = "401 Unauthorized";
                        statusReq.ForeColor = System.Drawing.Color.Orange;
                    }
                    if (response.StatusCode.ToString() == "NotFound")
                    {
                        MessageBox.Show("Message:Não localizamos qualquer NFe com os parâmetros informados");
                        statusReq.Text = "404 NotFound";
                        statusReq.ForeColor = System.Drawing.Color.Orange;
                    }
                    if (response.StatusCode.ToString() == "OK")
                    {
                        statusReq.Text = "200 Ok";
                        statusReq.ForeColor = System.Drawing.Color.Green;
                        jsonParce.Text = "id: "+item.id +"\n Emissão: "+item.emissao+"\n Status: "+item.status+"\n Emitente: "+item.emitente+ "\n Destinatario: " + item.destinatario + "\n Valor: " + item.valor + "\n Serie: " + item.serie + "\n Data Autorizacao: " + item.dataAutorizacao + "\n PDF: " + item.pdf + "\n XML: " + item.xml; 
                    }

                }
            }

            if (comboBox1.Text == "Produção")
            {

                var client = new RestClient("https://api.plugnotas.com.br/");
                client.Timeout = -1;
                var request = new RestRequest("nfe/" + idNota.Text + "/resumo", Method.GET);
                request.AddHeader("x-api-key", textToken.Text);
                request.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };
                IRestResponse response = client.Execute(request);
                Console.WriteLine(response.Content);

                responseJsonNfe.Text = response.Content.ToString();

                string json = response.Content;

                dynamic dynJson = JsonConvert.DeserializeObject(json);
                foreach (var item in dynJson)
                {
                    if (response.StatusCode.ToString() == "Accepted")
                    {
                        MessageBox.Show("Message :" + item.message);
                        statusReq.Text = "202 Accepted";
                        statusReq.ForeColor = System.Drawing.Color.Green;
                    }

                    if (response.StatusCode.ToString() == "Unauthorized")
                    {
                        MessageBox.Show("Message: Token inválido");
                        statusReq.Text = "401 Unauthorized";
                        statusReq.ForeColor = System.Drawing.Color.Orange;
                    }
                    if (response.StatusCode.ToString() == "NotFound")
                    {
                        MessageBox.Show("Message:Não localizamos qualquer NFe com os parâmetros informados");
                        statusReq.Text = "404 NotFound";
                        statusReq.ForeColor = System.Drawing.Color.Orange;
                    }
                    if (response.StatusCode.ToString() == "OK")
                    {
                        statusReq.Text = "200 Ok";
                        statusReq.ForeColor = System.Drawing.Color.Green;
                        jsonParce.Text = "id: " + item.id + "\n Emissão: " + item.emissao + "\n Status: " + item.status + "\n Emitente: " + item.emitente + "\n Destinatario: " + item.destinatario + "\n Valor: " + item.valor + "\n Serie: " + item.serie + "\n Data Autorizacao: " + item.dataAutorizacao + "\n PDF: " + item.pdf + "\n XML: " + item.xml;
                    }

                }
            }

        }

        private void labelToken_Click(object sender, EventArgs e)
        {

        }

        private void uploadCert_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.AddExtension = true;
            openFileDialog.Multiselect = false;


            

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                caminhoCert.Text = openFileDialog.FileName;
            }
        }

        private void sendCertUpload_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex.Equals(-1))
            {
                label1.Text = "Deve ser selecionado um Ambiente";
                label1.ForeColor = System.Drawing.Color.Red;


            }
            else
            {
                label1.Text = "Ambient";
                label1.ForeColor = System.Drawing.Color.Black;
            }

            if (comboBox1.Text == "SendBox")
            {
                if (caminhoCert.Text == string.Empty)
                {
                    MessageBox.Show("Deve ser selecionado um certificado");
                }
                else
                {
                    var client = new RestClient("https://api.sandbox.plugnotas.com.br/certificado");
                    client.Timeout = -1;
                    var request = new RestRequest(Method.POST);
                    request.AddHeader("x-api-key", "2da392a6-79d2-4304-a8b7-959572c7e44d");
                    request.AddFile("arquivo", caminhoCert.Text);
                    request.AddParameter("senha", senhaCert.PasswordChar);
                    request.AddParameter("email", emialCert.Text);
                    IRestResponse response = client.Execute(request);
                    MessageBox.Show(response.Content);

                }
           
            }
            if (comboBox1.Text == "Produção")
            {
                if (caminhoCert.Text == string.Empty)
                {
                    MessageBox.Show("Deve ser selecionado um certificado");
                }
                else
                {

                    var client = new RestClient("https://api.plugnotas.com.br/certificado");
                    client.Timeout = -1;
                    var request = new RestRequest(Method.POST);
                    request.AddHeader("x-api-key", textToken.Text);
                    request.AddFile("arquivo", caminhoCert.Text);
                    request.AddParameter("senha", senhaCert.PasswordChar);
                    request.AddParameter("email", emialCert.Text);
                    IRestResponse response = client.Execute(request);
                    MessageBox.Show(response.Content);
                }
            }
        }

        private void jsonNotaEnvia_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex.Equals(-1))
            {
                label1.Text = "Deve ser selecionado um Ambiente";
                label1.ForeColor = System.Drawing.Color.Red;


            }
            else
            {
                label1.Text = "Ambient";
                label1.ForeColor = System.Drawing.Color.Black;
            }

            var client = new RestClient("https://api.plugnotas.com.br/nfe");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("accept", "application/json");
            request.AddHeader("x-api-key", textToken.Text);
            request.AddHeader("Content-Type", "application/json");
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(jsonNota.Text);
            IRestResponse response = client.Execute(request);
            MessageBox.Show(response.Content);
         

            if (response.StatusCode.ToString() == "Accepted")
            {
                MessageBox.Show("Message :" + response.Content);
                statusReq.Text = "202 Accepted";
                statusReq.ForeColor = System.Drawing.Color.Green;
            }

            if (response.StatusCode.ToString() == "Unauthorized")
            {
                MessageBox.Show("Message: "+ response.Content);
                statusReq.Text = "401 Unauthorized";
                statusReq.ForeColor = System.Drawing.Color.Orange;
            }
            if (response.StatusCode.ToString() == "NotFound")
            {
                MessageBox.Show("Message: "+ response.Content);
                statusReq.Text = "404 NotFound";
                statusReq.ForeColor = System.Drawing.Color.Orange;
            }
            if (response.StatusCode.ToString() == "OK")
            {
                statusReq.Text = "200 Ok";
                statusReq.ForeColor = System.Drawing.Color.Green;
                responseJsonNfe.Text = response.Content;

            }
        }
    }
}
