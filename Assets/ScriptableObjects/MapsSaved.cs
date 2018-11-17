﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapsSaved : ScriptableObject
{
    public List<GameObject> paths = new List<GameObject>();
    public List<Vector3> positions = new List<Vector3>();
    public List<int> objectType = new List<int>();
}
