using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;

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
		LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[languageIndex];
	}
}
