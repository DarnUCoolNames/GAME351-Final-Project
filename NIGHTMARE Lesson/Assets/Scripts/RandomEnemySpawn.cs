using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// public class RandomEnemySpawn : MonoBehaviour
// {
//     public GameObject Bully;
//     public int xPos;
//     public int zPos;
//     public int enemyCount;

//     void Start() {
//         StartCoroutine(EnemyDrop());
//     }
    
//     void OnTriggerEnter(Collider other)
//     {
//         if (other.CompareTag("Player"))
//         {
//             IEnumerator EnemyDrop()
//             {
//                 while (enemyCount < 10)
//                 {
//                     xPos = Random.Range(565, 626);
//                     zPos = Random.Range(541, 566);
//                     Instantiate(Bully, new Vector3(xPos, 5.3f, zPos), Quaternion.identity);
//                     yield return new WaitForSeconds(0.1f);
//                     enemyCount ++;
//                 }
//             }
//         }
//     }
// }