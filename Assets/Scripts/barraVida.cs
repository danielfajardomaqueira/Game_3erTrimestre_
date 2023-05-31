using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class barraVida : MonoBehaviour
{

    public Image barraDeVida;
    public float vidaActual;
    public float vidaMaxima;
    public GameObject gameOverPanel;
    //public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        barraDeVida.fillAmount = vidaActual / vidaMaxima;
        
    }

    public void TakingDamage(float damage)
    {
        vidaActual -= damage;
        
        if(vidaActual <= 0)
        {
            SceneManager.LoadScene("GameOver");
            //Time.timeScale = 0;

            //Instantiate(gameOverPanel);

        }

       
    }

    public void CountHealth(float health)
    {
        vidaActual += health;
    }
}
