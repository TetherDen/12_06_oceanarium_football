
namespace hw_12_06_Oceanarium_football
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Завдання 1
            //Створіть клас «Океанаріум» з інформацією про «мешканців» Океанаріуму.Створіть клас для кожної істоти
            //Океанаріуму.Вони мають містити інформацію про кожну
            //морську істоту. Реалізуйте підтримку ітератора для класу
            //«Океанаріум». Протестуйте можливість використання
            //foreach для Океанаріуму.
            Whale whale = new Whale("Whalename", "WhaleType", 100.55);
            Turtle turtle = new Turtle("TurtleName", "TurtleType", 20.5);
            Dolphin dolphin = new Dolphin("DolphinName", "DolphineType",50.3);
            Whale whale2 = whale.Clone();
            Turtle turtle2 = turtle.Clone();

            Oceanarium oceanarium = new Oceanarium();
            oceanarium.Add(whale);
            oceanarium.Add(turtle);
            oceanarium.Add(dolphin);
            oceanarium.Add(whale2);
            oceanarium.Add(turtle2);

            if(oceanarium.Count()>0)
            {
                foreach (var el in oceanarium)
                {
                    Console.WriteLine(el);
                }
            }

            //            Завдання 2
            //Створіть клас «Футбольна Команда». Клас має містити
            //інформацію про гравців футбольної команди. Реалізуйте
            //підтримку ітератора для класу «Футбольна Команда».
            //Протестуйте можливість використання foreach для класу
            //«Футбольна Команда».
            Team team = new Team();
            team.Add(new Player("Player111", "def"));
            team.Add(new Player("Player222", "fwd"));
            team.Add(new Player("Player333", "mid"));
            team.Add(new Player("Player444", "gk"));
            team.Add(new Player("Player555", "cm"));

            foreach (var el in team)
            {
                Console.WriteLine(el);
            }
            //Console.WriteLine(team);

        }
    }
}
