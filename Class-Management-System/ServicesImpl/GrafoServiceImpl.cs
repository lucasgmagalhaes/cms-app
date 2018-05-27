using Class_Management_System.Entities;
using Class_Management_System.Enums;
using Class_Management_System.Interfaces;
using Class_Management_System.Services;
using Class_Management_System.Structures;
using System.Collections.Generic;
using System.Text;

namespace Class_Management_System.ServicesImp
{
    /// <summary>
    /// Implementação do serviço do IGrafoService
    /// </summary>
    public class GrafoServiceImpl : IGrafoService
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

        /// <summary>
        /// Cria o grafo das grade de horários com os vértices informados
        /// </summary>
        /// <param name="vertices"></param>
        /// <returns></returns>
        public Grafo GerarHorarios(List<Vertice> vertices)
        {
            return this.GerarGrafoBase(vertices);
        }

        public List<string> GerarHorariosFormatados(List<Vertice> vertices)
        {
            List<string> horarios = new List<string>();
            StringBuilder builder = new StringBuilder();
            Grafo grafo = this.GerarGrafoBase(vertices);

            this.BuscarVerticesDiaSemana(grafo).ForEach(dia =>
            {
                ((DiaSemana)dia.GetDado()).GetAulas().ForEach(aula =>
                {
                builder.Append((int)aula.GetDisciplina().GetPeriodo() + ";" + aula.GetDisciplina().GetNome() +
                    ";" + aula.GetProfessor().GetNome() + ";" + (int)((DiaSemana)dia.GetDado()).GetHorario()
                    + ";" + ((DiaSemana)dia.GetDado()).GetDia());
                    horarios.Add(builder.ToString());
                    builder.Clear();
                });
            });
            return horarios;
        }

        private Grafo GerarGrafoBase(List<Vertice> vertices)
        {
            if (vertices == null) return new Grafo();
            Grafo grafo = new Grafo();
            List<DiaSemana> dias = this.GerarDiasDaSemana();
            List<Aula> aulas = new List<Aula>();
            DiaSemana diaDisponivel;
            Aresta aresta;
            Vertice verticeDia;
            Vertice verticeAula;
            int totalDiasRestantes = 0;

            this.AdicionarVerticesEmVerticeEListas(grafo, dias, aulas, vertices);
            grafo.AddVertice(Vertice.ConverterParaVertice(new List<IDado>(dias)));
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
                            ((DiaSemana)verticeDia.GetDado()).AdicionarAula((Aula)verticeAula.GetDado());
                            aula.DiminuirAulasPorSemanasRestante();
                        }
                    }
                });
                totalDiasRestantes = this.GetTotalDiasRestantesAulas(aulas);
            }
            return grafo;
        }

        public int GetTotalDiasRestantesAulas(List<Aula> aulas)
        {
            if (aulas == null) return 0;
            int count = 0;
            aulas.ForEach(aula => count += aula.GetAulasPorSemanaRestante());
            return count;
        }

        public DiaSemana GetDiaDisponivelParaMateria(Aula aula, List<DiaSemana> dias)
        {
            List<DiaSemana> dias_ = dias.FindAll(dia => !dia.ExisteAulaNoPeriodo(aula)
            && !dia.ExisteAulaComProfessor(aula.GetProfessor()));
            List<DiaSemana> diasIguais;

            foreach(DiaSemana dia in dias_)
            {
                diasIguais = this.GetDiaSemanaPorDescricaoDia(dia.GetDia(), dias_);
                if (diasIguais.Count == 1) return dia;
            }
            return dias_[0];
        }

        public List<DiaSemana> GetDiaSemanaPorDescricaoDia(DiaLetivo dia, List<DiaSemana> dias)
        {
            return dias.FindAll(dia_ => dia_.GetDia() == dia);
        }

        public List<Vertice> BuscarVerticesAula(Grafo grafo)
        {
            if (grafo == null) return null;
            return grafo.GetVertices().FindAll(vertice => vertice.GetDado() is Aula);
        }

        public List<Vertice> BuscarVerticesDiaSemana(Grafo grafo)
        {
            if (grafo == null) return null;
            return grafo.GetVertices().FindAll(vertice => vertice.GetDado() is DiaSemana);
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