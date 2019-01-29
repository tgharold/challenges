using System;
using System.Collections.Generic;
using System.IO;

namespace Hunter2.ReaderTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hunter2.ReaderTest");

            var path = "/etc";

            StackBasedIteration.TraverseTree(new DirectoryInfo(path));

        }
    }

    public class StackBasedIteration
    {
        public static void TraverseTree(DirectoryInfo root)
        {
            // Data structure to hold names of subfolders to be
            // examined for files.
            Stack<DirectoryInfo> dirs = new Stack<DirectoryInfo>(20);

            if (!root.Exists)
            {
                throw new ArgumentException();
            }
            dirs.Push(root);

            while (dirs.Count > 0)
            {
                DirectoryInfo currentDir = dirs.Pop();
                DirectoryInfo[] subDirs;
                try
                {
                    subDirs = currentDir.GetDirectories();
                }
                // An UnauthorizedAccessException exception will be thrown if we do not have
                // discovery permission on a folder or file. It may or may not be acceptable 
                // to ignore the exception and continue enumerating the remaining files and 
                // folders. It is also possible (but unlikely) that a DirectoryNotFound exception 
                // will be raised. This will happen if currentDir has been deleted by
                // another application or thread after our call to Directory.Exists. The 
                // choice of which exceptions to catch depends entirely on the specific task 
                // you are intending to perform and also on how much you know with certainty 
                // about the systems on which this code will run.
                catch (UnauthorizedAccessException e)
                {                    
                    Console.WriteLine(e.Message);
                    continue;
                }
                catch (System.IO.DirectoryNotFoundException e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }

                FileInfo[] files = null;
                try
                {
                    files = currentDir.GetFiles();
                }

                catch (UnauthorizedAccessException e)
                {
                    
                    Console.WriteLine(e.Message);
                    continue;
                }

                catch (System.IO.DirectoryNotFoundException e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
                // Perform the required action on each file here.
                // Modify this block to perform your required task.
                foreach (var file in files)
                {
                    try
                    {
                        // Perform whatever action is required in your scenario.
                        var fi = file;
                        //Console.WriteLine("{0}: {1}, {2}", fi.Name, fi.Length, fi.CreationTime);
                    }
                    catch (System.IO.FileNotFoundException e)
                    {
                        // If file was deleted by a separate application
                        //  or thread since the call to TraverseTree()
                        // then just continue.
                        Console.WriteLine(e.Message);
                        continue;
                    }
                }

                // Push the subdirectories onto the stack for traversal.
                // This could also be done before handing the files.
                foreach (DirectoryInfo str in subDirs)
                    dirs.Push(str);
            }
        }
    }
}
