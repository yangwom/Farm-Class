namespace Animals;

class Chicken {
    public Guid Id =  Guid.NewGuid();
    public int EggsPerWeek;
    public Chicken? Mother;

    public Chicken(int EggsPerWeek, Chicken Mother) {
           if(EggsPerWeek < 0) {
            throw new ArgumentException();
           }


        this.EggsPerWeek = EggsPerWeek;
        this.Mother = Mother;
    }
    

}
