

using System;

namespace encoder_and_decoder;

internal class ENCODE
{
    public static int encoderver1()
    {
        int num = 0;
        Console.WriteLine("\nname of the sender");
        string sendername = keyboard.getnames();
        int sender = stringtonum.stringer(sendername, num);

        Console.WriteLine("name of the geter");
        string getername = keyboard.getnames();
        int geter = stringtonum.stringer(getername, num);

        

        int sum = sender + geter;

        return sum;
    }

    public static int encoderver2()
    {
        int num = 0;
        Console.WriteLine("name of the sender");
        string sendername = keyboard.getnames();
        int sender = stringtonum.stringer(sendername, num);

        Console.WriteLine("name of the geter");
        string getername = keyboard.getnames();
        int geter = stringtonum.stringer(getername, num);

        int sum = (geter * sender)/(geter + sender);

        //Console.WriteLine($"geter {geter}sender {sender}sum {sum}");
        return sum;
    }


   



}
