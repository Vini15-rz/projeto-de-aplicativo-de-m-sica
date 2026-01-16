class Podcast
{
    public Podcast(string host, string nome)
    {
        Host=host;
        Nome=nome;
    }
    private List<Episodio> Episodios=new List<Episodio>();
    public string Nome { get; }
    public string Host { get; }
    public int TotalEpisodios { get; set; }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast: {Nome}");
        Console.WriteLine($"Host: {Host}");
        Console.WriteLine($"Total de episódios: {TotalEpisodios}");
        foreach (var episodio in Episodios)
        {
            Console.WriteLine($"Episódio: {episodio.Titulo}, Ordem: {episodio.Ordem}, Duração: {episodio.Duracao} ");
            if (episodio.Convidados.Count > 0)
            {
            episodio.ExibirConvidados();
            }
            Console.WriteLine($"Resumo: {episodio.Resumo}");
        }
    }
    public void AdicionarEpisodio(Episodio episodio)
    {
        Episodios.Add(episodio);
        TotalEpisodios=TotalEpisodios+1;
    }
    
}