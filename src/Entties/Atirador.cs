namespace RPG.src.Entties
{
    public class Atirador : Herois
    {
        public Atirador(string Nome, int Level, string TipoHeroi) : base(Nome, Level, TipoHeroi)
        {
            this.Nome = Nome;
            this.Level = Level;
            this.TipoHeroi = TipoHeroi;
        }

        
    }
}