﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int [m, n];
// Random rnd = new Random();
// double [,] A = new double [m,n];
for (int i = 0; i < m; i++){
    for (int j = 0; j < n; j++){
        matrix[i, j] = new Random().Next(-100, 100);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine(); 
}