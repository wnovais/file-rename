using System;
using System.IO;

namespace RenomearArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o caminho do diretório: ");
            string diretorio = Console.ReadLine();
            Console.Write("Digite o novo prefixo dos arquivos: ");
            string prefixoNovo = Console.ReadLine();

            // obtem lista de arquivos no diretório
            string[] arquivos = Directory.GetFiles(diretorio);

            foreach (string arquivo in arquivos)
            {
                // obtem informações do arquivo
                var infoArquivo = new FileInfo(arquivo);
                // cria o novo nome do arquivo
                string novoNome = Path.Combine(infoArquivo.DirectoryName, prefixoNovo + infoArquivo.Name);
                // renomeia o arquivo
                File.Move(arquivo, novoNome);

                Console.WriteLine("O arquivo {0} foi renomeado para {1}", arquivo, novoNome);
            }
        }
    }
}
