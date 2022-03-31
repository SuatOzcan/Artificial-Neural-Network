using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ANN : MonoBehaviour {

	public int numInputs;
	public int numOutputs;
	public int numHidden;
	public int numNPerHidden;
	//Alpha is like a weight, it multiplies the input. By using alpha,
	//we can determine how fast a neural network learns, how much a new training set will effect theANN.
	//e.g. if we set it to 0.25
	//the ANN learns 25% slower.
	public double alpha;
	List<Layer> layers = new List<Layer>();

	public ANN(int nI,int nO,int nH, int nPH,double a)
    {
		numInputs = nI;
		numOutputs = nO;
		numHidden = nH;
		numNPerHidden = nPH;
		alpha = a;

        if (numHidden>0)
        {
			layers.Add(new Layer(numNPerHidden, numInputs));
            for (int i = 0; i < numHidden -1; i++)
            {
				layers.Add(new Layer(numNPerHidden, numNPerHidden));
            }

			layers.Add(new Layer(numOutputs, numNPerHidden));
        }
        else
        {
			layers.Add(new Layer(numOutputs, numInputs));
        }
    }

	public List<double> Go(List<double> inputValues, List<double> desiredOutput)
    {
		List<double> inputs = new List<double>();
		List<double> outputs = new List<double>();

        if (inputValues.Count != numInputs)
        {
			Debug.Log("ERROR: Number of inputs must be: " + numInputs);
			return outputs;
        }

		inputs = new List<double>(inputValues);
        for (int i = 0; i < numHidden + 1; i++)
        {
            if (i>0)
            {
				inputs = new List<double>(outputs);
            }
			outputs.Clear();

        }

    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
