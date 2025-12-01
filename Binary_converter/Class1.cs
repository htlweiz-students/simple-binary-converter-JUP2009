namespace Binary_converter;

public class Converter{
    private string Binary;
    private int decimal_number;

    private void read_binary(){
        string ? input = "";
        while(true)
        {
            Console.WriteLine("Binary 1 Ziffer: ");
            input = Console.ReadLine();
            if(input == "1" || input == "0")
            {
                Binary += input;
            }
            else
            {
                break;
            }
        }
        
    }
    public Converter(int type)
    {
        if(type == 1)
        {
            read_binary();
        }else if(type == 2){
            Console.WriteLine("Enter Decimal: ");
            decimal_number = int.Parse(Console.ReadLine());
        }
    }

    public bool binary_check()
    {
        foreach(char n in Binary)
        {
            if(n != '1' && n != '0')
            {
                return false;
            }
        }
        return true;
    }

    public string Convert_to_decimal()
    {
        if(!binary_check()){
            return "NON-Binary Number";
        }
        int cur_decimal = 0;
        double counter = 0;
        char[] reverse = Binary.ToCharArray();
        Array.Reverse(reverse);
        foreach(char n in reverse)
        {
            int current_number = int.Parse(n.ToString());
    
            cur_decimal += current_number * (int)Math.Pow(2, counter);
            counter++;
        
        }
        decimal_number = cur_decimal;
        return cur_decimal.ToString();
    }
    public string Convert_to_binary()
    {
        int decimal_clone = decimal_number;
        
        while(decimal_clone > 0)
        {
            Binary += (decimal_clone%2).ToString();
            decimal_clone /= 2;
        }
        char[] reverse = Binary.ToCharArray();
        Array.Reverse(reverse);
        Binary = new string(reverse);
        return Binary;
    }
}


