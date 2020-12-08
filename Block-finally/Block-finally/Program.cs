using System;
using System.IO;
public class ProcessFile
{
    public static void Main()
    {
        FileStream fs = null;
        try
        {
            fs = new FileStream(@"C:\temp\data.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string line = sr.ReadLine();
            Console.WriteLine(line);
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }
        //The finally block is a block that contains a code to be executed regardless of whether or not an exception has occurred. 
        finally
        {
            if (fs != null)
            {
                fs.Close();
            }
        }
    }
}