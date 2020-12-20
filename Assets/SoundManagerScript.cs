using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip bombSound;
    public static AudioClip gameOverSound;
    public static AudioClip gamePlaySound;
    public static AudioClip hitSound;
    public static AudioClip throwSound;

    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        bombSound = Resources.Load<AudioClip>("bombSound");
        bombSound = Resources.Load<AudioClip>("gameOverSound");
        bombSound = Resources.Load<AudioClip>("gamePlaySound");
        bombSound = Resources.Load<AudioClip>("hitSound");
        bombSound = Resources.Load<AudioClip>("throwSound");

        // Make reference to audio source
        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "bomb":
                audioSrc.PlayOneShot(bombSound);
                break;
            case "gameOver":
                audioSrc.PlayOneShot(gameOverSound);
                break;
            case "gamePlay":
                audioSrc.PlayOneShot(gamePlaySound);
                break;
            case "hit":
                audioSrc.PlayOneShot(hitSound);
                break;
            case "throw":
                audioSrc.PlayOneShot(throwSound);
                break;

        }
    }
}
