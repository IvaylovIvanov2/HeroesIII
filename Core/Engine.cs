using System;
using System.IO;
using System.Text;

public class Engine : IEngine
{
    private readonly IReader reader;
    private readonly IWriter writer;
    private readonly ICommandInterpreter commandInterpreter;
    private readonly StringBuilder commandsLog;
    private bool saveLoaded;
    private string saveFile;

    public Engine(IReader reader, IWriter writer, ICommandInterpreter commandInterpreter)
    {
        this.reader = reader;
        this.writer = writer;
        this.commandInterpreter = commandInterpreter;
        commandsLog = new StringBuilder();
    }

    public void Run()
    {
        LoadSave();
        Console.WriteLine("Enjoy playing!");
        string input = this.reader.ReadLine();
        while(true)
        {
            string[] commandTokens = this.ParseInput(input);
            if (commandTokens[0] == "END")
            {
                if(commandsLog.Length != 0)
                SaveGame();
                break;
            }
            try
            {
                this.writer.WriteLine(this.commandInterpreter.InterpretCommand(commandTokens));
                commandsLog.AppendLine(input);
            }
            catch(Exception e)
            {
                writer.WriteLine(e.Message);
            }

            input = Console.ReadLine();
        }
    }

    private void LoadSave()
    {
        Console.Write("Do you want to load a save? Y/N - ");
        saveLoaded = false;
        string answer = Console.ReadLine();
        while (answer != "Y" && answer != "N")
        {
            Console.WriteLine("Try again, Y - yes, N - no");
            answer = Console.ReadLine();
        }

        if (answer == "Y")
        {
            saveLoaded = true;
            Console.Write("Name of your save: ");
            var fileName = Console.ReadLine();
            StreamReader file = null;
            while (file == null)
            {
                try
                {
                    file = new StreamReader($"...\\Saves\\{fileName}.txt");
                }
                catch (FileNotFoundException e)
                {
                    Console.Write("No such save, try again: ");
                    fileName = Console.ReadLine();
                }
            }
            saveFile = fileName;
            string line;
            while((line = file.ReadLine()) != null)
            {
                commandsLog.AppendLine(line);
                string[] commandTokens = this.ParseInput(line);
                this.writer.WriteLine(this.commandInterpreter.InterpretCommand(commandTokens));
            }
            file.Close();
            Console.Write($"Save {fileName} was loaded successfully!\n\rDo you want to clear the console? Y/N - ");
            answer = Console.ReadLine();
            if (answer == "Y")
                Console.Clear();
        }   
    }

    private void SaveGame()
    {
        Console.Write("Do you want to save your game? Y/N - ");
        string answer = Console.ReadLine();

        while (answer != "Y" && answer != "N")
        {
            Console.WriteLine("Try again, Y - yes, N - no");
            answer = Console.ReadLine();
        }

        if (answer == "Y")
        {
            if (saveLoaded == false)
            {
                Console.Write("Name of your save: ");
                string fileName = Console.ReadLine();
                while (File.Exists($"...\\Saves\\{fileName}.txt"))
                {
                    Console.Write("Save already exists!\n\rA different name for this save is required!: ");
                    fileName = Console.ReadLine();
                }
                File.WriteAllText($"...\\Saves\\{fileName}.txt", commandsLog.ToString());
            }
            else
            {
                File.WriteAllText($"...\\Saves\\{saveFile}.txt", commandsLog.ToString());
            }
            Console.WriteLine("Saved!");
        }
    }

    private string[] ParseInput(string v)
    {
        return v.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
    }
}
