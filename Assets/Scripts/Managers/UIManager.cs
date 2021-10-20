using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Localization.Settings;
using System.Collections;

public class UIManager : MonoBehaviour
{
	public int interfaceFadeDelay;
	
	[SerializeField]
	private GameObject UI_About;
	[SerializeField]
	private GameObject UI_Settings;
	[SerializeField]
	private GameObject UI_Home;
	[SerializeField]
	private GameObject UI_Score;
	[SerializeField]
	private GameObject UI_GameOver;
	[SerializeField]
	private TMPro.TMP_Text UI_Score_Text;
	[SerializeField]
	private TMPro.TMP_Text UI_GameOver_Score;
	[SerializeField]
	private TMPro.TMP_Text UI_GameOver_HighScore;
	[SerializeField]
	private TMPro.TMP_Dropdown UI_Settings_Quality;
	
	private GameObject player;
	private	GameObject gameManager;
	private GameObject scoreManager;

	void Start()
	{
		player = GameObject.Find("Player");
		gameManager = GameObject.Find("Manager_Game");
		scoreManager = GameObject.Find("Manager_Score");
	}
	void Update()
	{
		UI_Score_Text.text = scoreManager.GetComponent<ScoreManager>().GetScore();
	}
	public void Open_UI_Home()
	{
		StartCoroutine(Close_UI(UI_About));
		StartCoroutine(Close_UI(UI_Settings));
		StartCoroutine(Close_UI(UI_GameOver));
		StartCoroutine(Open_UI(UI_Home));
	}
	public void Open_UI_Settings()
	{
		StartCoroutine(Close_UI(UI_Home));
		StartCoroutine(Open_UI(UI_Settings));
	}
	public void Open_UI_About()
	{
		StartCoroutine(Close_UI(UI_Home));
		StartCoroutine(Open_UI(UI_About));
	}
	public void Open_UI_GameOver()
	{
		StartCoroutine(Close_UI(UI_Score));
		StartCoroutine(Open_UI(UI_GameOver));
	}
	public void Start_Game()
	{
		StartCoroutine(Close_UI(UI_Home));
		StartCoroutine(Close_UI(UI_GameOver));
		StartCoroutine(Open_UI(UI_Score));
		gameManager.GetComponent<GameManager>().StartGame();
	}
	public void SetScore(float score, float highscore)
	{
		UI_GameOver_Score.text = score.ToString("0");
		UI_GameOver_HighScore.text = highscore.ToString("0");
	}
	public void Close_Game()
	{
		Application.Quit();
	}
	public void Open_Github()
	{
		Application.OpenURL("https://github.com/ArthurSegato");
	}
	public void Open_Website()
	{
		Application.OpenURL("https://arthursegato.com/");
	}
	public void Open_Store()
	{
		Application.OpenURL("https://arthursegato.itch.io/");
	}
	public void Open_StreamBeats()
	{
		Application.OpenURL("https://www.youtube.com/c/StreamBeatsbyHarrisHeller/");
	}
	public void Open_GoogleFonts()
	{
		Application.OpenURL("https://fonts.google.com/specimen/Roboto");
	}
	public void Set_Quality()
	{
		QualitySettings.SetQualityLevel(UI_Settings_Quality.value, true);
	}
	public void MostrarIntro(){
		//var videoPlayer = GetComponent<Camera>().AddComponent<UnityEngine.Video.VideoPlayer>();
	}
	IEnumerator Open_UI(GameObject targetInterface)
	{
		targetInterface.SetActive(true);
		yield return new WaitForSeconds(interfaceFadeDelay / 2);
	}
	IEnumerator Close_UI(GameObject targetInterface)
	{
		targetInterface.SetActive(false);
		yield return new WaitForSeconds(interfaceFadeDelay / 2);
	}
}
