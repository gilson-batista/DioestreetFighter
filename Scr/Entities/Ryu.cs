namespace DioestreetFighter.Scr.Entities
{
    public class Ryu : Figther
    {
        string Name { get; set; }
        public Ryu(string name)
        {
            this.Name = name;
        }

        public string Hadouken()
        {
            return "Lancou bola de energia  chacra com as maos!";
        }

        public string Shoryuken()
        {
            return " Utilizou golpe especial com punho gancho voador!";
        }
        
        public string HurricaneKick()
        {
            return "Utilizou golpe especial giratoria voadora com chute";
        }

        public override string ToString()
        {
            return "THE WINNER IS " + this.Name;
        }
    }
}