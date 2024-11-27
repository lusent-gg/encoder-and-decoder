using encoder_and_decoder;


char select = keyboard.getkey();

const string filename = "ram.txt";
if (!File.Exists(filename))
{
    using (StreamWriter sw = File.CreateText(filename))
    {



    }

}


string encode = "";

if(select == 'a')
{
    Console.WriteLine("method a or b");
    char get =Console.ReadKey().KeyChar;
    Console.WriteLine("enter  string");
    string Jomle = Console.ReadLine();
   


    if (get == 'a')
    {
        int Test = calculatro.cal();
        encode = calculatro.mainEncoder(Jomle, encode, Test);

    }

    if (get == 'b')
    {
        int Test = calculatro.cal2();
        encode = calculatro.mainEncoder(Jomle, encode, Test);
    }

    File.WriteAllText(filename, encode);
}


if (select == 'b')
{
    Console.WriteLine("method a or b");
    char get = Console.ReadKey().KeyChar;
    
    if (get == 'a')
    {
        int test = calculatro.cal();
        string decode = "";

        string tof;

        tof = File.ReadAllText(filename);

        decode = calculatro.mainDecoder(tof, decode, test);
        Console.WriteLine($"|{decode}|");

    }

    if (get == 'b')
    {
        int test = calculatro.cal2();
        string decode = "";

        string tof;

        tof = File.ReadAllText(filename);

        decode = calculatro.secondDecoder(tof, decode, test);
        Console.WriteLine($"|{decode}|");

    } 


   
}













