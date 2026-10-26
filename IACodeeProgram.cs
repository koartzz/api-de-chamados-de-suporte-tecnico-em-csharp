// CÓDIGO FEITO POR IA.  APENAS PARA COMPARAÇÃO E INTERPRETAÇÃO DO MEU PRÓPRIO CÓDIGO
// NÃO ESTÁ FUNCIONANDO NO MOMENTO


var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Simulação de banco de dados em memória com Livros Populares e Técnicos
var livros = new List<Livro>
{
    new Livro(1, "O Programador Pragmático", "Andrew Hunt & David Thomas", "TI", "Técnico", 1999),
    new Livro(2, "Código Limpo (Clean Code)", "Robert C. Martin", "TI", "Técnico", 2008),
    new Livro(3, "Arquitetura Limpa", "Robert C. Martin", "TI", "Técnico", 2017),
    new Livro(4, "O Pequeno Príncipe", "Antoine de Saint-Exupéry", "Fábula", "Ficção", 1943),
    new Livro(5, "O Hobbit", "J.R.R. Tolkien", "Fantasia", "Ficção", 1937),
    new Livro(6, "O Senhor dos Anéis", "J.R.R. Tolkien", "Fantasia", "Ficção", 1954)
};

// 1. Endpoint para listar todos os livros
app.MapGet("/livros", () => Results.Ok(livros));

// 2. Endpoint de Comparação
app.MapGet("/comparar", (int id1, int id2) =>
{
    var livro1 = livros.FirstOrDefault(l => l.Id == id1);
    var livro2 = livros.FirstOrDefault(l => l.Id == id2);

    if (livro1 is null || livro2 is null)
        return Results.NotFound("Um ou ambos os livros não foram encontrados.");

    bool mesmoAutor = livro1.Autor.Equals(livro2.Autor, StringComparison.OrdinalIgnoreCase);
    bool mesmoTipo = livro1.Tipo.Equals(livro2.Tipo, StringComparison.OrdinalIgnoreCase);
    bool mesmoGenero = livro1.Genero.Equals(livro2.Genero, StringComparison.OrdinalIgnoreCase);

    return Results.Ok(new
    {
        LivroA = livro1.Titulo,
        LivroB = livro2.Titulo,
        MesmoAutor = mesmoAutor,
        MesmoTipo = mesmoTipo,
        MesmoGenero = mesmoGenero,
        DiferencaDeAnos = Math.Abs(livro1.AnoPublicacao - livro2.AnoPublicacao),
        Analise = (mesmoAutor, mesmoTipo) switch
        {
            (true, _) => $"Ambos foram escritos por {livro1.Autor}!",
            (false, true) when mesmoGenero => $"Ambos são do gênero {livro1.Genero} ({livro1.Tipo}).",
            (false, true) => $"Ambos são livros do tipo '{livro1.Tipo}', mas de gêneros e autores diferentes.",
            _ => $"Obras totalmente distintas: '{livro1.Titulo}' é {livro1.Tipo} e '{livro2.Titulo}' é {livro2.Tipo}."
        }
    });
});

app.Run();

// Modelo/Registro do Livro
record Livro(int Id, string Titulo, string Autor, string Genero, string Tipo, int AnoPublicacao);
