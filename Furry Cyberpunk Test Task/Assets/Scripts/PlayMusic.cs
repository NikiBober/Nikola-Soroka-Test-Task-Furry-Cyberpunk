using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VNEngine
{
    public class PlayMusic : Node
    {
        [SerializeField] AudioClip musicClip;

        public override void Run_Node()
        {
            if ( !(musicClip == null) )
                AudionManger.inter.Play(musicClip, true, true);

            Finish_Node();
        }

        public override void Finish_Node()
        {
            //StopAllCoroutines();

            base.Finish_Node();
        }
    }
}