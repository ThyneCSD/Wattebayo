using UnityEngine;

public class PlayerMouse : MonoBehaviour
{
    [SerializeField] private AudioSource balloonHitSound;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePos = Input.mousePosition;
            Vector2 worldPos = Camera.main.ScreenToWorldPoint(mousePos);
            RaycastHit2D hit = Physics2D.Raycast(worldPos, Vector2.zero);

            if (hit.collider != null && hit.collider.CompareTag("Balloon"))
            {
                hit.collider.GetComponent<MoveBalloon>().health--;
                balloonHitSound.Play();
            }
        }
    }
}
