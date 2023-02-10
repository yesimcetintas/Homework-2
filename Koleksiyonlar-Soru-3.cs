// Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve 
// dizinin elemanlarını sıralayan programı yazınız.

using System.Collections;

internal class KoleksiyonlarSoru3
{
    public void soru3()
    {
        Console.WriteLine("Cümle giriniz:");
        string inputSentence = Console.ReadLine();

        char[] letterArr = inputSentence!.ToCharArray();

        char[] vowels = new char[] {'a','e','ı','i','o','ö','u','ü'};
        ArrayList inputVowels = new ArrayList();

        foreach (var vowel in vowels)
        {
            foreach (var letter in letterArr)
            {
                if(letter == vowel && inputVowels.IndexOf(letter)==-1){
                    inputVowels.Add(letter);
                }
            }
        }

        Console.Write("Girilen cümlenin sesli harfleri: ");

        foreach (var item in inputVowels)
        {
            Console.Write(item + " ");
        }
        
    }
}