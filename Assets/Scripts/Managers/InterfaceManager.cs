using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Localization.Settings;
using System.Collections;

public class InterfaceManager : MonoBehaviour
{
	public int interfaceFadeDelay;
	//About Interface
	public GameObject UI_About;
	//Settings Interface
	public GameObject UI_Settings;
	//Home Interface
	public GameObject UI_Home;
	private GameObject player;

	void Start(){
		player = GameObject.FindWithTag("Player");
	}
	public void Open_UI_Home()
	{
		StartCoroutine(Close_UI(UI_About));
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
	public void Start_Game()
	{
		StartCoroutine(Close_UI(UI_Home));
		player.SetActive(true);
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
