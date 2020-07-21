using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{


    public sound[] sounds;
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
        
        foreach (sound s in sounds)
        {
           s.source= gameObject.AddComponent<AudioSource>();
           s.source.clip = s.clip;

           s.source.volume = s.volume;
           s.source.pitch = s.pitch;
           s.source.loop = s.loop;
        }
    }


    public void Play(string name)
    {
        sound s = Array.Find(sounds, sound => sound.name == name);
        if(s == null){return;}
        s.source.Play();
    }

    private void Start()
    {
        Play("MainSound");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
