﻿using System;
class Pograma
{
    static void Main(string[] arg)
    {
        double salario = 4000.0;

        if(salario >= 1900.0 && salario <= 2800.0)
        {
            Console.WriteLine("o IR é de 7.5% e pode deduzir na declaração o valor de R$ 142");
        }
        else if(salario >= 2800.01 && salario <= 3751.0)
        {
            Console.WriteLine("o IR é de 15% e pode deduzir R$ 350");
        }
        else if(salario >= 3751.01 && salario <= 4664.00)
        {
            Console.WriteLine("o IR é de 22.5% e pode deduzir R$ 636");
        }
    }
}
