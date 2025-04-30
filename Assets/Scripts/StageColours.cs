using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageColours : MonoBehaviour
{
    public GameObject TopRing;
    public GameObject MiddleRing;
    public GameObject BottomRing;
    public GameObject LeftPillar;
    public GameObject RightPillar;
    public GameObject FirstArch;
    public GameObject MiddleArch;
    public GameObject FinalArch;

    private SpriteRenderer tRingRenderer;
    private SpriteRenderer mRingRenderer;
    private SpriteRenderer bRingRenderer;
    private SpriteRenderer lPillarRenderer;
    private SpriteRenderer rPillarRenderer;
    private SpriteRenderer firArchRenderer;
    private SpriteRenderer mArchRenderer;
    private SpriteRenderer finArchRenderer;

    private PolygonCollider2D tRingCollider;
    private PolygonCollider2D mRingCollider;
    private PolygonCollider2D bRingCollider;
    private PolygonCollider2D lPillarCollider;
    private PolygonCollider2D rPillarCollider;
    private PolygonCollider2D firArchCollider;
    private PolygonCollider2D mArchCollider;
    private PolygonCollider2D finArchCollider;

    private Color mBlue = new Color(0.0f, 0.36f, 0.77f);
    private Color cBlue = new Color(0.26f, 0.45f, 0.8f);
    private Color sGold = new Color(0.84f, 0.62f, 0.05f);
    private Color cPink = new Color(0.98f, 0.51f, 0.65f);
    private int RandomNumber;

    // Start is called before the first frame update
    void Start()
    {
        tRingRenderer = TopRing.GetComponent<SpriteRenderer>();
        mRingRenderer = MiddleRing.GetComponent<SpriteRenderer>();
        bRingRenderer = BottomRing.GetComponent<SpriteRenderer>();
        lPillarRenderer = LeftPillar.GetComponent<SpriteRenderer>();
        rPillarRenderer = RightPillar.GetComponent<SpriteRenderer>();
        firArchRenderer = FirstArch.GetComponent<SpriteRenderer>();
        mArchRenderer = MiddleArch.GetComponent<SpriteRenderer>();
        finArchRenderer = FinalArch.GetComponent<SpriteRenderer>();

        tRingCollider = TopRing.GetComponent<PolygonCollider2D>();
        mRingCollider = MiddleRing.GetComponent<PolygonCollider2D>();
        bRingCollider = BottomRing.GetComponent<PolygonCollider2D>();
        lPillarCollider = LeftPillar.GetComponent<PolygonCollider2D>();
        rPillarCollider = RightPillar.GetComponent<PolygonCollider2D>();
        firArchCollider = FirstArch.GetComponent<PolygonCollider2D>();
        mArchCollider = MiddleArch.GetComponent<PolygonCollider2D>();
        finArchCollider = FinalArch.GetComponent<PolygonCollider2D>();

        RandomNumber = Random.Range(1, 5);
        if (RandomNumber == 1)
            { tRingRenderer.color = mBlue; }
        else if (RandomNumber == 2)
            { tRingRenderer.color = cBlue;}
        else if (RandomNumber == 3)
            { tRingRenderer.color = sGold;}
        else
            {  tRingRenderer.color = cPink;}

        RandomNumber = Random.Range(1, 5);
        if (RandomNumber == 1)
            { mRingRenderer.color = mBlue; }
        else if (RandomNumber == 2)
            { mRingRenderer.color = cBlue; }
        else if (RandomNumber == 3)
            { mRingRenderer.color = sGold; }
        else
        { mRingRenderer.color = cPink; }

        RandomNumber = Random.Range(1, 5);
        if (RandomNumber == 1)
            { bRingRenderer.color = mBlue; }
        else if (RandomNumber == 2)
            { bRingRenderer.color = cBlue; }
        else if (RandomNumber == 3)
            { bRingRenderer.color = sGold; }
        else
        { bRingRenderer.color = cPink; }

        RandomNumber = Random.Range(1, 5);
        if (RandomNumber == 1)
            { lPillarRenderer.color = mBlue; }
        else if (RandomNumber == 2)
            { lPillarRenderer.color = cBlue; }
        else if (RandomNumber == 3)
            { lPillarRenderer.color = sGold; }
        else
        { lPillarRenderer.color = cPink; }

        RandomNumber = Random.Range(1, 5);
        if (RandomNumber == 1)
            { rPillarRenderer.color = mBlue; }
        else if (RandomNumber == 2)
            { rPillarRenderer.color = cBlue; }
        else if (RandomNumber == 3)
            { rPillarRenderer.color = sGold; }
        else
        { rPillarRenderer.color = cPink; }

        RandomNumber = Random.Range(1, 5);
        if (RandomNumber == 1)
            { firArchRenderer.color = mBlue; }
        else if (RandomNumber == 2)
            { firArchRenderer.color = cBlue; }
        else if (RandomNumber == 3)
            { firArchRenderer.color = sGold; }
        else
        { firArchRenderer.color = cPink; }

        RandomNumber = Random.Range(1, 5);
        if (RandomNumber == 1)
            { mArchRenderer.color = mBlue; }
        else if (RandomNumber == 2)
            { mArchRenderer.color = cBlue; }
        else if (RandomNumber == 3)
            { mArchRenderer.color = sGold; }
        else
        { mArchRenderer.color = cPink; }

        RandomNumber = Random.Range(1, 5);
        if (RandomNumber == 1)
            { finArchRenderer.color = mBlue; }
        else if (RandomNumber == 2)
            { finArchRenderer.color = cBlue; }
        else if (RandomNumber == 3)
            { finArchRenderer.color = sGold; }
        else
        { finArchRenderer.color = cPink; }
    }
}
