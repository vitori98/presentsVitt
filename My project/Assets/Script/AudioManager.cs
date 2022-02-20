using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;
    public int count = 0;

    //public static AudioManager instance;

    void Awake() //chiamata prima della start
    {

    //    if (instance == null)
    //        instance = this;
    //    else
    //    {
    //        Destroy(gameObject);
    //        return;
    //    }
    //    DontDestroyOnLoad(gameObject); //se vuoi persista al cambio scena

        foreach (Sound s in sounds)
        {
            //Debug.Log("AWAKE " + s.name);
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
            s.source.playOnAwake = s.playOnAwake;
            if (s.source.playOnAwake)
                Play(s.name);
            //s.source.playOnAwake = s.playOnAwake;
        }
    }

    //void Start()
    //{
    //    Play("Theme");
    //}

    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + " not found!");
            return;
        }
        if (s.name== "slide_dialogue" && count < 2)
            count++;
        else
            s.source.Play();
        s.source.mute = false;
        Debug.Log("playing " + s.name);
    }

    public void Stop(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + " not found!");
            return;
        }
        s.source.Stop();
        Debug.Log("stopping " + s.name);
    }

    public bool isPlaying(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + " not found!");
            return false;
        }
        return s.source.isPlaying;
    }

    public void Mute(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + " not found!");
            return;
        }
        s.source.mute=true;
        Debug.Log("muting " + s.name);
    }

    public void Fade(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + " not found!");
            return;
        }
        s.source.mute = true;
        Debug.Log("muting " + s.name);
    }
    //PER GLI SCRIPT
    //FindObjectOfType<AudioManager>().Play("nome");

}
