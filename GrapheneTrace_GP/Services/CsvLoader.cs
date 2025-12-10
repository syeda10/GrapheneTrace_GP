using System.Globalization;

namespace GrapheneTrace_GP.Services
{
    public class CsvLoader
    {
        private readonly string _basePath;

        public CsvLoader(IWebHostEnvironment env)
        {
            _basePath = Path.Combine(env.WebRootPath, "Heatmapdata");
        }

        // -----------------------------------------
        // Load latest CSV from folder
        // -----------------------------------------
        public string? GetLatestCsvPath()
        {
            if (!Directory.Exists(_basePath))
                return null;

            var files = Directory.GetFiles(_basePath, "*.csv");

            if (files.Length == 0)
                return null;

            // Sort by date contained in filename
            return files
                .OrderByDescending(f => ExtractDateFromFilename(f))
                .FirstOrDefault();
        }

        private DateTime ExtractDateFromFilename(string filePath)
        {
            var file = Path.GetFileNameWithoutExtension(filePath);
            var parts = file.Split('_');

            if (parts.Length < 2)
                return DateTime.MinValue;

            if (DateTime.TryParseExact(
                    parts[1],
                    "yyyyMMdd",
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.None,
                    out var date))
            {
                return date;
            }

            return DateTime.MinValue;
        }

        // -----------------------------------------
        // Read CSV into List<float[]> heatmap rows
        // -----------------------------------------
        public List<float[]> LoadCsvHeatmap(string csvPath)
        {
            var rows = new List<float[]>();

            foreach (var line in File.ReadLines(csvPath))
            {
                var cols = line.Split(',');

                float[] row = cols
                    .Select(c => float.Parse(c, CultureInfo.InvariantCulture))
                    .ToArray();

                rows.Add(row);
            }

            return rows;
        }
    }
}
