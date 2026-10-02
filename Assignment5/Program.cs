using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment5
{
    internal class Program
    {

        #region Q7 ProcessPerson
        static void ProcessPerson(Person person)
        {
            person.Greet();
            person.Display();
        }
        #endregion
        static void Main(string[] args)
        {

            #region Q3
            Shape shape = new Shape(2, 3);

            Console.WriteLine(shape.Area());
            // 2*3 => 6

            Cube cube = new Cube(2, 3, 4);
            Console.WriteLine(cube.Area());
            // 2 × 3 × 4 = 24



            Shape shapeRef = new Cube(2, 3, 4);

            Console.WriteLine(shapeRef.Area());
            // 6 , new => Hiding method
            // static binding => Because the method was determined based on the reference type
            #endregion


            #region Q4
            object obj = new Cube(1, 2, 3);

            Console.WriteLine(obj.ToString());
            // (Width = 1, Height = 2)  ,ToString() is virtual by default
            #endregion

            #region Q7
            Person doctor = new Doctor
            {
                ID = 1,
                Name = "Ahmed",
                Age = 35,
                Specialty = "Cardiology"
            };

            ProcessPerson(doctor);


            Person engineer = new Engineer
            {
                ID = 2,
                Name = "Mohamed",
                Age = 30,
                Field = "Software",
                YearsOfExperience = 5
            };

            ProcessPerson(engineer);


            // Greet Compile Time (Static Binding)

            // Display Runtime (Dynamic Binding)
            // Greet() is non-virtual, so it depends on the reference type (Person)
            // Display() is virtual, so it depends on the actual object type in memory (Doctor/Engineer)

            #endregion

            #region Q8
            // Error: CS0115: no suitable method found to override
            #endregion

            #region Q9
            // The Problem: It forces classes to implement methods they don't need
            // Result: NotImplementedException
            // Solution: Split actions into smaller interfaces
            #endregion


            #region َ12
            Car car = new Car();

            car.MoveForward();
            car.MoveBackward();


            Ship ship = new Ship();

            ship.MoveForward();
            ship.MoveBackward();



            Airplane airplane = new Airplane();

            airplane.MoveForward();
            airplane.MoveBackward();
            airplane.MoveUp();
            airplane.MoveDown();



            IMoveable carRef = new Car();

            carRef.MoveForward();
            carRef.MoveBackward();



            IMoveable planeRef = new Airplane();

            planeRef.MoveForward();
            planeRef.MoveBackward();

            // Can you call MoveUp() on planeRef? Why or why not? What reference type would you need?
            // No , compiler error ,  Because the reference type is IMoveable


            #endregion

            #region َ14
            // Can a class implement explicitly? Yes
            // void IMoveable.MoveForward() 

            #endregion

            #region 15
            /*
             Feature               Static Binding(new)      Dynamic Binding(override)     
            Keyword in base          None                     virtual
            Keyword in derived       new                      override
            Resolved at             Compile Time              Runtime
            base reference          Base version              Derived version
            
             */
            #endregion

            #region َ16
            /*
             override (requires virtual): The base class must explicitly allow polymorphism by enabling dynamic binding (V-Table entry).

             new (works anywhere): It simply hides the base method and creates an independent one using static binding, requiring no permission.
             */
            #endregion
        }
    }
}
