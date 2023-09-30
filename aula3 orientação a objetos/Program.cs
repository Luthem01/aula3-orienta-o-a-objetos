using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using agrupamento_notas;

namespace info_alunos;

public class Program
{
    
    
    public static void Main(string[] args)
    {
        
        

        matematicaAlunos alunos = new ();
        alunos.nome = "Luthemberg";
        matematicaAlunos matricula = new ();
        alunos.matricula = "1347";

        matematicaAlunos notas = new()
        {
            nota1 = 8.5,
            nota2 = 7.5,
            trabalhoAluno = 6
        };
        
        

        Console.WriteLine( alunos.nome );        
        Console.WriteLine( alunos.matricula );
        Console.WriteLine(notas.media().ToString("0.00"));

    }

    
}