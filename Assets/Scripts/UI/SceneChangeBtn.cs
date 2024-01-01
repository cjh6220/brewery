using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChangeBtn : MonoBehaviour
{
    public e_Scene Scene;

    public void OnClickSceneChange()
    {
        SceneManager.Instance.ChangeScene(Scene);
    }
}
