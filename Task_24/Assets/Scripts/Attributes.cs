using System;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class Attributes : MonoBehaviour
{
    [Header("Characteristics")] [SerializeField] [Range(-10, 10)] private float speed;
    [SerializeField] private float health;
    [SerializeField] private Statistics statistics;
    [Header("Direction")] [SerializeField] private Vector2 coordinates;
}

public class Statistics
{
    public int Wins = 0;
    public int Loses = 0;
}
