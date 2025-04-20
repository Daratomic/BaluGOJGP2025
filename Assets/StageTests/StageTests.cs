using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

[TestFixture]
public class StageTests
{
    // A Test behaves as an ordinary method
    [Test]
    public void StageTestsSimplePasses()
    {
        // Use the Assert class to test conditions
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.

    [UnityTest]
    public IEnumerator StageTestsWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }

    [Test]
    public void CreateStage_ShouldInstantiateStageTileAndSetProperties()
    {
        // Arrange
        var gameObject = new GameObject();
        var stageManager = gameObject.AddComponent<BoardManager>();

        var stageInner = new GameObject();
        stageInner.AddComponent<SpriteRenderer>();
        stageManager.GetType().GetField("stageInner", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).SetValue(stageManager, stageInner);

        var stageOuter = new GameObject();
        stageOuter.AddComponent<SpriteRenderer>();
        stageManager.GetType().GetField("stageOuter", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).SetValue(stageManager, stageOuter);

        var stageThird = new GameObject();
        stageThird.AddComponent<SpriteRenderer>();
        stageManager.GetType().GetField("stageThird", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).SetValue(stageManager, stageThird);

        // Act
        stageManager.Start();

        // Assert
        Assert.AreEqual(Color.yellow, stageInner.GetComponent<SpriteRenderer>().color);
    }



    [Test]
    public void GetStageInner_ShouldReturnStageInner()
    {
        // Arrange
        var gameObject = new GameObject();
        var stageManager = gameObject.AddComponent<BoardManager>();
        var stageInner = new GameObject();
        stageManager.GetType().GetField("stageInner", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).SetValue(stageManager, stageInner);

        stageInner.transform.position = new Vector3(5, 5, 0);

        Vector2 expectedPosition = new Vector2(5, 5);
        Vector2 actualPosition = new Vector2(stageInner.transform.position.x, stageInner.transform.position.y);

        // Act
        var result = stageManager.GetStageInner();

        // Assert
        Assert.AreEqual(stageInner, result);
        Assert.AreEqual(expectedPosition.x, actualPosition.x, 0.01f);
        Assert.AreEqual(expectedPosition.y, actualPosition.y, 0.01f);
    }

}