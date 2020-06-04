using System;

class Mensal : Relatorio
{
    public override void mostrarRelatorio()
    {
        base.mostrarRelatorio();
        System.Console.WriteLine("mostar relatorio do mês");
    }
}