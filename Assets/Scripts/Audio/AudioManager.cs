using UnityEngine;


public class AudioManager : MonoBehaviour
{
	public AudioClip[] soundtracks;
	public AudioSource audioSource;

	public static AudioManager instance;

	void Awake()
	{
		if (instance == null)
		{
			instance = this;
		}
		else
		{
			Destroy(gameObject);
			return;
		}

		DontDestroyOnLoad(gameObject);
	}
	private AudioClip GetRandomMusic()
	{
		return soundtracks[Random.Range(0, soundtracks.Length)];
	}
	private void Update()
	{
		if (!audioSource.isPlaying)
		{
			audioSource.clip = GetRandomMusic();
			audioSource.Play();
		}
	}
}
