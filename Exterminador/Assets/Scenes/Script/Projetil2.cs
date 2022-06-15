using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projetil2 : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    public float velocidadeY2;
    public int pontuacao;
    // Start is called before the first frame update
    void Start()
    {
        this.rigidbody.velocity = new Vector2(0,this.velocidadeY2);
    }

    public void OnTriggerEnter2D(Collider2D collider){
       if( collider.CompareTag("Alvo")){
            //marreta o malfeitor 
           Alvo alvo = collider.GetComponent<Alvo>();
           alvo.Destruir();
             //acaba laser
            Destroy(this.gameObject);
            
          // Debug.Log("NUMERO DO CASSETE :" + collider);
        }
       
    }
    

    
    void Update()
    {
        
    }
}
