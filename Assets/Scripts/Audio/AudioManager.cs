using UnityEngine;


public class AudioManager : MonoBehaviour
{
	public AudioClip[] soundtracks;
	public AudioSource audioSource;
	private AudioClip lastTrack;
	private AudioClip newTrack;

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
		newTrack = soundtracks[Random.Range(0, soundtracks.Length)];
		if (newTrack == lastTrack)
		{
			newTrack = soundtracks[Random.Range(0, soundtracks.Length)];
			lastTrack = newTrack;
		}
		return newTrack;
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
