using UnityEngine;

public class SpwanManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spwanRange = 9.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
        Instantiate(enemyPrefab, GenerateSpwanPos(), enemyPrefab.transform.rotation);

    }

    // Update is called once per frame
    void Update()
    {

    }
    private Vector3 GenerateSpwanPos()
    {
        float spwanPosX = Random.Range(-spwanRange, spwanRange);
        float spwanPosZ = Random.Range(-spwanRange, spwanRange);
        Vector3 randomPos = new Vector3(spwanPosX, 0, spwanPosZ);
        return randomPos;
    }
}
