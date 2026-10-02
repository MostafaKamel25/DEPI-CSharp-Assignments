namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] EmpArr = new Employee[3];
          
            EmpArr[0] = new Employee(1, "Ahmed", SecurityLevel.DBA, 25000,  new HiringDate(15, 3, 2022), Gender.M);

           
            EmpArr[1] = new Employee(2, "Mona", SecurityLevel.Guest, 8000, new HiringDate(10, 7, 2024), Gender.F );

           
            EmpArr[2] = new Employee(3, "Omar", SecurityLevel.Secretary,30000,new HiringDate(1, 1, 2020),Gender.M);

            
            foreach (Employee emp in EmpArr)
            {
                Console.WriteLine(emp);
            }

        }
    }
}
