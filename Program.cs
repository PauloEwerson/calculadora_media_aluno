using System;

namespace ExercicioAluno
{
    public class Aluno
    {
        public string Matricula { get; }
        public string Nome { get; }
        private double NotaProva1, NotaProva2, NotaTrabalho;

        /// <summary>
        /// Construtor para a classe Aluno.
        /// 
        /// <param name="matricula">Número de matrícula do aluno.</param>
        /// <param name="nome">Nome do aluno.</param>
        public Aluno(string matricula, string nome)
        {
            Matricula = matricula;
            Nome = nome;
        }

        /// <summary>
        /// Registra as notas das provas e do trabalho do aluno.
        /// </summary>
        /// <param name="notaProva1">Nota da primeira prova.</param>
        /// <param name="notaProva2">Nota da segunda prova.</param>
        /// <param name="notaTrabalho">Nota do trabalho.</param>
        public void RegistrarNotas(double notaProva1, double notaProva2, double notaTrabalho)
        {
            if (notaProva1 < 0 || notaProva1 > 10 || notaProva2 < 0 || notaProva2 > 10 || notaTrabalho < 0 || notaTrabalho > 10)
            {
                throw new ArgumentException("Todas as notas devem estar no intervalo de 0 a 10.");
            }

            NotaProva1 = notaProva1;
            NotaProva2 = notaProva2;
            NotaTrabalho = notaTrabalho;
        }

        /// <summary>
        /// Calcula e retorna a média final do aluno com base nas notas registradas.
        /// </summary>
        /// <returns>Média final ponderada do aluno.</returns>
        public double CalcularMediaFinal()
        {
            return (NotaProva1 * 2.5 + NotaProva2 * 2.5 + NotaTrabalho * 2) / 7;
        }
    }

    class Program
    {
        static void Main()
        {
            var aluno = new Aluno("12345", "Amanda");
            aluno.RegistrarNotas(7, 8, 5);
            Console.WriteLine($"A média final de {aluno.Nome} é {aluno.CalcularMediaFinal():0.0}");
        }
    }
}
