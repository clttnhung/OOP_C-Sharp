namespace Animal
{
class Dog
{
public string Name{get; set;}
static public int Count;
public Dog(string _name)
{
Name = _name;
Count++;
}
public void Go()
{
Console.WriteLine("Going....");
}
public static int GetNum()
{
return Count;
}
~Dog()
{
Console.WriteLine("Object is being deleted.");
}
}
class Demo
{
public static void Main(string[] args)
{
Dog d1 = new Dog("Bull");
Dog d2 = new Dog("Poodle");
int NumOfDogs = Dog.GetNum();
Console.WriteLine(NumOfDogs);
}
}
}