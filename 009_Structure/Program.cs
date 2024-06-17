using System.Numerics;
ZipCode zipCode = new ZipCode();

zipCode.FiveDigitCode = 12345;
zipCode.PlusFourExtension = 1234;

Console.WriteLine(zipCode.FiveDigitCode);
Console.WriteLine(zipCode.PlusFourExtension);

//Пример плохого дизайна.
struct ZipCode
{
    int fiveDigitCode;
    int plusFourExtension;

    public int FiveDigitCode 
    {
        get { return fiveDigitCode; }
        set { fiveDigitCode = value; } 
    }

    public int PlusFourExtension
    {
        get { return plusFourExtension; }
        set { plusFourExtension = value; }
    }
}