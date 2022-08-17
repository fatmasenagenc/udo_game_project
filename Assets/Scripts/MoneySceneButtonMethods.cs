using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/* Bu sayfa da uygulama içi satýn alým sayfasý olarak 
 * planlanmýþtý fakat herhangi bir fonksiyonelliði yok.
 * */
public class MoneySceneButtonMethods : MonoBehaviour
{
    public void BackToMain()
    {
        SceneManager.LoadScene(0);
    }
    
    //buralara gerçek para harcamayla alakalý baðlantýlar konabilir
}
