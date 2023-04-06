int[,] A = new int[2,3];
int[,] B = new int[3,4];
int[,] C = new int[2,4];
// Заполняем Матрицу А
Console.WriteLine("Матрица А: ");
for (int i = 0; i < A.GetLength(0); i++)
{
   for (int j = 0; j < A.GetLength(1); j++)
   {
      A[i,j]=new Random().Next(0,10);
      Console.Write(A[i,j]+" ");
   }
   Console.WriteLine();
}
// Заполняем Матрицу В
Console.WriteLine("Матрица B: ");
for (int i = 0; i < B.GetLength(0); i++)
{
   for (int j = 0; j < B.GetLength(1); j++)
   {
      B[i,j]=new Random().Next(0,10);
      Console.Write(B[i,j]+" ");
   }
Console.WriteLine();
}
Console.WriteLine("Матрица C: ");

for (int i = 0; i < C.GetLength(0); i++)
{
   for (int j = 0; j < C.GetLength(1); j++)
   {
       for (int k = 0; k < B.GetLength(0); k++)
       {
           C[i,j] += A[i,k]*B[k,j];
       }
       
       Console.Write(C[i,j]+" ");
   }
Console.WriteLine();
}