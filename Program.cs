internal class Program
{
    public delegate void Great (bool isSingIn);

    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;// console yozuvlariga rang berish
        Console.WriteLine("Sariq rangda chiqadi console yozuvlar");
        Console.WriteLine();
        Thread.Sleep(3000);// 3 sekund console qotib turadi
        Console.ForegroundColor= ConsoleColor .Green;//yangi rang urnatish
        Console.WriteLine("Yashil rang urnatildi");
        Console.WriteLine();
       // Console.ResetColor();// consoleni dastlabgi holatiga qaytarish white and black

        Console.BackgroundColor = ConsoleColor.Red;// console orqa foniga rang berish
        Console.WriteLine("hello world , this is  a red color");

    }


    
}