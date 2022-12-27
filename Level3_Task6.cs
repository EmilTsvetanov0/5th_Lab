using System;
class HelloWorld {
    delegate int DiagMax(double[,] a);
    delegate int FirstRowMax(double[,] a);
    
    static int MaxInDiag(double[,] a){
        int max=0;
        for(int i=0; i<a.GetLength(0); i++){
            if(a[max,max]<a[i,i]){
                max=i;
            }
        }
        return max;
    }
    
    static int MaxInFirstRow(double[,] a){
        int max=0;
        for(int i=0; i<a.GetLength(1); i++){
            if(a[0,max]<a[0,i]){
                max=i;
            }
        }
        return max;
    }
    
    static void SwapColumns(double[,] a, int first, int second){
        for(int i=0; i<a.GetLength(0); i++)
            a[i,first] = a[i,first] + a[i,second] - (a[i,second]=a[i,first]);
    }

    static void Main() {
        FirstRowMax max2 = MaxInFirstRow;
        DiagMax max1 = MaxInDiag;
        int n;
        bool input = false;
        Console.Write("Enter n: ");
        input = int.TryParse(Console.ReadLine(),out n);
        while(!input){
            Console.Write("Wrong input, try again: ");
            input = int.TryParse(Console.ReadLine(),out n);
        }
        double[,] a = new double[n,n];
        Random rnd = new Random();
        for(int i=0; i<a.GetLength(0); i++){
            for(int j=0; j<a.GetLength(1); j++){
                a[i,j] = rnd.Next()%10;
            }
        }
        
        for(int i=0; i<a.GetLength(0); i++){
            for(int j=0; j<a.GetLength(1); j++){
                Console.Write($"{a[i,j]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        
        int row1 = max1(a), row2 = max2(a);
        SwapColumns(a,row1,row2);
        
        Console.WriteLine("Answer matrix:");
        for(int i=0; i<a.GetLength(0); i++){
            for(int j=0; j<a.GetLength(1); j++){
                Console.Write($"{a[i,j]} ");
            }
            Console.WriteLine();
        }
    }
}
