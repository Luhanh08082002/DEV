
using LAP_TUAN1;
using System;

class Program
{
   public static void Main(string[] args)
    {
        equaton e = new equaton();
        Console.ReadLine(e)
        Console.WriteLine("nhap so nguyen A :");
        int A = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("nhap so nguyen B :");
        int B = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("nhap toan tu (+-*/) :");
            char operatorSymbol = Convert.ToChar(Console.ReadLine());

        double result = 0;
        switch (operatorSymbol)
        { 
            case '+':
                result = A + B; 
                break;
            case '-':
                result = A - B;
                break;
            case '*':
                result = A * B;
                break;
             case '/':
                if (B != 0)
                {
                    result = A / B;
                }
                else{
                    Console.WriteLine("loi thong tin nhap vao , B khong duoc bang 0");
                    return;
                }
                break;
            default:
                Console.WriteLine("loi toan tu khong hop le");
                return;
        }
        Console.WriteLine("ket qua toan tu " + A + operatorSymbol + B + " = " + result);
        Console.ReadLine(); 




    }
}