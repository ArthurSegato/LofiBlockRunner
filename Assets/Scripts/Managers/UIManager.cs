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
	private float delayBetweenUI = 0f;
	[Header("SplashScreen Settings")]
	[SerializeField]
	private GameObject uiSplashScreen;
	[SerializeField]
	private GameObject splashScreenLogo;
	[SerializeField]
	private float splashDelayToStart = 0f;
	[SerializeField]
	private float splashDelayToHidde = 0f;
	[SerializeField]
	private float splashAnimationDuration = 0f;
	[SerializeField]
	private float splashMaxOpacity = 0f;
	[SerializeField]
	private float splashMinOpacity = 0f;
	[SerializeField]
	private float splashDelayToDeactivate = 0f;
	[SerializeField]
	private float logoScale = 0f;
	[SerializeField]
	private float splashScaleDuration = 0f;
	[Header("MainMenu Settings")]
	[SerializeField]
	private GameObject uiMainMenu;
	[Header("About Settings")]
	[SerializeField]
	private GameObject uiAbout;
	[Header("Settings")]
	[SerializeField]
	private GameObject uiSettings;
	[Header("Game Settings")]
	[SerializeField]
	private GameObject uiGame;
	[SerializeField]
	private TMP_Text uiGameScore;
	[Header("GameOver Settings")]
	[SerializeField]
	private GameObject uiGameOver;
	[SerializeField]
	private TMP_Text uiGameOverScore;
	[SerializeField]
	private TMP_Text uiGameOverScoreHigh;

	// Seta todas as Interfacess para o estado padrão
	public void StartUI()
	{
		// Desativa as UI
		uiBackground.SetActive(true);
		uiSplashScreen.SetActive(false);
		uiMainMenu.SetActive(false);
		uiAbout.SetActive(false);
		uiSettings.SetActive(false);
		uiGame.SetActive(false);
		uiGameOver.SetActive(false);
		// Faz o conteudo das UI's transparente
		LeanTween.alphaCanvas(uiSplashScreen.GetComponent<CanvasGroup>(), 0f, 0f);
		LeanTween.alphaCanvas(uiMainMenu.GetComponent<CanvasGroup>(), 0f, 0f);
		LeanTween.alphaCanvas(uiAbout.GetComponent<CanvasGroup>(), 0f, 0f);
		LeanTween.alphaCanvas(uiSettings.GetComponent<CanvasGroup>(), 0f, 0f);
		LeanTween.alphaCanvas(uiGame.GetComponent<CanvasGroup>(), 0f, 0f);
		LeanTween.alphaCanvas(uiGameOver.GetComponent<CanvasGroup>(), 0f, 0f);
	}
	// Mostra a SplashScreen
	public IEnumerator ShowSplash()
	{
		// Torna a UI Ativa
		uiSplashScreen.SetActive(true);
		// Mostra a logo
		LeanTween.alphaCanvas(uiSplashScreen.GetComponent<CanvasGroup>(), splashMaxOpacity, splashAnimationDuration).setDelay(splashDelayToStart);
		// Aumenta a logo
		LeanTween.scale(splashScreenLogo.GetComponent<RectTransform>(), splashScreenLogo.GetComponent<RectTransform>().localScale * logoScale, splashScaleDuration).setEase(LeanTweenType.easeOutCirc).setDelay(splashDelayToStart);
		// Esconde a logo
		LeanTween.alphaCanvas(uiSplashScreen.GetComponent<CanvasGroup>(), splashMinOpacity, splashAnimationDuration).setDelay(splashDelayToStart + splashDelayToHidde);
		// Espera mais alguns Segundos
		yield return new WaitForSeconds((splashDelayToStart + splashDelayToHidde) + splashDelayToDeactivate);
		// Desativa a UI
		uiSplashScreen.SetActive(false);
		StartCoroutine(ShowMainMenu());
		yield return null;
	}
	public IEnumerator ShowMainMenu(){
		// Torna a UI do menu Ativa
		uiMainMenu.SetActive(true);
		// Mostra a UI do Menu
		LeanTween.alphaCanvas(uiMainMenu.GetComponent<CanvasGroup>(), maxOpacity, animationDuration).setDelay(delayToStart);
		yield return null;
	}
	public void StartGame(){
		StartCoroutine(ChangeUI(uiMainMenu,uiGame));
	}
	public void PlayAgain(){
		StartCoroutine(ChangeUI(uiGameOver,uiGame));
	}
	public void ChangeGameOverToMenu(){
		StartCoroutine(ChangeUI(uiGameOver,uiMainMenu));
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
	public void ChangeGameToGameOver(){
		StartCoroutine(ChangeUI(uiGame,uiGameOver));
	}
	// Troca as UI
	private IEnumerator ChangeUI(GameObject fromUI, GameObject toUI){
		// Esconde a primeira UI
		LeanTween.alphaCanvas(fromUI.GetComponent<CanvasGroup>(), 0f, animationDuration).setDelay(0f);
		// Espera um tempo
		yield return new WaitForSeconds(delayToStart);
		// Desliga a UI que foi escondida
		fromUI.SetActive(false);
		// Caso a UI em questão seja a de GameOver
		if(toUI == uiGameOver){
			// Esconde o fundo
			LeanTween.alphaCanvas(uiBackground.GetComponent<CanvasGroup>(), maxOpacity, animationDuration).setDelay(0f);
		}
		// Espera um tempo
		yield return new WaitForSeconds(delayBetweenUI);
		// Liga a UI que vai ser mostrada
		toUI.SetActive(true);
		// Mostra a UI
		LeanTween.alphaCanvas(toUI.GetComponent<CanvasGroup>(), maxOpacity, animationDuration).setDelay(0f);
		// Se a ui a ser motrada é a da gameplay
		if(toUI == uiGame){
			// Espera um tempo
			yield return new WaitForSeconds(delayBetweenUI / 2);
			// Esconde o fundo
			LeanTween.alphaCanvas(uiBackground.GetComponent<CanvasGroup>(), 0f, animationDuration).setDelay(0f);
		}
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
	// Define a qualidade gráfica
	public void SetQuality(int value)
	{
		QualitySettings.SetQualityLevel(value, true);
	}
	// Define o idioma
	public void SetLanguage(int value)
	{
		LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[value];
	}
	// Mostra a pontuação na tela
	public void SetScore(float score){
		uiGameScore.text = score.ToString("0");
	}
	public void SetGameOverScore(float score, float scoreHigh){
		uiGameOverScore.text = score.ToString("0");
		uiGameOverScoreHigh.text = scoreHigh.ToString("0");
	}
}
