using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public sealed class GWorld
{

    private static readonly GWorld instance = new GWorld();
    private static WorldStates world;
    public GameObject target;

    static GWorld()
    {
        world = new WorldStates();
    }

    private GWorld()
    {

    }

    public static GWorld Instance
    {
        get { return instance; }
    }

    public WorldStates GetWorld()
    {
        return world;
    }
}
