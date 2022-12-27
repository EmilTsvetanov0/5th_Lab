using System;
class HelloWorld {
    static void DeleteColumn(ref double[,] a, int index){
        int counter = 0, n=a.GetLength(0), m=a.GetLength(1);
        double[,] b = new double[n,m-1];
        for(int i=0; i<a.GetLength(0); i++){
            counter=0;
            for(int j=0; j<a.GetLength(1); j++){
                if(j!=index){
                    b[i,counter++]=a[i,j];
                }
            }
        }
        a=b;
    }
    static void Main() {
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
        
        int maxX=0, maxY=0, minX=0, minY=0;
        for(int i=0; i<a.GetLength(0); i++){
            for(int j=0; j<a.GetLength(1); j++){
                if(a[maxX,maxY]<a[i,j]&&j<=i){
                    maxX=i;
                    maxY=j;
                }
                if(a[minX,minY]>a[i,j]&&j>i){
                    minX=i;
                    minY=j;
                }
            }
        }
        DeleteColumn(ref a, maxY);
        if(minY!=maxY){
            minY=(minY>maxY)?minY-1:minY;
            DeleteColumn(ref a, minY);
        }
        
        Console.WriteLine("Answer matrix:");
        for(int i=0; i<a.GetLength(0); i++){
            for(int j=0; j<a.GetLength(1); j++){
                Console.Write($"{a[i,j]} ");
            }
            Console.WriteLine();
        }
    }
}
