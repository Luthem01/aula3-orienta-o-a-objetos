using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using agrupamento_notas;
using System.Transactions;
using System.Collections.Generic;



namespace agrupamento_notas
{
    public class matematicaAlunos
    {
        public string matricula;
        public string nome;
        public double nota1;
        public double nota2;
        public double trabalhoAluno;

        

        /* Escreva uma classe cujos objetos representam alunos matriculados em uma disciplina.
         
Cada objeto dessa classe deve guardar os seguintes dados do aluno:
matrícula, nome, 2 notas de prova e 1 nota de trabalho.
Construa os seguintes métodos para esta classe:
métodos construtores,
registrar nota de cada prova e trabalho,
calcula a média final do aluno (cada prova tem peso 2,5 e o trabalho tem peso 2).
Teste na main, se atente para o que precisar ser public, private, parametros, retornos..
Coloque o summary nos métodos e explique sua funcionalidade
*/


        public double media()
        {
            double resultado = (((nota1*2.5) + (nota2*2.5) + (trabalhoAluno*2))/6);

            return resultado;
        }
        

    }
}
