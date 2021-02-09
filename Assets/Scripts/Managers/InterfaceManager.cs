using UnityEngine;
using TMPro;
using UnityEngine.Audio;
using UnityEngine.Localization.Settings;

public class InterfaceManager : MonoBehaviour
{
	public GameObject player;
	public GameObject gameManager;
	public GameObject scoreManager;
	public GameObject obstacleManager;
	//DevMode Interface
	public GameObject interfaceDevMode;
	public TextMeshProUGUI textDevModeBuild;
	public TextMeshProUGUI textDevModeFps;
	public TextMeshProUGUI textDevModeSpeed;
	public TextMeshProUGUI textDevModeForce;
	public TextMeshProUGUI textDevModeCheckPoint;
	public TextMeshProUGUI textDevModePosition;
	//Score Interface
	public TextMeshProUGUI textScore;
	//Geral Interface
	public GameObject interfaceGeral;
	//GameOver Interface
	public GameObject interfaceGameOver;
	public TextMeshProUGUI textGameOverScore;
	public TextMeshProUGUI textGameOverHighScore;
	//About Interface
	public GameObject interfaceAbout;
	//Settings Interface
	public GameObject interfaceSettings;
	public AudioMixer audioMixer;
	//Home Interface
	public GameObject interfaceHome;

	void Update()
	{
		if (gameManager.GetComponent<GameManager>().developerMode)
		{
			DeveloperModeInterface();
		}
		else
		{
			interfaceDevMode.SetActive(false);
		}
		ScoreInterface();
	}
	public void DeveloperModeInterface()
	{
		interfaceDevMode.SetActive(true);

		string fpsteste = (1.0 / Time.deltaTime).ToString("0");
		float playerSpeed = player.GetComponent<PlayerMovement>().speed;
		float lateralForce = player.GetComponent<PlayerMovement>().sidewaysForce;
		float checkpointDistance = player.GetComponent<PlayerMovement>().checkpoint;
		string playerPosition = player.transform.position.z.ToString("0");
		
		textDevModeBuild.text = $"Build: {Application.version}";

		textDevModeFps.text = $"Fps: {fpsteste}";

		textDevModeSpeed.text = $"Player_Speed: {playerSpeed}";

		textDevModeForce.text = $"Lateral_Force: {lateralForce}";

		textDevModeCheckPoint.text = $"CheckPoint_Distance: {checkpointDistance}";

		textDevModePosition.text = $"Player_Position: {playerPosition}";
	}
	public void ScoreInterface()
	{
		//Exibe a posição do jogador
		textScore.text = (player.transform.position.z / 10).ToString("0");
	}
	public void GameOverInterface()
	{
		interfaceGeral.SetActive(true);
		interfaceGameOver.SetActive(true);

		string score = scoreManager.GetComponent<ScoreManager>().score.ToString("0");
		string highScore = scoreManager.GetComponent<ScoreManager>().scoreHigh.ToString("0");

		textGameOverScore.text = score;
		textGameOverHighScore.text = highScore;
	}
	public void StartGame()
	{
		gameManager.GetComponent<GameManager>().StartGame();
		gameManager.GetComponent<GameManager>().ResetPlayer();
		interfaceGeral.SetActive(false);
		interfaceHome.SetActive(false);
		player.SetActive(true);
		obstacleManager.SetActive(true);
	}
	public void OpenSetting()
	{
		interfaceHome.SetActive(false);
		interfaceSettings.SetActive(true);
	}
	public void OpenAbout()
	{
		interfaceHome.SetActive(false);
		interfaceAbout.SetActive(true);
	}
	public void ExitGame()
	{
		Application.Quit();
	}
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
	public void BackHome()
	{
		interfaceSettings.SetActive(false);
		interfaceAbout.SetActive(false);
		interfaceGameOver.SetActive(false);
		interfaceHome.SetActive(true);
	}
	public void OpenGithub()
	{
		Application.OpenURL("https://github.com/ArthurSegato");
	}
	public void OpenWebsite()
	{
		Application.OpenURL("https://arthursegato.com/");
	}
	public void OpenStore()
	{
		Application.OpenURL("https://arthursegato.itch.io/");
	}
	public void OpenStreamBeats()
	{
		Application.OpenURL("https://www.youtube.com/c/StreamBeatsbyHarrisHeller/");
	}
	public void OpenGoogleFonts()
	{
		Application.OpenURL("https://fonts.google.com/specimen/Roboto");
	}
	public void PlayAgain()
	{
		gameManager.GetComponent<GameManager>().StartGame();
		gameManager.GetComponent<GameManager>().ResetPlayer();
		interfaceGameOver.SetActive(false);
		interfaceGeral.SetActive(false);
		obstacleManager.SetActive(true);
	}
}
