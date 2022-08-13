namespace Animals;

class Pig {
   public Guid Id = Guid.NewGuid();
   public int Age;

   public Pig(int Age) {
   if(Age < 0) {
    throw new  ArgumentException();
   }

   this.Age = Age;
   }
}
