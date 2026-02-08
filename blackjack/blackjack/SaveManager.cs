using System.IO;

public class SaveManager
{
	private string filePath = "Viimeisin käsi.txt";

	public void SaveScore(int score)
	{
		File.WriteAllText(filePath, score.ToString());
	}

	public int LoadScore()
	{
		if (File.Exists(filePath))
		{
			string text = File.ReadAllText(filePath);
			return int.Parse(text);
		}

		return 0;
	}
}
