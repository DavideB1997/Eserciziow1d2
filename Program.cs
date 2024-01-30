namespace EsercizioW1D2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona Johnny = new Persona("johnny", "bellafaccia", 25);
            Console.WriteLine(Johnny.Dettagli());

        }
    }

    public class Persona
    {
        private string _nome = "";
        private string _cognome = "";
        private int _eta = 0;

        public Persona(string nome, string cognome, int eta)
        {
            _nome = char.ToUpper(nome[0]) + nome.Substring(1);
            _cognome = char.ToUpper(cognome[0]) + cognome.Substring(1);
            if (eta > 0)
            {
                _eta = eta;
            }
            else
            {
                _eta = 0;
            }

        }


        public string Dettagli()
        {
            if (_nome.Length <= 1)
                return "Nome troppo corto!";

            return $"{_nome} {_cognome} {_eta}";
        }
    }

}
