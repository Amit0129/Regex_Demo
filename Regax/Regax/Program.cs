namespace Regax
{
    public class Program
    {
        //A Regex (regular expression)is a parttern that used to check wheater a given strinng matches that pattern.
        //
        static void Main(string[] args)
        {
            Console.WriteLine("1. Regex Exmaple");
            Console.WriteLine("2. Validate Name");
            Console.WriteLine("3. Validate Last Name");
            Console.WriteLine("4. Validate Phone Number");
            RegexEx regexEx = new RegexEx();
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    regexEx.MyRegex();
                    break;
                case 2:
                    Console.WriteLine("Enter First Name");
                    string fName = Console.ReadLine();
                    regexEx.CheckName(fName);
                    break;
                case 3:
                    Console.WriteLine("Enter Last Name");
                    string lName = Console.ReadLine();
                    regexEx.CheckLastName(lName);
                    break;
                case 4:
                    Console.WriteLine("Enter Phone Number");
                    string pNumber = Console.ReadLine();
                    regexEx.MoblieNo(pNumber);
                    break;
                default:
                    break;
            }
            
        }
    }
}