using System;

class Anual : Relatorio
{
    public override void mostrarRelatorio()
    {
        base.mostrarRelatorio();
        System.Console.WriteLine("mostar relatorio anual");
    }
}