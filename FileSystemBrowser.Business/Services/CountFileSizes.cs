using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileSystemBrowser.Business.Services
{
    public class CountFileSizes
    {
        public static int[] GetCount(string directory)
        {
            int lessThan10 = 0, More10Less50 = 0, More100 = 0;

            double size;
            double mb;

            IEnumerable<string> files = EnumerateFiles(directory, ".", SearchOption.AllDirectories);

            foreach (string fileName in files)
            {
                FileInfo fi = new FileInfo(fileName);
                if ((fi.Attributes & FileAttributes.Hidden) != FileAttributes.Hidden)
                {
                    size = fi.Length;
                    mb = size / 1000000;
                    if (mb <= 10)
                    {
                        lessThan10++;
                    }
                    else if (mb > 10 & mb <= 50)
                    {
                        More10Less50++;
                    }
                    else if (mb >= 100)
                    {
                        More100++;
                    }
                }
            }

            int[] results = new int[] { lessThan10, More10Less50, More100 };
            return results;
        }

        static IEnumerable<string> EnumerateFiles(string path, string searchPattern, SearchOption searchOpt)
        {
            try
            {
                var dirFiles = Enumerable.Empty<string>();
                if (searchOpt == SearchOption.AllDirectories)
                {
                    dirFiles = Directory.EnumerateDirectories(path)
                                        .SelectMany(x => EnumerateFiles(x, searchPattern, searchOpt));
                }
                return dirFiles.Concat(Directory.EnumerateFiles(path, searchPattern));
            }
            catch (UnauthorizedAccessException)
            {
                return Enumerable.Empty<string>();
            }
        }

    }
}
