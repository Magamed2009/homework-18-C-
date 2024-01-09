public class Player 
{
    public string Name;
    public int Number;
    public string Position;
    public string Team;
    public void ScoreGoal()
    {
        System.Console.WriteLine($"{Name} scores a goal!");
    }
    public void AssistGoal(string name)
    {
        System.Console.WriteLine($"{Name} assists a goal for {name}");
    }
    public string Getinfo()
    {
        return $"Name : {Name}\nNumber : {Number}\nPosition : {Position}\nTeam : {Team}";
    }
}