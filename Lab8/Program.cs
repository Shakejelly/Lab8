
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
           
            foreach (Employee employee in stack) 
            {
                
            }
            
        }
    }
}