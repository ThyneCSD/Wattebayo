using System.Collections;
using UnityEngine;


public class PlayerStats : MonoBehaviour
{
    public int health = 3;
    bool checkcoroutine = false;
    [SerializeField] AudioSource screm;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0 && checkcoroutine == false)
        {
            StartCoroutine(GameOverWait());
            checkcoroutine = true;
        }
    }

    IEnumerator GameOverWait()
    {
        screm.Play();
        yield return new WaitForSeconds(3f);   
        Application.Quit();
    }
    
}
