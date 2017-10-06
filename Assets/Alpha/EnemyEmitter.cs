using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyEmitter : MonoBehaviour
{

    public float minLength = 5f;
    public float maxLength = 15f;
    public float maxEnemy = 10;

    public Enemy enemy;

    void Start()
    {

    }

    void Update()
    {

    }

    private void OnGUI()
    {
        if (GUILayout.Button("Emit"))
        {
            EmitEnemies();
        }
    }

    void EmitEnemies()
    {

        for (int i = 0; i < maxEnemy; i++)
        {
            Vector3 rv = Random.onUnitSphere;

            float rl = Random.Range(minLength, maxLength);

            Instantiate(enemy, transform.position + rl * rv, Quaternion.identity);
        }

    }

}
