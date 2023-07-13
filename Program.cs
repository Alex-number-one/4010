int j = 0;
int size = 10;
int [] M = new int [size]; 
for (int i = 0; i < size; i++ )
{
M [i] = Convert.ToInt32(Console.ReadLine());
    if (M [i] > 0) 
    {
j++;
    }

}
   Console.Write($"{string.Join(", ", M)}");
   Console.Write(" -> " + j);