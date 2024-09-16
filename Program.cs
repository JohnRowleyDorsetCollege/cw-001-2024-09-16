// See https://aka.ms/new-console-template for more information

using cw_001.Models;
using System.Xml.Linq;

string myName = "John";
int myAge = 62;

// create 1 or more instances of the class => objects
Person p = new Person();
p.Name = myName;
p.Age = myAge;

Person p1 = new Person();
p1.Name = "Bruce Wayne";
p1.Age = 60;

Console.WriteLine($"Hello, {p.Name}! I am {p.Age} years old");
Console.WriteLine($"Hello, {p1.Name}! I am {p1.Age} years old");

List<Person> list = new List<Person>();
list.Add(p);
list.Add(p1);

foreach (Person person in list)
{
   // Console.WriteLine($"Hello, {person.Name}! I am {person.Age} years old");
    Console.WriteLine(person.ToString());
}

List<SuperHero> heroes = new List<SuperHero>() {

    new SuperHero(){  Name="Bruce Wayne" , HeroName = "Batman"},
    new SuperHero(){  Name="Peter Parker" , HeroName = "Spiderman"},
    new SuperHero(){  Name="David Banner" , HeroName = "The Hulk"},
};

heroes.Add(new SuperHero() { Name = "Clarke Kent", HeroName = "Superman" } );

SuperHero superHero = new SuperHero();
superHero.Name = "Steve Rogers";
superHero.HeroName = "Captain America";

heroes.Add(superHero);

foreach (SuperHero hero in heroes)
{
    // Console.WriteLine($"Hello, {person.Name}! I am {person.Age} years old");
    Console.WriteLine(hero);
}


