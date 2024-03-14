using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class script : MonoBehaviour
{
    public void Awake()
    {
        Scene Scene2 = SceneManager.CreateScene("Scene2");

        Scene Scene3 = SceneManager.CreateScene("Scene3");
    }
}
