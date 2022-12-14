using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPause : MonoBehaviour
{
    [SerializeField] private GameObject botonPausa;
    [SerializeField] private GameObject menuPausa;
    private bool juegoPausado = false;

    private void Update() 
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(juegoPausado) 
            {
                Reanudar();
            }
            else 
            {
                Pause();
            }
        }
    }
    public void Pause() 
    {
        juegoPausado = true;
        Time.timeScale = 0f;
        botonPausa.SetActive(false);
        menuPausa.SetActive(true);
    }

    public void Reanudar() 
    {
        juegoPausado = false;
        Time.timeScale = 1f;
        botonPausa.SetActive(true);
        menuPausa.SetActive(false);
    }

    public void Reiniciar() 
    {
        juegoPausado = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Cerrar(string nameScene) 
    {
        SceneManager.LoadScene(nameScene);
        Debug.Log("Cerrando Juego");
    }
}
