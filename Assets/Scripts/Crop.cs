// this will be used to track all the crops for the 
// game, we also want this to control the frame on each crop

using UnityEngine;

public class Crop {

    protected int days_grown;
    protected int days_to_grow;
    protected int plant_type;

    public void grow() {
        // grow the plant

        days_grown++;
    }

}