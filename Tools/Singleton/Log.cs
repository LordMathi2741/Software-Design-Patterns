namespace Tools.Singleton;

public class Log
{
    private  static Log _instance;
    private string _path;

    private Log(string path)
    {
        _path = path;
    }
    
    public static Log GetInstance(string path)
    {
        if (_instance == null)
        {
            _instance = new Log(path);
        }
        return _instance;
    }

    public void Save(string message)
    {
        File.AppendAllLines(_path,[message + Environment.NewLine]);
    }
}