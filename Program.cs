using desafio_gft_dotnet.Desafio_1;

ContaBancaria conta = new ContaBancaria(123123, "Maria");

conta.Depositar(1000);

conta.Sacar(500);

conta.ExibirSaldo();
conta.Sacar(501);
conta.ExibirSaldo();
conta.Sacar(500);
conta.ExibirSaldo();

