using System.ComponentModel;

namespace KyhInterfaceDemo;

public interface IDogSaving // Löfte, kontrakt, Power plug med två hål
{
    public void Save(List<string> dogNames);
}

public class DogDatabase : IDogSaving // implementation av ett kontrakt - Solceller
{
    public void Save(List<string> dogNames)
    {
        File.WriteAllLines("dog.txt", dogNames);
    }
}

public class SqlServerDogDatabase : IDogSaving
{
    public void Save(List<string> dogNames)
    {
        // Lagra i SQL Server databas
    }
}

public class Kennel
{
    private List<string> dogNames = new List<string>();
    private IDogSaving dogDatabase = new SqlServerDogDatabase();

    public void AddDog(string name)
    {
        dogNames.Add(name);
        dogDatabase.Save(dogNames);
    }

}

public class App
{
    public void Run()
    {
        var kennel = new Kennel();
        kennel.AddDog("Karo");
        kennel.AddDog("Dogge");





        var array = new[] { 1, 2, 3 };
        int antal = array.Count();


        foreach (var line in File.ReadLines("aaa.txt"))
        {

        }


        foreach (var x in array)
        {
        }

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }

        var a2 = new List<int> {1, 2, 3};
        int antal2 = a2.Count();

        foreach (var x in a2)
        {
        }

        for (int i = 0; i < a2.Count(); i++)
        {
            Console.WriteLine(a2[i]);
        }



    }
}