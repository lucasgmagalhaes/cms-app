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
        /// <summary>
        /// Cria objetos do tipo DiaSemana referente a cada dia da semana e a cada horário de aula.
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Cria o grafo das grade de horários com os vértices informados
        /// </summary>
        /// <param name="vertices"></param>
        /// <returns></returns>
        public Grafo GerarHorarios(List<Vertice> vertices)
        {
            if (vertices == null) return new Grafo();
            Grafo grafo = new Grafo();
            List<DiaSemana> dias = new List<DiaSemana>();
            List<Aula> aulas = new List<Aula>();
            DiaSemana diaDisponivel;
            Aresta aresta;
            Vertice verticeDia;
            Vertice verticeAula;
            int totalDiasRestantes = 0;

            this.AdicionarVerticesEmVerticeEListas(grafo, dias, aulas, vertices);
            totalDiasRestantes = this.GetTotalDiasRestantesAulas(aulas);

            while (totalDiasRestantes > 0)
            {
                aulas.ForEach(aula =>
                {
                    if (aula.GetAulasPorSemanaRestante() > 0)
                    {
                        diaDisponivel = this.GetDiaDisponivelParaMateria(aula, dias);
                        if (diaDisponivel != null)
                        {
                            verticeDia = grafo.GetVertice(diaDisponivel);
                            verticeAula = grafo.GetVertice(aula);

                            aresta = new Aresta(verticeDia, verticeAula, 0);

                            verticeDia.AddAresta(aresta);
                            verticeAula.AddAresta(aresta);
                            aula.DiminuirAulasPorSemanasRestante();
                        }
                    }
                });
                totalDiasRestantes = this.GetTotalDiasRestantesAulas(aulas);
            }

            return grafo;
        }

        /// <summary>
        /// Informa o total de aulas na semana todas as aulas juntas terão
        /// </summary>
        /// <param name="aulas"></param>
        /// <returns></returns>
        public int GetTotalDiasRestantesAulas(List<Aula> aulas)
        {
            if (aulas == null) return 0;
            int count = 0;
            aulas.ForEach(aula => count += aula.GetAulasPorSemanaRestante());
            return count;
        }

        /// <summary>
        /// Retorna o dia semana disponível para a matéria passada por parâmetro.
        /// Para "dia disponível" é verificado quais dias da semana não tem aula para o período
        /// em que a matéria é, e se já não existe uma matéria com o mesmo professor da aula passada por parâmetro.
        /// </summary>
        /// <param name="materia"></param>
        /// <returns></returns>
        private DiaSemana GetDiaDisponivelParaMateria(Aula aula, List<DiaSemana> dias)
        {
            return dias.Find(dia => dia.ExisteAulaNoPeriodo(aula)
            && dia.ExisteAulaComProfessor(aula.GetProfessor()));
        }


        /// <summary>
        /// Adiciona a lista de vértices no grafo e, para cada vértice , se ele  for do tipo Dia, 
        /// ele também é adicionado na lista de dias. Se for do tipo Materia, é adicionado na lista de Materia
        /// </summary>
        /// <param name="grafo"></param>
        /// <param name="dias"></param>
        /// <param name="aulas"></param>
        /// <param name="vertices"></param>
        private void AdicionarVerticesEmVerticeEListas(Grafo grafo, List<DiaSemana> dias, List<Aula> aulas, List<Vertice> vertices)
        {
            vertices.ForEach(vertice =>
            {
                if (vertice.GetDado() is Aula)
                {
                    if (!grafo.Contem(vertice))
                    {
                        grafo.AddVertice(vertice);
                        aulas.Add((Aula)vertice.GetDado());
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