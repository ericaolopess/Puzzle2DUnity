using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject pc1, pc2, pc3, pc4, pc5;
    public GameObject pc6, pc7, pc8, pc9, pc10, pc11, pc12;

    public GameObject pc1_fundo, pc2_fundo, pc3_fundo, pc4_fundo, pc5_fundo;
    public GameObject pc6_fundo, pc7_fundo, pc8_fundo, pc9_fundo, pc10_fundo, pc11_fundo, pc12_fundo;

    private Vector3 PosInit_pc1, PosInit_pc2, PosInit_pc3, PosInit_pc4, PosInit_pc5, PosInit_pc6;
    private Vector3 PosInit_pc7, PosInit_pc8, PosInit_pc9, PosInit_pc10, PosInit_pc11, PosInit_pc12;

    // Start is called before the first frame update
    void Start()
    {
        PosInit_pc1 = pc1.transform.position;
        PosInit_pc2 = pc2.transform.position;
        PosInit_pc3 = pc3.transform.position;
        PosInit_pc4 = pc4.transform.position;
        PosInit_pc5 = pc5.transform.position;
        PosInit_pc6 = pc6.transform.position;
        PosInit_pc7 = pc7.transform.position;
        PosInit_pc8 = pc8.transform.position;
        PosInit_pc9 = pc9.transform.position;
        PosInit_pc10 = pc10.transform.position;
        PosInit_pc11 = pc11.transform.position;
        PosInit_pc12 = pc12.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //pc1
    public void DropPc1()
    {
        float distance = Vector3.Distance(pc1.transform.position, pc1_fundo.transform.position);
        print(distance);
        if(distance < 10)
        {
            pc1.transform.position = pc1_fundo.transform.position;
            pc1.transform.localScale = pc1_fundo.transform.localScale;
        }
        else
        {
            pc1.transform.position = PosInit_pc1;
        }
    }

    public void DragPc1()
    {
        pc1.transform.position = Input.mousePosition;
    }

    //pc2
    public void DropPc2()
    {
        float distance = Vector3.Distance(pc2.transform.position, pc2_fundo.transform.position);

        if (distance < 50)
        {
            pc2.transform.position = pc2_fundo.transform.position;
            pc2.transform.localScale = pc2_fundo.transform.localScale;
        }
        else
        {
            pc2.transform.position = PosInit_pc2;
        }
    }

    public void DragPc2()
    {
        pc1.transform.position = Input.mousePosition;
    }

}
