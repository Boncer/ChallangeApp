namespace ChallangeApp

{

    public class Employee
    {
        private List<int> Grands = new List<int>();


        public Employee(string FirstName, string LastName, int Age)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }



        public int Result
        {
            get
            {
                return this.Grands.Sum();
            }
        }

        public void AddGrands(int number)
        {
            this.Grands.Add(number);
        }
    }
}