using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class RSLoad : MonoBehaviour
{
    [SerializeField]
    private int scene;

	// Update is called once per frame
	void Update ()
    {
        StartCoroutine(LoadNewScene());
	}
    IEnumerator LoadNewScene()
    {
        //This line will wait before executing the next line in the coroutine.
        yield return new WaitForSeconds(2);
        AsyncOperation async = SceneManager.LoadSceneAsync(scene);
        while(!(async.isDone))
        {
            yield return null;
        }
    }
}
