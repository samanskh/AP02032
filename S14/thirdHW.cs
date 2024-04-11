interface IAnimal
{
    string move{get;}
    string makesound{get;}

}
public class Lion : IAnimal
{
    string m_sound = "roar";
    string m_move = "40 km";
    public string move => m_move;

    public string makesound => m_sound;
}
public class Dog : IAnimal
{
    string m_sound = "bark";
    string m_move = "20 km";
    public string move => m_move;

    public string makesound => m_sound;
}
public class Cat : IAnimal
{
    string m_sound = "meow";
    string m_move = "15 km";
    public string move => m_move;

    public string makesound => m_sound;
}