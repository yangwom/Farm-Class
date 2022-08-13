namespace Animals;

public class Chicken {
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
    // isso se chama sobre carga precisamos chamar o contrutor navamente com uma nova 
    // assinatura para que que a classe Chicken possa ser criada sem a mãe
    public Chicken(int eggsPerWeek)
  {
        if (eggsPerWeek < 0) throw new ArgumentException();
       EggsPerWeek = eggsPerWeek;
    }
  }
    
