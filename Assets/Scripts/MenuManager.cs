using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Salir()
    {
        Application.Quit();
    }

    public void EscenaJuego()
    {
        SceneManager.LoadScene("Instrucciones");
    }

    public void VolverMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Creditos()
    {
        SceneManager.LoadScene("Credits");
    }

    public void Options()
    {
        SceneManager.LoadScene("Opciones");
    }

    public void Nivel()
    {
        SceneManager.LoadScene("Level1");
    }
}
