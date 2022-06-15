using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorPontuacao 
{
         private static int pontuacao;
         private static int passarFase;


        public static int Pontuacao{
            get {
                return pontuacao;
            }
            set {
                pontuacao = value;
                if (pontuacao < 0) {
                    pontuacao = 0;
                }
                Debug.Log("Pontuação atualizada" + Pontuacao);
            }
    

        }       

        public static int getPontuacao(){
            return pontuacao;
        }

        public static int PassarFase{
            get {
                return passarFase;
            }
            set{

            if(Input.GetKeyDown(KeyCode.Space)){

           SceneManager.LoadScene("Fase2");

        }
            }
        }
     

}

        
