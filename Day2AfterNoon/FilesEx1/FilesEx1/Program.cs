using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FilesEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            // if used ,"using()", no need of closing files, automatically it will close
            using(StreamWriter source= new StreamWriter("original.txt") ){
                source.WriteLine("Line1");
                source.WriteLine("Line2");
                source.WriteLine("Line3");
                source.WriteLine("Line4");
            }
            Console.WriteLine("Contents of the original file are :");
            using(StreamReader read=new StreamReader("original.txt")){
                Console.WriteLine(read.ReadToEnd());
            }
            List<string> data = new List<string>();
            using (StreamReader read = new StreamReader("original.txt"))
            {
                string line;
                while ((line = read.ReadLine()) != null)
                {
                    data.Add(line);
                }
            }
            data.Reverse();

            using (StreamWriter destination = new StreamWriter("destination.txt"))
            {
                foreach(string line in data){
                    destination.WriteLine(line);
                }

            }
            Console.WriteLine("Content after the reversed file");
            
                using (StreamReader read = new StreamReader("destination.txt"))
                {
                    Console.WriteLine(read.ReadToEnd());
                }
                Console.Read();

        }
    }
}
