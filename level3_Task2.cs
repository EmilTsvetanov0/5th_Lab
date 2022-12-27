using System;
class HelloWorld{
    delegate void Sorting(int l, int r, int row, double[,] a);
    static Random rnd = new Random();
    static void Qsort(int l, int r, int row, double[,] a){
        if((r-l)<=1) return;
        double tmp;
        double pivot = a[row, l+rnd.Next()%(r-l)];
        int m=l;
        for(int i=l; i<r; i++)
            if(a[row,i]<pivot){
                tmp=a[row,i];
                a[row,i] = a[row,m];
                a[row,m] = tmp;
                m++;
            }
        int p=l,q=l;
        for(;a[row,p]<pivot;p++);
        for(;q<a.GetLength(1)&&a[row,q]<=pivot;q++);
        Qsort(l,p,row,a);
        Qsort(q,r,row,a);
    }
    
    static void F(double[,] a){
        Sorting qsort = Qsort;
        for(int i=0; i<a.GetLength(0); i++){
            qsort(0,a.GetLength(1),i,a);
            if(i%2==1){
                for(int j=0; j<a.GetLength(1)/2; j++) a[i,j]=a[i,j]+a[i,a.GetLength(1)-j-1]-(a[i,a.GetLength(1)-j-1]=a[i,j]);
            }
        }
    }
    static void Main (){
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
        Console.Write("There is your random matrix:\n");
        double[,] a = new double[n,m];
        Random rnd = new Random();
        for(int i=0; i<n; i++){
            for(int j=0; j<m; j++){
                a[i,j] = rnd.Next()%10;
                Console.Write($"{a[i,j]} ");
            }
            Console.WriteLine();
        }
        
        F(a);
        
        Console.WriteLine("There is your answer matrix:");
        for(int i=0; i<n; i++){
            for(int j=0; j<m; j++){
                Console.Write($"{a[i,j]} ");
            }
            Console.WriteLine();
        }
    }
}
