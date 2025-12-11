namespace Binary_converter;

public class Converter{
    private string Binary;
    private int decimal_number;

/// <summary>
/// reads the binary Number and saves it in Binary
/// </summary>
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
    /// <summary>
    /// the Constructor for this class (reads in a type(1=binary; 2 = Decimal))
    /// </summary>
    /// <param name="type">which numbersystem you want to read</param>
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

/// <summary>
/// checks if the number is binary
/// </summary>
/// <returns>returns true if the number is binary</returns>
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

/// <summary>
/// Converts the binary string into a decimal string
/// </summary>
/// <returns>The string in decimal</returns>
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
    /// <summary>
    /// Converts a decimal into binary
    /// </summary>
    /// <returns>the binary number in string</returns>
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
/// <summary>
/// prints the decimal
/// </summary>
/// <returns>A string with the decimal number in it</returns>
    public string print_decimal(){
        return $"{decimal_number}";
    }
/// <summary>
/// prints the binary
/// </summary>
/// <returns>returns a string with the binary in it</returns>
    public string print_binary(){
        return Binary;
    }
}


