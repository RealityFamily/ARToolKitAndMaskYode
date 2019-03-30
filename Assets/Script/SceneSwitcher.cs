using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public GameObject artoolkit;
    public GameObject xzimg;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwitchToSceneMask()
    {
        //AsyncOperation asyncLoad = SceneManager.UnloadSceneAsync(sceneName: "TwoNFTMarkerScene");

        //SceneManager.LoadSceneAsync(sceneName: "sample-AugmentedFace",mode: LoadSceneMode.Single);
        //UnityEditor.SceneManagement.EditorSceneManager.CloseScene(SceneManager.GetActiveScene(), false);
        //UnityEditor.SceneManagement.EditorSceneManager.OpenScene("Assets/Scene/sample-AugmentedFace.unity");
        artoolkit.GetComponentInChildren<ARController>().KillAR();
        /*if (artoolkit.GetComponentInChildren<ARController>().IsRunning)*/ artoolkit.GetComponentInChildren<ARController>().StopAllCoroutines();
        SceneManager.UnloadScene(sceneName: "TwoNFTMarkerScene");
        while (artoolkit.GetComponent<ARController>().IsRunning)
        {
            StartCoroutine(Example());
        }
        artoolkit.SetActive(false);
        
         SceneManager.LoadScene(sceneName: "sample-AugmentedFace", mode: LoadSceneMode.Single);
    }


    public void SwitchToSceneAR()
    {
        Camera.main.cullingMask = 0;
#if (!UNITY_EDITOR && UNITY_ANDROID)
         xmgAugmentedFaceBridge.xzimgCamera_delete();
#endif
        //UnityEditor.SceneManagement.EditorSceneManager.CloseScene(SceneManager.GetActiveScene(), false);
        //UnityEditor.SceneManagement.EditorSceneManager.OpenScene("Assets/ARToolKit5-Unity/Example Scenes/TwoNFTMarkerScene.unity");
        SceneManager.UnloadScene(sceneName: "sample-AugmentedFace");

        SceneManager.LoadScene(sceneName: "TwoNFTMarkerScene",mode: LoadSceneMode.Single);

        //SceneManager.LoadSceneAsync(sceneName: "TwoNFTMarkerScene", mode: LoadSceneMode.Single);


    }

    IEnumerator Example()
    {

        yield return null;

    }
}
