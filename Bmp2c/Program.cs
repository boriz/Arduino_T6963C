using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.IO;


class Program
{
    static void Main(string[] args)
    {
        if (args.Length != 1)
        {
            Console.WriteLine("Converts bmp image to C-style (HEX) array to be used on monochrome LCD dispaly");
            Console.WriteLine("Usage: bmp2c.exe <file_name.bmp>");
            return;
        }

        if (!File.Exists(args[0]))
        {
            Console.WriteLine(string.Format("File {0} does not exists", args[0]));
            return;
        }

        Bitmap bmp=null;
        try
        {
            // Try to read bmp from the file
            Image img = Image.FromFile(args[0]);
            bmp = (Bitmap)img;
        }
        catch (Exception ex)
        {
            Console.WriteLine(string.Format("Can not parse image file {0}; Exeption: {1}", args[0], ex.ToString()));
            return;
        }

        string strOrigFileName = Path.GetFileNameWithoutExtension(args[0]);
        string strNewFileNameExt = string.Format("{0}{1}", strOrigFileName, ".hex");

        StreamWriter outFile = new StreamWriter(strNewFileNameExt);
        Console.WriteLine(string.Format("Creating output file: {0}", strNewFileNameExt));

        int Elements = 0;   // Total bytes
        for (int y = 0; y < bmp.Height; y++)
        {
            int x = 0;  // Columns
            while (x < bmp.Width)
            {
                byte b = 0;
                for (int i = 0; i < 8; i++)
                {
                    b = (byte)(b << 1);
                    // GetBrightness scaled between 0.0 and 1.0
                    if (bmp.GetPixel(x, y).GetBrightness() <= 0.8)
                    {
                        // Assume dark pixel
                        b |= 0x01;
                    }                        
                    x++;
                }
                outFile.Write("0x" + b.ToString("X2") + ", ");
                Elements++; // Got the whole byte
            }
            // Next row
            outFile.WriteLine();
        }

        // All done
        outFile.Close();
        Console.WriteLine(string.Format("Done. Bytes: {0}", Elements.ToString()));
    }
}
