// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.


 static void Print2(object[] arr)
    {
     if (arr.Length == 0) return;
        else
        {
            Console.Write(" " + arr[0]);
            Print2(arr.Skip(1).ToArray());
        }
      
    }
void PrintNumbers(int M, int N)
{
if(M > N) return;
PrintNumbers(M + 1, N);
Console.Write(M + " ");
}
PrintNumbers(1,7);
