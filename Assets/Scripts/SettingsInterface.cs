using UnityEngine;
using UnityEngine.Audio;

public class SettingsInterface : MonoBehaviour
{
	public AudioMixer audioMixer;
    public void SetVolume(float volume)
	{
		audioMixer.SetFloat("volumeMixer", volume * -30f);
	}
	public void SetQuality(int qualityIndex)
	{
		QualitySettings.SetQualityLevel(qualityIndex);
	}
	public void SetLanguage(int languageIndex)
	{
		Debug.Log(languageIndex);
	}
}
