using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(fileName = "Mech", menuName = "ScriptableMech", order = 0)]
public class ScriptableMech : ScriptableObject {
    public new string name;
    public Sprite sprite;
    public BaseMech UnitPrefab;
    
    public int moveRange;
    public bool flying;

    //public MechActionType action1;
}
