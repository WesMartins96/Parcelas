using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WFList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 1 Criar a lista de times
        private void btnCriarList1_Click(object sender, EventArgs e)
        {
            string[] times = { "São Paulo", "Flamengo", "Palmeiras", "Atletico-MG", "Fortaleza" };
            List<string> listaUm = new List<string>(times);
            foreach (string l in listaUm)
            {
                lstNumero1.Items.Add(l);
            }
        }

        private void lstNumero1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCriarList2_Click(object sender, EventArgs e)
        {
            string[] times = { "Corinthians", "Botafogo", "Ceara", "Cuiaba", "Fluminense" };
            List<string> listaDois = new List<string>(times);
            foreach (string l in listaDois)
            {
                lstNumero2.Items.Add(l);
            }
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {

            lstNumero2.Items.AddRange(lstNumero1.Items);
            lstNumero1.Items.Clear();
        }

        private void btnAaZ_Click(object sender, EventArgs e)
        {
            // organização em ordem alfabetica da ListBox
            lstNumero2.Sorted = true;



        }

        private void lstNumero2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            lstNumero2.Items.Clear();

        }

        private void btnZaA_Click(object sender, EventArgs e)
        {
            

        }
    }

}
