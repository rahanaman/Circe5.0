using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices.WindowsRuntime;
using static UnityEngine.EventSystems.EventTrigger;

public class CSVReader
{
    static string SPLIT_RE = @",(?=(?:[^""]*""[^""]*"")*(?![^""]*""))"; // REGEX ����ǥ 0,2���� ���� �� �տ� �ִ� �� ī��Ʈ, 1���� ������ ī��ƮX

    static string LINE_SPLIT_RE = @"\r\n|\n\r|\n|\r";
    static char[] TRIM_CHARS = { '\"' };
    public static List<Dictionary<string, object>> Read(TextAsset data)
    {
        var list = new List<Dictionary<string, object>>();

        var lines = Regex.Split(data.text, LINE_SPLIT_RE);

        if (lines.Length <= 1) return list;

        var header = Regex.Split(lines[0], SPLIT_RE);
        for (var i = 1; i < lines.Length; i++)
        {

            var values = Regex.Split(lines[i], SPLIT_RE);
            if (values.Length == 0 || values[0] == "") continue;

            var entry = new Dictionary<string, object>();
            for (var j = 0; j < header.Length && j < values.Length; j++)
            {
                string value = values[j];
                value = value.TrimStart(TRIM_CHARS).TrimEnd(TRIM_CHARS).Replace("\\", "");
                object finalvalue = value;
                int n;
                float f;
                if (int.TryParse(value, out n))
                {
                    finalvalue = n;
                }
                else if (float.TryParse(value, out f))
                {
                    finalvalue = f;
                }
                entry[header[j]] = finalvalue;
            }
            list.Add(entry);
        }
        return list;
    }

    public static List<object> ReadLine(string data)
    {
        List<object> list = new List<object>();
        var values = Regex.Split(data, SPLIT_RE);
        for(int i =0; i < values.Length; ++i)
        {
            string value = values[i];
            value = value.TrimStart(TRIM_CHARS).TrimEnd(TRIM_CHARS).Replace("\\", "");
            object finalvalue = value;
            int n;
            float f;
            if (int.TryParse(value, out n))
            {
                finalvalue = n;
            }
            else if (float.TryParse(value, out f))
            {
                finalvalue = f;
            }
            list.Add(finalvalue);
        }
        
        return list;
    }
}

public class CSVWriter
{
    public static string Write(PlayerData data)
    {
        string save = "";
        save += @""""+ data.ID + @""",";
        save += @""""+ data.CurrentHP + @""",";
        save += @""""+ data.MaxHP + @""",";
        save += @""""+ data.MaxMP + @""",";
        save += @""""+ data.RestoreMP + @""",";
        string card = "";
        for(int i = 0; i < data.Cards.Count; ++i)
        {
            card += data.Cards[i] + ",";
        }
        save += @"""" + card + @"""";

        return save;

    }
}

public class StringParser
{
    static string NUM_PARSE = @"{[\d]*}";
    public static string ParseDesc(string desc, int[] data)
    {
        string str = desc;
        MatchCollection mc = Regex.Matches(str, NUM_PARSE);
        foreach (Match m in mc)
        {
            string value = m.Value;
            //{1}
            int index = int.Parse(value.Trim('{').TrimEnd('}'));
            if (0 <= index && index < data.Length)
            {
                str = Regex.Replace(str, string.Concat("\\", value), data[index].ToString());
            }
        }
        return str;
    }
}