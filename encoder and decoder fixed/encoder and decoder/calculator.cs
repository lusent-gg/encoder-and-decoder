

using System.Diagnostics.Metrics;
using System.Reflection;

namespace encoder_and_decoder;

internal class calculatro
{

    public static int cal()
    {
        int sum = ENCODE.encoderver1();

        int cal = sum % 64;


        return cal;
    }

    public static int decal()
    {
        int sum = Decode.decoderver2();

        int cal = sum % 64;


        return cal;
    }

    public static int cal2()
    {
        int sum = ENCODE.encoderver2();

        int cal = sum % 64;


        return cal;


    }




    public static string mainEncoder(string jomle, string encode, int cal)

    {
        for (int I = jomle.Length; I > 0; I--)
        {

            int charcode = (int)jomle[I - 1];
            int calcolator = 64 + ((charcode + cal) % 122) ;

         
           
            char character = (char)calcolator;

            encode += character;


            if (I == 1)
            {
                
                return encode;

            }
        }
        return encode;
    }

    public static string mainDecoder(string encode, string decoded, int cal)
    {
        for (int I = encode.Length; I > 0; I--)
        {
            int charcode = (int)encode[I - 1]; 
            int originalCharCode = (charcode - cal - 64 +122) % 122; 

           
            if (originalCharCode < 65)
            {
                originalCharCode += 57; 
            }

            char originalChar = (char)originalCharCode;

           
            decoded += originalChar;
        }
       
        return decoded;
    }

    public static string secondDecoder(string encode, string decoded, int cal)
    {
        for (int I = encode.Length; I > 0; I--)
        {
            int charcode = (int)encode[I - 1];

            

            int originalCharCode = (charcode - cal - 64 + 122) % 122;
            

            if (originalCharCode < 65)
            {
                originalCharCode += 64;
            }

            char originalChar = (char)originalCharCode;


            decoded += originalChar;
        }

        return decoded;
    }

}
/*
        abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ

        
        27 IS [
        28 IS \
        29 IS ]
        30 IS ^
        31 IS _
        32 IS `
hjkl;'\][ponM,./kl:"|\
*/