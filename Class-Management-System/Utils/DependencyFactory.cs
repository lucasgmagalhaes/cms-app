using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Class_Management_System.Utils
{
    /// <summary>
    /// Classe para instânciar objetos que implementam uma interface.
    /// Gera o objeto criando a Injeção de dependência.
    /// </summary>
    public static class DependencyFactory
    {
        /// <summary>
        /// Instâncializa uma classe que implementa uma interface 
        /// </summary>
        /// <typeparam name="T">interface para buscar implementação</typeparam>
        /// <returns></returns>
        public static T Resolve<T>()
        {
            Type interface_ = typeof(T);
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type[] types = assembly.GetTypes();

            IEnumerable<Type> implementacoes = types.Where(t => t.GetInterfaces().Contains(interface_));

            if (implementacoes != null)
            {
                foreach (Type tipo in implementacoes)
                {
                    if (!tipo.IsInterface) return (T)Activator.CreateInstance(tipo); 
                }
            }
            throw new NullReferenceException("Não existem implemeñtações da interface para incialização de objeto");
        }

        /// <summary>
        /// Instancializa uma classe especifica que implementa uma interface
        /// parâemtro. 
        /// </summary>
        /// <typeparam name="T">interface para buscar implementação</typeparam>
        /// <typeparam name="C">Classe específica para ser instanciada</typeparam>
        /// <returns></returns>
        public static T Resolve<T, C>()
        {
            Type interface_ = typeof(T);
            Type classe = typeof(C);

            if(classe.GetInterface(interface_.Name) == null)
            {
                throw new NullReferenceException("A classe " + interface_.Name 
                    + " não implementa a interface " + classe.Name);
            }

            Assembly assembly = Assembly.GetExecutingAssembly();
            Type[] types = assembly.GetTypes();

            IEnumerable<Type> implementacoes = types.Where(t => t.GetInterfaces()
            .Contains(interface_) && classe.Equals(t));

            if (implementacoes != null)
            {
                foreach (Type tipo in implementacoes)
                {
                    if (!tipo.IsInterface) return (T)Activator.CreateInstance(tipo);
                }
            }
            throw new NullReferenceException("Não existem implemeñtações da interface para incialização de objeto");
        }
    }
}
