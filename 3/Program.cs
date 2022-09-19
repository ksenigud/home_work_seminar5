double[]array =new double [5];
double max =0;
double min =10;
double dif = 0;

void InputArray ()
{
    for (int i=0; i<array.Length;i++)
        array[i]=new Random().Next(1,10)+ new Random().NextDouble();
}



void  MaxMin ()
{
    for (int i=0; i<array.Length;i++)
    
    {
    
        if (array[i]>max)
        max=array[i];

        if (array[i]<min)
        min=array[i];
    
    }
}


InputArray();
Console.WriteLine("Исходный массив данных: "+string.Join(", ",array)+ "]");
MaxMin ();
dif=max-min;
Console.WriteLine("Среднее между max и min = "+dif);