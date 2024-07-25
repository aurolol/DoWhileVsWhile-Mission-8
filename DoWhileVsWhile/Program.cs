//// -------- While ---------
//Console.WriteLine("Lütfen bir sayı limiti giriniz:");
//int limit = Convert.ToInt32(Console.ReadLine());

//int sayac = 1;

//while(limit >= sayac)
//{
//    Console.WriteLine("Ben bir Patika'lıyım");
//    sayac++;
//}
// -------- Do-While ---------

Console.WriteLine("Lütfen bir sayı limiti giriniz:");
int limit = Convert.ToInt32(Console.ReadLine());

int sayac = 1;
do                      
{
    Console.WriteLine("Ben bir Patika'lıyım");
    sayac++;
}while(limit >= sayac);

//   FARKI DO DÖNGÜSÜ EN AZ BİR KERE ÇALIŞMA GARANTİSİ VERİRKEN WHILE DÖNGÜSÜ BU GARANTİYİ VERMEZ.