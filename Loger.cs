namespace Diagnostic
{
    public static class Loger
    {
        public enum Type
        {
            Info,
            Warning,
            Error
        }
        public struct Log
        {
            public DateTime time = DateTime.Now;
            public Type type;
            public string text;

            public Log(string text, Type type)
            {
                this.type = type;
                this.text = text;
            }

            public override string ToString()
            {
                return $"{time} {type} {text}";
            }
        }
        public static List<Log> logs = new List<Log>();

        public static void Add(Log log)
        {
            logs.Add(log);
        }

        public static void Message(string text, Type type = Type.Info)
        {
            logs.Add(new Log(text, type));
        }
        public static void Warning(string text)
        {
            Message(text, Type.Warning);
        }
        public static void Error(string text)
        {
            Message(text, Type.Error);
        }
    }

    public static class FileLoger
    {
        public static void Save(string path)
        {
            File.WriteAllLinesAsync(path, Loger.logs.ConvertAll(log => log.ToString()));
        }
    }
}