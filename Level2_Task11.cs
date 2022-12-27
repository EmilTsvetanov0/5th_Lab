using System;
class HelloWorld {
    static int[] MaxElement(double[,] a){
        int[] max = new int[2]{0,0};
        for(int i=0; i<a.GetLength(0); i++){
            for(int j=0; j<a.GetLength(1); j++){
                if(a[max[0],max[1]]<a[i,j]){
                    max[0]=i;
                    max[1]=j;
                }
            }
        }
        return max;
    }
    static void Main() {
        int n,m;
        bool input = false;
        Console.Write("Enter n for the first matrix: ");
        input = int.TryParse(Console.ReadLine(),out n);
        while(!input){
            Console.Write("Wrong input, try again: ");
            input = int.TryParse(Console.ReadLine(),out n);
        }
        Console.Write("Enter m for the first matrix: ");
        input = int.TryParse(Console.ReadLine(),out m);
        while(!input){
            Console.Write("Wrong input, try again: ");
            input = int.TryParse(Console.ReadLine(),out m);
        }
        double[,] a = new double[n,m];
        Random rnd = new Random();
        for(int i=0; i<n; i++){
            for(int j=0; j<m; j++){
                a[i,j] = rnd.Next()%10;
            }
        }
        
        Console.WriteLine("Your random matrix:");
        for(int i=0; i<n; i++){
            for(int j=0; j<m; j++){
                Console.Write($"{a[i,j]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        
        Console.Write("Enter n for the second matrix: ");
        input = int.TryParse(Console.ReadLine(),out n);
        while(!input){
            Console.Write("Wrong input, try again: ");
            input = int.TryParse(Console.ReadLine(),out n);
        }
        Console.Write("Enter m for the second matrix: ");
        input = int.TryParse(Console.ReadLine(),out m);
        while(!input){
            Console.Write("Wrong input, try again: ");
            input = int.TryParse(Console.ReadLine(),out m);
        }
        double[,] b = new double[n,m];
        for(int i=0; i<n; i++){
            for(int j=0; j<m; j++){
                b[i,j] = rnd.Next()%20;
            }
        }
        
        Console.WriteLine("Your another random matrix:");
        for(int i=0; i<n; i++){
            for(int j=0; j<m; j++){
                Console.Write($"{b[i,j]} ");
            }
            Console.WriteLine();
        }
        
        
        int[] maxA = new int[2], maxB = new int[2];
        maxA = MaxElement(a);
        maxB = MaxElement(b);
        double tmp = a[maxA[0],maxA[1]];
        a[maxA[0],maxA[1]] = b[maxB[0],maxB[1]];
        b[maxB[0],maxB[1]] = tmp;
        
        Console.WriteLine("Your matrix A:");
        for(int i=0; i<a.GetLength(0); i++){
            for(int j=0; j<a.GetLength(1); j++){
                Console.Write($"{a[i,j]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("\nYour matrix B:");
        for(int i=0; i<b.GetLength(0); i++){
            for(int j=0; j<b.GetLength(1); j++){
                Console.Write($"{b[i,j]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
