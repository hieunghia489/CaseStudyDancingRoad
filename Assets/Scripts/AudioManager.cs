using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;

    // Start is called before the first frame update
    void Start()
    {
        foreach (Sound s in sounds)
        {
            s.source=gameObject.AddComponent<AudioSource>();
            s.source.clip=s.clip;
            s.source.loop=s.loop;
        }
       
    }
    public void PlaySound(string name)
    {
        foreach(Sound s in sounds)
        {
            if (s.name == name)
            {
                s.source.Play();
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    [System.Serializable]
    public class Sound
    {
        public string name;
        public float volume;
        public bool loop;
        public AudioSource source;
        public AudioClip clip;
        public Sound()
        {

        }
    }
}
