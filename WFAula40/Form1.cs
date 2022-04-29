﻿using System;
using System.Collections;
using System.Windows.Forms;

namespace WFAula40
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbArray_SelectedIndexChanged(object sender, EventArgs e)
        {
            // para mostrar na label as informações do array
            int escolha = cbArray.SelectedIndex;
            Random r = new Random();
            r.Next();

            switch (escolha)
            {

                case 0: lbResult.Text = "Dinheiro"; break;
                case 1: lbResult.Text = "Cartão"; break;
                case 2: lbResult.Text = "Boleto"; break;
                case 3: lbResult.Text = "Pix"; break;
                default:
                    lbResult.Text = "0";
                    break;
            }

            cbParcelas.Items.Clear();
            if (escolha == 1)
            {
                for (int i = 0; i <= 12; i++)
                {
                    cbParcelas.Items.Add(i);
                }
            }
            else
            {
                cbParcelas.Items.Add(1);
            }
            if (escolha == 3)
            {
                int codPix = new Random().Next();
                lbCodigoPix.Text = $"{codPix}";
            }
            else
            {
                lbCodigoPix.Text = null;
            }

            //if (cbArray.Text == "Dinheiro")
            //{
            //    lbResult.Text = "Pago em Dinheiro";
            //    lbCodigoPix.ResetText();
            //}
            //else if (cbArray.Text == "Cartão")
            //{
            //    lbResult.Text = "Pago em 2x";
            //    lbCodigoPix.ResetText();
            //}
            //else if (cbArray.Text == "Boleto")
            //{
            //    lbResult.Text = "Use o código para realizar o pagamento";
            //    lbCodigoPix.Text = $"{r.Next()}";
            //}
            //else if (cbArray.Text == "Pix")
            //{
            //    lbResult.Text = "Chave pix aleátoria gerado";
            //    lbCodigoPix.Text = $"{r.Next()}";

            //}
            //else
            //{
            //    lbCodigoPix.Text = " ";
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // para criar carregamentos - Loadings

            // Criar um arrayList  (using System.Windows.Forms;)
            ArrayList formaPagamento = new ArrayList();

            formaPagamento.Add(new FormaDePagamento(0, "Dinheiro"));
            formaPagamento.Add(new FormaDePagamento(1, "Cartão"));
            formaPagamento.Add(new FormaDePagamento(2, "Boleto"));
            formaPagamento.Add(new FormaDePagamento(3, "Pix"));

            // vincular ao comboBox1 = cbArray
            cbArray.DataSource = formaPagamento;
            cbArray.DisplayMember = "Descrição";
            cbArray.ValueMember = "descricao";





        }
        // Construtor
        public class FormaDePagamento
        {
            public int ID { get; set; }
            public string Descricao { get; set; }

            public FormaDePagamento(int ID, string descricao)
            {
                this.ID = ID;
                this.Descricao = descricao;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }

        private void cbParcelas_SelectedIndexChanged(object sender, EventArgs e)
        {
            double valor = double.Parse(txtValor.Text);
            int parcela = int.Parse(cbParcelas.SelectedItem.ToString());
            double vezes = valor / parcela;

            if (cbParcelas.SelectedIndex == 0)
            {
                lbResult.Text = $"Pagamento a vista: ${valor.ToString("F2")}";
            }
            else
            {
                lbResult.Text = $"Pago em X{parcela} no valor: ${vezes.ToString("F2")}";
            }
        }
    }

}


