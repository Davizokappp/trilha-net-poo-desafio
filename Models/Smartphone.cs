namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public Smartphone(string numero, string Modelo_, string IMEI_, int Memoria_)
        {
            Numero = numero; Modelo = Modelo_; IMEI = IMEI_; Memoria = Memoria_;
            // TODO: Passar os parâmetros do construtor para as propriedades
        }

         public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama

        protected string Modelo { get; set; }
        protected string IMEI { get; set; }
        protected int Memoria { get; set; }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
      

    }
}