using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class UnitManager : MonoBehaviour
{
 public static UnitManager Instance;
 private List<ScriptableMech> _units;
 public BaseMech SelectedMech;

 void Awake(){
    Instance = this;

    _units = Resources.LoadAll<ScriptableMech>("Mechs").ToList();
 }

 public void SpawnMechs(){
    var mechCount = 1;

    for (int i = 0; i < mechCount; i++)
    {
       var nextPrefab = _units[i].UnitPrefab;
       var spawnedMech = Instantiate(nextPrefab);
       spawnedMech.transform.position = new Vector3(1,1,-1);
    }

 }

  public BaseMech GetUnitAtPosition(Vector3 position){
    for (int i = 0; i < _units.length; i++)
    {
        var unit = _units[i];
        if (unit.transform.position = position)
        {
            return unit;
        }
    }
    return;
 }

}



