
namespace Lab8
{
    
        internal class Program
   {
        static void Main(string[] args)
        {
            Employee empolyee1 = new Employee(4142, "Ragnar", "Male", 774124);
            Employee empolyee2 = new Employee(3250, "Konrad Von Chilklan", "Female", 121314);
            Employee empolyee3 = new Employee(8765, "Soufhiejah", "Female", 100000000);
            Employee empolyee4 = new Employee(7126, "Kurt-Olof", "Male", 89217);
            Employee empolyee5 = new Employee(8123, "Julius Petrus Angeruds", "Female", 871);

            Stack<Employee> stack = new Stack<Employee>();

            

            stack.Push(empolyee1);
            stack.Push(empolyee2);
            stack.Push(empolyee3);
            stack.Push(empolyee4);
            stack.Push(empolyee5);

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
            stack.Push(empolyee1);
            stack.Push(empolyee2);
            stack.Push(empolyee3);
            stack.Push(empolyee4);
            stack.Push(empolyee5);
            Console.WriteLine();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine();



           Employee peekEmployee = stack.Peek();

            Console.WriteLine($"ID:{peekEmployee.Id} |NAME: {peekEmployee.Name} |SEX: {peekEmployee.Gender} |SALARY: {peekEmployee.Salary} SEK ");
            Console.WriteLine($"Objects left in stack {stack.Count} ");
            Console.WriteLine($"ID:{peekEmployee.Id} |NAME: {peekEmployee.Name} |SEX: {peekEmployee.Gender} |SALARY: {peekEmployee.Salary} SEK ");
            Console.WriteLine($"Objects left in stack {stack.Count} ");








        }
   }
}