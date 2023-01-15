int[] array = {13,4,14,65,4,23,13,34};

int n = array.Length;
int find = 4;

int index = 0;
while (index < n )
{
    if (array[index] == find){
        System.Console.WriteLine(index);
    break;
    }
    index++;
}