using System;
using System.Collections.Generic;
using System.IO;

namespace Class_Management_System.Utils
{
    /// <summary>
    /// Classe auxiliar para leitura de arquivo padronizado para o TI
    /// </summary>
    public class LeitorArquivo
    {
        /// <summary>
        /// Lê o arquivo, validando suas linhas e retorna todo o arquivo em uma lista de strings
        /// invoca a exceção IOException caso as linhas do arquivo não estejam divididas por ';' ou 
        /// se a quantidade de itens divididos pelo ';' forem diferentes que 4. 
        /// 
        /// Invoca a exceção FileNotFoundException caso o caminho passado no parâmetro não seja de um arquivo
        /// válido
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public List<string> Ler(string path)
        {
            List<string> retorno = new List<string>();
            if (File.Exists(path))
            {
                using (StreamReader leitor = new StreamReader("path"))
                {
                    string line;

                    while ((line = leitor.ReadLine()) != null)
                    {
                        if (this.LinhaValida(line))
                        {
                            retorno.Add(line);
                        }
                        else
                        {
                            throw new IOException("Arquivo de leitura não é válido");
                        }
                    }
                }
            }
            else
            {
                throw new FileNotFoundException("Arquivo não existe");
            }
            return retorno;
        }

        /// <summary>
        /// Valida se a linha é separada por ';' e se o número de elementos dividios pelo ';' é igual
        /// a 4.
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        private bool LinhaValida(string line)
        {
            try
            {
                string[] divisao = line.Split(';');
                if (divisao.Length == 4) return true;
                return false;

            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
