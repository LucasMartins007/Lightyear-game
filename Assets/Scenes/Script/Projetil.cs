using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projetil : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    public float velocidadeY;
    public int pontuacao;
  
    
    void Start() {
        this.rigidbody.velocity = new Vector2(0,this.velocidadeY);
    }

    public void OnTriggerEnter2D(Collider2D collider) {
       if( collider.CompareTag("Inimigo")){
           Inimigo inimigo = collider.GetComponent<Inimigo>();
           inimigo.Destruir();

           Destroy(this.gameObject);
        }
    }
}
