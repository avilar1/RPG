namespace RPG.src.Entties
{
    public class Wizard : Herois {
        public Wizard(string Nome, int Level, string TipoHeroi) : base(Nome, Level, TipoHeroi)
        {
            this.Nome = Nome;
            this.Level = Level;
            this.TipoHeroi = TipoHeroi;
        }

        // public override string Ataque(){
        //     return this.Nome + " lançou magia";
   
        // }

        
    }
}