﻿using System.Numerics;
ZipCode zipCode = new ZipCode(12345, 1234);

Console.WriteLine(zipCode.FiveDigitCode);
Console.WriteLine(zipCode.PlusFourExtension);

//Пример хорошего дизайна.
struct ZipCode
{
    int fiveDigitCode;
    int plusFourExtension;
    //Конструкторы
    public ZipCode(int fiveDigitCode, int plusFourExtension)
    {
        this.fiveDigitCode = fiveDigitCode;
        this.plusFourExtension = plusFourExtension;
    }

    public ZipCode(int fiveDigitCode)
        :this(fiveDigitCode, 0)
    {   
    }
    //Свойства
    public int FiveDigitCode
    {
        get { return fiveDigitCode; }
    }

    public int PlusFourExtension
    {
        get { return plusFourExtension; }
    }
}