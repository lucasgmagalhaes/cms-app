using Class_Management_System.Enums;
using Class_Management_System.Interfaces;
using System.Collections.Generic;

namespace Class_Management_System.Structures
{
    public class Aresta
    {
        private Vertice vertice1;
        private Vertice vertice2;
        private bool visitada; //visitada, usada para grafo euleriano
        private int peso;
        private Cor cor;
        public Aresta(Vertice v1, Vertice v2)
        {
            this.vertice1 = v1;
            this.vertice2 = v2;
            this.visitada = false;
        }

        public Aresta(Vertice v1, Vertice v2, int peso)
        {
            this.vertice1 = v1;
            this.vertice2 = v2;
            this.peso = peso;
            this.visitada = false;
        }

        public Aresta(Vertice v1, Vertice v2, Cor cor)
        {
            this.vertice1 = v1;
            this.vertice2 = v2;
            this.cor = cor;
            this.visitada = false;
        }

        /// <summary>
        /// Retorna os vértices que constituem a aresta
        /// </summary>
        /// <returns></returns>
        public List<Vertice> GetVertices()
        {
            return new List<Vertice> { this.vertice1, this.vertice2 };
        }

        public int GetPeso()
        {
            return this.peso;
        }

        /// <summary>
        /// Dado um vértice para comparação, retorna aquele que não é o passado por parâmetro.
        /// 
        /// <para>Tendo uma aresta dois vértices, A e B, passando A no parâmetro do método, este irá 
        /// retornar B, e vice versa.</para>
        /// É retornado null caso o vértice no parâmetro seja igual aos dois vértices da aresta
        /// ou seja, a aresta seja um loop para o vértice
        /// </summary>
        /// <param name="vertice">vertice</param>
        /// <returns></returns>
        public Vertice GetVerticeDiferente(Vertice vertice)
        {
            if (this.vertice1 == vertice)
            {
                return this.vertice2;
            }
            else if (this.vertice2 == vertice)
            {
                return this.vertice1;
            }
            return null;
        }

        /// <summary>
        /// Retorna se a busca/pesquisa já passou por esta aresta
        /// </summary>
        /// <returns></returns>
        public bool FoiVisitado()
        {
            return visitada;
        }
        public void SetVisitado(bool visita) => this.visitada = visita;

        /// <summary>
        /// Formado a - a; Peso x
        /// <para> a = aresta </para>
        /// <para> x = peso </para>
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("{0} - {1} ; Peso {2}", this.vertice1.GetDadoValor(), this.vertice2.GetDadoValor(),
                    this.peso);
        }

        /// <summary>
        /// Formato: a-a;x
        /// <para> a = aresta </para>
        /// <para> x = peso </para>
        /// </summary>
        /// <returns></returns>
        public string ToStringSemEspaco()
        {
            return string.Format("{0}-{1};{2}", this.vertice1.GetDadoValor(), this.vertice2.GetDadoValor(),
                    this.peso);
        }

        /// <summary>
        /// Compara a igualdade entre duas arestas comparando seus vértices e pesos
        /// </summary>
        /// <param name="aresta"></param>
        /// <returns></returns>
        public bool Equals(Aresta aresta)
        {
            try
            {
                Aresta comparar = (Aresta)aresta;
                return (comparar.getDadoVertice1.Equals(this.vertice1.GetDado())
                    && comparar.getDadoVertice2.Equals(this.vertice2.GetDado()) &&
                    comparar.GetPeso().Equals(this.peso));
            }
            catch
            {
                return false;
            }
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public object getValorVertice1
        {
            get
            {
                if (this.vertice1 != null) return this.vertice1.GetDadoValor();
                else return null;
            }
        }
        public object getValorVertice2
        {
            get
            {
                if (this.vertice2 != null) return this.vertice2.GetDadoValor();
                else return null;
            }
        }
        public IDado getDadoVertice1
        {
            get

            {
                if (this.vertice1 != null) return this.vertice1.GetDado();
                else return null;
            }
            set
            {
                this.vertice1.SetDado(value);
            }
        }
        public IDado getDadoVertice2
        {
            get
            {
                if (this.vertice2 != null) return this.vertice2.GetDado();
                else return null;
            }
            set
            {
                this.vertice2.SetDado(value);
            }
        }

        public Cor GetCor()
        {
            return this.cor;
        }

        public void SetCor(Cor cor)
        {
            this.cor = cor;
        }

        public Vertice getVertice1 { get { return this.vertice1; } }
        public Vertice getVertice2 { get { return this.vertice2; } }
        public void SetVertice1(Vertice vertice) => this.vertice1 = vertice;
        public void SetVertice2(Vertice vertice) => this.vertice2 = vertice;
    }
}