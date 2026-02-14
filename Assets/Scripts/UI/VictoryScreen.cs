using UnityEngine;

public class VictoryScreen : MonoBehaviour
{
    [SerializeField] SpawnBalloon spawnBalloon;
    [SerializeField] GameObject victoryScreen;
    void Update()
    {
        if (spawnBalloon.levelFinished == true)
        {
            victoryScreen.SetActive(true);
        }
    }
}
