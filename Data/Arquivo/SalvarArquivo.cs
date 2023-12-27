namespace Data.Arquivo
{
    public class SalvarArquivo
    {
        public void Salvar(string operacao)
        {
            using (StreamWriter writer = new StreamWriter("ultimo_comando.txt"))
            {
                writer.Write($"{operacao}-{DateTime.Now}");
            }
        }
    }
}
