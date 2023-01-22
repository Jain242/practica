


int [] arr = {4,6,3,1,5,1,6,9,8};

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    { System.Console.Write($"{array[i]} ");
        }
    System.Console.WriteLine();

}


void ArraySort(int [] array)
{ 
 int count = array.Length;
for (int i = 0; i < count-1; i++)
{
   int maxindex = i;
    for (int j = i+1; j < count; j++)
    {if (array[j] > array[maxindex]){maxindex = j;}
    }  
    int temp = array[i];
    arr[i]= array[maxindex];
    array[maxindex] = temp;   

}

}


PrintArray(arr);
ArraySort(arr);
PrintArray(arr);