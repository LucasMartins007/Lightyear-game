using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Alvo : MonoBehaviour
{

    public Rigidbody2D rigidbody;
    public float velocidadeMax2;
    public float velocidadeMin2;

      /*  public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Bola"))
        {
                SceneManager.LoadScene("Fase2");
        }
    }*/

    private float velocidadeY2;
    // Start is called before the first frame update
    void Start()
    {
        this.velocidadeY2 = Random.Range(this.velocidadeMin2, this.velocidadeMax2);
    }

    // Update is called once per frame
    void Update()
    {
        this.rigidbody.velocity = new Vector2(0, -this.velocidadeY2);
    }

    public void Destruir(){
        ControladorPontuacao.Pontuacao++;
        Destroy(this.gameObject);
        
        
    }



   

}
