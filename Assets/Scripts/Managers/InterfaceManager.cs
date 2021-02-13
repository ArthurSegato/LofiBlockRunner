using TMPro;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Localization.Settings;
using System.Collections;

public class InterfaceManager : MonoBehaviour
{
	public float interfaceFadeDelay;
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
	public CanvasGroup interfaceGeral;
	//GameOver Interface
	public CanvasGroup interfaceGameOver;
	public TextMeshProUGUI textGameOverScore;
	public TextMeshProUGUI textGameOverHighScore;
	//About Interface
	public CanvasGroup interfaceAbout;
	//Settings Interface
	public CanvasGroup interfaceSettings;
	public AudioMixer audioMixer;
	[HideInInspector]
	public int languageIndex = 0;
	[HideInInspector]
	public float volumeLevel = 0f;
	//Home Interface
	public CanvasGroup interfaceHome;
	
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
		StartCoroutine(OpenInterface(interfaceGeral));
		StartCoroutine(OpenInterface(interfaceGameOver));

		StartCoroutine(gameManager.GetComponent<GameManager>().ResetPlayer());

		string score = scoreManager.GetComponent<ScoreManager>().score.ToString("0");
		string highScore = scoreManager.GetComponent<ScoreManager>().scoreHigh.ToString("0");

		textGameOverScore.text = score;
		textGameOverHighScore.text = highScore;
	}
	public void StartGame()
	{
		StartCoroutine(CloseInterface(interfaceHome));
		StartCoroutine(CloseInterface(interfaceGeral));
		gameManager.GetComponent<GameManager>().StartGame();
		player.SetActive(true);
		obstacleManager.SetActive(true);
	}
	public void OpenSetting()
	{
		StartCoroutine(CloseInterface(interfaceHome));
		StartCoroutine(OpenInterface(interfaceSettings));
	}
	public void OpenAbout()
	{
		StartCoroutine(CloseInterface(interfaceHome));
		StartCoroutine(OpenInterface(interfaceAbout));
	}
	public void ExitGame()
	{
		Application.Quit();
	}
	public void SetVolume(float volumeLevel)
	{
		audioMixer.SetFloat("volumeMixer", volumeLevel * -30f);
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
		StartCoroutine(CloseInterface(interfaceAbout));
		StartCoroutine(CloseInterface(interfaceSettings));
		StartCoroutine(CloseInterface(interfaceGameOver));
		StartCoroutine(OpenInterface(interfaceGeral));
		StartCoroutine(OpenInterface(interfaceHome));
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
		StartCoroutine(CloseInterface(interfaceGeral));
		StartCoroutine(CloseInterface(interfaceGameOver));
		gameManager.GetComponent<GameManager>().StartGame();
		obstacleManager.SetActive(true);
	}
	IEnumerator OpenInterface(CanvasGroup targetInterface)
	{
		yield return new WaitForSeconds(interfaceFadeDelay / 2);
		targetInterface.DOFade(1f, interfaceFadeDelay);
		targetInterface.blocksRaycasts = true;
		targetInterface.interactable = true;
		
	}
	IEnumerator CloseInterface(CanvasGroup targetInterface)
	{
		targetInterface.DOFade(0f, interfaceFadeDelay);
		targetInterface.blocksRaycasts = false;
		targetInterface.interactable = false;
		yield return new WaitForSeconds(interfaceFadeDelay / 2);
	}
}
