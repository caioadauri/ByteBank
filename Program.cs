﻿using System;

namespace _01_ByteBank
{
  class Program
  {
    static void Main(string[] args)
    {
      new ContaCorrente();

      ContaCorrente contaDaGabriela = new ContaCorrente();

      contaDaGabriela.titular = "Gabriela";
      contaDaGabriela.agencia = 863;
      contaDaGabriela.numero = 863452;
      contaDaGabriela.saldo = 100;

      Console.WriteLine(contaDaGabriela.titular);
      Console.WriteLine("Agencia: " + contaDaGabriela.agencia);
      Console.WriteLine("Número: " + contaDaGabriela.numero);
      Console.WriteLine("Saldo: " + contaDaGabriela.saldo);

      contaDaGabriela.saldo += 200;

      Console.WriteLine(contaDaGabriela.saldo);

      Console.ReadLine();
    }
  }
}
