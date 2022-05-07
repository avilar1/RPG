
using System;
using RPG.src.Entties;

namespace RPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //H.E.P.A

            //HERANÇA
            //ENCAPSULAMENTO
            //POLIMORFISMO
            //ABSTRAÇÃO
            Guerreiro heroi = new Guerreiro("Guerreiro Finer", 2, "Guerreiro");
            Wizard wizard = new Wizard("Mago Paul", 4, "Espadachin");
            Atirador atirador = new Atirador("Atirador Arley", 7, "Atirador");
            Ogro ogro = new Ogro("Ogro Barsow", 4, "Ogro");

            //apenas para simplificação, isso poderia ser feito no construtor
            heroi.HP = 100 * heroi.Level;
            heroi.MP = 100;

            wizard.HP = 100 * atirador.Level;
            wizard.MP = 100;

            atirador.HP = 100 * atirador.Level;
            atirador.MP = 100;

            ogro.HP = 100 * atirador.Level;
            ogro.MP = 100;




            Console.WriteLine("realizar ataque? 1-Sim 2-Não");
            string opcaoUsuario = ObterOpcaoUsuario();

                switch (opcaoUsuario)
                {
                    case "1":{
                Console.WriteLine("escolha o personagem que atacará");
                Console.WriteLine("1- heroi | 2- wizard | 3- atirador | 4- ogro");
                    string heroiAtacador = Console.ReadLine();

                    switch (heroiAtacador){
                        case "1":{
                            Console.WriteLine(heroi.Ataque());
                            break;
                        }
                        case "2":{
                            Console.WriteLine(wizard.Ataque());
                            break;
                        }
                        case "3":{

                            Console.WriteLine(atirador.Ataque());
                            break;
                        }
                        case "4":{
                            Console.WriteLine(ogro.Ataque());
                            break;
                        }
                    }

                Console.WriteLine("escolha o personagem que sofrerá o ataque");
                Console.WriteLine("1- heroi | 2- wizard | 3- atirador | 4- ogro");
                    string heroiSofredor = Console.ReadLine();

                switch (heroiSofredor){
                    case "1":{

                        Console.WriteLine(heroi.Atacado());
                        break;
                    }
                    case "2":{
                        Console.WriteLine(wizard.Atacado());
                        break;
                    }
                    case "3":{
                        Console.WriteLine(atirador.Atacado());
                        break;
                    }
                    case "4":{
                        Console.WriteLine(ogro.Atacado());
                        break;
                    }
                }
                   break;
                    }
                    
                   case "2":{
                       break;
                   } 
                }
                    

            }
             public static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1- Atacar");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;
        }
        }
    }
