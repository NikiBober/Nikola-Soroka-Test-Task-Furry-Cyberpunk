using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace VNEngine
{
    public class ChangeActorSkin : Node
    {
        [SerializeField] string actorName;
        [SerializeField] string emotion;
        [SerializeField] bool isDressed;

        ActorController actorController;

        // Called initially when the node is run, put most of your logic here
        public override void Run_Node()
        {
            actorController = GameObject.Find(actorName).GetComponent<ActorController>();
            actorController.UpdateSkin(isDressed, "emotions/" + emotion);

            // if there's no need to  wait for other operations/coroutines, call finish node at the end of this method
            Finish_Node();
        }

        // Do any necessary cleanup here, like stopping coroutines that could still be running and interfere with future nodes
        public override void Finish_Node()
        {
            StopAllCoroutines();

            base.Finish_Node();
        }
    }
}