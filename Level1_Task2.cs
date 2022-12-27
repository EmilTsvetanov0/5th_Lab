using System;
class HelloWorld {
    static double S(double a, double b, double c){
        double p = (a+b+c)/2;
        return Math.Sqrt(p*(p-a)*(p-b)*(p-c));
    }
    static void Main() {
        double a,b,c,S1,S2;
        bool input = false;
        Console.Write("Enter a,b,c for the first triangle: ");
        input = double.TryParse(Console.ReadLine(),out a);
        while(!input){
            Console.Write("Wrong input, try again: ");
            input = double.TryParse(Console.ReadLine(),out a);
        }
        input = double.TryParse(Console.ReadLine(),out b);
        while(!input){
            Console.Write("Wrong input, try again: ");
            input = double.TryParse(Console.ReadLine(),out b);
        }
        input = double.TryParse(Console.ReadLine(),out c);
        while(!input){
            Console.Write("Wrong input, try again: ");
            input = double.TryParse(Console.ReadLine(),out c);
        }
        S1 = S(a,b,c);
        Console.Write("Enter a,b,c for the second triangle: ");
        input = double.TryParse(Console.ReadLine(),out a);
        while(!input){
            Console.Write("Wrong input, try again: ");
            input = double.TryParse(Console.ReadLine(),out a);
        }
        input = double.TryParse(Console.ReadLine(),out b);
        while(!input){
            Console.Write("Wrong input, try again: ");
            input = double.TryParse(Console.ReadLine(),out b);
        }
        input = double.TryParse(Console.ReadLine(),out c);
        while(!input){
            Console.Write("Wrong input, try again: ");
            input = double.TryParse(Console.ReadLine(),out c);
        }
        S2 = S(a,b,c);
        Console.Write($"S1 = {S1}\nS2 = {S2}");
    }
}
