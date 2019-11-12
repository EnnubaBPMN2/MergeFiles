using System;
using System.Collections.Generic;
using System.IO;
using Spire.Pdf;

namespace MergeFiles
{
    internal class MergeFiles
    {
        private static void Main(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine("Usage: MergeFiles  InputFile1.pdf  InputFile2.pdf  OutputFile.pdf");
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