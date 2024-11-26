namespace encoder_and_decoder;

internal class Decode
{


    public static int decoderver1()
    {
        int num = 0;
        Console.WriteLine("name of the sender");
        string sendername = keyboard.getnames();
        int sender = stringtonum.stringer(sendername, num);

        Console.WriteLine("name of the geter");
        string getername = keyboard.getnames();
        int geter = stringtonum.stringer(getername, num);

        Console.WriteLine($"{sender}, {geter}");

        int sum = sender - geter;

        return sum;
    }

    public static int decoderver2()
    {
        int num = 0;
        Console.WriteLine("name of the sender");
        string sendername = keyboard.getnames();
        int sender = stringtonum.stringer(sendername, num);

        Console.WriteLine("name of the geter");
        string getername = keyboard.getnames();
        int geter = stringtonum.stringer(getername, num);

        int sum = (sender / geter ) * (sender - geter);

        //Console.WriteLine($"geter {geter}sender {sender}sum {sum}");
        return sum;
    }


    public static string mainencoder(string jomle, string encode, int cal)

    {
        for (int I = jomle.Length; I > 0; I--)
        {

            int charcode = (int)jomle[I - 1];
            int calcolator = ((charcode + cal) % 122) + 64;





            char character = (char)calcolator;

            encode += character;


            if (I == 1)
            {

                return encode;

            }
        }
        return encode;

    }

}


