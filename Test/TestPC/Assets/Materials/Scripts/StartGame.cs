using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    private string CurrentScene;
    void Start()
    {
        CurrentScene = SceneManager.GetActiveScene().name;
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(CurrentScene);
        }
    }
}
