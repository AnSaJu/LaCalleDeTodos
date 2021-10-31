using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirMoneda : MonoBehaviour
{
    // Start is called before the first frame update
    public int destruirAlTiempo;

    void Start()
    {
        Destroy(gameObject, destruirAlTiempo);
    }

    
}
