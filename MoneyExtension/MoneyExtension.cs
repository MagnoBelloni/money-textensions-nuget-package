namespace MoneyExtension;

public static class Money
{
    public static int ToCents(this decimal amount)
    {
        if (amount <= 0)
            return 0;

        var value = amount.ToString("N2").Replace(",", "").Replace(".", "");
        if(string.IsNullOrEmpty(value))
            return 0;

        _ = int.TryParse(value, out int result);
        return result;
    }
}
