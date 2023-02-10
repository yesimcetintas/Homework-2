//Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. 
// (ArrayList sınıfını kullanara yazınız.)

// Negatif ve numeric olmayan girişleri engelleyin.
// Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
// Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
using System.Collections;

internal class KoleksiyonlarSoru1
{
    public void soru1()
    {
        Console.WriteLine("20 adet pozitif tam sayı girin:");

        ArrayList primeNumbers = new ArrayList();
        ArrayList notPrimeNumbers = new ArrayList(); 
        int[] numberArray = new int[20];

        int numberCount = 0;

        while (numberCount<20)
        {
            Console.WriteLine((numberCount+1) +". sayıyı giriniz:");
            var stringNumber = Console.ReadLine();
            int numericValue;
            bool isNumber = int.TryParse(stringNumber, out numericValue);

            if(!isNumber || numericValue<0) 
            {
                Console.WriteLine("Numeric değer veya negatif olmayan sayı giriniz.");
            }
            else
            {
                numberArray[numberCount] = numericValue;
                numberCount += 1;
            }
        }

        for (int j = 0; j < 20; j++)
        {
            int count = 0;
            for (int x = 1; x <= numberArray[j]; x++)
            {
                if(numberArray[j] % x == 0){
                    count += 1;
                }
            }
            if(count == 2){
                primeNumbers.Add(numberArray[j]);
            }else{
                notPrimeNumbers.Add(numberArray[j]);
            }
        }
        primeNumbers.Sort();
        primeNumbers.Reverse();

        notPrimeNumbers.Sort();
        notPrimeNumbers.Reverse();

        int primeNumberTotal=0;
        int notprimeNumberTotal=0;

        Console.WriteLine("Asal sayılar:");

        foreach (int primeNumber in primeNumbers)
        {
            Console.Write(primeNumber + " ");
            Console.WriteLine();
            primeNumberTotal = primeNumberTotal + primeNumber;
        }

        Console.WriteLine("Asal sayılar eleman sayısı:" + primeNumbers.Count);
        Console.WriteLine("Asal sayılar toplamı:" + primeNumberTotal);

        Console.WriteLine("Asal olmayan sayılar:");

        foreach (int notPrimeNumber in notPrimeNumbers)
        {
            Console.Write(notPrimeNumber + " ");
            Console.WriteLine();
            notprimeNumberTotal = notprimeNumberTotal + notPrimeNumber;
        }

        Console.WriteLine("Asal olmayan sayıların eleman sayısı:" + notPrimeNumbers.Count);
        Console.WriteLine("Asal olmayan sayıların toplamı:" + notprimeNumberTotal);

    }

}