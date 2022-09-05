using UnityEngine;
using System.Collections;

namespace VNEngine
{
    // Sets the looping background music that's currently playing
    // This node must have a child object with an Audio Source so that the child
    // can be moved to be a child of MusicManager
    public class StopMusic : Node
    {
        public override void Run_Node()
        {
            AudionManger.inter.StopMusice();
                Finish_Node();
        }

        public override void Finish_Node()
        {
            //StopAllCoroutines();

            base.Finish_Node();
        }
    }
}