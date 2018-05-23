using Class_Management_System.Entities;
using Class_Management_System.Enums;
using Class_Management_System.Interfaces;
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

        public IGrafo GerarHorarios(List<Vertice> vertices)
        {
            IGrafo grafo = new Grafo();
            return grafo;
        }
    }
}