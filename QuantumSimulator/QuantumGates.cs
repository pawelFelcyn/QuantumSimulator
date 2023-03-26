namespace QuantumSimulator;

public static class QuantumGates
{
    public static void X(Qubit q)
    {
        
         double originalZero = q.Zero;
         q.Zero = q.One;
         q.One = originalZero;
    }

    public static void H(Qubit q)
    {
         double originalZero = q.Zero;
         double originalOne = q.One;
         
         q.Zero = 0.70710678118 * (originalOne + originalZero);
         q.One = 0.70710678118 * (originalOne - originalZero);
    }
}