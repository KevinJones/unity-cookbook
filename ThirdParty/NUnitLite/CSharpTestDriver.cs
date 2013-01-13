#region Usings

using UnityEngine;


#endregion

public class CSharpTestDriver : MonoBehaviour
{
    public bool runTests = true;
	public bool breakOnTestFail = true;


    private void Start()
    {
        if (runTests)
            NUnitLiteUnityRunner.RunTests();
		
		if (breakOnTestFail && NUnitLiteUnityRunner.testsFailed)
		{
			Debug.Break();	
		}
    }
}
