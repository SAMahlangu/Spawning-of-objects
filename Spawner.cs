using UnityEngine;
public class Spawner : MonoBehaviour
{
    public GameObject Cube;

    public float waitTime = 10f;
    public float count;
    //private IEnumerator coroutine; 
    // Start is called before the first frame update 
    void Start()
    {
        InvokeRepeating("Spawn", waitTime, 5);
        // spawnParent = GameObject.Find("Spawned Objects").transformation;
        //        StartCoroutine(WaitToSpawn());
    }
    // Update is called once per frame 
    void Update()
    {

    }
    void Spawn()
    {
       if (count < 30)
       {
            for (int i = 0; i < 15; i++)
//           while(true)
            {
                Vector3 randomSpawnPosistion = new Vector3(Random.Range(-500, 11), 60, Random.Range(-500, 50));
            Instantiate(Cube, randomSpawnPosistion, Quaternion.identity);
            //Instantiate(Cube, new Vector3(500, 60, 500), Quaternion.identity);
            //Instantiate(objectsToSpawn[Random.Range(0, objectsToSpawn.Length)], randomSpawnPosistion, Random.Rotation, spawnParent);
          //  StartCouroutine(WaitToSpawn());

        count++;
            }
        }
    }
}