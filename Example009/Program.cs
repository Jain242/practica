﻿int Max(int arg1, int arg2, int arg3){
    int result = arg1;
    if (result<arg2) result = arg2;
    if (result<arg3) result = arg3;
     return result;
}

int[] array = {13,24,54,65,232,12,87,22,42};


int max = Max(Max(array[0],array[1],array[2]),
Max(array[3],array[4],array[5]),
Max(array[6],array[7],array[8])
);

System.Console.WriteLine(max);