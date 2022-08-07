// Имеется одномерный массив array из n элементов, требуется найти элемент массива, равный find
int [] array = {1, 6, 69, 67, 5, 50, 67, 4, 66};

int n = array.Length;
int find = 67;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
