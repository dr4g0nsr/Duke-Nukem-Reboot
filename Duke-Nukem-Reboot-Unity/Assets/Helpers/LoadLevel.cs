using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadLevel : MonoBehaviour
{

    public int newLevel;

    public void LoadLevelID()
    {
        StartCoroutine(LoadLevelAsync(newLevel));
    }

    IEnumerator LoadLevelAsync(int sceneIndex)
    {
        AsyncOperation operation = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(sceneIndex);

        while (!operation.isDone)
        {
            Debug.Log(operation.progress);

            yield return null;
        }
    }
}
