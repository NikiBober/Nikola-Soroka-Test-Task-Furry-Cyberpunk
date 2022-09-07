using Spine;
using Spine.Unity;
using UnityEngine;

public class ActorController : MonoBehaviour
{
    #region Inspector
    [SerializeField] [SpineSkin] string baseSkin;
    [SerializeField] [SpineSkin] string emotionSkin;
    [SerializeField] [SpineSkin] string dressSkin;
    [SerializeField] bool isDressed;
    #endregion

    #region private
    SkeletonGraphic skeletonGraphic;
    Skeleton skeleton;
    SkeletonData skeletonData;

    Skin currentSkin;
    Skin baseLayer;
    Skin dressLayer;
    Skin emotionLayer;
    #endregion

    void Awake()
    {
        //get references to components
        skeletonGraphic = GetComponent<SkeletonGraphic>();
        skeleton = skeletonGraphic.Skeleton;
        skeletonData = skeletonGraphic.SkeletonData;
    }

    void Start()
    {
        //save skins that never changes
        baseLayer = skeletonData.FindSkin(baseSkin);
        dressLayer = skeletonData.FindSkin(dressSkin);

        //initial skin
        UpdateSkin(isDressed, emotionSkin);
    }

    //find new emotion skin, mix and set total skin
    public void UpdateSkin(bool isDressed, string emotionSkin)
    {
        currentSkin = new Skin("currentSkin");
        emotionLayer = skeletonData.FindSkin(emotionSkin);

        currentSkin.AddSkin(baseLayer);
        if (isDressed)
            currentSkin.AddSkin(dressLayer);
        currentSkin.AddSkin(emotionLayer);

        skeleton.SetSkin(currentSkin);
        skeleton.SetSlotsToSetupPose();
    }
}
