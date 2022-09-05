using UnityEngine;
using System.Collections;

namespace VNEngine
{
    // Sets the looping background music that's currently playing
    // This node must have a child object with an Audio Source so that the child
    // can be moved to be a child of MusicManager
    public class FadeOutMusic : Node
    {
        public bool fadeOutPreviousMusic;
        public float fadeOutTime = 1.0f;

        public override void Run_Node()
        {
            if (fadeOutPreviousMusic && AudioManager.audio_manager.background_music_audio_source.isPlaying)
            {
                // Fade out the previous background music for a smooth transition
                StartCoroutine(AudioManager.audio_manager.Fade_Out_Music(fadeOutTime));
                Finish_Node();
            }
            else
            {
                Finish_Node();
            }
        }

        public override void Finish_Node()
        {
            //StopAllCoroutines();

            base.Finish_Node();
        }
    }
}