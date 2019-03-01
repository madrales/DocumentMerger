using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DocumentMerger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Document Merger");
            Console.WriteLine("\n");
            Console.WriteLine("This program requires two documents to be provided." + "\n");
            do
            {
                Console.WriteLine("What is the name of the first document?");
                string doc1 = Console.ReadLine();
                if (File.Exists(doc1 + ".txt"))
                {
                    Console.WriteLine("The file exists." + "\n");
                    Console.WriteLine("Awesome! What is the name of the second document?");
                    string doc2 = Console.ReadLine();
                    if (File.Exists(doc2 + ".txt"))
                    {
                        Console.WriteLine("The file exists.");
                        Console.WriteLine("Both files exist! Time to get mergin'!" + "\n");
                        try
                        {
                            string newFilePath = (@"C:\" + doc1 + doc2 + ".txt");
                            string allText = System.IO.File.ReadAllText(doc1 + ".txt");
                            allText += "\n";
                            allText += System.IO.File.ReadAllText(doc2 + ".txt");
                            using (FileStream fs = new FileStream(newFilePath, FileMode.OpenOrCreate))
                            {
                                System.IO.File.WriteAllText(newFilePath, allText);
                            }
                            Console.WriteLine("File Merging was successful!");
                            Console.WriteLine("Would you like to merge more files? (y/n): ");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Excpetion: " + e.Message);
                        }
                    }
                    else
                    {
                        Console.WriteLine("The file does not exist. Please try again with an existing document.");
                        doc2 = Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("The file does not exist. Please retry with an existing document.");
                    doc1 = Console.ReadLine();
                }
            } while (Console.ReadLine().ToLower().Equals("y"));








        }
    }
}
