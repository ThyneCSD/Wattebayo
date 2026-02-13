using UnityEngine;

public class MoveBalloon : MonoBehaviour
{
    public int health = 5;
    [SerializeField] private float moveSpeed = 2f;
    void Update()
    {
        gameObject.transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        CheckDeath();
    }

    private void CheckDeath()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        
            //hier later nog SFX
        }
    }
}
