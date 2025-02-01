namespace ScreenSound.Modelos;

internal class Musica
{
    public Musica(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; set; }
    public int Id { get; set; }

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
      
    }

    // Por padrão, quando você chama ToString() em um objeto, ele retorna o nome completo da classe. No entanto, ao sobrescrever (override) esse método, você define como os dados da sua classe devem ser exibidos.
    public override string ToString()
    {
        return @$"Id: {Id}
        Nome: {Nome}";
    }
}