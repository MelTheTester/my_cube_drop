using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class drop_cube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Addressables.Instantiate("Cube");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
