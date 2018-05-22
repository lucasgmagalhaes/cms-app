using Class_Management_System.Enums;
using Class_Management_System.Interfaces;
using System.Collections.Generic;
using System.Text;

namespace Class_Management_System.Structures
{
    public class Vertice
    {
        private List<Aresta> arestas;
        private IDado dado;
        private Cor cor; //Usado para realizar os métodos de pesquisa
        private bool visitado;
        private Vertice chefe;
        public Cor Cor { get { return this.cor; } }

        public Vertice(IDado dados)
        {
            this.dado = dados;
            this.Init();
        }

        public Vertice(IDado dado, List<Aresta> arestas)
        {
            this.dado = dado;
            this.Init();
            this.arestas.AddRange(arestas);
        }

        private void Init()
        {
            this.chefe = this;
            this.arestas = new List<Aresta>();
        }

        /// <summary>
        /// Cria um clone superficial do vértice
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return this.MemberwiseClone();
        }

        /// <summary>
        /// Clona o vértice, e seu dado. Porém, mantem as arestas
        /// </summary>
        /// <returns></returns>
        public Vertice Clonar()
        {
            Vertice retorno = new Vertice(this.dado.Clone());
            retorno.AddArestas(this.GetArestas());
            return retorno;
        }

        /// <summary>
        /// Clona o vértice removendo as arestas
        /// </summary>
        /// <returns></returns>
        public Vertice ClonarSemArestas()
        {
            return new Vertice(this.dado.Clone());
        }

        public Aresta GetAresta(int index)
        {
            return this.arestas[index];
        }

        public void SetAresta(int index, Aresta aresta)
        {
            if (index >= 0 && index <= this.arestas.Count - 1)
            {
                this.arestas[index] = aresta;
            }
        }

        /// <summary>
        /// Insere uma nova aresta na lista de arestas do vértice.
        /// Não permite a inserção de arestas repetidas
        /// </summary>
        /// <param name="aresta"></param>
        public void AddAresta(Aresta aresta)
        {
            if (!this.Contem(aresta))
            {
                this.arestas.Add(aresta);
            }
        }

        public void AddArestas(List<Aresta> arestas)
        {
            if (arestas != null)
            {
                foreach (Aresta aresta in arestas)
                {
                    if (!this.Contem(aresta))
                    {
                        this.arestas.Add(aresta);
                    }
                }
            }
        }

        public Vertice GetVerticeChefe()
        {
            return this.chefe;
        }

        public void SetVerticeChefe(Vertice chefe)
        {
            if (chefe != null) this.chefe = chefe;
        }

        public IDado GetDado()
        {
            return this.dado;
        }

        public void SetDado(IDado dado)
        {
            this.dado = dado;
        }

        public override string ToString()
        {
            return this.dado.GetValor().ToString();
        }

        /// <summary>
        /// Fornece a lista de todos os vértices que fazem ligação(possuem aresta) com
        /// </summary>
        /// <returns></returns>
        public List<Vertice> GetAdjacentes()
        {
            List<Vertice> listaRetorno = new List<Vertice>();
            foreach (Aresta aresta in this.arestas)
            {
                listaRetorno.Add(aresta.GetVerticeDiferente(this));
            }
            return listaRetorno;
        }

        public string ToStringComArestas()
        {
            StringBuilder retorno = new StringBuilder();
            this.arestas.ForEach(delegate (Aresta aresta) { retorno.AppendLine(aresta.ToString() + " "); });
            return retorno.ToString();
        }

        public string ToStringComArestasSemEspaco()
        {
            StringBuilder retorno = new StringBuilder();
            this.arestas.ForEach(delegate (Aresta aresta) { retorno.Append(aresta.ToStringSemEspaco() + " "); });
            return retorno.ToString();
        }

        public List<Aresta> GetArestas()
        {
            List<Aresta> retorno = new List<Aresta>();
            this.arestas.ForEach(aresta => retorno.Add(aresta));
            return retorno;
        }

        /// <summary>
        /// Retorna todas as arestas do vértice que não foram visitadas
        /// </summary>
        /// <returns></returns>
        public List<Aresta> GetArestasNaoVisitadas()
        {
            return this.arestas.FindAll(ab => !ab.FoiVisitado());
        }

        public bool FoiVisitado()
        {
            return this.visitado;
        }

        public object GetDadoValor()
        {
            return this.dado.GetValor();
        }

        public void SetVisitado(bool visita)
        {
            this.visitado = visita;
        }

        /// <summary>
        /// Define a cor do vértice baseado na cor atual. Se ela for BRANCA, passará a ser CINZA,
        /// e se for CINZA, será PRETA.
        /// </summary>
        public void AtualizarCor()
        {
            if (this.cor == Cor.BRANCO) this.cor = Cor.CINZA;
            else if (this.cor == Cor.CINZA) this.cor = Cor.PRETO;
        }

        /// <summary>
        /// Torna a cor do vértice, PRETO
        /// </summary>
        public void FinalizaPercurso()
        {
            this.cor = Cor.PRETO;
        }

        /// <summary>
        /// Restaura a cor do vértice para a cor padrão dele, ou seja, BRANCO.
        /// </summary>
        public void ResetarCor()
        {
            this.cor = Cor.BRANCO;
        }

        /// <summary>
        /// Define um valor para a cor
        /// </summary>
        /// <param name="cor"></param>
        public void SetCor(Cor cor)
        {
            this.cor = cor;
        }

        /// <summary>
        /// Faz a busca da aresta de menor peso do vertice
        /// </summary>
        /// <returns>Retorna aresta de menor peso</returns>
        public Aresta GetMenorAresta()
        {
            Aresta aMenor = null;
            this.arestas.ForEach(aItem =>
            {
                if (aMenor == null || aItem.GetPeso() < aMenor.GetPeso()) aMenor = aItem;
            });
            return aMenor;
        }

        /// <summary>
        /// Faz a busca da aresta de menor peso do vertice e que 
        /// não foi visitada
        /// </summary>
        /// <returns>Retorna aresta de menor peso</returns>
        public Aresta GetMenorArestaNaoVisitada()
        {
            Aresta aMenor = null;
            this.arestas.ForEach(aItem =>
            {
                if (!aItem.FoiVisitado())
                {
                    if (aMenor == null || aItem.GetPeso() < aMenor.GetPeso()) aMenor = aItem;
                }
            });
            return aMenor;
        }

        /// <summary>
        /// Verifica se o vértice atual possui adjacência com outro vértice
        /// </summary>
        /// <param name="vertice"></param>
        /// <returns></returns>
        public bool IsAdjacente(Vertice vertice)
        {
            List<Vertice> adjacentes = this.GetAdjacentes();
            foreach (Vertice v in adjacentes)
            {
                if (v.GetDadoValor().Equals(vertice.GetDadoValor())) return true;
            }
            return false;
        }

        /// <summary>
        /// Verifica se o vértice possui pelo menos uma aresta com o vértice passado
        /// no parâmetro
        /// </summary>
        /// <param name="vertice"></param>
        /// <returns></returns>
        public bool TemArestaComVertice(Vertice vertice)
        {
            foreach (Aresta aresta in this.arestas)
            {
                if (aresta.GetVerticeDiferente(this).Equals(vertice)) return true;
            }
            return false;
        }

        /// <summary>
        /// Verifica se o vértice já possui uma aresta igual aquela passada por parâmetro
        /// </summary>
        /// <param name="aresta"></param>
        /// <returns></returns>
        public bool Contem(Aresta aresta)
        {
            foreach (Aresta aresta1 in this.arestas)
            {
                if (aresta1.Equals(aresta)) return true;
            }
            return false;
        }

        /// <summary>
        /// Verifica se o vértice possui aresta com ele mesmo
        /// </summary>
        /// <returns></returns>
        public bool TemCiclos()
        {
            foreach (Aresta aresta in this.arestas) if (aresta.GetVerticeDiferente(this) == null) return true;
            return false;
        }

        /// <summary>
        /// Verifica a igualdade entre dois vértices através do dado que eles armazenam
        /// </summary>
        /// <param name="vertice"></param>
        /// <returns></returns>
        public bool Equals(Vertice vertice)
        {
            return (vertice.GetDado().Equals(this.dado));
        }

        /// <summary>
        /// Procura por uma aresta na lista de arestas do vértice e retorna em qual posição da lista
        /// essa aresta está. Retorna -1 caso a aresta não exista na lista.
        /// </summary>
        /// <param name="aresta"></param>
        /// <returns></returns>
        public int getIndexAresta(Aresta aresta)
        {
            Aresta atual;
            for (int i = 0; i < this.arestas.Count; i++)
            {
                atual = (Aresta)this.arestas[i];
                if (atual.getValorVertice1.Equals(aresta.getValorVertice1)
                    && atual.getValorVertice2.Equals(aresta.getValorVertice2)
                    && aresta.GetPeso() == atual.GetPeso()) return i;
            }
            return -1;
        }

        /// <summary>
        /// Limpa a lista de arestas do vértice
        /// </summary>
        public void LimparArestas()
        {
            if (this.arestas == null) this.arestas = new List<Aresta>();
            else this.arestas.Clear();
        }

        /// <summary>
        /// Torna a resta como não visitada
        /// </summary>
        public void ResetarVisitaArestas() => this.arestas.ForEach(aresta => aresta.SetVisitado(false));

        /// <summary>
        /// Número de arestas que o vértice possui
        /// </summary>
        /// <returns></returns>
        public int GetGrau()
        {
            return this.arestas.Count;
        }

        /// <summary>
        /// Caso a aresta do parâmetro exista na lista de arestas do vértices, ela é removida
        /// </summary>
        /// <param name="aresta"></param>
        public void RemoverAresta(Aresta aresta)
        {
            this.arestas.RemoveAll(aresta_local => aresta_local.Equals(aresta));
        }

        /// <summary>
        /// Para uma lista de vértices, verifica se o vértice passado no parâmetro existe nessa lista,
        /// comparando pelo valor do dado do vértice
        /// </summary>
        /// <param name="vertices"></param>
        /// <param name="vertice"></param>
        /// <returns></returns>
        public static bool Contem(List<Vertice> vertices, Vertice vertice)
        {
            foreach (Vertice vertice_index in vertices)
            {
                if (vertice.GetDadoValor().Equals(vertice_index.GetDadoValor())) return true;
            }
            return false;
        }

        /// <summary>
        /// Busca um vértice da lista caso ele exista nela
        /// </summary>
        /// <param name="vertice"></param>
        /// <param name="vertices"></param>
        /// <returns></returns>
        public static Vertice Get(Vertice vertice, List<Vertice> vertices)
        {
            foreach (Vertice vertice_index in vertices)
            {
                if (vertice.GetDadoValor().Equals(vertice_index.GetDadoValor())) return vertice_index;
            }
            return null;
        }
    }
}