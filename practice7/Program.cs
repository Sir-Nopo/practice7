//Mohammadreza Fatahi
//T.me/SirNopo
first:
List<Student> students = new List<Student>();
Student student = new Student();

string filelocation = @"C:\Users\SirGoogle\source\repos\practice7\practice7\ListOfStudent.txt";
StreamReader sr = new StreamReader(filelocation);
Console.WriteLine(" ");
Console.WriteLine("salam !");
Console.WriteLine("barye daryaft Etelat daneshjoyan adad 1 :");
Console.WriteLine("barye daryaft Nomerat daneshjoyan adad 2 :");
Console.WriteLine("barye daryaft MoadelKol daneshjoyan adad 3 :");
Console.WriteLine("barye daryaft Modael Doros Takhasosi daneshjoyan adad 4 :");
Console.WriteLine("barye daryaft Modael Doros Nime Takhasosi daneshjoyan adad 5 :");
Console.WriteLine("barye daryaft Etelat Kamel daneshjoyan adad 6 :");
string s = Console.ReadLine();
switch (s)
{
    case "1":
        information();
        goto first;
    case "2":
        nomerat();
        goto first;
    case "3":
        moadelkol();
        goto first;
    case "4":
        moadeltakhs();
        goto first;
    case "5":
        moadelnimtakhs();
        goto first;
    case "6":
        fullinformation();
        goto first;
    default:
        Console.WriteLine("adad vared shode eshtebah ast !");
        goto first;
}
void information()
{
    while (!sr.EndOfStream)
    {

        string line = sr.ReadLine();

        student.FName = line.Split(',')[0];
        student.LName = line.Split(',')[1];
        Console.WriteLine("Name:" + student.FName + " " + student.LName + System.Environment.NewLine + "=====================");
    }
}
void nomerat()
{
    while (!sr.EndOfStream)
    {

        string line = sr.ReadLine();

        student.FName = line.Split(',')[0];
        student.LName = line.Split(',')[1];
        student.PishrafteMark = Convert.ToDouble(line.Split(',')[2]);
        student.tafsirMark = Convert.ToDouble(line.Split(',')[3]);
        student.MathMark = Convert.ToDouble(line.Split(',')[4]);
        student.KargahMark = Convert.ToDouble(line.Split(',')[5]);
        student.ZabanMark = Convert.ToDouble(line.Split(',')[6]);
        student.Pishrafte2Mark = Convert.ToDouble(line.Split(',')[7]);
        student.SheygaraeiMark = Convert.ToDouble(line.Split(',')[8]);
        student.TarbiyatMark = Convert.ToDouble(line.Split(',')[9]);
        student.SystemMark = Convert.ToDouble(line.Split(',')[10]);
        student.AlogoritmMark = Convert.ToDouble(line.Split(',')[11]);

        Console.WriteLine("Name:" + student.FName + " " + student.LName + System.Environment.NewLine + "=====================");
        Console.ForegroundColor = ConsoleColor.Green;
        switch (student.PishrafteMark)
        {
            case 2:
                Console.WriteLine("Pishrafte 1** : " + student.PishrafteMark + " Prime Number");
                break;
            case 3:
                Console.WriteLine("Pishrafte 1** : " + student.PishrafteMark + " Prime Number");
                break;
            case 5:
                Console.WriteLine("Pishrafte 1** : " + student.PishrafteMark + " Prime Number");
                break;
            case 7:
                Console.WriteLine("Pishrafte 1** : " + student.PishrafteMark + " Prime Number");
                break;
            case 11:
                Console.WriteLine("Pishrafte 1** : " + student.PishrafteMark + " Prime Number");
                break;
            case 13:
                Console.WriteLine("Pishrafte 1** : " + student.PishrafteMark + " Prime Number");
                break;
            case 17:
                Console.WriteLine("Pishrafte 1** : " + student.PishrafteMark + " Prime Number");
                break;
            case 19:
                Console.WriteLine("Pishrafte 1** : " + student.PishrafteMark + " Prime Number");
                break;
            default:
                Console.WriteLine("Pishrafte 1** : " + student.PishrafteMark);
                break;
        }
        Console.ForegroundColor = ConsoleColor.White;
        switch (student.tafsirMark)
        {
            case 2:
                Console.WriteLine("Tafsir: " + student.tafsirMark + " Prime Number");
                break;
            case 3:
                Console.WriteLine("Tafsir: " + student.tafsirMark + " Prime Number");
                break;
            case 5:
                Console.WriteLine("Tafsir: " + student.tafsirMark + " Prime Number");
                break;
            case 7:
                Console.WriteLine("Tafsir: " + student.tafsirMark + " Prime Number");
                break;
            case 11:
                Console.WriteLine("Tafsir: " + student.tafsirMark + " Prime Number");
                break;
            case 13:
                Console.WriteLine("Tafsir: " + student.tafsirMark + " Prime Number");
                break;
            case 17:
                Console.WriteLine("Tafsir: " + student.tafsirMark + " Prime Number");
                break;
            case 19:
                Console.WriteLine("Tafsir: " + student.tafsirMark + " Prime Number");
                break;
            default:
                Console.WriteLine("Tafsir: " + student.tafsirMark);
                break;
        }
        switch (student.MathMark)
        {
            case 2:
                Console.WriteLine("Riazi: " + student.MathMark + " Prime Number");
                break;
            case 3:
                Console.WriteLine("Riazi: " + student.MathMark + " Prime Number");
                break;
            case 5:
                Console.WriteLine("Riazi: " + student.MathMark + " Prime Number");
                break;
            case 7:
                Console.WriteLine("Riazi: " + student.MathMark + " Prime Number");
                break;
            case 11:
                Console.WriteLine("Riazi: " + student.MathMark + " Prime Number");
                break;
            case 13:
                Console.WriteLine("Riazi: " + student.MathMark + " Prime Number");
                break;
            case 17:
                Console.WriteLine("Riazi: " + student.MathMark + " Prime Number");
                break;
            case 19:
                Console.WriteLine("Riazi: " + student.MathMark + " Prime Number");
                break;
            default:
                Console.WriteLine("Riazi: " + student.MathMark);
                break;
        }
        switch (student.KargahMark)
        {
            case 2:
                Console.WriteLine("Kargah: " + student.KargahMark + " Prime Number");
                break;
            case 3:
                Console.WriteLine("Kargah: " + student.KargahMark + " Prime Number");
                break;
            case 5:
                Console.WriteLine("Kargah: " + student.KargahMark + " Prime Number");
                break;
            case 7:
                Console.WriteLine("Kargah: " + student.KargahMark + " Prime Number");
                break;
            case 11:
                Console.WriteLine("Kargah: " + student.KargahMark + " Prime Number");
                break;
            case 13:
                Console.WriteLine("Kargah: " + student.KargahMark + " Prime Number");
                break;
            case 17:
                Console.WriteLine("Kargah: " + student.KargahMark + " Prime Number");
                break;
            case 19:
                Console.WriteLine("Kargah: " + student.KargahMark + " Prime Number");
                break;
            default:
                Console.WriteLine("Kargah: " + student.KargahMark);
                break;
        }
        switch (student.ZabanMark)
        {
            case 2:
                Console.WriteLine("Zaban Khareji : " + student.ZabanMark + " Prime Number");
                break;
            case 3:
                Console.WriteLine("Zaban Khareji : " + student.ZabanMark + " Prime Number");
                break;
            case 5:
                Console.WriteLine("Zaban Khareji: " + student.ZabanMark + " Prime Number");
                break;
            case 7:
                Console.WriteLine("Zaban Khareji : " + student.ZabanMark + " Prime Number");
                break;
            case 11:
                Console.WriteLine("Zaban Khareji : " + student.ZabanMark + " Prime Number");
                break;
            case 13:
                Console.WriteLine("Zaban Khareji : " + student.ZabanMark + " Prime Number");
                break;
            case 17:
                Console.WriteLine("Zaban Khareji : " + student.ZabanMark + " Prime Number");
                break;
            case 19:
                Console.WriteLine("Zaban Khareji : " + student.ZabanMark + " Prime Number");
                break;
            default:
                Console.WriteLine("Zaban Khareji : " + student.ZabanMark);
                break;
        }
        Console.ForegroundColor = ConsoleColor.Green;
        switch (student.Pishrafte2Mark)
        {
            case 2:
                Console.WriteLine("Pishrafte 2** : " + student.Pishrafte2Mark + " Prime Number");
                break;
            case 3:
                Console.WriteLine("Pishrafte 2** : " + student.Pishrafte2Mark + " Prime Number");
                break;
            case 5:
                Console.WriteLine("Pishrafte 2** : " + student.Pishrafte2Mark + " Prime Number");
                break;
            case 7:
                Console.WriteLine("Pishrafte 2** : " + student.Pishrafte2Mark + " Prime Number");
                break;
            case 11:
                Console.WriteLine("Pishrafte 2** : " + student.Pishrafte2Mark + " Prime Number");
                break;
            case 13:
                Console.WriteLine("Pishrafte 2** : " + student.Pishrafte2Mark + " Prime Number");
                break;
            case 17:
                Console.WriteLine("Pishrafte 2** : " + student.Pishrafte2Mark + " Prime Number");
                break;
            case 19:
                Console.WriteLine("Pishrafte 2** : " + student.Pishrafte2Mark + " Prime Number");
                break;
            default:
                Console.WriteLine("Pishrafte 2** : " + student.Pishrafte2Mark);
                break;
        }
        switch (student.SheygaraeiMark)
        {
            case 2:
                Console.WriteLine("SheyGaraee** : " + student.SheygaraeiMark + " Prime Number");
                break;
            case 3:
                Console.WriteLine("SheyGaraee** : " + student.SheygaraeiMark + " Prime Number");
                break;
            case 5:
                Console.WriteLine("SheyGaraee** : " + student.SheygaraeiMark + " Prime Number");
                break;
            case 7:
                Console.WriteLine("SheyGaraee** : " + student.SheygaraeiMark + " Prime Number");
                break;
            case 11:
                Console.WriteLine("SheyGaraee** : " + student.SheygaraeiMark + " Prime Number");
                break;
            case 13:
                Console.WriteLine("SheyGaraee** : " + student.SheygaraeiMark + " Prime Number");
                break;
            case 17:
                Console.WriteLine("SheyGaraee** : " + student.SheygaraeiMark + " Prime Number");
                break;
            case 19:
                Console.WriteLine("SheyGaraee** : " + student.SheygaraeiMark + " Prime Number");
                break;
            default:
                Console.WriteLine("SheyGaraee** : " + student.SheygaraeiMark);
                break;
        }
        Console.ForegroundColor = ConsoleColor.White;

        switch (student.TarbiyatMark)
        {
            case 2:
                Console.WriteLine("Tarbiat Badani : " + student.TarbiyatMark + " Prime Number");
                break;
            case 3:
                Console.WriteLine("Tarbiat Badani : " + student.TarbiyatMark + " Prime Number");
                break;
            case 5:
                Console.WriteLine("Tarbiat Badani : " + student.TarbiyatMark + " Prime Number");
                break;
            case 7:
                Console.WriteLine("Tarbiat Badani : " + student.TarbiyatMark + " Prime Number");
                break;
            case 11:
                Console.WriteLine("Tarbiat Badani : " + student.TarbiyatMark + " Prime Number");
                break;
            case 13:
                Console.WriteLine("Tarbiat Badani : " + student.TarbiyatMark + " Prime Number");
                break;
            case 17:
                Console.WriteLine("Tarbiat Badani : " + student.TarbiyatMark + " Prime Number");
                break;
            case 19:
                Console.WriteLine("Tarbiat Badani : " + student.TarbiyatMark + " Prime Number");
                break;
            default:
                Console.WriteLine("Tarbiat Badani : " + student.TarbiyatMark);
                break;
        }
        Console.ForegroundColor = ConsoleColor.Magenta;

        switch (student.SystemMark)
        {
            case 2:
                Console.WriteLine("System Amel* : " + student.SystemMark + " Prime Number");
                break;
            case 3:
                Console.WriteLine("System Amel* : " + student.SystemMark + " Prime Number");
                break;
            case 5:
                Console.WriteLine("System Amel* : " + student.SystemMark + " Prime Number");
                break;
            case 7:
                Console.WriteLine("System Amel* : " + student.SystemMark + " Prime Number");
                break;
            case 11:
                Console.WriteLine("System Amel* : " + student.SystemMark + " Prime Number");
                break;
            case 13:
                Console.WriteLine("System Amel* : " + student.SystemMark + " Prime Number");
                break;
            case 17:
                Console.WriteLine("System Amel* : " + student.SystemMark + " Prime Number");
                break;
            case 19:
                Console.WriteLine("System Amel* : " + student.SystemMark + " Prime Number");
                break;
            default:
                Console.WriteLine("System Amel* : " + student.SystemMark);
                break;
        }

        switch (student.AlogoritmMark)
        {
            case 2:
                Console.WriteLine("Algorithm* : " + student.AlogoritmMark + " Prime Number");
                break;
            case 3:
                Console.WriteLine("Algorithm* : " + student.AlogoritmMark + " Prime Number");
                break;
            case 5:
                Console.WriteLine("Algorithm* : " + student.AlogoritmMark + " Prime Number");
                break;
            case 7:
                Console.WriteLine("Algorithm* : " + student.AlogoritmMark + " Prime Number");
                break;
            case 11:
                Console.WriteLine("Algorithm* : " + student.AlogoritmMark + " Prime Number");
                break;
            case 13:
                Console.WriteLine("Algorithm* : " + student.AlogoritmMark + " Prime Number");
                break;
            case 17:
                Console.WriteLine("Algorithm* : " + student.AlogoritmMark + " Prime Number");
                break;
            case 19:
                Console.WriteLine("Algorithm* : " + student.AlogoritmMark + " Prime Number");
                break;
            default:
                Console.WriteLine("Algorithm* : " + student.AlogoritmMark);
                break;
        }
        Console.ForegroundColor = ConsoleColor.White;

    }
}
void moadelkol()
{
    while (!sr.EndOfStream)
    {

        string line = sr.ReadLine();

        student.FName = line.Split(',')[0];
        student.LName = line.Split(',')[1];
        student.PishrafteMark = Convert.ToDouble(line.Split(',')[2]);
        student.tafsirMark = Convert.ToDouble(line.Split(',')[3]);
        student.MathMark = Convert.ToDouble(line.Split(',')[4]);
        student.KargahMark = Convert.ToDouble(line.Split(',')[5]);
        student.ZabanMark = Convert.ToDouble(line.Split(',')[6]);
        student.Pishrafte2Mark = Convert.ToDouble(line.Split(',')[7]);
        student.SheygaraeiMark = Convert.ToDouble(line.Split(',')[8]);
        student.TarbiyatMark = Convert.ToDouble(line.Split(',')[9]);
        student.SystemMark = Convert.ToDouble(line.Split(',')[10]);
        student.AlogoritmMark = Convert.ToDouble(line.Split(',')[11]);

        Console.WriteLine("Name : " + student.FName + " " + student.LName);
        switch (student.TotalAverage())
        {
            case >= 17:
                Console.WriteLine("Moadel Kol : " + student.TotalAverage() + "      Grade : A");
                break;
            case >= 15 and < 17:
                Console.WriteLine("Moadel Kol : " + student.TotalAverage() + "      Grade : B");
                break;
            case >= 13 and < 15:
                Console.WriteLine("Moadel Kol : " + student.TotalAverage() + "      Grade : C");
                break;
            case >= 10 and < 13:
                Console.WriteLine("Moadel Kol : " + student.TotalAverage() + "      Grade : D");
                break;
            case >= 7 and < 10:
                Console.WriteLine("Moadel Kol : " + student.TotalAverage() + "      Grade : E");
                break;
            case >= 3 and < 7:
                Console.WriteLine("Moadel Kol : " + student.TotalAverage() + "      Grade : F");
                break;
            case >= 0:
                Console.WriteLine("Moadel Kol : " + student.TotalAverage() + "      Grade : G");
                break;
        }
        Console.WriteLine("=====================");
    }

}
void moadeltakhs()
{
    while (!sr.EndOfStream)
    {

        string line = sr.ReadLine();

        student.FName = line.Split(',')[0];
        student.LName = line.Split(',')[1];
        student.PishrafteMark = Convert.ToDouble(line.Split(',')[2]);
        student.tafsirMark = Convert.ToDouble(line.Split(',')[3]);
        student.MathMark = Convert.ToDouble(line.Split(',')[4]);
        student.KargahMark = Convert.ToDouble(line.Split(',')[5]);
        student.ZabanMark = Convert.ToDouble(line.Split(',')[6]);
        student.Pishrafte2Mark = Convert.ToDouble(line.Split(',')[7]);
        student.SheygaraeiMark = Convert.ToDouble(line.Split(',')[8]);
        student.TarbiyatMark = Convert.ToDouble(line.Split(',')[9]);
        student.SystemMark = Convert.ToDouble(line.Split(',')[10]);
        student.AlogoritmMark = Convert.ToDouble(line.Split(',')[11]);

        Console.WriteLine("Name : " + student.FName + " " + student.LName);
        switch (student.TakhsAverage())
        {
            case >= 17:
                Console.WriteLine("Modael Doros Takhasosi : " + student.TakhsAverage() + "      Grade : A");
                break;
            case >= 15 and < 17:
                Console.WriteLine("Modael Doros Takhasosi : " + student.TakhsAverage() + "      Grade : B");
                break;
            case >= 13 and < 15:
                Console.WriteLine("Modael Doros Takhasosi : " + student.TakhsAverage() + "      Grade : C");
                break;
            case >= 10 and < 13:
                Console.WriteLine("Modael Doros Takhasosi : " + student.TakhsAverage() + "      Grade : D");
                break;
            case >= 7 and < 10:
                Console.WriteLine("Modael Doros Takhasosi : " + student.TakhsAverage() + "      Grade : E");
                break;
            case >= 3 and < 7:
                Console.WriteLine("Modael Doros Takhasosi : " + student.TakhsAverage() + "      Grade : F");
                break;
            case >= 0:
                Console.WriteLine("Modael Doros Takhasosi : " + student.TakhsAverage() + "      Grade : G");
                break;
        }
        Console.WriteLine("=====================");
    }
}
void moadelnimtakhs()
{
    while (!sr.EndOfStream)
    {

        string line = sr.ReadLine();

        student.FName = line.Split(',')[0];
        student.LName = line.Split(',')[1];
        student.PishrafteMark = Convert.ToDouble(line.Split(',')[2]);
        student.tafsirMark = Convert.ToDouble(line.Split(',')[3]);
        student.MathMark = Convert.ToDouble(line.Split(',')[4]);
        student.KargahMark = Convert.ToDouble(line.Split(',')[5]);
        student.ZabanMark = Convert.ToDouble(line.Split(',')[6]);
        student.Pishrafte2Mark = Convert.ToDouble(line.Split(',')[7]);
        student.SheygaraeiMark = Convert.ToDouble(line.Split(',')[8]);
        student.TarbiyatMark = Convert.ToDouble(line.Split(',')[9]);
        student.SystemMark = Convert.ToDouble(line.Split(',')[10]);
        student.AlogoritmMark = Convert.ToDouble(line.Split(',')[11]);

        Console.WriteLine("Name : " + student.FName + " " + student.LName);
        switch (student.Takhs2Average())
        {
            case >= 17:
                Console.WriteLine("Modael Doros Nime Takhasosi : " + student.Takhs2Average() + "      Grade : A");
                break;
            case >= 15 and < 17:
                Console.WriteLine("Modael Doros Nime Takhasosi : " + student.Takhs2Average() + "      Grade : B");
                break;
            case >= 13 and < 15:
                Console.WriteLine("Modael Doros Nime Takhasosi : " + student.Takhs2Average() + "      Grade : C");
                break;
            case >= 10 and < 13:
                Console.WriteLine("Modael Doros Nime Takhasosi : " + student.Takhs2Average() + "      Grade : D");
                break;
            case >= 7 and < 10:
                Console.WriteLine("Modael Doros Nime Takhasosi : " + student.Takhs2Average() + "      Grade : E");
                break;
            case >= 3 and < 7:
                Console.WriteLine("Modael Doros Nime Takhasosi : " + student.Takhs2Average() + "      Grade : F");
                break;
            case >= 0:
                Console.WriteLine("Modael Doros Nime Takhasosi : " + student.Takhs2Average() + "      Grade : G");
                break;
        }
        Console.WriteLine("=====================");
    }
}
void fullinformation()
{
    while (!sr.EndOfStream)
    {

        string line = sr.ReadLine();
        Student student = new Student();

        student.FName = line.Split(',')[0];
        student.LName = line.Split(',')[1];
        student.PishrafteMark = Convert.ToDouble(line.Split(',')[2]);
        student.tafsirMark = Convert.ToDouble(line.Split(',')[3]);
        student.MathMark = Convert.ToDouble(line.Split(',')[4]);
        student.KargahMark = Convert.ToDouble(line.Split(',')[5]);
        student.ZabanMark = Convert.ToDouble(line.Split(',')[6]);
        student.Pishrafte2Mark = Convert.ToDouble(line.Split(',')[7]);
        student.SheygaraeiMark = Convert.ToDouble(line.Split(',')[8]);
        student.TarbiyatMark = Convert.ToDouble(line.Split(',')[9]);
        student.SystemMark = Convert.ToDouble(line.Split(',')[10]);
        student.AlogoritmMark = Convert.ToDouble(line.Split(',')[11]);

        Console.WriteLine("Name:" + student.FName + " " + student.LName + System.Environment.NewLine + "=====================");
        Console.ForegroundColor = ConsoleColor.Green;
        switch (student.PishrafteMark)
        {
            case 2:
                Console.WriteLine("Pishrafte 1** : " + student.PishrafteMark + " Prime Number");
                break;
            case 3:
                Console.WriteLine("Pishrafte 1** : " + student.PishrafteMark + " Prime Number");
                break;
            case 5:
                Console.WriteLine("Pishrafte 1** : " + student.PishrafteMark + " Prime Number");
                break;
            case 7:
                Console.WriteLine("Pishrafte 1** : " + student.PishrafteMark + " Prime Number");
                break;
            case 11:
                Console.WriteLine("Pishrafte 1** : " + student.PishrafteMark + " Prime Number");
                break;
            case 13:
                Console.WriteLine("Pishrafte 1** : " + student.PishrafteMark + " Prime Number");
                break;
            case 17:
                Console.WriteLine("Pishrafte 1** : " + student.PishrafteMark + " Prime Number");
                break;
            case 19:
                Console.WriteLine("Pishrafte 1** : " + student.PishrafteMark + " Prime Number");
                break;
            default:
                Console.WriteLine("Pishrafte 1** : " + student.PishrafteMark);
                break;
        }
        Console.ForegroundColor = ConsoleColor.White;
        switch (student.tafsirMark)
        {
            case 2:
                Console.WriteLine("Tafsir: " + student.tafsirMark + " Prime Number");
                break;
            case 3:
                Console.WriteLine("Tafsir: " + student.tafsirMark + " Prime Number");
                break;
            case 5:
                Console.WriteLine("Tafsir: " + student.tafsirMark + " Prime Number");
                break;
            case 7:
                Console.WriteLine("Tafsir: " + student.tafsirMark + " Prime Number");
                break;
            case 11:
                Console.WriteLine("Tafsir: " + student.tafsirMark + " Prime Number");
                break;
            case 13:
                Console.WriteLine("Tafsir: " + student.tafsirMark + " Prime Number");
                break;
            case 17:
                Console.WriteLine("Tafsir: " + student.tafsirMark + " Prime Number");
                break;
            case 19:
                Console.WriteLine("Tafsir: " + student.tafsirMark + " Prime Number");
                break;
            default:
                Console.WriteLine("Tafsir: " + student.tafsirMark);
                break;
        }
        switch (student.MathMark)
        {
            case 2:
                Console.WriteLine("Riazi: " + student.MathMark + " Prime Number");
                break;
            case 3:
                Console.WriteLine("Riazi: " + student.MathMark + " Prime Number");
                break;
            case 5:
                Console.WriteLine("Riazi: " + student.MathMark + " Prime Number");
                break;
            case 7:
                Console.WriteLine("Riazi: " + student.MathMark + " Prime Number");
                break;
            case 11:
                Console.WriteLine("Riazi: " + student.MathMark + " Prime Number");
                break;
            case 13:
                Console.WriteLine("Riazi: " + student.MathMark + " Prime Number");
                break;
            case 17:
                Console.WriteLine("Riazi: " + student.MathMark + " Prime Number");
                break;
            case 19:
                Console.WriteLine("Riazi: " + student.MathMark + " Prime Number");
                break;
            default:
                Console.WriteLine("Riazi: " + student.MathMark);
                break;
        }
        switch (student.KargahMark)
        {
            case 2:
                Console.WriteLine("Kargah: " + student.KargahMark + " Prime Number");
                break;
            case 3:
                Console.WriteLine("Kargah: " + student.KargahMark + " Prime Number");
                break;
            case 5:
                Console.WriteLine("Kargah: " + student.KargahMark + " Prime Number");
                break;
            case 7:
                Console.WriteLine("Kargah: " + student.KargahMark + " Prime Number");
                break;
            case 11:
                Console.WriteLine("Kargah: " + student.KargahMark + " Prime Number");
                break;
            case 13:
                Console.WriteLine("Kargah: " + student.KargahMark + " Prime Number");
                break;
            case 17:
                Console.WriteLine("Kargah: " + student.KargahMark + " Prime Number");
                break;
            case 19:
                Console.WriteLine("Kargah: " + student.KargahMark + " Prime Number");
                break;
            default:
                Console.WriteLine("Kargah: " + student.KargahMark);
                break;
        }
        switch (student.ZabanMark)
        {
            case 2:
                Console.WriteLine("Zaban Khareji : " + student.ZabanMark + " Prime Number");
                break;
            case 3:
                Console.WriteLine("Zaban Khareji : " + student.ZabanMark + " Prime Number");
                break;
            case 5:
                Console.WriteLine("Zaban Khareji: " + student.ZabanMark + " Prime Number");
                break;
            case 7:
                Console.WriteLine("Zaban Khareji : " + student.ZabanMark + " Prime Number");
                break;
            case 11:
                Console.WriteLine("Zaban Khareji : " + student.ZabanMark + " Prime Number");
                break;
            case 13:
                Console.WriteLine("Zaban Khareji : " + student.ZabanMark + " Prime Number");
                break;
            case 17:
                Console.WriteLine("Zaban Khareji : " + student.ZabanMark + " Prime Number");
                break;
            case 19:
                Console.WriteLine("Zaban Khareji : " + student.ZabanMark + " Prime Number");
                break;
            default:
                Console.WriteLine("Zaban Khareji : " + student.ZabanMark);
                break;
        }
        Console.ForegroundColor = ConsoleColor.Green;
        switch (student.Pishrafte2Mark)
        {
            case 2:
                Console.WriteLine("Pishrafte 2** : " + student.Pishrafte2Mark + " Prime Number");
                break;
            case 3:
                Console.WriteLine("Pishrafte 2** : " + student.Pishrafte2Mark + " Prime Number");
                break;
            case 5:
                Console.WriteLine("Pishrafte 2** : " + student.Pishrafte2Mark + " Prime Number");
                break;
            case 7:
                Console.WriteLine("Pishrafte 2** : " + student.Pishrafte2Mark + " Prime Number");
                break;
            case 11:
                Console.WriteLine("Pishrafte 2** : " + student.Pishrafte2Mark + " Prime Number");
                break;
            case 13:
                Console.WriteLine("Pishrafte 2** : " + student.Pishrafte2Mark + " Prime Number");
                break;
            case 17:
                Console.WriteLine("Pishrafte 2** : " + student.Pishrafte2Mark + " Prime Number");
                break;
            case 19:
                Console.WriteLine("Pishrafte 2** : " + student.Pishrafte2Mark + " Prime Number");
                break;
            default:
                Console.WriteLine("Pishrafte 2** : " + student.Pishrafte2Mark);
                break;
        }
        switch (student.SheygaraeiMark)
        {
            case 2:
                Console.WriteLine("SheyGaraee** : " + student.SheygaraeiMark + " Prime Number");
                break;
            case 3:
                Console.WriteLine("SheyGaraee** : " + student.SheygaraeiMark + " Prime Number");
                break;
            case 5:
                Console.WriteLine("SheyGaraee** : " + student.SheygaraeiMark + " Prime Number");
                break;
            case 7:
                Console.WriteLine("SheyGaraee** : " + student.SheygaraeiMark + " Prime Number");
                break;
            case 11:
                Console.WriteLine("SheyGaraee** : " + student.SheygaraeiMark + " Prime Number");
                break;
            case 13:
                Console.WriteLine("SheyGaraee** : " + student.SheygaraeiMark + " Prime Number");
                break;
            case 17:
                Console.WriteLine("SheyGaraee** : " + student.SheygaraeiMark + " Prime Number");
                break;
            case 19:
                Console.WriteLine("SheyGaraee** : " + student.SheygaraeiMark + " Prime Number");
                break;
            default:
                Console.WriteLine("SheyGaraee** : " + student.SheygaraeiMark);
                break;
        }
        Console.ForegroundColor = ConsoleColor.White;

        switch (student.TarbiyatMark)
        {
            case 2:
                Console.WriteLine("Tarbiat Badani : " + student.TarbiyatMark + " Prime Number");
                break;
            case 3:
                Console.WriteLine("Tarbiat Badani : " + student.TarbiyatMark + " Prime Number");
                break;
            case 5:
                Console.WriteLine("Tarbiat Badani : " + student.TarbiyatMark + " Prime Number");
                break;
            case 7:
                Console.WriteLine("Tarbiat Badani : " + student.TarbiyatMark + " Prime Number");
                break;
            case 11:
                Console.WriteLine("Tarbiat Badani : " + student.TarbiyatMark + " Prime Number");
                break;
            case 13:
                Console.WriteLine("Tarbiat Badani : " + student.TarbiyatMark + " Prime Number");
                break;
            case 17:
                Console.WriteLine("Tarbiat Badani : " + student.TarbiyatMark + " Prime Number");
                break;
            case 19:
                Console.WriteLine("Tarbiat Badani : " + student.TarbiyatMark + " Prime Number");
                break;
            default:
                Console.WriteLine("Tarbiat Badani : " + student.TarbiyatMark);
                break;
        }
        Console.ForegroundColor = ConsoleColor.Magenta;

        switch (student.SystemMark)
        {
            case 2:
                Console.WriteLine("System Amel* : " + student.SystemMark + " Prime Number");
                break;
            case 3:
                Console.WriteLine("System Amel* : " + student.SystemMark + " Prime Number");
                break;
            case 5:
                Console.WriteLine("System Amel* : " + student.SystemMark + " Prime Number");
                break;
            case 7:
                Console.WriteLine("System Amel* : " + student.SystemMark + " Prime Number");
                break;
            case 11:
                Console.WriteLine("System Amel* : " + student.SystemMark + " Prime Number");
                break;
            case 13:
                Console.WriteLine("System Amel* : " + student.SystemMark + " Prime Number");
                break;
            case 17:
                Console.WriteLine("System Amel* : " + student.SystemMark + " Prime Number");
                break;
            case 19:
                Console.WriteLine("System Amel* : " + student.SystemMark + " Prime Number");
                break;
            default:
                Console.WriteLine("System Amel* : " + student.SystemMark);
                break;
        }

        switch (student.AlogoritmMark)
        {
            case 2:
                Console.WriteLine("Algorithm* : " + student.AlogoritmMark + " Prime Number");
                break;
            case 3:
                Console.WriteLine("Algorithm* : " + student.AlogoritmMark + " Prime Number");
                break;
            case 5:
                Console.WriteLine("Algorithm* : " + student.AlogoritmMark + " Prime Number");
                break;
            case 7:
                Console.WriteLine("Algorithm* : " + student.AlogoritmMark + " Prime Number");
                break;
            case 11:
                Console.WriteLine("Algorithm* : " + student.AlogoritmMark + " Prime Number");
                break;
            case 13:
                Console.WriteLine("Algorithm* : " + student.AlogoritmMark + " Prime Number");
                break;
            case 17:
                Console.WriteLine("Algorithm* : " + student.AlogoritmMark + " Prime Number");
                break;
            case 19:
                Console.WriteLine("Algorithm* : " + student.AlogoritmMark + " Prime Number");
                break;
            default:
                Console.WriteLine("Algorithm* : " + student.AlogoritmMark);
                break;
        }
        Console.ForegroundColor = ConsoleColor.White;
        switch (student.TotalAverage())
        {
            case >= 17:
                Console.WriteLine("Moadel Kol : " + student.TotalAverage() + "      Grade : A");
                break;
            case >= 15 and < 17:
                Console.WriteLine("Moadel Kol : " + student.TotalAverage() + "      Grade : B");
                break;
            case >= 13 and < 15:
                Console.WriteLine("Moadel Kol : " + student.TotalAverage() + "      Grade : C");
                break;
            case >= 10 and < 13:
                Console.WriteLine("Moadel Kol : " + student.TotalAverage() + "      Grade : D");
                break;
            case >= 7 and < 10:
                Console.WriteLine("Moadel Kol : " + student.TotalAverage() + "      Grade : E");
                break;
            case >= 3 and < 7:
                Console.WriteLine("Moadel Kol : " + student.TotalAverage() + "      Grade : F");
                break;
            case >= 0:
                Console.WriteLine("Moadel Kol : " + student.TotalAverage() + "      Grade : G");
                break;
        }
        Console.ForegroundColor = ConsoleColor.Green;
        switch (student.TakhsAverage())
        {
            case >= 17:
                Console.WriteLine("Moadel Doros** : " + student.TakhsAverage() + "      Grade : A");
                break;
            case >= 15 and < 17:
                Console.WriteLine("Moadel Doros** : " + student.TakhsAverage() + "      Grade : B");
                break;
            case >= 13 and < 15:
                Console.WriteLine("Moadel Doros** : " + student.TakhsAverage() + "      Grade : C");
                break;
            case >= 10 and < 13:
                Console.WriteLine("Moadel Doros** : " + student.TakhsAverage() + "      Grade : D");
                break;
            case >= 7 and < 10:
                Console.WriteLine("Moadel Doros** : " + student.TakhsAverage() + "      Grade : E");
                break;
            case >= 3 and < 7:
                Console.WriteLine("Moadel Doros** : " + student.TakhsAverage() + "      Grade : F");
                break;
            case >= 0:
                Console.WriteLine("Moadel Doros** : " + student.TakhsAverage() + "      Grade : G");
                break;
        }
        Console.ForegroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Magenta;

        switch (student.Takhs2Average())
        {
            case >= 17:
                Console.WriteLine("Moadel Doros* : " + student.Takhs2Average() + "      Grade : A");
                break;
            case >= 15 and < 17:
                Console.WriteLine("Moadel Doros* : " + student.Takhs2Average() + "      Grade : B");
                break;
            case >= 13 and < 15:
                Console.WriteLine("Moadel Doros* : " + student.Takhs2Average() + "      Grade : C");
                break;
            case >= 10 and < 13:
                Console.WriteLine("Moadel Doros* : " + student.Takhs2Average() + "      Grade : D");
                break;
            case >= 7 and < 10:
                Console.WriteLine("Moadel Doros* : " + student.Takhs2Average() + "      Grade : E");
                break;
            case >= 3 and < 7:
                Console.WriteLine("Moadel Doros* : " + student.Takhs2Average() + "      Grade : F");
                break;
            case >= 0:
                Console.WriteLine("Moadel Doros* : " + student.Takhs2Average() + "      Grade : G");
                break;
        }
        Console.ForegroundColor = ConsoleColor.White;

        Console.WriteLine("=====================");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("--------------------------------------------------");
        Console.ForegroundColor = ConsoleColor.White;

    }

    foreach (var student in students)
    {








    }
}

class Student
{
    public string FName { get; set; }

    public string LName { get; set; }

    public double PishrafteMark { get; set; }

    public double tafsirMark { get; set; }

    public double MathMark { get; set; }

    public double KargahMark { get; set; }

    public double ZabanMark { get; set; }

    public double Pishrafte2Mark { get; set; }

    public double SheygaraeiMark { get; set; }

    public double TarbiyatMark { get; set; }

    public double SystemMark { get; set; }

    public double AlogoritmMark { get; set; }


    public double TotalAverage()
    {
        return Math.Round((((PishrafteMark * 3) + (tafsirMark) + (MathMark * 2) + (KargahMark) + (ZabanMark * 2) + (Pishrafte2Mark * 3) +
            (SheygaraeiMark * 3) + (TarbiyatMark) + (SystemMark * 3) + (AlogoritmMark * 3)) / 22), 2);
    }


    public double TakhsAverage()
    {
        return Math.Round((((PishrafteMark * 3) + (Pishrafte2Mark * 3) +
            (SheygaraeiMark * 3)) / 9), 2);
    }

    public double Takhs2Average()
    {
        return Math.Round((((SystemMark * 3) + (AlogoritmMark * 3)) / 6), 2);
    }
}