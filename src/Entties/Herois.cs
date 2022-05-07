namespace RPG.src.Entties
{
    public abstract class Herois
    {
        public Herois(string Nome, int Level, string TipoHeroi)
        {
            this.Nome = Nome;
            this.Level = Level;
            this.TipoHeroi = TipoHeroi;
        }

            public string Nome { get; set; }
            public int Level { get; set; }
            public string TipoHeroi { get; set; }
            public int MP { get; set; }
            public int HP { get; set; }

   public override string ToString(){
       return this.Nome + " Level " + this.Level + " Classe " + this.TipoHeroi;
   }
   

   public virtual string Ataque(){
       this.MP = this.MP - 10;
       return this.Nome + " Atacará! Isso consumirá seu MP, antes de "+ (this.MP + 10) +", ficará " + this.MP;
   }

   public virtual string Atacado(){
       this.HP = this.HP - 10;
       return this.Nome + " Sofreu dano! seu HP, que era de "+ (this.HP + 10) +", agora será " + this.HP;
   }

    }
}