using System.Security.Cryptography.X509Certificates;
using System.Windows.Markup;
/*
class Egg
{
    public void Main(string[] args)
    {

        List<Egg> MyCarton = new List<Egg>(); //tworzenie obiektu

        Egg x = new Egg(); //dodawanie do listy
        MyCarton.Add(x);

        Egg y = new Egg(); // dodawanie do listy czegoś innego
        MyCarton.Add(y);

        int size = MyCarton.Count; // sprawdzanie elementów znajdujących się na liście

        bool isIn = MyCarton.Contains(x); //sprawdzanie czy lista zawiera określony element

        int index = MyCarton.IndexOf(x); // sprawdzanie gdzie na liście znajduje się określony elemnt

        MyCarton.Remove(x); // usuwanie z listy
    }

  



}
*/

   public class TaskMenager
{

    


      private  List<string> tasks = new List<string>();

      public  void AddTask(string addTask)
        {
            tasks.Add(addTask);
        }
        public void RemoveTask(string removeTask)
        {
            tasks.Remove(removeTask);
        }
      public List<string> GetTask()
        {
            return tasks;
        }
    }
         
