using UnityEngine;

public class ChickenController : MonoBehaviour
{
    public GameObject eggPrefab; // Prefab trứng
    public Transform eggSpawnPoint; // Vị trí trứng xuất hiện
    public float layInterval = 3f; // Thời gian giữa mỗi lần đẻ trứng

    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= layInterval)
        {
            LayEgg();
            timer = 0f; // Reset thời gian
        }
    }

    void LayEgg()
    {
        Instantiate(eggPrefab, eggSpawnPoint.position, Quaternion.identity);
    }
}
