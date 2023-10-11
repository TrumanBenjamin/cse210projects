class scripture
{
    static void Main(string[] args)
    {
        string reference = "Wherefore, the Lord God gave unto man that he should aact for himself. Wherefore, man could not bact for himself save it should be that he was centiced by the one or the other.";

        string referencemod = reference.remove(0, 3);

        Console.WriteLine(referencemod);
    }

}