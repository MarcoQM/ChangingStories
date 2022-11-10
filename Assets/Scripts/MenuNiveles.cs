using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuNiveles : MonoBehaviour
{

    public void JugarNivelAntiguedad()
    {
        SceneManager.LoadScene("NivelAntiguedad");
    }

    public void JugarNivelMedieval()
    {
        SceneManager.LoadScene("NivelMedieval");
    }

    public void JugarNivelFuturista()
    {
        SceneManager.LoadScene("NivelFuturista");
    }


}
