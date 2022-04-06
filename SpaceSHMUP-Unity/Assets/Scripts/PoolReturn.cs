/**** 
 * Created by: Xingzhou Li
 * Date Created: April 6, 2022
 * 
 * Last Edited by: Xingzhou Li
 * Last Edited: April 6, 2022
 * 
 * Description: Return the object back into the pool
****/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolReturn : MonoBehaviour
{
    private ObjectPool pool;

    // Start is called before the first frame update
    void Start()
    {
        pool = ObjectPool.POOL; // reference to pool
    } // end start()

    private void OnDisable()
    {
        if(pool != null)
        {
            pool.ReturnObjects(this.gameObject); // return this object to pool
        }
    } // end ondisable()
}
