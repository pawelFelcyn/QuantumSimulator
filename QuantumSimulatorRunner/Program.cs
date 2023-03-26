using QuantumSimulator;

var qubit = new Qubit();
QuantumGates.X(qubit);
var result = QubitHandler.Measure(qubit);
Console.WriteLine(result);