using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public static Menu instance;

    public static string Name;
    private void Awake()
    {
        instance = this;
        //DontDestroyOnLoad(gameObject);
    }
    public void StartGame()
    {
        SceneManager.LoadScene("main");
    }

    public void SaveName(string name)
    {
        Name = name;
        Debug.Log(Name);
    }
}
