using NUnit.Framework;
using UnityEngine;

namespace Thomsen.GuessingGame.Assets.Editor

{
	[TestFixture()]
	public class LevelManagerTest
	{//need integration tests here?
	    [Test()]
	    public void ShouldLoadLevelWhenPassedAName()
	    {
	        Assert.True(false);
/*	        LevelManager level = new LevelManager();

            Assert.IsInstanceOf<Start>(level.LoadLevel("Start"));*/
	    }

		[Test()]
        public void ShouldRunQuitWhenQuitRequested ()
        {
            Assert.True(false);
/*          LevelManager level = new LevelManager();

            Assert.IsInstanceOf<Start>(level.LoadLevel("Start"));*/
        }
	}
}
