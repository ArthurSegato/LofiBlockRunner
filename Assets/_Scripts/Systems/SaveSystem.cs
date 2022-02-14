using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
    public static void SaveScore(ScoreManager player)
	{
		BinaryFormatter formatter = new BinaryFormatter();
		string path = Application.persistentDataPath + "/player.score";
		FileStream stream = new FileStream(path, FileMode.Create);

		PlayerData data = new PlayerData(player);

		formatter.Serialize(stream, data);
		stream.Close();
	}
	public static PlayerData LoadScore()
	{
		string path = Application.persistentDataPath + "/player.score";
		if (File.Exists(path))
		{
			BinaryFormatter formatter = new BinaryFormatter();
			FileStream stream = new FileStream(path, FileMode.Open);

			PlayerData data = formatter.Deserialize(stream) as PlayerData;
			stream.Close();

			return data;
		}
		else
		{
			BinaryFormatter formatter = new BinaryFormatter();
			string newpath = Application.persistentDataPath + "/player.score";
			FileStream stream = new FileStream(path, FileMode.Create);
			stream.Close();
			return null;
		}
	}
}
