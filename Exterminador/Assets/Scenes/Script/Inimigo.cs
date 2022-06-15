using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{

    public Rigidbody2D rigidbody;
    public float velocidadeMax;
    public float velocidadeMin;
    

    private float velocidadeY;
    // Start is called before the first frame update
    void Start()
    {
        this.velocidadeY = Random.Range(this.velocidadeMin, this.velocidadeMax);
    }

    // Update is called once per frame
    void Update()
    {
        this.rigidbody.velocity = new Vector2(0, -this.velocidadeY);
    }

    public void Destruir(){
        ControladorPontuacao.Pontuacao++;
        Destroy(this.gameObject);
        
        
        
    }
}
