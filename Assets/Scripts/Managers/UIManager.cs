using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Localization.Settings;
using System.Collections;

public class UIManager : MonoBehaviour
{
	[Header("Global Settings")]
	[SerializeField]
	private GameObject uiBackground;
	[SerializeField]
	private float delayToStart = 0f;
	[SerializeField]
	private float animationDuration = 0f;
	[SerializeField]
	private float maxOpacity = 0f;
	[SerializeField]
	private float delayBetweenAnimation = 0f;
	[SerializeField]
	private float delayBetweenUI = 0f;
	[Header("SplashScreen Settings")]
	[SerializeField]
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
	[Header("Settings Settings")]
	[SerializeField]
	private GameObject uiSettings;

	private TMPro.TMP_Text UI_Score_Text;
	[SerializeField]
	private TMPro.TMP_Text UI_GameOver_Score;
	[SerializeField]
	private TMPro.TMP_Text UI_GameOver_HighScore;
	[SerializeField]
	private TMPro.TMP_Dropdown UI_Settings_Quality;

	// Seta todas as Interfacess para o estado padrão
	public void StartUI()
	{
		uiBackground.SetActive(true);
		uiSplashScreen.SetActive(false);
		uiMainMenu.SetActive(false);
		uiAbout.SetActive(false);
		uiSettings.SetActive(false);
		LeanTween.alphaCanvas(uiSplashScreen.GetComponent<CanvasGroup>(), 0f, 0f);
		LeanTween.alphaCanvas(uiMainMenu.GetComponent<CanvasGroup>(), 0f, 0f);
		LeanTween.alphaCanvas(uiAbout.GetComponent<CanvasGroup>(), 0f, 0f);
		LeanTween.alphaCanvas(uiSettings.GetComponent<CanvasGroup>(), 0f, 0f);
		return;
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
		uiMainMenu.SetActive(true);
		LeanTween.alphaCanvas(uiMainMenu.GetComponent<CanvasGroup>(), maxOpacity, animationDuration).setDelay(delayToStart / 2);
		yield return null;
	}
	public void ChangeMenuToAbout(){
		StartCoroutine(ChangeUI(uiMainMenu,uiAbout));
	}
	public void ChangeAboutToMenu(){
		StartCoroutine(ChangeUI(uiAbout,uiMainMenu));
	}
	public void ChangeMenuToSettings(){
		StartCoroutine(ChangeUI(uiMainMenu,uiSettings));
	}
	public void ChangeSettingsToMenu(){
		StartCoroutine(ChangeUI(uiSettings,uiMainMenu));
	}
	// Fecha a primeira UI e abre a segunda
	private IEnumerator ChangeUI(GameObject fromUI, GameObject toUI){
		LeanTween.alphaCanvas(fromUI.GetComponent<CanvasGroup>(), 0f, animationDuration).setDelay(0f);
		yield return new WaitForSeconds(delayToStart);
		fromUI.SetActive(false);
		yield return new WaitForSeconds(delayBetweenUI);
		toUI.SetActive(true);
		LeanTween.alphaCanvas(toUI.GetComponent<CanvasGroup>(), maxOpacity, animationDuration).setDelay(0f);
		yield return null;
	}
	// Fecha o jogo
	public void CloseGame()
	{
		Application.Quit();
	}
	// Abre o meu site
	public void OpenWebsite()
	{
		Application.OpenURL("https://arthursegato.com");
		return;
	}
	// Abre o site do streamBeats
	public void OpenStreamBeats()
	{
		Application.OpenURL("https://www.streambeats.com");
		return;
	}
	// Abre o google fonts
	public void OpenGoogleFonts()
	{
		Application.OpenURL("https://fonts.google.com/specimen/Roboto");
		return;
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
