// Задача 3: Напишите программу, которая выводит
// массив из 8 элементов, заполненный нулями и
// единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

void arr(int num)
{
    int[] array = new int[num];
    for(int i=0; i < num; i++)
    {
        array[i]=new Random().Next(0, 2);
        Console.Write($"{array[i]} ");
    }
}
arr(8);

дз:
//int [] EightMass()
//{
//    return arr;
//}

//void Print(int[] arr)
//{

//}

//int arr_1 = EightMas();
//Print(arr_1);


