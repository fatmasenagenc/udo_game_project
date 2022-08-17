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
    
    //buralara gerçek para harcamayla alakalý baðlantýlar konabilir
}
