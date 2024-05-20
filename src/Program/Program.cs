using System;
using RoleplayGame;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            SpellsBook book = new SpellsBook();
            book.AddSpell(new SpellOne());
            book.AddSpell(new SpellOne());

            Wizard gandalf = new Wizard("Gandalf");
            gandalf.AddItem(book);

            Dwarf gimli = new Dwarf("Gimli");

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");
            Console.WriteLine($"Gandalf attacks Gimli with ⚔️ {gandalf.AttackValue}");

            gimli.ReceiveAttack(gandalf.AttackValue);

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");

            gimli.Cure();

            Console.WriteLine($"Someone cured Gimli. Gimli now has ❤️ {gimli.Health}");
            */

            //Creo héroe.
            /*

            AHeroes Link = new Archer("Link");

            AHeroes Gandalf = new Wizard("Gandalf");

            AHeroes John = new Dwarf("John");

            AHeroes Arturo = new Knight("Arturo");


            //Creo villano.
            AVillains Ganon = new EvilArcher("Ganondorf");

            AVillains Saruman = new EvilWizard("Saruman");

            AVillains Surtur = new EvilKnight("Surtur");

            AVillains Heracles = new EvilDwarf("Heracles");






            //Creo batalla.
            Battle firstBattle = new Battle("First Battle.");

            //Añado quiénes pelearán.
            firstBattle.AddHeroes(Link);
            firstBattle.AddVillains(Ganon);

            firstBattle.AddHeroes(Gandalf);
            firstBattle.AddVillains(Saruman);


            firstBattle.AddHeroes(Arturo);
            firstBattle.AddVillains(Surtur);

            firstBattle.AddHeroes(John);
            firstBattle.AddVillains(Heracles);


            //Se pelean.
            firstBattle.CreateBattle();
            
            */







             //Creo héroe.
            
            AHeroes Link = new GoodArcher("Link");
            AHeroes Gandalf = new GoodWizard("Gandalf");
            AHeroes Arturo = new GoodKnight("Arturo");
            AHeroes Ramon = new GoodDwarf ("Ramon");

            //Creo villano.
            AVillan Antonio = new EvilArcher("Antonio");
            AVillan Mauricio = new EvilWizard("Mauricio");
            AVillan Jose = new EvilKnight("Jose");
            AVillan Roberto = new EvilDwarf ("Roberto");
            
            //Conocer porcentaje de vide del personaje
            Console.WriteLine($"Link tiene ❤️ {Link.Health}");
            Console.WriteLine($"Gandalf tiene ❤️ {Gandalf.Health}");
            Console.WriteLine($"Arturo tiene ❤️ {Arturo.Health}");
            Console.WriteLine($"Ramon tiene ❤️ {Ramon.Health}");



            //Creo batalla.
            Battle firstBattle = new Battle("First Battle.");
            Battle secondBattle = new Battle("Second Battle.");


            //Añado quiénes pelearán.
            firstBattle.AddHeroes(Link);
            firstBattle.AddVillan(Mauricio);

            secondBattle.AddHeroes(Gandalf);
            secondBattle.AddVillan(Antonio);




            //Se pelean.
            firstBattle.CreateBattle();
            Console.WriteLine($"Link attacks Mauricio con ⚔️{Link.AttackValue}");
            Console.WriteLine($"Mauricio tiene ❤️ {Mauricio.Health}");


        }
    }
}
