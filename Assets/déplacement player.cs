using System.Collections;
using UnityEngine;
    

public class déplacementplayer : MonoBehaviour
{
    // Type in the name of the Scene you would like to load in the Inspector
    public moveplayer moveplayer;
    
    public string m_Scene;

    // Assign your GameObject you want to move Scene in the Inspector
    public GameObject m_MyGameObject;

    public string sceneActuel;

    private string GetNomScene;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //  Debug.LogError("yo");
            StartCoroutine(LoadYourAsyncScene());


            //SceneManager.LoadScene("Scene2", LoadSceneMode.Single);
            //SceneManager.UnloadSceneAsync("Scene1");

        }

        // Press the space key to add the Scene additively and move the GameObject to that Scene
    }

    IEnumerator LoadYourAsyncScene()
    {
        // Set the current Scene to be able to unload it later
        Scene currentScene = SceneManager.GetActiveScene();
        

        // The Application loads the Scene in the background at the same time as the current Scene.
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(m_Scene, LoadSceneMode.Single);

        // Wait until the last operation fully loads to return anything
        //Debug.Log(currentScene.name);
        DontDestroyOnLoad(m_MyGameObject);

        while (!asyncLoad.isDone)
        {
            yield return null;
        }
        //Debug.Log("Active Scene is '" + currentScene.name + "'.");

        

        // Move the GameObject (you attach this in the Inspector) to the newly loaded Scene
        // SceneManager.MoveGameObjectToScene(m_MyGameObject, SceneManager.GetSceneByName(m_Scene));
        // Unload the previous Scene

        SceneManager.UnloadSceneAsync(currentScene.name);
    }

    void GetScene(string scene)
    {
        scene = GetNomScene;
    }
}
