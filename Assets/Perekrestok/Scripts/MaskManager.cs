using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaskManager : MonoBehaviour
{

    [SerializeField] private Transform masksParent;

    private List<MaskObject> _masks;
    
    private void Awake()
    {
        _masks = new List<MaskObject>();

        foreach (Transform child in masksParent)
        {
            _masks.Add(child.GetComponent<MaskObject>());
        }
        
        Debug.Log(_masks.Count.ToString() + "masks were found in children");
    }

    public void SelectMask(MaskInfo maskInfo)
    {
        foreach (var child in _masks)
        {
            child.gameObject.SetActive(child.GetMask() == maskInfo);
        }
    }
    
}
