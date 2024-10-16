namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string Modelo_, string IMEI_, int Memoria_) : base(numero, Modelo_, IMEI_, Memoria_)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"O Aplicativo {nomeApp}, está sendo baixado.");
        }
    }
}