using Newtonsoft.Json;
using System.Xml.Linq;

namespace FileTaskSt;
internal class FileHelper
{
    private List<string> _names = [];
    public string Path { get; }

    public FileHelper(string path)
    {
        Path = path;
    }

    public async Task AppendAsync(List<string> text)
    {
        using StreamWriter sw = new StreamWriter(Path, true);
        foreach (var line in text)
        {
            await sw.WriteLineAsync(line);
        }
    }

    public async Task ReplaceAsync(string json)
    {
        using StreamWriter sw = new StreamWriter(Path, false); 
        await sw.WriteAsync(json);
    }

    public async Task<string> ReadAsync()
    {
        using StreamReader sr = new StreamReader(Path);
        return await sr.ReadToEndAsync();
    }

    public async Task AddAsync(string name)
    {
        var result = await ReadAsync();
        _names = JsonConvert.DeserializeObject<List<string>>(result);
        _names.Add(name);
        string json = JsonConvert.SerializeObject(_names);
        await ReplaceAsync(json);
    }

    public async Task<bool> ExistsAsync(string name)
    {
        var result = await ReadAsync();
        _names = JsonConvert.DeserializeObject<List<string>>(result);
        return _names.Contains(name);

    }

    public async Task UpdateAsync(int index,string name)
    {
        var result = await ReadAsync();
        _names = JsonConvert.DeserializeObject<List<string>>(result);
        _names[index]= name;
        string json = JsonConvert.SerializeObject(_names);
        await ReplaceAsync(json);
    }
    public async Task DeleteAsync(int index)
    {
        var result = await ReadAsync();
        _names = JsonConvert.DeserializeObject<List<string>>(result);
        _names.RemoveAt(index);
        string json = JsonConvert.SerializeObject(_names);
        await ReplaceAsync(json);

    }
}


