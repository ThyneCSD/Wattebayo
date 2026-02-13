using UnityEngine;

public class HyperMode : MonoBehaviour
{
    [SerializeField] private GameObject songHikari;
    [SerializeField] private GameObject hypermode;
    [SerializeField] private GameObject mainCamera;

    public void hyperButton()
    {
        songHikari.SetActive(false);
        hypermode.SetActive(true);
        mainCamera.SetActive(false);
    }
}
