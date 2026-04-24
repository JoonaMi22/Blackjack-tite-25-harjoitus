using System.IO;

public class SaveManager : ISaveable
//rajapinta ISaveable classista
{
	private string filePath = "Last score.txt";
	public int LastScore;

	public void Save() //tallentaa tekstin tiedostoon
	{
		File.WriteAllText(filePath, LastScore.ToString());
	}

	public void Load() //lataa tekstin tiedostosta
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