using Microsoft.Data.SqlClient;
using ScreenSound.Modelos;

namespace ScreenSound.Banco;

internal class ArtistaDAL
{
    private readonly ScreenSoundContext context;

    public ArtistaDAL(ScreenSoundContext context)
    {
        this.context = context;
    }

    public IEnumerable<Artista> Listar()
    {
        return context.Artistas.ToList();
    }

    public void Adicionar(Artista artista)
    {
        context.Artistas.Add(artista);
        context.SaveChanges();
    }

    public void Atualizar(Artista artista)
    {
        context.Artistas.Update(artista);
        context.SaveChanges();
    }

    public void Deletar(Artista artista)
    {
        context.Artistas.Remove(artista);
        context.SaveChanges();
    }

    public Artista RecuperarPeloNome(string nome)
    {
        var artista = context.Artistas.Where(x  => x.Nome == nome).FirstOrDefault();

        return artista;
    }
}
