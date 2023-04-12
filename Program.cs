using static MODUL8_1302213054.BankTransferConfig;

BankTransferConfig = new BankTransferConfig();
readJson read = new readJson();

read.BankTransferConfig.changelang();
Console.WriteLine("Please insert the amount of money to transfer");
int mon = int.Parse(Console.ReadLine());

int sum =0;
if(mon <= read.BankTransferConfig.threshold)
{
    sum = mon + read.BankTransferConfig.low_fee;
    Console.WriteLine("Transfer fee = Rp" + read.BankTransferConfig.low_fee);
    ConsoleWriteLine("Total ammount = Rp" + sum);
}else
{
    sum = mon + read.BankTransferConfig.high_fee;
    Console.WriteLine("Transfer fee = Rp" + read.BankTransferConfig.high_fee);
    ConsoleWriteLine("Total ammount = Rp" + sum);
}

Console.WriteLine("\n Select Transfer Method :");
Console.WriteLine(read.BankTransferConfig.m1);
Console.WriteLine(read.BankTransferConfig.m2);
Console.WriteLine(read.BankTransferConfig.m3);
Console.WriteLine(read.BankTransferConfig.m4);
string m = Console.ReadLine();

Console.WriteLine("\n Please type" + read.BankTransferConfig.confirmationen + "to confirm the transaction");
string confirm = Console.ReadLine();
if (confirm == read.BankTransferConfig.confirmationen)
{
    Console.WriteLine("The transfer is completed");
}else
{
    Console.WriteLine("Transfer is cancelled");
}