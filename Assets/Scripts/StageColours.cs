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

        /*RandomNumber = Random.Range(1, 5);
        if (RandomNumber == 1)
            { tRingRenderer.color = ColourManager.mBlue; }
        else if (RandomNumber == 2)
            { tRingRenderer.color = ColourManager.cBlue;}
        else if (RandomNumber == 3)
            { tRingRenderer.color = ColourManager.sGold;}
        else
            {  tRingRenderer.color = ColourManager.cPink;}

        RandomNumber = Random.Range(1, 5);
        if (RandomNumber == 1)
            { mRingRenderer.color = ColourManager.mBlue; }
        else if (RandomNumber == 2)
            { mRingRenderer.color = ColourManager.cBlue; }
        else if (RandomNumber == 3)
            { mRingRenderer.color = ColourManager.sGold; }
        else
        { mRingRenderer.color = ColourManager.cPink; }

        RandomNumber = Random.Range(1, 5);
        if (RandomNumber == 1)
            { bRingRenderer.color = ColourManager.mBlue; }
        else if (RandomNumber == 2)
            { bRingRenderer.color = ColourManager.cBlue; }
        else if (RandomNumber == 3)
            { bRingRenderer.color = ColourManager.sGold; }
        else
        { bRingRenderer.color = ColourManager.cPink; }

        RandomNumber = Random.Range(1, 5);
        if (RandomNumber == 1)
            { lPillarRenderer.color = ColourManager.mBlue; }
        else if (RandomNumber == 2)
            { lPillarRenderer.color = ColourManager.cBlue; }
        else if (RandomNumber == 3)
            { lPillarRenderer.color = ColourManager.sGold; }
        else
        { lPillarRenderer.color = ColourManager.cPink; }

        RandomNumber = Random.Range(1, 5);
        if (RandomNumber == 1)
            { rPillarRenderer.color = ColourManager.mBlue; }
        else if (RandomNumber == 2)
            { rPillarRenderer.color = ColourManager.cBlue; }
        else if (RandomNumber == 3)
            { rPillarRenderer.color = ColourManager.sGold; }
        else
        { rPillarRenderer.color = ColourManager.cPink; }

        RandomNumber = Random.Range(1, 5);
        if (RandomNumber == 1)
            { firArchRenderer.color = ColourManager.mBlue; }
        else if (RandomNumber == 2)
            { firArchRenderer.color = ColourManager.cBlue; }
        else if (RandomNumber == 3)
            { firArchRenderer.color = ColourManager.sGold; }
        else
        { firArchRenderer.color = ColourManager.cPink; }

        RandomNumber = Random.Range(1, 5);
        if (RandomNumber == 1)
            { mArchRenderer.color = ColourManager.mBlue; }
        else if (RandomNumber == 2)
            { mArchRenderer.color = ColourManager.cBlue; }
        else if (RandomNumber == 3)
            { mArchRenderer.color = ColourManager.sGold; }
        else
        { mArchRenderer.color = ColourManager.cPink; }

        RandomNumber = Random.Range(1, 5);
        if (RandomNumber == 1)
            { finArchRenderer.color = ColourManager.mBlue; }
        else if (RandomNumber == 2)
            { finArchRenderer.color = ColourManager.cBlue; }
        else if (RandomNumber == 3)
            { finArchRenderer.color = ColourManager.sGold; }
        else
        { finArchRenderer.color = ColourManager.cPink; }*/
    }
}
