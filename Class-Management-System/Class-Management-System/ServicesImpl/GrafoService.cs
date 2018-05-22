using Class_Management_System.Entities;
using Class_Management_System.Services;
using Class_Management_System.Structures;
using System;
using System.Collections.Generic;

namespace Class_Management_System.ServicesImp
{
    public class GrafoService : IGrafoService
    {
        public List<DiaSemana> GerarDiasDaSemana()
        {
            throw new NotImplementedException();
        }

        public Grafo GerarHorarios(string[] arquivo)
        {
            throw new NotImplementedException();
        }

        Grafo IGrafoService.GerarHorarios(string[] arquivo)
        {
            throw new NotImplementedException();
        }
    }
}