using System;

namespace QuantumSimulator;

public static class QubitHandler
{
    public static QubitValue Measure(Qubit q)
    {
        lock (q)
        {
            var rand = Random.Shared.NextDouble();
            if (rand < q.Zero * q.Zero)
            {
                return QubitValue.Zero;
            }
            return QubitValue.One;
        }
    }

    public static void Reset(Qubit q)
    {
        lock (q)
        {
            q.Zero = 1;
            q.One = 0;
        }
    }
}