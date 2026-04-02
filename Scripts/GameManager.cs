using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Button jogarNovamente;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        jogarNovamente.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReiniciarJogo()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
