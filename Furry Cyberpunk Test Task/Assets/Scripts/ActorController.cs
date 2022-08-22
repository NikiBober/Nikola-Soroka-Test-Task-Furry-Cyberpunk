using Spine;
using Spine.Unity;
using UnityEngine;

public class ActorController : MonoBehaviour
{
    #region Inspector
    [SpineSkin] public string baseSkin;
    [SpineSkin] public string emotionSkin;
    [SpineSkin] public string dressSkin;
    public bool isDressed;
    #endregion

    #region private
    private SkeletonGraphic skeletonGraphic;
    private Skeleton skeleton;
    private SkeletonData skeletonData;

    private Skin currentSkin;
    private Skin baseLayer;
    private Skin dressLayer;
    private Skin emotionLayer;
    #endregion

    private void Awake()
    {
        //get references to components
        skeletonGraphic = GetComponent<SkeletonGraphic>();
        skeleton = skeletonGraphic.Skeleton;
        skeletonData = skeletonGraphic.SkeletonData;
    }

    private void Start()
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
