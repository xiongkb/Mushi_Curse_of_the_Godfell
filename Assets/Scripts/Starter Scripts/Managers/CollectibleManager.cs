using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using UnityEngine.SceneManagement; //K: code test

public class CollectibleManager : MonoBehaviour
{
    [SerializeField] private TMP_Text collectibles;
    [SerializeField] private static int collected;

 //   public static SceneManagement.Scene GetSceneByName();
  //  private string sceneName;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("START");
        if(SceneManager.GetSceneByName("Level_One").isLoaded){
            collected = 0;
            Debug.Log("Collected seeds: " + collected);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("UPDATE");
        collectibles.text = "Seeds: " + collected;
    }

    public void Collected(int value)
    {
        Debug.Log("COLLECTED");
        // Scene currentScene = SceneManager.GetSceneByName().name; //K: code test
        if(SceneManager.GetSceneByName("Start").isLoaded){
            collected = 0;
            Debug.Log("Collected seeds: " + collected);
        }
        // Debug.Log(currentScene);
       // string sceneName = currentScene.name;

            collected += value;
        //collected += value;
    }

}
