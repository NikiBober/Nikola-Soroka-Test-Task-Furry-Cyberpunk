using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySounds : MonoBehaviour
{
    public AudioClip[] soundClip;

    public void PlaySound(int clipNumber)
    {
        AudionManger.inter.Play(soundClip[clipNumber], false, false);
    }
}
