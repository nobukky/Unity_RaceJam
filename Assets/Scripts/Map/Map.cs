using System.Collections.Generic;
using UnityEngine;

namespace Map
{
    [System.Serializable]
    public class Map
    {
        public List<Point> circuit;
    
        public Map(List<Point> circuit)
        {
            this.circuit = circuit;
        }

        /// <summary>
        /// Returns the orientation cars must have at the beginning of the circuit as an eulerAngles Vector3
        /// to be in the correct direction to start the race
        /// </summary>
        public Vector3 GetStartOrientation()
        {
            if (circuit.Count <= 2)
            {
                Debug.LogError("MAP: circuit size is too small. couldn't get the correct starting orientation.");
                return Vector3.zero;
            }

            Vector3 output = new Vector3();
        
            if (circuit[0].x < circuit[1].x) output = new Vector3(0, 90, 0);
            if (circuit[0].z < circuit[1].z) output = new Vector3(0, 0, 0);
        
            return output;
        }

        /// <summary>
        /// Returns the transform of the further cell in the circuit 
        /// </summary>
        public Transform GetNextCellTransform(int index, int offset)
        {
            int furtherIndex = index + offset;
            if (furtherIndex >= circuit.Count - 1) furtherIndex = circuit.Count - 1;
            return circuit[furtherIndex].graphics.transform;
        }
    }
}