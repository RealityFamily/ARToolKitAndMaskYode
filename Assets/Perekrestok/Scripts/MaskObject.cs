using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaskObject : MonoBehaviour
{

    [SerializeField] private MaskInfo maskInfo;

    public MaskInfo GetMask()
    {
        return maskInfo;
    }
    
}
