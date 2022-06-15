using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exterminador : MonoBehaviour
{

    public Rigidbody2D rigidbody;
    public float velocidadeMovimento;

    public Projetil projetilPrefab;
    public float tempoEsperaTiro;
    private float intervaloTiro;
    public AudioSource audioSourceExplosao;

    public Transform [] posicoesArmas;
    private Transform armaAtual;
   

    void Start() {
        this.armaAtual = this.posicoesArmas[0];
        ControladorPontuacao.Pontuacao = 0;    
    }

    void Update() {
        this.intervaloTiro += Time.deltaTime;
        if (this.intervaloTiro >= this.tempoEsperaTiro){
            this.intervaloTiro = 0;
            audioSourceExplosao.Play();
            Atirar();
        }

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        float velocidadeX = (horizontal * this.velocidadeMovimento);
        float velocidadeY = (vertical * this.velocidadeMovimento);

        this.rigidbody.velocity = new Vector2(velocidadeX, velocidadeY);

    }

    private void Atirar () {
        Instantiate(this.projetilPrefab, this.armaAtual.position, Quaternion.identity);
        if (this.armaAtual == this.posicoesArmas[0]){
            this.armaAtual = this.posicoesArmas[1];
        } else {
            this.armaAtual = this.posicoesArmas[0];
        }
    }

  
}
