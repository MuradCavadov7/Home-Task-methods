using System;
using System.Threading.Tasks;
using FileTaskSt;
using Newtonsoft.Json;

namespace FileTaskSt;

internal class Program
{
    static void Main(string[] args)
    {
        string path = new(@"C:\Users\99477\Desktop\homework\FileTaskSt\FileTaskSt\names.json");
        FileHelper helper = new (path);
        helper.AddAsync("Murad").Wait();
        helper.AddAsync("Farid").Wait();
        helper.DeleteAsync(2).Wait();
        helper.UpdateAsync(2, "Musa").Wait();
    }
}