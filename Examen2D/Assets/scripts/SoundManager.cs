using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip coinSound, coinRed;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        coinSound = Resources.Load<AudioClip>("coin_sound");
        coinRed = Resources.Load<AudioClip>("coin_red");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound (string clip)
    {
        switch(clip)
        {
            case "Coin":
                audioSrc.PlayOneShot(coinSound);
                break;
            case "CoinRed":
                audioSrc.PlayOneShot(coinRed);
                break;
        }
    }
}
