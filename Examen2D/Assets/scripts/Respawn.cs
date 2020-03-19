using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro2;
    public int count2;
    [SerializeField] Transform spawnPoint;

    void Update()
    {
        if(count2 == 0)
        {
            SceneManager.LoadScene("gameover");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            collision.transform.position = spawnPoint.position;
            if(count2 != 0)
            {
                count2--;
                textMeshPro2.text = "" + count2;
            }
        }
    }
}
