using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerLives : MonoBehaviour
{
    public int lives = 3;
    public Image[] playerLivesUI;
    public GameObject explosionPrefab;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.tag == "Enemy" || collision.collider.gameObject.tag == "SpawnerEnemy" )
        {
            Destroy(collision.collider.gameObject); //collider means the children items
            Instantiate(explosionPrefab,transform.position,Quaternion.identity);
            lives -= 1;
            for (int i = 0; i < playerLivesUI.Length; i++)
            {
                if (i < lives)
                {
                    playerLivesUI[i].enabled = true;

                }
                else
                {
                    playerLivesUI[i].enabled = false;
                }
            }
            if (lives <= 0)
            {
                Destroy(gameObject);

                //SceneManager.LoadScene("MainScene");

            }

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "EnemyProjectile" || collision.gameObject.tag == "SpawnerEnemy")
        {
            Destroy(collision.gameObject); 
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            lives -= 1;
            for (int i = 0; i < playerLivesUI.Length; i++)
            {
                if (i < lives)
                {
                    playerLivesUI[i].enabled = true;

                }
                else
                {
                    playerLivesUI[i].enabled = false;
                }
            }
            if (lives <= 0)
            {

                Destroy(gameObject);
                SceneManager.LoadScene("StartingMenu");

            }

        }
    }

}
