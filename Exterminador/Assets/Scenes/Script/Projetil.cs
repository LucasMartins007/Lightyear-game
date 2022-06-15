using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projetil : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    public float velocidadeY;
    public int pontuacao;
    //public AudioSource audioSourceExplosao;

    // Start is called before the first frame update
    void Start()
    {
        this.rigidbody.velocity = new Vector2(0,this.velocidadeY);
    }

    public void OnTriggerEnter2D(Collider2D collider){
       if( collider.CompareTag("Inimigo")){
            //marreta o malfeitor 
           Inimigo inimigo = collider.GetComponent<Inimigo>();
           inimigo.Destruir();
             //acaba laser
            Destroy(this.gameObject);
            
            
          // Debug.Log("NUMERO DO CASSETE :" + collider);
        }
       
    }
    

    
    void Update()
    {
        
    }
}
