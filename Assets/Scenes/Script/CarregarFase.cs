using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarregarFase : MonoBehaviour
{
    public string faseParaCarregar;


    
   void Update() {
      if (ControladorPontuacao.getPontuacao() == 10){
          Debug.Log("Entrou caralho" );
          SceneManager.LoadScene(faseParaCarregar);
      };
   }
   
}
