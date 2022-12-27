using System;
class HelloWorld {
    static void del(ref double[] a, int index){
        for(int i=index; (i+1)<a.Length; i++)
            a[i]=a[i+1];
        if(a.Length!=0)
            Array.Resize(ref a, a.Length-1);
    }
    static void Main() {
        double[] a = new double[7]{3,1,4,1,5,9,2}, b = new double[8]{6,5,3,5,8,9,7,9};
        int maxA=0,maxB=0;
        for(int i=1; i<a.Length; i++){
            if(a[maxA]<a[i])
                maxA=i;
        }
        for(int i=1; i<b.Length; i++){
            if(b[maxB]<b[i])
                maxB=i;
        }
        del(ref a, maxA);
        del(ref b, maxB);
        Array.Resize(ref a, a.Length+b.Length);
        for(int i=a.Length-b.Length; i<a.Length; i++){
            a[i]=b[i-(a.Length-b.Length)];
        }
        Console.Write("There is your array:");
        foreach(var i in a)
            Console.Write($" {i}");
    }
}
