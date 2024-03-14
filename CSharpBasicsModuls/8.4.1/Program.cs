
string SettingsFileName = @"/Users/s.hlestunov/Repositories/C_SharpBasics/CSharpBasicsModuls/BinaryFile.bin";

ReadValues(ref SettingsFileName);

static void ReadValues(ref string way)
{
    string inFile;

    if (File.Exists(way))
    {
        using (BinaryReader reader = new BinaryReader(File.Open(way, FileMode.Open)))
        {
            inFile = reader.ReadString();
        }

        Console.WriteLine("Из файла считано:");

        Console.WriteLine(inFile);
    }
}