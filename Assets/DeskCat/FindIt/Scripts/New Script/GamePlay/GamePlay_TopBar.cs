using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GamePlay_TopBar : MonoBehaviour
{
    [SerializeField] private Button btnNoAds, btnSettings, btnHome, btnShop;
    [SerializeField] private GameObject NoAds, Settings, Canvas;
    private void Start()
    {
        btnNoAds.onClick.AddListener(delegate
        {
            GameObject noAds = Instantiate(NoAds, Canvas.transform);
        });

        btnSettings.onClick.AddListener(delegate
        {
            GameObject settings = Instantiate(Settings, Canvas.transform);
        });
        btnHome.onClick.AddListener(delegate
        {
            SceneManager.LoadScene("GameMenu");
        });
    }
}
