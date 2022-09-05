using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusic : MonoBehaviour
{
    public AudioClip musicClip;

    // Start is called before the first frame update
    void Start()
    {
        AudionManger.inter.Play(musicClip, true, true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
