using System;
using System.Text.RegularExpressions;
using Geco.Common.SimpleMetadata;

namespace Geco.Util
{
    public class Util
    {
        public static bool TableNameMatchesRegex(Table table, string tablesRegex, bool onNull)
        {
            if (String.IsNullOrWhiteSpace(tablesRegex))
                return onNull;
            return
                (
                    Regex.IsMatch(table.Name, tablesRegex) ||
                    Regex.IsMatch($"[{table.Name}]", tablesRegex) ||
                    Regex.IsMatch($"{table.Schema.Name}.{table.Name}", tablesRegex) ||
                    Regex.IsMatch($"[{table.Schema.Name}].[{table.Name}]", tablesRegex)
                );
        }

        public static bool TableNameMatches(Table table, string name)
        {
            return string.Equals(name, table.Name, StringComparison.OrdinalIgnoreCase) ||
                   string.Equals(name, $"[{table.Name}]", StringComparison.OrdinalIgnoreCase) ||
                   string.Equals(name, $"{table.Schema.Name}.{table.Name}", StringComparison.OrdinalIgnoreCase) ||
                   string.Equals(name, $"[{table.Schema.Name}].[{table.Name}]", StringComparison.OrdinalIgnoreCase);
        }
    }
}