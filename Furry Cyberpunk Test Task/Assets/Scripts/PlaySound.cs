using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public AudioClip soundClip;

    public void Play()
    {
        AudionManger.inter.Play(soundClip, false, false);
    }
}
