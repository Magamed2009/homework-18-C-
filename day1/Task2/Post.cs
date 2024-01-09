public class Post 
{
    public string Text;
    public int Likes;
    public List<string> Comments;

    public void SetPost(string text)
    {
        Text = text; 
    }
    public void AddLike()
    {
        Likes++;
    }
    public void AddComment(string comment)
    {
        Comments.Add(comment);
    }
    public void GetInfo()
    {
        System.Console.WriteLine($"Text = {Text}\nLikes = {Likes}\nComments = ");
        foreach (var item in Comments)
        {
            System.Console.WriteLine($"{item}\n");            
        }
    }
}