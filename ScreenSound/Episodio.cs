class Episodio
{
    public Episodio(string titulo, string ordem)
    {
        Titulo=titulo;
        Ordem=ordem;
    }
    public List<string> Convidados=new List<string>();
    public string Titulo { get; }
    public string Ordem { get; }
    public int Duracao { get; set; }
    public string Resumo { get; set;}
    public string Convidado { get; set; }
    public void AdicionarConvidado(string convidado)
    {
        Convidados.Add(convidado);
    }
    public void ExibirConvidados()
    {
        Console.WriteLine("Convidados: ");
        foreach(var convidado in Convidados)
        {
            Console.WriteLine(convidado);
        }
    }
}