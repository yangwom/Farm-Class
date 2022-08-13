namespace Animals;

public class Cow
{
    public Guid Id = Guid.NewGuid();
    public int Weight;

    public string Beed;

    public Cow(int Weight, string Beed)
    {
        try
        {
            if (Weight <= 0 || Beed == null || Beed == "")
            {
                throw new ArgumentException();
            }
        }
        catch(ArgumentException ex)
        {
         Console.WriteLine(ex.Message);
         throw;
        }


     this.Weight = Weight;
     this.Beed = Beed;
    }


}
