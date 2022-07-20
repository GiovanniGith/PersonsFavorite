// See https://aka.ms/new-console-template for more information

using PracticeRun2;

List<Person> people = new List<Person>();
while (true)
{
    //ask for name
    Console.Write("Please enter your name(type 'quit' to quit): ");

    String nameInput = Console.ReadLine();
    if (nameInput.ToLower() == "quit")
    {
        break;
    }



    // ask for fave color
    Console.WriteLine();
    Console.WriteLine("What's your favorite color?");

    string colorInput = Console.ReadLine();

    //ask for fave food
    Console.WriteLine();
    Console.WriteLine("What's your favorite food?");

    string foodInput = Console.ReadLine();

    Person person = new Person(nameInput, colorInput, foodInput);
    people.Add(person);
}

foreach (Person person in people)
{
    person.DisplayInfo();

}

// summarize all info entered so far






Console.ReadLine();
