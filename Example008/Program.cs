int Max(int arg1, int arg2, int arg3){
    int result = arg1;
    if (result<arg2) result = arg2;
    if (result<arg3) result = arg3;
     return result;
}

int a1 = 23;
int b1 = 34;
int c1 = 43;
int a2 = 42;
int b2 = 31;
int c2 = 899;
int a3 = 27;
int b3 = 32;
int c3 = 90;


int max1 = Max(a1,b1,c1);
int max2 = Max(a2,b2,c2);
int max3 = Max(a3,b3,c3);
int max = Max(max1,max2,max3);



System.Console.WriteLine(max);