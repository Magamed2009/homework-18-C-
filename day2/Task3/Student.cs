public class Student
{
    public string Name;
    public int GradeLevel;
    public double TestScores;
    public string GetAverage()
    {
        if(TestScores>=70 && TestScores<=85)
        {
            return $"Congratulations {Name} on achieving above average scores ({TestScores}) in grade {GradeLevel}!\nKeep up the good work!";
        }
        else 
        {
            return $"{Name}, if you're having difficulties with your studies, don't hesitate to\nseek help. Your current average score is {TestScores} in grade {GradeLevel}.";
        }
    }
}