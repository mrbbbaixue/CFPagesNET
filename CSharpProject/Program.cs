﻿class Program
{
    static void Main(string[] args)
    {
        string workingDirectory = "./";

        // Read parameters from build script.
        foreach (string arg in args)
        {
            if (arg.StartsWith("--working-dir="))
            {
                workingDirectory = arg.Split('=')[1];
                break;
            }
        }
        if (!Directory.Exists(workingDirectory))
        {
            Directory.CreateDirectory(workingDirectory);
        }

        Directory.SetCurrentDirectory(workingDirectory);
        Console.WriteLine("Current Directory: " + Directory.GetCurrentDirectory());


        // 文件路径
        string filePath = "index.html";

        // HTML 内容
        string htmlContent = @"
<!DOCTYPE html>
<html lang='en'>
<head>
    <meta charset='UTF-8'>
    <meta name='viewport' content='width=device-width, initial-scale=1.0'>
    <title>My Index Page</title>
    <style>
        body { font-family: Arial, sans-serif; text-align: center; padding: 50px; }
        h1 { color: #333; }
    </style>
</head>
<body>
    <h1>Welcome to My Index Page</h1>
    <p>This page was generated by a C# program!</p>
</body>
</html>";

        try
        {
            // 写入文件
            File.WriteAllText(filePath, htmlContent);
            Console.WriteLine($"HTML file '{filePath}' has been created successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
