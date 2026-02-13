using UnityEngine;

public class PlayerMouse : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePos = Input.mousePosition;
            Vector2 worldPos = Camera.main.ScreenToWorldPoint(mousePos);
            RaycastHit2D hit = Physics2D.Raycast(worldPos, Vector2.zero);

            if (hit.collider != null && hit.collider.CompareTag("Balloon"))
            {
                Destroy(hit.collider.gameObject);
            }
        }
    }
}
