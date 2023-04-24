using System.Text;

namespace Project_2;

public class ArrToString
{
    public static string ArrayToString(string[,] array)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                sb.Append(array[i, j]);
                sb.Append(",");
            }
            sb.AppendLine();
        }
        return sb.ToString();
    }
    
    
    public static string[,] StringToArray(string str)
    {
        string[] rows = str.Trim().Split('\n');
        int rowsCount = rows.Length;
        int colsCount = rows[0].Split(',').Length;
        string[,] array = new string[rowsCount, colsCount];
        for (int i = 0; i < rowsCount; i++)
        {
            string[] cols = rows[i].Split(',');
            for (int j = 0; j < colsCount; j++)
            {
                array[i, j] = cols[j];
            }
        }
        return array;
    }
}