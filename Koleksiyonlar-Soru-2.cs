// Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, 
// her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. 
// (Array sınıfını kullanarak yazınız.)

internal class KoleksiyonlarSoru2
{
    public void soru2(){
        Console.WriteLine("20 adet pozitif tam sayı girin:");
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
        Array.Sort(numberArray);
        Console.WriteLine("En büyük 3 tanesi:" + numberArray[19] + ", " + numberArray[18] + ", " + numberArray[17]);
        Console.WriteLine("En küçük 3 tanesi:" + numberArray[0] + ", " + numberArray[1] + ", " + numberArray[2]);

        int greatestAverage = (numberArray[19] + numberArray[18] + numberArray[17])/3;
        int smallestAverage = (numberArray[0]+ numberArray[1]+ numberArray[2])/3;

        Console.WriteLine("En büyük 3 tanenin ortalaması:" +  greatestAverage);
        Console.WriteLine("En küçük 3 tanesinin ortalaması:" + smallestAverage);
        Console.WriteLine("Ortalamaların toplamı:" + (greatestAverage + smallestAverage));

    }
}