using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip Bgmusic, OhNo, Cheering;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        Bgmusic = Resources.Load<AudioClip> ("Bgmusic2");
        OhNo = Resources.Load<AudioClip> ("OhNo");
        Cheering = Resources.Load<AudioClip> ("cheering");

        audioSrc = GetComponent<AudioSource> ();
    }

    // Update is called once per frame
    void Update()
    {}

    public static void PlaySound (string clip)
    {
        switch (clip)
        {
            case "bgsound":
                audioSrc.PlayOneShot (Bgmusic);
                break;

            case "OhNo":
                audioSrc.PlayOneShot (OhNo);
                break;

            case "Cheering":
                audioSrc.PlayOneShot (Cheering);
                break;
            
        }
    }
}
