namespace User_Registration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome User Regidtrsion \n1 To Enter First Name");
            int Choice=Convert.ToInt32(Console.ReadLine());
            switch(Choice)
            {
                case 1:
                    First_Name first_Name=new First_Name();
                    first_Name.FirstName();
                    break;
                default:
                    Console.WriteLine("Enter valid choice");
                    break;
            }
        }
    }
}   
