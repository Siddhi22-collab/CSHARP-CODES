public static bool IsHappy(int n) {
    HashSet<int> seen = new HashSet<int>();
    while (n != 1 && !seen.Contains(n)) {
        seen.Add(n);
        n = GetNext(n);
    }
    return n == 1;
}

private static int GetNext(int n) {
    int sum = 0;
    while (n > 0) {
        int digit = n % 10;
        n /= 10;
        sum += digit * digit;
    }
    return sum;
}