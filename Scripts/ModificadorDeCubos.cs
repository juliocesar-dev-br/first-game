using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ModificadorDeCubos : MonoBehaviour
{
    public float velocity = 5f; // Variàvel da velocidade para que o nosso cubo se mova
    private int pontuacaoAtual = 0;
    public TextMeshProUGUI textoPontuacao;
    public TextMeshProUGUI textoVitoria;
    public AudioClip somDaMoeda;
    public AudioSource audioSource;
    public GameObject prefabParticle;
    public Button botaoReiniciar;

    void Start()
    {

        textoVitoria.gameObject.SetActive(false);
        audioSource = audioSource.GetComponent<AudioSource>();
        // Posição:

        //transform.position = new Vector3(2f, 5f, 0f);  // Define uma posição específica
        //transform.position += new Vector3(1f, 0f, 0f); // Move o objeto 1 unidade para direita em relação à posição atual

        // Tamanho/Escala

        //transform.localScale = new Vector3(2f, 2f, 2f); // Define um tamanho específico
        //transform.localScale *= 1.1f; // Aumenta o tamanho atual em 10%
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal"); // Pega os movimentos das teclas A/D
        float vertical = Input.GetAxis("Vertical"); // Pega os movimentos das teclas W/S


        // Atribui os movimentos das teclas a um vetor
        Vector3 movimento = new Vector3(horizontal, 0, vertical); // (X , Y, Z)

        // Soma o movimento, velocidade e time.deltaTime para que a velocidade
        // seja independente da taxa de quadros!
        transform.position += movimento * velocity * Time.deltaTime;

        

    }

    private void VerificarVitoria()
    {
        if (pontuacaoAtual == 7)
        {
            textoVitoria.gameObject.SetActive(true);
            botaoReiniciar.gameObject.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Moeda"))
        {
            //pontuacaoAtual += 1;
            ColisaoMoeda refer = other.GetComponent<ColisaoMoeda>();
            pontuacaoAtual += refer.dadosMoeda.valorEmPontos;
            textoPontuacao.text = $"Coins: {pontuacaoAtual}";
            audioSource.PlayOneShot(somDaMoeda);

            Instantiate(prefabParticle, other.transform.position, Quaternion.identity);


            VerificarVitoria();
        }
    }
}
