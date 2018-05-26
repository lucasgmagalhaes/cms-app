using Class_Management_System.Entities;
using Class_Management_System.Enums;
using Class_Management_System.Services;
using Class_Management_System.Structures;
using System.Collections.Generic;

namespace Class_Management_System.ServicesImp
{
    /// <summary>
    /// Implementação do serviço do IGrafoService
    /// </summary>
    public class GrafoService : IGrafoService
    {
        public List<DiaSemana> GerarDiasDaSemana()
        {
            List<DiaSemana> listaRetorno = new List<DiaSemana>();
            listaRetorno.Add(new DiaSemana(Horario.PRIMEIRO, DiaLetivo.SEGUNDA));
            listaRetorno.Add(new DiaSemana(Horario.SEGUNDO, DiaLetivo.SEGUNDA));

            listaRetorno.Add(new DiaSemana(Horario.PRIMEIRO, DiaLetivo.TERCA));
            listaRetorno.Add(new DiaSemana(Horario.SEGUNDO, DiaLetivo.TERCA));

            listaRetorno.Add(new DiaSemana(Horario.PRIMEIRO, DiaLetivo.QUARTA));
            listaRetorno.Add(new DiaSemana(Horario.SEGUNDO, DiaLetivo.QUARTA));

            listaRetorno.Add(new DiaSemana(Horario.PRIMEIRO, DiaLetivo.QUINTA));
            listaRetorno.Add(new DiaSemana(Horario.SEGUNDO, DiaLetivo.QUINTA));

            listaRetorno.Add(new DiaSemana(Horario.PRIMEIRO, DiaLetivo.SEXTA));
            listaRetorno.Add(new DiaSemana(Horario.SEGUNDO, DiaLetivo.SEXTA));
            return listaRetorno;
        }

        public Grafo GerarHorarios(List<Vertice> vertices)
        {
            Grafo grafo = new Grafo();
            List<DiaSemana> dias = new List<DiaSemana>();
            List<Aula> materias = new List<Aula>();
            DiaSemana diaDisponivel;
            Aresta aresta;
            Vertice verticeDia, verticeMateria;

            this.AdicionarVerticesEmVerticeEListas(grafo, dias, materias, vertices);

            materias.ForEach(materia =>
            {
                if(materia.GetAulasPorSemanaRestante() > 0)
                {
                    diaDisponivel = this.GetDiaDisponivelParaMateria(materia, dias);

                    verticeDia = grafo.GetVertice(diaDisponivel);
                    verticeMateria = grafo.GetVertice(materia);

                    aresta = new Aresta(verticeDia, verticeMateria, 0);

                    verticeDia.AddAresta(aresta);
                    verticeMateria.AddAresta(aresta);
                }
            });

            return grafo;
        }

        /// <summary>
        /// Retorna o dia semana disponível para a matéria passada por parâmetro.
        /// Verifica horario da matéria e período.
        /// </summary>
        /// <param name="materia"></param>
        /// <returns></returns>
        private DiaSemana GetDiaDisponivelParaMateria(Aula materia, List<DiaSemana> dias)
        {
            return dias.Find(dia => dia.ExisteAulaNoPeriodo(materia));
        }

        /// <summary>
        /// Para todos o
        /// </summary>
        /// <param name="grafo"></param>
        /// <param name="dias"></param>
        /// <param name="materias"></param>
        /// <param name="vertices"></param>
        private void AdicionarVerticesEmVerticeEListas(Grafo grafo, List<DiaSemana> dias, List<Aula> materias, List<Vertice> vertices)
        {
            vertices.ForEach(vertice =>
            {
                if (vertice.GetDado() is Aula)
                {
                    if (!grafo.Contem(vertice))
                    {
                        grafo.AddVertice(vertice);
                        materias.Add((Aula)vertice.GetDado());
                    }
                }
                else if (vertice.GetDado() is DiaSemana)
                {
                    if (!grafo.Contem(vertice))
                    {
                        if (!grafo.Contem(vertice))
                        {
                            grafo.AddVertice(vertice);
                            dias.Add((DiaSemana)vertice.GetDado());
                        }
                    }
                }
            });
        }
    }
}