using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Layer {

    public int numNeurons;
    public List<Neuron> neurons = new List<Neuron>();

    //Creates nNeurons number of neurons and numNeuronInputs number of weights.
    //numNeuronInput number is essentially the number of neurons on the previous layer.
    //Because a neuron receives input from each of them.
    
    public Layer(int nNeurons, int numNeuronInputs) {
       
        numNeurons = nNeurons;
        for (int i = 0; i < nNeurons; i++)
        {
            neurons.Add(new Neuron(numNeuronInputs));
        }
    }
}
