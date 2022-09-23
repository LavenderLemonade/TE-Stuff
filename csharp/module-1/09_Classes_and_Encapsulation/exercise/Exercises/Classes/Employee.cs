namespace Exercises.Classes
{
    public class Employee
    {
        public int EmployeeId { get; private set; }

        public string FirstName { get; private set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return $"{LastName}, {FirstName}";
                
            }
 
        }
        public string Department { get; set; }
        public double AnnualSalary { get; private set; }


        public Employee(int employeeId, string firstName, string lastName, double salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.AnnualSalary = salary;
            this.EmployeeId = employeeId;
        }

        public void RaiseSalary(double percent)
        {
            double increase = (AnnualSalary) * (percent/100);
            AnnualSalary += increase;
            
        }








    }





}
