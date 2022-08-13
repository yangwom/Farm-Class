namespace Animals;

class Cow
{
    public Guid Id = Guid.NewGuid();
    public int Wheight;

    public string Beed;

    public Cow(int Wheight, string Beed)
    {
        try
        {
            if (Wheight <= 0 || Beed == null || Beed == "")
            {
                throw new ArgumentException();
            }
        }
        catch(ArgumentException ex)
        {
         Console.WriteLine(ex.Message);
         throw;
        }


     this.Wheight = Wheight;
     this.Beed = Beed;
    }


}
