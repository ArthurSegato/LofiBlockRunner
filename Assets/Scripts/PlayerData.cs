[System.Serializable]
public class PlayerData
{
	public float scoreHighSaved;

	public PlayerData(ScoreManager player)
	{
		scoreHighSaved = player.scoreHigh;
	}
}
