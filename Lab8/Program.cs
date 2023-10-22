
using System.Linq;

namespace Lab8
{
    
        internal class Program
   {
        private static Employee empolyee1;

        static void Main(string[] args)
        {
            Employee employee1  = new Employee(4142, "Ragnar", "Male", 774124);
            Employee employee2 = new Employee(3250, "Konrad Von Chilklan", "Female", 121314);
            Employee employee3 = new Employee(8765, "Soufhiejah", "Female", 100000000);
            Employee employee4 = new Employee(7126, "Kurt-Olof", "Male", 89217);
            Employee employee5 = new Employee(8123, "Julius Petrus Angeruds", "Female", 871);

            Stack<Employee> stack = new Stack<Employee>();

            

            stack.Push(employee1);
            stack.Push(employee2);
            stack.Push(employee3);
            stack.Push(employee4);
            stack.Push(employee5);

            //Stack<Employee> stackCopy = new Stack<Employee>(stack);

            foreach (Employee employee in stack)
            {

                Console.Write($"ID:{employee.Id} ");
                Console.Write($"|NAME: {employee.Name} ");
                Console.Write($"|SEX: {employee.Gender} ");
                Console.WriteLine($"|SALARY: {employee.Salary} SEK  ");
                Console.WriteLine($"Objects left in stack {stack.Count} ");
            }
            Console.WriteLine();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine();
            while (stack.Count > 0)
            {
                Employee popEmployee = stack.Pop();

                    Console.Write($"ID:{popEmployee.Id} ");
                    Console.Write($"|NAME: {popEmployee.Name} ");
                    Console.Write($"|SEX: {popEmployee.Gender} ");
                    Console.WriteLine($"|SALARY: {popEmployee.Salary} SEK  ");
                    Console.WriteLine($"Objects left in stack {stack.Count} ");
            }
            stack.Push(employee1);
            stack.Push(employee2);
            stack.Push(employee3);
            stack.Push(employee4);
            stack.Push(employee5);
            Console.WriteLine();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine();



           Employee peekEmployee = stack.Peek();

            Console.WriteLine($"ID:{peekEmployee.Id} |NAME: {peekEmployee.Name} |SEX: {peekEmployee.Gender} |SALARY: {peekEmployee.Salary} SEK ");
            Console.WriteLine($"Objects left in stack {stack.Count} ");
            Console.WriteLine($"ID:{peekEmployee.Id} |NAME: {peekEmployee.Name} |SEX: {peekEmployee.Gender} |SALARY: {peekEmployee.Salary} SEK ");
            Console.WriteLine($"Objects left in stack {stack.Count} ");
            Console.WriteLine();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine();

           
            bool employeeExist = stack.Contains(employee3);

            if ( employeeExist )
            {
               Console.WriteLine("Employee3 finns i Stacken.");
            }









        }
   }
}