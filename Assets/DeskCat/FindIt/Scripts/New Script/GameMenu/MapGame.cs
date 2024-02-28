using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MapGame : MonoBehaviour
{
    public string LevelName;

    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(() => SceneManager.LoadScene(LevelName));
    }
}
