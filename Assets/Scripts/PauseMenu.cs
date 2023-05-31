using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pause = !pause;
            PauseMenuPanel.SetActive(pause);
            Time.timeScale = 0f;
        }
    }

    public GameObject PauseMenuPanel;
    public bool pause;


    //public void Pause()
    //{
        //PauseMenuPanel.SetActive(true);
        //Time.timeScale = 0f;
    //}

    public void Resume()
    {
        PauseMenuPanel.SetActive(false);
        Time.timeScale = 1f;
    }
}
