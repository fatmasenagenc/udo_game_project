using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoneySceneButtonMethods : MonoBehaviour
{
    public void BackToMain()
    {
        SceneManager.LoadScene(0);
    }
    
    //buralara ger�ek para harcamayla alakal� ba�lant�lar konabilir
}
