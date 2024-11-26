

namespace encoder_and_decoder;

internal class stringtonum
{
    public static int stringer(string jomle , int num)
    {
        
        
        for ( int I = jomle.Length ; I > 0; I--)
        {
            
            int charcode = (int)jomle[I-1] - 64;

            

            num += charcode;

            if (I == 1)
            {
                
                return num;

            }
        }

        return 0;


         
       
    }


}
