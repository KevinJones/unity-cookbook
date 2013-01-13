using UnityEngine;
using System.Collections;
using NUnit.Framework;

namespace Test
{
	[TestFixture]
	public class KinematicHelperTest : KinematicSteerHelper{

		[Test]
		public void TestZeroSteer()
		{
			KinematicSteeringOutput ks = new KinematicSteeringOutput();
			ks.velocity = Vector3.zero;
			ks.rotation = Angle.WithDeg(0);

			Transform t = new GameObject().transform;
			ApplySteer(ks, t);
			
			
			
			Assert.True(t.position == Vector3.zero);
			Assert.True(t.eulerAngles == Vector3.zero);
		}
		
		[Test]
		public void TestVelocitySteer()
		{
				
		}
	}
}


