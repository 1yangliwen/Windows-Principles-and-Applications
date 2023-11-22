#include "MathFunctions.h"
#include "pch.h"

long long Factorial(int number) {
    if (number < 0) return -1; // ´íÎó´¦Àí

    if (number == 0) return 1;
    long long result = 1;
    for (int i = 1; i <= number; ++i) {
        result *= i;
    }
    return result;
}

int Difference(int a, int b) {
    if (a < b) {
        int temp = a;
        a = b;
        b = temp;
    }
    return a - b;
}