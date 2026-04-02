using UnityEngine;

public class SpawnerCoins : MonoBehaviour
{
    public GameObject areaPlane;
    public GameObject coinPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        for (int i = 0; i < 7; i++)
        {
            SpawnNoPlane();
        }
    }

        void SpawnNoPlane()
        {
            // Pega os limites reais do Plane no mundo (levando em conta a escala)
            Bounds limites = areaPlane.GetComponent<MeshRenderer>().bounds;

            // Sorteia um valor entre o mínimo e o máximo de cada eixo
            float xAleatorio = Random.Range(limites.min.x, limites.max.x);
            float zAleatorio = Random.Range(limites.min.z, limites.max.z);

            // A altura (Y) usamos o topo do plane para o objeto não nascer "enterrado"
            float yNoTopo = limites.max.y + 0.8f;

            Vector3 posicaoFinal = new Vector3(xAleatorio, yNoTopo, zAleatorio);

            Instantiate(coinPrefab, posicaoFinal, Quaternion.identity);
        }
}

