using RefModifier;

namespace RefModifier {
    class Calculator {
        // Ref Modifier:
        public static void Triple(ref int x)
        {
            x = x * 3;
        }
    }
}