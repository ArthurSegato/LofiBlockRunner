using UnityEngine;
using System;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;

    public static AudioManager instance;

    // Cria uma, e apenas uma, intancia do AudioManager em todas as cenas
    // Faz alguma coisa com o audio que eu não faço idea.
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
		foreach (Sound s in sounds)
		{
            s.source = gameObject.AddComponent<AudioSource>();
            
            s.source.clip = s.clip;
            
            s.source.volume = s.volume;
            
            s.source.pitch = s.pitch;

            s.source.loop = s.loop;
		}
    }
    // Toca o som de fundo
	public void Start()
	{
        Play("BackgroundMusic");
	}
    // Função que faz tocar o som recebido
	public void Play(string name)
	{
        Sound s = Array.Find(sounds, sounds => sounds.name == name);
        s.source.Play();
	}
}
