
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

Lista<Produto> produtos = new List<Produto> {
    new Produto {Nome = "Bruno", Valor = 999.9, Quantidade = 1};
}

app.MapGet("/", () => {
    
});

app.MapGet("/api/produto/listar", () => {
    return produtos;
});

app.MapPost("/API/produto/cadastrar/{nome}", (string nome) => {
    produtos produto = new produtos();
    produto.Nome = nome;
    produtos.Add(produto);
    return produtos;
});

app.Run();
