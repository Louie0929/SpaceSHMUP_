/**** 
 * Created by: Xingzhou Li
 * Date Created: Mar 30, 2022
 * 
 * Last Edited by: Xingzhou Li
 * Last Edited: Mar 30, 2022
 * 
 * Description: Projectile Behavior
****/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    /*** VARIABLES ***/
    private BoundsCheck bndCheck; // reference to the bounds check
    // Start is called before the first frame update
    void Awake()
    {
        bndCheck = GetComponent<BoundsCheck>();

    } // end Awake()

    // Update is called once per frame
    void Update()
    {
        // if off screen up 
        if (bndCheck.offUp)
        {
            gameObject.SetActive(false);
            bndCheck.offUp = false; // reset the boundary settings
        }
    } // end Update()
}
