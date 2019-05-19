using System.IO;
using System.Text.RegularExpressions;

namespace LogiCal
{
    static class PathValidator
    {
        public static string ValidatePath(string s)
        {
            s = s.Replace(" ", string.Empty);
            string regexSearch = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());
            Regex r = new Regex(string.Format("[{0}]", Regex.Escape(regexSearch)));
            return r.Replace(s, "");
        }
    }
}
