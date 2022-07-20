using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

[CreateAssetMenu(menuName = "EnemyAIParameters", fileName = "ScriptableObject/EnemyAIParameters")]
public class EnemyAIParameters : ScriptableObject
{
    [Range(1f,100f)]public float walkPointRange;
    [Range(1f,100f)]public float timeBetweenAttacks;
    [Range(1f,100f)]public float sightRange;
    [Range(1f,100f)]public float attackRange;
    [Range(1, 10)]public int maxEngagedEnemies;
    [Range(1f, 100f)] public float enemiesWithinPlayerSphere;
    [FormerlySerializedAs("enemiesWithinPlayerSphereTimer")] [Range(0.25f, 5f)] public float playerSphereTimer;
    [Range(0.25f, 5f)] public float enemyInSphereTimerMax;
    [Range(0.5f, 10f)] public float engagedEnemiesTimer;
}
