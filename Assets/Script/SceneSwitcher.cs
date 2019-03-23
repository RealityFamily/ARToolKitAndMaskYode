using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwitchSceneMask()
    {
        SceneManager.LoadScene(sceneName: "sample-AugmentedFace_2");
    }

    public void SwitchSceneAR()
    {
#if (!UNITY_EDITOR && UNITY_ANDROID)
         //xmgAugmentedFaceBridge.xzimgCamera_delete();
#endif
        SceneManager.LoadScene(sceneName: "Ar");
    }
}
