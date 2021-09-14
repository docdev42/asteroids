using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentacao : MonoBehaviour
{
    //variáveis publicas ficam acesiveis pela unity
    public float velocidade;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //0.1f * Time.deltaTime em termos de velocidade (fórmula da física)
        if (Input.GetKey(KeyCode.Space)) {
            transform.position += new Vector3(velocidade * Time.deltaTime, 0.0f, 0.0f);
        }
    }
}
