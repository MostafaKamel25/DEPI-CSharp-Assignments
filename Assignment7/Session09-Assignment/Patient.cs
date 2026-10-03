using System;
using System.Collections.Generic;
using System.Text;

namespace Session09_Assignment
{

    public class Patient(int Id, string FullName, string PhoneNumber, string MedicalHistory)
    {
        public int Id { get; } = Id;
        public string FullName { get; } = FullName;
        public string PhoneNumber { get; } = PhoneNumber;
        public string MedicalHistory { get; } = MedicalHistory;

        public override string ToString()
        {
            return $"Id: {Id} :: FullName: {FullName} :: PhoneNumber: {PhoneNumber} :: MedicalHistory: {MedicalHistory}";
        }
    }


    public record PatientDto(int Id, string FullName, string PhoneNumber);

}
