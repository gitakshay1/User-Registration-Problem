namespace User_Registration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome User Regidtrsion \n1 Enter First Name \n2 Enter Last Name" +
                "\n3 Enter Email Id \n4 Enter Mobile Number");
            int Choice=Convert.ToInt32(Console.ReadLine());
            switch(Choice)
            {
                case 1:
                    First_Name first_Name=new First_Name();
                    first_Name.FirstName();
                    break;
                case 2:
                    Last_Name last_Name = new Last_Name();
                    last_Name.Lastname();
                    break;
                case 3:
                    Email_Id email_Id = new Email_Id();
                    email_Id.EmailId();
                    break;
                case 4:
                    Mobile_Number mobile_Number = new Mobile_Number();
                    mobile_Number.MobileNumber();
                    break;
                default:
                    Console.WriteLine("Enter valid choice");
                    break;
            }
        }
    }
}   
