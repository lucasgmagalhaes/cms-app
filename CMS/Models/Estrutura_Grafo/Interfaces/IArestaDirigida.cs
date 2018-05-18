using CMS.Models.Estrutura_Grafo.Estruturas;

namespace CMS.Models.Estrutura_Grafo.Interfaces
{
    interface IArestaDirigida
    {
        Vertice getOrigem();
        Vertice GetDestino();
    }
}
