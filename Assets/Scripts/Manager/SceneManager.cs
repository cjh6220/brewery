using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : SingletonBase<SceneManager>
{
    public void ChangeScene(e_Scene sceneEnum)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene((int)sceneEnum);
    }
}
