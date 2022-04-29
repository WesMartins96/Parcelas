using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAula41
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {


            // Protocolos
            //HTTP: Hyper text Transfer Protocol
            //HTTPS: Hyper text Transfer Protocol Security
            //pop3: usado para envio e recebimento de email
            //smtp: usado para envio e recebimento de email
            //FTP:
            //get:
            //request:


            // Digitar o CEP e carregar todo o endereço (usando dados de uma API)
            //CRUD > Matemática > Datas > Tratamento > Informações > Array > List
            try
            {
                DataSet ds = new DataSet();
                string xml = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml".Replace("@cep", txtCEP.Text);
                ds.ReadXml(xml);
                txtLogradouro.Text = ds.Tables[0].Rows[0]["logradouro"].ToString();
                txtBairro.Text = ds.Tables[0].Rows[0]["bairro"].ToString();
                txtCidade.Text = ds.Tables[0].Rows[0]["cidade"].ToString();
                txtUF.Text = ds.Tables[0].Rows[0]["uf"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR!");
            }

        }
    }
}
