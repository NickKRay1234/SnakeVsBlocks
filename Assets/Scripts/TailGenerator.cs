using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TailGenerator : MonoBehaviour
{
    [SerializeField] private int _tailSize;
    [SerializeField] private Segment _segmentTempate;


    public List<Segment> Generate()
    {
        List<Segment> tail = new List<Segment>();


        for (int i = 0; i < _tailSize; i++)
        {
            tail.Add(Instantiate(_segmentTempate, transform));
        }

        return tail;
    }
}
