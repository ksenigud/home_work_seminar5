void InputArray (int[]array)// процедура, которая будет заполнять наш масив
{
    for (int i=0; i<array.Length;i++)
        array[i]=new Random().Next(100,1000);
}

int  EvenNumber (int[]array)
{
   int summa =0;
    for (int i=0; i<array.Length;i++)
    
    if (array[i] %2 ==0)
    summa+=array[i];

    return summa;
}


int[]arr =new int [5];
InputArray(arr);
Console.WriteLine("Исходный массив данных: "+string.Join(", ",arr)+ "]");
Console.WriteLine(EvenNumber(arr));