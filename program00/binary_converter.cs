using System.Data.SqlTypes;

namespace binary_converter;
public class converter{
    private string Binary;

    public converter(string CBinary){
        Binary = CBinary;
    }

    public bool binary_check(){
        foreach(char n in Binary){
            if(n != '1' && n != '0'){
                return false;
            }
        }
        return true;
    }

    public string convert_to_decimal(){
        char[] ? DBinary;
        int counter = 0;
        foreach(char n in Binary){
            DBinary[counter] = (Binary[counter] * square(counter, 2)).ToString();
            counter++;
        }
        
        return DcBinary;
    }

    public int square(int number, int Exponent){
        int result = number;
        for(int i = 0; i < Exponent; i++){
            result = result * number;
        }
        return result;
    }
}

