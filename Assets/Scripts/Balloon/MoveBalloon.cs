using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveBalloon : MonoBehaviour
{
    public int health = 5;
    public int pointValue = 1;
    [SerializeField] private float moveSpeed = 2f;
    [SerializeField] private float maxHeight = 8f;

    void Update()
    {
        gameObject.transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        CheckDeath();
        //sum missing here... can you find out what?
        if (transform.position.y >= maxHeight)
        {
            PlayerStats scm = FindAnyObjectByType<PlayerStats>();
            scm.health--;
            Destroy(gameObject);
        }
    }

    private void OnDestroy()
    {
        if (gameObject.transform.position.y <= 6)
        {
            PointSystem pointSystem = FindAnyObjectByType<PointSystem>();
            pointSystem.points += pointValue;
        }
        
    }


    private void CheckDeath()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
            //pointSystem.points += pointValue;

            //hier later nog SFX
        }
    }
}
