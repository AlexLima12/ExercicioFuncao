﻿using System;
using System.IO;
namespace ExercicioFuncao
{
    class Program
    {
        static void Main(string[] args)
        {
        string[] perguntas = File.ReadAllLines(@"C:\Users\FIC\Desktop\ALEX\ExercicioFuncao\perguntas.txt");
            string[] respostas = new string[perguntas.Length];

            
            string continuar = "s";

             while(continuar == "s"){
                GravarDados(perguntas, respostas);
             System.Console.WriteLine("Gostaria de cadastrar mais alguém? Digite s para continuar...");   
             continuar = Console.ReadLine();
                                    }
                         
        }
            static void GravarDados(string[] perguntas, string[] respostas){

            
            StreamWriter rp = new StreamWriter(@"C:\Users\FIC\Desktop\ALEX\ExercicioFuncao\respostas.csv", true);
            

            for(int i = 0; i<perguntas.Length; i++)
            {
                System.Console.WriteLine("Qual " + perguntas[i] + ": ");
                respostas[i] = Console.ReadLine();
                rp.Write(respostas[i] + ";");                
             };
             rp.WriteLine();
             rp.Close();

                                                                                          }
           
    
   /* bool UmMaioDois = 1 > 2;

            if (UmMaioDois)
            {
                System.Console.WriteLine("1 é maior que dois");
            }
            else
                System.Console.WriteLine("2 é maior");
            
ARRAY
            int[] idades = new int[5];
            idades[0] = 1;
            idades[1] = 22;
            idades[2] = 23;

            for(int i = 0; i < idades.Length; i++)
            {
                System.Console.WriteLine(idades[i]);
            }
            */

        //   mostrar dados
            

        
    }
}
