using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CenaMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public string nomeDaCena;
   

   public void Cena(){

      SceneManager.LoadScene(nomeDaCena);
      Debug.Log("funcionado");

   }

    public void Sair(){

        Application.Quit();
    }
    
}



