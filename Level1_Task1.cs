using System;
class HelloWorld {
    static int C(int n, int k){
        int prod=1, tmp=1;
        for(int i=1; i<=n; i++){
            prod*=i;
            if(i==k||i==(n-k)){
                tmp*=prod;
                if(k==(n-k))
                    tmp*=prod;
            }
        }
        return prod/tmp;
    }
    static void Main() {
        int team = 5;
        int[] options = new int[3]{8,10,11};
        foreach(int people in options)
            Console.WriteLine($"Unique teams made of {team} people chosen from {people}: {C(people,team)}");
    }
}
