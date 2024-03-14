using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class chargescene : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.LogError("yo");
            SceneManager.LoadScene("Scene2", LoadSceneMode.Single);
            //SceneManager.UnloadSceneAsync("Scene1");

        }

    }
}
