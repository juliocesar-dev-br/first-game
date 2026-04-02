using UnityEngine;
using TMPro;

public class ColisaoMoeda : MonoBehaviour
{
    public DadosDaMoeda dadosMoeda;
 
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /* // Resistência Física caso estiver com Rigid Body para colisões:
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //Destroy(gameObject);
        }
    }
    */

    // Sensor de presença:

    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.CompareTag("Player"))
        {

            Destroy(gameObject);
            
        }
    }
    

}
