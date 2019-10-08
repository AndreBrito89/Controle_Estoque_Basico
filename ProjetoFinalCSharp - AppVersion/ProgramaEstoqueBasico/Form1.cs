using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaEstoqueBasico
{
    public partial class Form1 : Form
    {
        Produto produtoAuxuliar = new Produto();
        List<Produto> estoque = new List<Produto>();
        public Form1()
        {
            InitializeComponent();
        }

        /////////////////////////////
        //// PAGINA DE CADASTRO ////
        ///////////////////////////

        /////////////////
        //// BOTOES ////
        ///////////////
        //botao limpar campos de cadastro
        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBox_NomeProduto.Text = "";
            textBox_LoteProduto.Text = "";
            textBox_QuantidadeProduto.Text = "";
            textBox_ValorUnitarioProduto.Text = "";
        }
        //botao cadastrar produto
        private void button_Cadastrar_Click(object sender, EventArgs e)
        {
            if (textBox_NomeProduto.Text.Equals("") || textBox_LoteProduto.Text.Equals("") ||
                textBox_QuantidadeProduto.Text.Equals("") ||textBox_ValorUnitarioProduto.Text.Equals(""))
            {
                label_ConfirmaCadastro.Text = "Favor preencher todos os campos.";
            }
            else
            {
                string nomeProduto = textBox_NomeProduto.Text;
                string loteProduto = textBox_LoteProduto.Text;
                int quantidadeProduto = int.Parse(textBox_QuantidadeProduto.Text);
                double precoUnitarioProduto = double.Parse(textBox_ValorUnitarioProduto.Text);


                estoque.Add(new Produto(nomeProduto, loteProduto, quantidadeProduto, precoUnitarioProduto));
                label_ConfirmaCadastro.Text = nomeProduto + " cadastrado com sucesso.";
                buttonLimpar.PerformClick();
            }
        }

        ///////////////////////////////
        //// PAGINA DE RELATORIOS ////
        /////////////////////////////

        /////////////////
        //// BOTOES ////
        ///////////////
        //botao para procurar na lista baseado no checkbox
        private void button_ConfirmaProcura_Click(object sender, EventArgs e)
        {
            string procura = comboBox_EscolhaRelatorios.Text;
            switch (procura)
            {
                case "Todos os produtos": mostrarListaCompleta(estoque);
                    break;
                case "Produto mais caro": mostrarProdutoMaisCaro(estoque);
                    break;
                case "Produto mais barato":mostrarProdutoMaisBarato(estoque);
                    break;
                case "Maior lote":mostrarMaiorLote(estoque);
                    break;
                case "Menor lote":mostrarMenorLote(estoque);
                    break;
                case "Lote mais caro":mostrarLoteMaisCaro(estoque);
                    break;
                case "Lote mais barato":mostrarLoteMaisBarato(estoque);
                    break;
                default:naoSelecionouCheckBoxDireito();
                    break;
            }
        }
        ////////////////////////////////////////////
        /////////// METODOS DE BUSCA //////////////
        //////////////////////////////////////////
        
        //-lista completa
        private void mostrarListaCompleta(List<Produto>estoque)
        {
            label_ResultadoRelatorio.Text = "____________________________________\n";
            foreach (Produto p in estoque)
            {
                label_ResultadoRelatorio.Text += p.imprimeKek()+ "\n____________________________________\n";
            }
        }
        //-produto mais caro
        private void mostrarProdutoMaisCaro(List<Produto> estoque)
        {
            double valorProdutoMaisCaro = 0;
            foreach (var produto in
                estoque.Where(p=>p.getPrecoUnitario()>= valorProdutoMaisCaro))
            {
                valorProdutoMaisCaro = produto.getPrecoUnitario();
                produtoAuxuliar = produto;
            }
            label_ResultadoRelatorio.Text = produtoAuxuliar.imprimeKek();
            produtoAuxuliar = null;
        }
        //-produto mais barato
        private void mostrarProdutoMaisBarato(List<Produto> estoque)
        {
            double valorProdutoMaisBarato = 999999999999999999;
            foreach (var produto in
                estoque.Where(p => p.getPrecoUnitario() <= valorProdutoMaisBarato))
            {
                valorProdutoMaisBarato = produto.getPrecoUnitario();
                produtoAuxuliar = produto;
            }
            label_ResultadoRelatorio.Text = produtoAuxuliar.imprimeKek();
            produtoAuxuliar = null;
        }
        //-maior lote
        private void mostrarMaiorLote(List<Produto>estoque)
        {
            double maiorLoteQtd = 0;
            foreach (var produto in
                estoque.Where(p => p.getQuantidade() >= maiorLoteQtd))
            {
                maiorLoteQtd = produto.getQuantidade();
                produtoAuxuliar = produto;
            }
            label_ResultadoRelatorio.Text = produtoAuxuliar.imprimeKek();
            produtoAuxuliar = null;
        }
        //-menor lote
        private void mostrarMenorLote(List<Produto> estoque)
        {
            double maiorLoteQtd = 999999999999999999;
            foreach (var produto in
                estoque.Where(p => p.getQuantidade() <= maiorLoteQtd))
            {
                maiorLoteQtd = produto.getQuantidade();
                produtoAuxuliar = produto;
            }
            label_ResultadoRelatorio.Text = produtoAuxuliar.imprimeKek();
            produtoAuxuliar = null;
        }
        //-lote mais caro
        private void mostrarLoteMaisCaro(List<Produto> estoque)
        {
            double valorLoteMaisCaro = 0;
            foreach (var produto in
                estoque.Where(p => p.getValorLote() >= valorLoteMaisCaro))
            {
                valorLoteMaisCaro = produto.getValorLote();
                produtoAuxuliar = produto;
            }
            label_ResultadoRelatorio.Text = produtoAuxuliar.imprimeKek();
            produtoAuxuliar = null;
        }
        //-lote mais barato
        private void mostrarLoteMaisBarato(List<Produto>estoque)
        {
            double valorLoteMaisCaro = 999999999999999999;
            foreach (var produto in
                estoque.Where(p => p.getValorLote() <= valorLoteMaisCaro))
            {
                valorLoteMaisCaro = produto.getValorLote();
                produtoAuxuliar = produto;
            }
            label_ResultadoRelatorio.Text = produtoAuxuliar.imprimeKek();
            produtoAuxuliar = null;
        }
        //-nao selecionou nada
        private void naoSelecionouCheckBoxDireito()
        {
            label_ResultadoRelatorio.Text = "Favor escolher uma das opções ao lado.";
        }
    }
}
