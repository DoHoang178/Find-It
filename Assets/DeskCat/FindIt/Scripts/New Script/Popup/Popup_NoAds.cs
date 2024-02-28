using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Popup_NoAds : MonoBehaviour
{
    [SerializeField] Button btnExit;
    void Start()
    {
        btnExit.onClick.AddListener(delegate
        {
            Destroy(gameObject);
        });
    }
}
