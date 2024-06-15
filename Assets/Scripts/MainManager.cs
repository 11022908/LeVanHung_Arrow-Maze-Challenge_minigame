using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainManager : MonoBehaviour
{
    public Button playBtn;
    public GameObject selectLevel;

    private void Start()
    {
        playBtn.onClick.AddListener(() =>
        {
            selectLevel.SetActive(true);
        });
    }
}
