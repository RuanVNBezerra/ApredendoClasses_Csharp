namespace ApredendoClasses
{
    // clase chamada carro
     class Carro
    {
        // função para ligar o carro
        // fazendo a função se torna publica para ser usada em outros lugares fora da clase Carro.
       public void Ligar()
        {
            Console.WriteLine("Carro ligado! vrummmm");
        }
        // função para desligar o carro
        // tornando publico aqui tambem.
        public void Desligar()
        {
            Console.WriteLine("Carro desligado!");
        }
    }
}
