namespace Session09_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 1 - Primary Constructor & Records

            // Q2
            Patient patient01 = new Patient(
                1,
                "Ahmed Ali",
                "01012345678",
                "Diabetes"
            );

            Patient patient02 = new Patient(
                1,
                "Ahmed Ali",
                "01012345678",
                "Diabetes"
            );

            Console.WriteLine("Q2: Patient Class: ");

            Console.WriteLine(patient01);
            Console.WriteLine(patient02);

            Console.WriteLine($"Patient01 HashCode: {patient01.GetHashCode()}");
            Console.WriteLine($"Patient02 HashCode: {patient02.GetHashCode()}");

            // Patient is a normal class, so patient01 and patient02
            // are two different objects in memory
            // Therefore, their default equality is reference-based
            Console.WriteLine($"Equals: {patient01.Equals(patient02)}");

            // Both variables now reference the same object.
            patient01 = patient02;

            Console.WriteLine($"After assignment Equals: {patient01.Equals(patient02)}");

            // Q3
            PatientDto patientDto01 = new PatientDto(
                1,
                "Ahmed Ali",
                "01012345678"
            );

            PatientDto patientDto02 = new PatientDto(
                1,
                "Ahmed Ali",
                "01012345678"
            );

            Console.WriteLine("\n===== Q3: PatientDto Record =====");

            Console.WriteLine($"PatientDto01 HashCode: {patientDto01.GetHashCode()}");
            Console.WriteLine($"PatientDto02 HashCode: {patientDto02.GetHashCode()}");

            Console.WriteLine($"Equals: {patientDto01.Equals(patientDto02)}");

            /*
             * Difference:
             * Class uses reference equality by default.
             * Record uses value-based equality.
             * So two records with the same values are considered equal.
             */

            // Q4
            Patient patientForMapping = new Patient(
                2,
                "Sara Mohamed",
                "01111111111",
                "Heart Disease"
            );

            PatientDto mappedPatient =
                PatientMapper.MapFromModelToDto(patientForMapping);

            Console.WriteLine("\n===== Q4: Patient Mapper =====");
            Console.WriteLine(mappedPatient);

            #endregion


            #region Part 2 - Singleton

            Console.WriteLine("\n===== Q6: Singleton =====");

            AppLogger logger01 = AppLogger.GetLogger();
            AppLogger logger02 = AppLogger.GetLogger();
            AppLogger logger03 = AppLogger.GetLogger();
            AppLogger logger04 = AppLogger.GetLogger();

            Console.WriteLine(logger01.GetHashCode());
            Console.WriteLine(logger02.GetHashCode());
            Console.WriteLine(logger03.GetHashCode());
            Console.WriteLine(logger04.GetHashCode());

            /*
             * All hash codes are the same because GetLogger()
             * creates the AppLogger object only on the first call.
             * Every later call returns the same instance.
             */

            #endregion


            #region Part 3 - var & dynamic

            Console.WriteLine("\n===== Q7: var & dynamic =====");

            // Target-typed new:
            Patient p = new(
                3,
                "Omar Hassan",
                "01222222222",
                "Asthma"
            );

            Console.WriteLine(p);

            // var: the compiler determines the type at compile time.
            var patientUsingVar = new Patient(
                4,
                "Mona Ali",
                "01555555555",
                "Allergy"
            );

            Console.WriteLine(patientUsingVar);

            // dynamic: the type is resolved at run time.
            dynamic patientUsingDynamic = new Patient(
                5,
                "Khaled Ahmed",
                "01099999999",
                "Flu"
            );

            Console.WriteLine(patientUsingDynamic);

            /*
             * var:
             * The type is determined at compile time and cannot change.
             *
             * dynamic:
             * The type is resolved at run time, so type checking
             * for operations happens at run time.
             */

            #endregion


            #region Part 4 - Anonymous Types

            Console.WriteLine("\n===== Q8: Anonymous Types =====");

            var doctor01 = new
            {
                Name = "Sara",
                Specialty = "Cardiology",
                ExperienceYears = 8,
                Salary = 25_000
            };

            var doctor02 = new
            {
                Name = "Sara",
                Specialty = "Cardiology",
                ExperienceYears = 8,
                Salary = 25_000
            };

            Console.WriteLine($"Name: {doctor01.Name}");
            Console.WriteLine($"Specialty: {doctor01.Specialty}");

            Console.WriteLine(
                $"Doctor01 HashCode: {doctor01.GetHashCode()}"
            );

            Console.WriteLine(
                $"Doctor02 HashCode: {doctor02.GetHashCode()}"
            );

            Console.WriteLine($"Type: {doctor01.GetType()}");

            Console.WriteLine(
                $"Equals: {doctor01.Equals(doctor02)}"
            );

            Console.WriteLine(
                $"ToString: {doctor01}"
            );

            /*
             * Anonymous types with the same property names,
             * types, and values use value-based equality.
             *
             * A normal class uses reference equality by default.
             *
             * A record also uses value-based equality.
             *
             * Therefore anonymous types behave similarly to records
             * regarding equality of their values.
             */

            #endregion


            #region Part 5 - Extension Methods

            Console.WriteLine("\n Q10: Extension Methods: ");

            Console.WriteLine(
                $"IsShorterThan: {"Stethoscope".IsShorterThan(5)}"
            );

            Console.WriteLine(
                $"Repeat: {"Ab".Repeat(4)}"
            );

            #endregion
        }
    }
    
}
