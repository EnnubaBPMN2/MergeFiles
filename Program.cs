using System;
using System.Collections.Generic;
using System.IO;
using Spire.Pdf;

namespace MergeFiles
{
    class MergeFiles
    {
        private static void Main(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine("Usage: MergeFiles  Filename1  Filename2");
                return;
            }

            var filesStreams = new List<Stream>
            {
                File.OpenRead(args[0]),
                File.OpenRead(args[1])
            };

            var outputFile = args[2];
            
            var result = PdfDocument.MergeFiles(filesStreams.ToArray());

            result.Save(outputFile);
        }
    }
}