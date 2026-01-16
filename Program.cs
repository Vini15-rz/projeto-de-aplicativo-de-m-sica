Banda ado=new Banda("Ado");
Album albumAdo=new Album("Kyögen");
Genero generoJpop=new Genero("J-Pop");

string estilo=generoJpop.GeneroMusical;

//Usseewa 207/ Gira Gira 476 / Hanabi 212
Musica musica1=new Musica(ado, "Usseewa")
{
    Duracao=207,
    Disponivel=true,
};
albumAdo.AdicionarMusica(musica1);

Musica musica2=new Musica(ado, "Gira Gira")
{
    Duracao=476,
    Disponivel=true,
};
albumAdo.AdicionarMusica(musica2);

Musica musica3=new Musica(ado, "Hanabi")
{
    Duracao=212,
    Disponivel=false,
};
albumAdo.AdicionarMusica(musica3);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
musica3.ExibirFichaTecnica();
ado.AdicionarAlbum(albumAdo);
albumAdo.ExibirMusicasDoAlbum();
ado.ExibirDiscografia();
Console.WriteLine($"O gênero musical do album é {estilo}");

Podcast podcado=new Podcast("ViniBrabo", "Podcado");
podcado.TotalEpisodios=0;

Episodio episodio1= new Episodio("História da Ado","1");
episodio1.Duracao=60;
episodio1.Resumo="Contando um pouco de como a Ado começou a sua carreira";

Episodio episodio2= new Episodio("Entrevista com Ado", "2");
episodio2.Duracao=45;
episodio2.Resumo="Entrevista com a cantora Ado";
episodio2.AdicionarConvidado("Ado");

Episodio episodio3=new Episodio("Encontro com Hatsune MIku", "3");
episodio3.Duracao=120;
episodio3.Resumo="Ado encontra Hatsune Miku e elas conversam sobre suas carreiras";
episodio3.AdicionarConvidado("Hatsune Miku");
episodio3.AdicionarConvidado("Ado");

podcado.AdicionarEpisodio(episodio1);
podcado.AdicionarEpisodio(episodio2);
podcado.AdicionarEpisodio(episodio3);

podcado.ExibirDetalhes();
