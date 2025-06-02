
using UnityEngine;

public class SpwanManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject powerupPrefab;
    public float spwanRange = 9.0f;
    private int enemyCount;
    private int waveNumber = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpwanEnemyWave(waveNumber);
        Instantiate(powerupPrefab, GenerateSpwanPos(), powerupPrefab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsByType<Enemy>(FindObjectsSortMode.None).Length;
        if (enemyCount == 0)
        {
            waveNumber++;
            SpwanEnemyWave(1);
            Instantiate(powerupPrefab,GenerateSpwanPos(),powerupPrefab.transform.rotation);
        }
        
       
    }
    private Vector3 GenerateSpwanPos()
    {
        float spwanPosX = Random.Range(-spwanRange, spwanRange);
        float spwanPosZ = Random.Range(-spwanRange, spwanRange);
        Vector3 randomPos = new Vector3(spwanPosX, 0, spwanPosZ);
        return randomPos;
    }
    void SpwanEnemyWave( int maxSpwan)
    {
        for (int i = 0; i < maxSpwan; i++)
        {
            Instantiate(enemyPrefab, GenerateSpwanPos(), enemyPrefab.transform.rotation);
        }
    }
}
