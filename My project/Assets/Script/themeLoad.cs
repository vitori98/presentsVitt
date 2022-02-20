using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class themeLoad : MonoBehaviour
{
    public static themeLoad instance;

    void Awake()
    {
        //if (SceneManager.GetActiveScene().buildIndex < 2 || SceneManager.GetActiveScene().buildIndex == 5)
        //{
            if (instance == null)
                instance = this;
            else
            {
                Destroy(gameObject);
                return;
            }
            DontDestroyOnLoad(gameObject);
        //}
        //else
        //    Destroy(gameObject);
    }
    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex > 1 && SceneManager.GetActiveScene().buildIndex <5)
            Destroy(gameObject);
    }


}
