using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class StageManager : MonoBehaviour
{
    [SerializeField] private List<CornStageSlot> _slotPrefabs;
    [SerializeField] private DragNDrop _piecePrefab;
    [SerializeField] private Transform _slotParent, _cornParent;


    private void Start()
    {
        spawn();
    }


    void spawn()
    {
        //var randomSet = _slotPrefabs.OrderBy(s => Random.value).Take(3).ToList();

        //for (int i = 0; i < randomSet.Count; i++) {
        //    var spawnedSlot = Instantiate(randomSet[i], _slotParent.GetChild(i).position, Quaternion.identity);

        //    var spawnedPiece = Instantiate(_piecePrefab, _cornParent.GetChild(i).position, Quaternion.identity);
        //    spawnedPiece.Init(spawnedSlot);




        
    }
}
