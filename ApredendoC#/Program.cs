
namespace ApredendoClasses;
internal class Program
{
    public static void Main()
    {
        // o "meuCarro" se transforma em um objeto do tipo Carro e o "new Carro()" faz o objeto se torna uma instâcia concreta da clase carro
        Carro meuCarro = new Carro();
        // chamando a função "Ligar", irá exibir a mensagem que está dentro dela
        meuCarro.Ligar();
        // aqui acontece a mesma coisa
        meuCarro.Desligar();
    }
}

