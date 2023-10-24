
var conta1 = new ContaCorrente();
conta1.Numero = "150.102-0";
conta1.Saldo = 645;
conta1.ImprimirInfo();
conta1.Depositar(100);
conta1.ImprimirInfo();

var conta2  = new ContaCorrente();
conta2.Numero = "321.654-9";
conta2.Saldo = 0;
conta2.ImprimirInfo();
conta2.Depositar(100);
conta2.ImprimirInfo();