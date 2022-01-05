using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Localization.Settings;
using System.Collections;

public class UIManager : MonoBehaviour
{
	[Header("Global Settings")]
	[SerializeField]
	private float delayToStart = 0f;
	[SerializeField]
	private float animationDuration = 0f;
	[SerializeField]
	private float maxOpacity = 0f;
	[SerializeField]
	private float delayBetweenAnimation = 0f;
	[SerializeField]
	private GameObject uiBackground;
	[SerializeField]
	[Header("SplashScreen Settings")]
	private GameObject uiSplashScreen;
	[SerializeField]
	private GameObject splashScreen_Logo;
	[SerializeField]
	private float logoScale = 0f;
	[SerializeField]
	private float delayToChangeUI = 0f;
	[SerializeField]
	private float scaleDuration = 0f;
	[Header("MainMenu Settings")]
	[SerializeField]
	private GameObject uiMainMenu;
	[Header("About Settings")]
	[SerializeField]
	private GameObject uiAbout;

	private TMPro.TMP_Text UI_Score_Text;
	[SerializeField]
	private TMPro.TMP_Text UI_GameOver_Score;
	[SerializeField]
	private TMPro.TMP_Text UI_GameOver_HighScore;
	[SerializeField]
	private TMPro.TMP_Dropdown UI_Settings_Quality;

	// Seta todas as Interfacess para o estado padrão
	public IEnumerator StartUI()
	{
		uiBackground.SetActive(true);
		uiSplashScreen.SetActive(false);
		uiMainMenu.SetActive(false);
		uiAbout.SetActive(false);
		LeanTween.alphaCanvas(uiSplashScreen.GetComponent<CanvasGroup>(), 0f, 0f);
		LeanTween.alphaCanvas(uiMainMenu.GetComponent<CanvasGroup>(), 0f, 0f);
		LeanTween.alphaCanvas(uiAbout.GetComponent<CanvasGroup>(), 0f, 0f);
		yield return null;
	}

	public IEnumerator ShowSplash()
	{
		// Torna a UI Ativa
		uiSplashScreen.SetActive(true);
		// Mostra a logo
		LeanTween.alphaCanvas(uiSplashScreen.GetComponent<CanvasGroup>(), maxOpacity, animationDuration).setDelay(delayToStart);
		// Aumenta a logo
		LeanTween.scale(splashScreen_Logo.GetComponent<RectTransform>(), splashScreen_Logo.GetComponent<RectTransform>().localScale * logoScale, scaleDuration).setEase(LeanTweenType.easeOutCirc).setDelay(delayToStart);
		// Espera alguns segundos
		yield return new WaitForSeconds(delayBetweenAnimation);
		// Esconde a logo
		LeanTween.alphaCanvas(uiSplashScreen.GetComponent<CanvasGroup>(), 0f, animationDuration).setDelay(delayToStart);
		yield return new WaitForSeconds(delayToChangeUI);
		uiSplashScreen.SetActive(false);
		StartCoroutine(OpenUI(uiMainMenu));
		yield return null;
	}
	public void OpenAbout(){
		StartCoroutine(CloseUI(uiMainMenu));
		StartCoroutine(OpenUI(uiAbout));
	}
	// Abre a UI que foi passada
	private IEnumerator OpenUI(GameObject targetUI){
		yield return new WaitForSeconds(delayToChangeUI);
		targetUI.SetActive(true);
		LeanTween.alphaCanvas(targetUI.GetComponent<CanvasGroup>(), maxOpacity, animationDuration).setDelay(delayToStart / 2);
	}
	// Fecha a UI que foi passada
	private IEnumerator CloseUI(GameObject targetUI){
		LeanTween.alphaCanvas(targetUI.GetComponent<CanvasGroup>(), 0f, animationDuration).setDelay(delayToStart);
		yield return new WaitForSeconds(delayToStart);
		targetUI.SetActive(true);
		yield return null;
	}
	// Fecha o jogo
	public void CloseGame()
	{
		Application.Quit();
	}
	public void OpenWebsitesAbout(int option){
		if (option == 0){
			StartCoroutine(OpenWebsite());
		}
		else if (option == 1){
			StartCoroutine(OpenStreamBeats());
		}
		else if (option == 2){
			StartCoroutine(OpenGoogleFonts());
		}
		else{
			return;
		}
	}
	// Abre o meu site
	private IEnumerator OpenWebsite()
	{
		Application.OpenURL("https://arthursegato.com");
		yield return null;
	}
	// Abre o site do streamBeats
	private IEnumerator OpenStreamBeats()
	{
		Application.OpenURL("https://www.streambeats.com");
		yield return null;
	}
	// Abre o google fonts
	private IEnumerator OpenGoogleFonts()
	{
		Application.OpenURL("https://fonts.google.com/specimen/Roboto");
		yield return null;
	}
	/*
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
	public void Set_Quality()
	{
		QualitySettings.SetQualityLevel(UI_Settings_Quality.value, true);
	}
	*/
}
