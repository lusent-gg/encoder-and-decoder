
namespace encoder_and_decoder;

class keyboard
{

    public static char getkey()
    {
        char b;

        Console.Clear();
        Console.WriteLine("a_encode");
        Console.WriteLine("b_decode");
        

        b = Console.ReadKey().KeyChar;
        Console.Clear();
        return b;



    }


    public static string getnames()
    {


        
        string y = Console.ReadLine();
        

        return y;
    }



    
    

}