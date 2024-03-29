using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class D8 : MonoBehaviour
{

    public Material material;

    // Start is called before the first frame update
    void Start()
    {
        CreateCube();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void CreateCube()
    {
        Vector3[] vertices = {
            new Vector3(0, 0, 0), //A, 0

            new Vector3(1, 0, 0), //B, 1
            new Vector3(1, 0, 1), //C, 2

            new Vector3(0, 0, 1), //D, 3
            new Vector3(0, 0, 1), //E, 4

            new Vector3(0.5f, -1, .5f), //F, 5

            new Vector3(0.5f, 1, 0.5f), //G, 6
            new Vector3(0.5f, 1, 0.5f), //H, 7
            new Vector3(0.5f, 1, 0.5f), //I, 8
            new Vector3(0.5f, 1, 0.5f), //J, 9
        };

        int[] triangles = {
            /*0,1,9,
            0,8,2,
            2,7,4,
            1,3,6,
            5,2,4,
            0,2,5,
            5,1,0,
            5,3,1,*/

            7,1,0, //3
            8,2,1, //2
            9,3,2, //8 
            6,0,4, //5

            0,1,5,//1
            1,2,5,
            2,3,5,
            4,0,5,
        };



        Vector2[] uvs = {
            /*new Vector2(.75f, 1f),
            new Vector2(0, 0.75f),
            new Vector2(0, 0.25f),
            new Vector2(0.75f, 0),

            new Vector2(1f, 0.75f),
            new Vector2(1f, 0.25f),

            new Vector2(0.50f, 0.75f),
            new Vector2(0.25f, 0.50f),
            new Vector2(0.75f, 0.50f),
            new Vector2(0.5f, 0.25f),*/

            new Vector2(.5f,.75f),

            new Vector2(.25f,.5f),
            new Vector2(.5f,.25f),

            new Vector2(1f,.25f),
            new Vector2(1f,.75f),

            new Vector2(.75f,.5f),

            new Vector2(.75f,1),
            new Vector2(0,.75f),
            new Vector2(0,.25f),
            new Vector2(.75f,0),
        };

        Mesh mesh = GetComponent<MeshFilter>().mesh;
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.material = material;
        mesh.Clear();
        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.uv = uvs;
        mesh.Optimize();
        mesh.RecalculateNormals();
    }
}