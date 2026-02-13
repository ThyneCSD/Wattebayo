using UnityEngine;

public class MoveBalloon : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        gameObject.transform.Translate(Vector3.up * Time.deltaTime);
    }
}
