using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorInimigo : MonoBehaviour
{
    public Inimigo inimigoOrigem;
    private float tempoDecorrido;

    void Start()
    {
        this.tempoDecorrido = 0;
    }
    void Update()
    {
      this.tempoDecorrido += Time.deltaTime;  
      if (this.tempoDecorrido >= 1f){
          this.tempoDecorrido = 0;

          Vector2 posicaoMax = Camera.main.ViewportToWorldPoint(new Vector2(1,1));
          Vector2 posicaoMin = Camera.main.ViewportToWorldPoint(new Vector2(0,0));

          float posicaoX = Random.Range(posicaoMin.x, posicaoMax.x);
          Vector2 posicaoInimigo = new Vector2(posicaoX, posicaoMax.y );
          
          Instantiate(this.inimigoOrigem, posicaoInimigo, Quaternion.identity);
      }
    }
}
