using System.IO;

public class SaveManager : ISaveable
{
	private string filePath = "Last score.txt";
	public int LastScore;

	public void Save()
	{
		File.WriteAllText(filePath, LastScore.ToString());
	}

	public void Load()
	{
		if (File.Exists(filePath))
		{
			string text = File.ReadAllText(filePath);

			if (int.TryParse(text, out int score))
			{
				LastScore = score;
			}
		}
	}
}