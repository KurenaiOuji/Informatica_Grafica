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
        float size = 1f;
        Vector3[] vertices = {
            new Vector3(0, 0, size), //A, 0
            new Vector3(-size, 0, 0), //B, 1
            new Vector3(0, -size, 0), //C, 2
            new Vector3(size, 0, 0), //E, 3
            new Vector3(0, size, 0), //F, 4
            new Vector3(0, 0, -size), //G, 5
        };

        int[] triangles = {
            0, 1, 2, // front (A, E)
			1, 5, 2,

            3, 4, 0, // back (B, G)
			5, 4, 3,

            4, 1,0,// left (C, D)
			1, 4, 5,

            5, 3, 2,//right (?, F)
			0, 2, 3


        };



        Vector2[] uvs = {
            new Vector2(0, 0.66f),
            new Vector2(0.25f, 0.66f),
            new Vector2(0, 0.33f),
            new Vector2(0.25f, 0.33f),

            new Vector2(0.5f, 0.66f),
            new Vector2(0.5f, 0.33f),
            new Vector2(0.75f, 0.66f),
            new Vector2(0.75f, 0.33f),

            new Vector2(1, 0.66f),
            new Vector2(1, 0.33f),

            new Vector2(0.25f, 1),
            new Vector2(0.5f, 1),

            new Vector2(0.25f, 0),
            new Vector2(0.5f, 0),
        };

        Mesh mesh = GetComponent<MeshFilter>().mesh;
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.material = material;
        mesh.Clear();
        mesh.vertices = vertices;
        mesh.triangles = triangles;
        /*mesh.uv = uvs;*/
        mesh.Optimize();
        mesh.RecalculateNormals();
    }
}