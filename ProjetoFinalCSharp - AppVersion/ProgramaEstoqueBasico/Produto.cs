
namespace ProgramaEstoqueBasico
{
        class Produto
        {
            //atributos
            string nome, lote;
            int  quantidade;
            double precoUnitario, valorLote;
            //get&set
            //-nome
            public void setNome(string nome)
            {
                this.nome = nome;
            }
            public string getNome()
            {
                return this.nome;
            }
            //-lote
            public void setLote(string lote)
            {
                this.lote = lote;
            }
            public string getLote()
            {
                return this.lote;
            }
            //-quantidade
            public void setQuantidade(int quantidade)
            {
                this.quantidade = quantidade;
            }
            public int getQuantidade()
            {
                return this.quantidade;
            }
            //-preco unitario
            public void setPrecoUnitario(double precoUnitario)
            {
                this.precoUnitario = precoUnitario;
            }
            public double getPrecoUnitario()
            {
                return this.precoUnitario;
            }
            //-valor do lote
            public void setValorLote(int quantidade, double precoUnitario)
            {
                this.valorLote = precoUnitario * quantidade;
            }
            public double getValorLote()
            {
                return this.valorLote;
            }
            //contrutores
            public Produto()
            {

            }
            public Produto(string nome, string lote, int quantidade, double precoUnitario)
            {
                setNome(nome);
                setLote(lote);
                setQuantidade(quantidade);
                setPrecoUnitario(precoUnitario);
                setValorLote(quantidade, precoUnitario);
            }
        public string imprimeKek()
        {
            string impressao=
            "Produto: " + nome + " \tLote: " + lote + "\nQuantidade: " + quantidade + " Preco Unitario: " +
            precoUnitario + "\nValor deste lote: R$" + valorLote;
            return impressao;
        }
    }
    }
