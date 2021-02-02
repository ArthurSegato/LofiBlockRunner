using UnityEngine;

public class SettingsInterface : MonoBehaviour
{
    public void SetQuality (int qualityIndex)
	{
		Debug.Log(QualitySettings.GetQualityLevel());
		QualitySettings.SetQualityLevel(qualityIndex);
	}
}
